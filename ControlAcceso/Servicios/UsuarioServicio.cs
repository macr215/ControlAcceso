using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlAcceso.Entidades;
using ControlAcceso.InterfacesDao;
using GenericAccesoDatos;
namespace ControlAcceso.Servicios
{
   public class UsuarioServicio :GenericServicio <Usuario ,string >

    {
       private IUsuarioPrivilegioDao daoUsuarioPrivilegio;
       public UsuarioServicio(ISessionProvider sessionProvider, IDaoFactory daoFactory)
            : base(sessionProvider)
        {
            Dao = daoFactory.getUsuarioDAO (sessionProvider);
            daoUsuarioPrivilegio = daoFactory.getUsuarioPrivilegioDAO (sessionProvider);
        }

       // public IDaoFactory daoFactory { get; set; }
        public  IUsuarioDao  Dao
        {
            get { return (IUsuarioDao)base.Dao; }
            set { base.Dao = value; }
        }
         public bool  ExistePrivilegio(string nombre, IList<Privilegio> lista)
            {
                bool band = false;
                for (int i = 0; i <= lista.Count - 1; i++)
                {
                    if (lista[i].Descripcion == nombre)
                    {
                        band = true;
                       // return true;
                    }
                }
                return band ;
            }

        public bool ExisteUsuario(Usuario USU)
            {
                IList<Usuario> UsuariosL;
                bool existe = false;
                UsuariosL = Dao.UsuarioExiste(USU);
                if (UsuariosL.Count == 1)
                    existe = true;
                return existe;
            }


    public string CrearUsuario(Usuario usu)
    {
        var MENSAJE = "OK";
        if (usu.Privilegios.Count > 0)
        {
            if (!ExisteUsuario(usu))
            {
                try
                {
                    SessionProvider.BeginTransaction();

                    Dao.Guardar(usu);
                    for (int index = 0; index <= usu.Privilegios.Count - 1; index++)
                    {
                        usu.Privilegios[index].Usuario = usu;
                        daoUsuarioPrivilegio.Guardar(usu.Privilegios[index]);
                    }
                    SessionProvider.CommitTransaction();
                }
                catch (Exception ex)
                {
                    SessionProvider.RollBackTransaction();
                    throw ex;
                }
            }
            else
                MENSAJE = "Ya Existe un usuario con ese nombre de cuenta";
        }
        else
            MENSAJE = "El número de privilegios debe ser como minimo uno(1)";
        return MENSAJE;
    }

      //public Usuario  EstaAutenticado(string username, string contraseña)
      //  {
      //      bool B = false;
      //      IList<Usuario> usuariosL;
      //      Usuario usuarioL = null/* TODO Change to default(_) if this is not a reference type */;
      //      usuariosL = Dao.Autenticar(username, Seguridad.cifrar ( contraseña));
      //      if (usuariosL.Count == 1)
      //          usuarioL = usuariosL[0];
      //      return usuarioL;
      //  }

    public  bool ComprobarPrivilegios(Usuario usuariol) // funcion no la utilizo pero los parametros deberian ser usuario y lista de privilegios a comprobar para esta accion
    {
        int i = 0;
        bool band = false;
        if (usuariol.Privilegios != null)
        {
            if (usuariol.Privilegios.Count > 0)
            {
                while (!band & (i <= usuariol.Privilegios.Count - 1))
                {
                    if ((usuariol.Privilegios[i].Privilegio.Id == 3 | usuariol.Privilegios[i].Privilegio.Id == 7))
                        band = true;
                    i = i + 1;
                }
            }
        }

        return band;
    }
       /// <summary>
       /// sin cifrado
       /// </summary>
       /// <param name="usuario"></param>
       /// <param name="pass"></param>
       /// <returns></returns>
    public IList<Usuario> Autenticar(string usuario, string pass)
    {
        return Dao.Autenticar(usuario, pass);
    }

        //autenticacion con bcrypt
      public bool AuthenticateBcrypt(string usuario,String password)
        {
            var users = Dao.UsuarioExiste(usuario);
            Usuario usuarioL = null;
            if (users.Count == 1)
                usuarioL = users[0];
            // verify password
            if (usuarioL == null || !Seguridad.verificarBCRYPT(password, usuarioL.Password))
               return false;
            if (usuarioL.Estado != "ACTIVO")
                return false;
            return true;
           
        }

        public Usuario EstaAutenticado(string username, string contraseña)
        {
           
            var users = Dao.UsuarioExiste(username);
            Usuario usuarioL = null;
            if (users.Count == 1)
                usuarioL = users[0];

            // verify password
            if (usuarioL == null || !Seguridad.verificarBCRYPT(contraseña, usuarioL.Password))
                return null;
            if (usuarioL.Estado != "ACTIVO")
                return null;
            return usuarioL;
        }

        public void ActualizarPrivilegios(IList<Privilegio> privilegiosActuales, IList<Privilegio> privilegiosNuevos, Usuario u)
         {
        try
        {
            SessionProvider.BeginTransaction();
            // eliminiar privilegios
            for (int i = 0; i <= privilegiosActuales.Count - 1; i++)
            {
                if (!ExistePrivilegio(privilegiosActuales[i].Descripcion, privilegiosNuevos))
                {
                    // borrar
                    UsuarioPrivilegio up1;
                    up1 = daoUsuarioPrivilegio.DevolverxPropiedadQuery("id", new object [] {"Privilegio.Id", "=", privilegiosActuales[i].Id}, new object []{"Usuario.NombreCuenta","=",u.NombreCuenta })[0];
                    daoUsuarioPrivilegio.Eliminar(up1);
                }
            }
            // añdri nuevos privilegios
            for (int i = 0; i <= privilegiosNuevos.Count - 1; i++)
            {
                if (!ExistePrivilegio(privilegiosNuevos[i].Descripcion, privilegiosActuales))
                {
                    UsuarioPrivilegio up = new UsuarioPrivilegio();
                    up.Privilegio = privilegiosNuevos[i]; // privdao.DevolverPorId(Me.ListView2.Items(index).SubItems(1).Text)
                    up.Usuario = u;
                    daoUsuarioPrivilegio.Guardar(up);
                }
            }
            Dao.Actualizar(u);
            SessionProvider.CommitTransaction();
        }
        catch (Exception ex)
        {
            SessionProvider.RollBackTransaction();
            throw ex;
        }
    }
    }
}




