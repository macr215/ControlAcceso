using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericAccesoDatos;
using ControlAcceso.Entidades ;
namespace ControlAcceso.InterfacesDao
{
 public    interface  IUsuarioDao : IGenericDAO <Usuario ,string > 
    {
     IList <Usuario > Autenticar(string usuarioNombre,string password);
     IList<Usuario> UsuarioExiste(Usuario usuario);
     IList<Usuario> UsuarioExiste(String  nombreUsuario);
    }
}
