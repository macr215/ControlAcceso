using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericAccesoDatos;
using ControlAcceso.Entidades ;
namespace ControlAcceso.InterfacesDao
{
  public   interface IUsuarioPrivilegioDao : IGenericDAO <UsuarioPrivilegio , int>
    {
    }
}
