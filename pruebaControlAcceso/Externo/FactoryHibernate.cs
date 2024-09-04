

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericAccesoDatos;
using AccesoDatos;

namespace pruebaControlAcceso.Externo
{
   public class FactoryHibernate : AbstractFactory

    {
        ISessionProvider AbstractFactory.getSessionprovider()
        {

            return new SessionProviderHibernate(NhibernateHelper2.SessionFactory);//de accesonativo
        }

    }
}
