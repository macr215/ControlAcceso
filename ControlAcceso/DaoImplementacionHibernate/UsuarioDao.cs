
using GenericAccesoDatos;
using ControlAcceso.InterfacesDao;
using ControlAcceso.Entidades;
using AccesoDatos;
using NHibernate;
using System;

namespace ControlAcceso.DaoImplementacionHibernate
{

    public class UsuarioDao : GenericNHibernateDAO<Usuario, string>, IUsuarioDao
    {
        public UsuarioDao(SessionProviderHibernate sessionProvider)
            : base(sessionProvider)
        {
        }


        public System.Collections.Generic.IList<Usuario> Autenticar(string usuarioNombre, string password)
        {
                 string  query ="";
                    IQuery   iq ; 
                     query = "from Usuario u where u.NombreCuenta=:user and u.Password=:pas  and u.Estado='ACTIVO'";
                iq = Session.CreateQuery(query);
                iq.SetString("user", usuarioNombre);
                iq.SetString("pas", password);
                return iq.List<Usuario>();
        }

        public System.Collections.Generic.IList<Usuario> UsuarioExiste(Usuario usuario)
        {
               string  query ="";
                IQuery   iq ; 
                query = "from Usuario u where u.NombreCuenta=:user ";
                iq = Session.CreateQuery(query);
                iq.SetString("user", usuario.NombreCuenta);
                return iq.List< Usuario>();
                }

        public System.Collections.Generic.IList<Usuario> UsuarioExiste(String nombreUsuario)
        {
            string query = "";
            IQuery iq;
            query = "from Usuario u where u.NombreCuenta=:user ";
            iq = Session.CreateQuery(query);
            iq.SetString("user", nombreUsuario);
            return iq.List<Usuario>();
        }
    }

}