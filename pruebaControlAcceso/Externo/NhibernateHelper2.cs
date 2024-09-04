using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;



namespace pruebaControlAcceso.Externo
{
  
    
  public  class NhibernateHelper2
    {
        public static readonly ISessionFactory SessionFactory;
    
         static NhibernateHelper2()
        {
            try
            {
                // Dim cfg As New Configuration()
                // SessionFactory = cfg.Configure("hibernate.cfg.xml").BuildSessionFactory()
                // SessionFactory = cfg.Configure().BuildSessionFactory()
                var m_configuration = new Configuration();
                IDictionary props = new Hashtable();
                props["connection.provider"] = "NHibernate.Connection.DriverConnectionProvider";
                props["connection.driver_class"] = "NHibernate.Driver.SqlClientDriver";
                props["dialect"] = "NHibernate.Dialect.MsSql2008Dialect";
                props["connection.connection_string"] = "data source = " + Globales.servidor  + "; initial catalog =" + Globales.basedatos + "; user id = " + Globales.User  + "; password = " + Globales.pass  + ";";
                props["show_sql"] = "true";
                foreach (DictionaryEntry de in props)
                    m_configuration.SetProperty(de.Key.ToString(), de.Value.ToString());
              //    m_configuration.AddClass(typeof(Banco));
              //    m_configuration.AddClass(typeof(Calidad ));
              //     m_configuration.AddClass(typeof(Conductor));
              //     m_configuration.AddClass(typeof(Parcela));
              //  m_configuration.AddAssembly("DaoImplemtacionHibernate");
                m_configuration.AddAssembly("ControlAcceso");
                //   m_configuration.AddClass(typeof(Sector));
                   
              //     m_configuration.AddClass(typeof(Vehiculo ));
               
                SessionFactory = m_configuration.BuildSessionFactory();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                throw new Exception("Building SessionFactory failed", ex);
            }
        }
    }
}
