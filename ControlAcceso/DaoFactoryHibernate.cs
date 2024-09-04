using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlAcceso .InterfacesDao;
using ControlAcceso .DaoImplementacionHibernate ;
using AccesoDatos;
using GenericAccesoDatos;

namespace ControlAcceso
{
    public class DaoFactoryHibernate : IDaoFactory
    {
      /*  public IUsuarioDao IDaoFactory.getUsuarioDAO (ISessionProvider sessionProvider)
        {
           
        }
        public IUsuarioPrivilegioDao  IDaoFactory.getUsuarioPrivilegioDAO(ISessionProvider sessionProvider)
        {
         
        }*/

        public IUsuarioDao getUsuarioDAO(ISessionProvider sessionProvider)
        {
            return new UsuarioDao((SessionProviderHibernate)sessionProvider);
        }

        public IUsuarioPrivilegioDao getUsuarioPrivilegioDAO(ISessionProvider sessionProvider)
        {
            return new UsuarioPrivilegioDao((SessionProviderHibernate)sessionProvider);
        }
        public IPrivilegioDao getPrivilegioDAO (ISessionProvider sessionProvider)
        {
            return new PrivilegioDao((SessionProviderHibernate)sessionProvider);
        }
    }
}
