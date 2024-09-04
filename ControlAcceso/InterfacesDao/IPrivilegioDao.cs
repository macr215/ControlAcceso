using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericAccesoDatos;
using ControlAcceso.Entidades ;
namespace ControlAcceso.InterfacesDao
{
 public    interface IPrivilegioDao  :IGenericDAO <Privilegio,int >
    {
         IList<object[]> DevolverModulos();
    }
}
