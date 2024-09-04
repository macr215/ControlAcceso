using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAcceso.Entidades
{
  public   class Privilegio
    {
        public virtual int Id { get; set; }
        public virtual string  Descripcion { get; set; }
        public virtual string Modulo { get; set; }
    }
}
