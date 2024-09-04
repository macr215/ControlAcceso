
using GenericAccesoDatos;
using ControlAcceso.InterfacesDao;
using ControlAcceso.Entidades;
using AccesoDatos;
using System.Collections.Generic;
using NHibernate;

namespace ControlAcceso.DaoImplementacionHibernate
{
   public class PrivilegioDao: GenericNHibernateDAO<Privilegio , int>, IPrivilegioDao 
    {
        public PrivilegioDao(SessionProviderHibernate sessionProvider)
            : base(sessionProvider)
        {
        }

        public IList<object []> DevolverModulos()
        {
            string query = "";
            IQuery iq;
            query = " select  from Usuario u where u.NombreCuenta=:user and u.Password=:pas  and u.Estado='ACTIVO'";
            iq = Session.CreateQuery(query);
         
            return iq.List<object []>();
        }

    }
}
