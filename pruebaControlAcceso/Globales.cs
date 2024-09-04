using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericAccesoDatos;
using ControlAcceso.InterfacesDao;
using ControlAcceso;
using pruebaControlAcceso.Externo;


namespace pruebaControlAcceso
{
public     class Globales
    {

    public static IDaoFactory _factoryDao = new DaoFactoryHibernate();
    public static AbstractFactory _factory = new FactoryHibernate();
     
    public static string basedatos = "bd_olpasa";  //'"Bs_logprueba"
    public static string servidor = "26.20.136.161";// @"localhost\SQLEXPRESS"; //' "serverolpasa\SQLEXPRESS"
                                                    // public static string servidor = @"192.168.1.139";

        public static string pass = "Olpasaboqueron_2021";// "R4kler.2015";  //'"Bs_logprueba".
     //public static string pass = "@dmin12345";  //'"Bs_logprueba".
   public static string User = "sa";  //'"Bs_logprueba".
   // public static string User = "concar";
    public static string ConecctionString = "data source = " + servidor + "; initial catalog =" + basedatos + "; user id =" + User + "; password =" + pass;
    
   public  static void cargar()
    {
        GlobalesControl._factory = _factory;
        GlobalesControl._factoryDao = _factoryDao;
    }
      
    }

}
