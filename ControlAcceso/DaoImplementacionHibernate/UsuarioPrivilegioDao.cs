
using GenericAccesoDatos;
using ControlAcceso.InterfacesDao;
using ControlAcceso.Entidades;
using AccesoDatos;

namespace ControlAcceso.DaoImplementacionHibernate
{
   public class UsuarioPrivilegioDao: GenericNHibernateDAO<UsuarioPrivilegio  , int>, IUsuarioPrivilegioDao  
    {
       public UsuarioPrivilegioDao(SessionProviderHibernate sessionProvider)
            : base(sessionProvider)
        {
        }

    }
}
