using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAcceso.Entidades
{
   public  class UsuarioPrivilegio
    {
        public  virtual int Id { get; set; }
        public virtual Usuario  Usuario { get; set; }
        public virtual Privilegio  Privilegio { get; set; }
    }
}
