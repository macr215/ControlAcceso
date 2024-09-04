using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericAccesoDatos;
using ControlAcceso.InterfacesDao;
using ControlAcceso.Entidades;



namespace ControlAcceso
{
public  class GlobalesControl
    {

    public static IDaoFactory _factoryDao = new DaoFactoryHibernate();
    public static AbstractFactory _factory;// = new FactoryHibernate();
    }

}
