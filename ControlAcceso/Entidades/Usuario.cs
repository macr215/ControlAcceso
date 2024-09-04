using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAcceso.Entidades
{
   public  class Usuario
    {
        public  virtual   String NombreCuenta { get; set; }
        public virtual string  Nombres { get; set; }
        public virtual  string  Password { get; set; }
        private string  _estado="ACTIVO";

        public  virtual string  Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        private IList <UsuarioPrivilegio  > _privilegios;

        public virtual  IList <UsuarioPrivilegio > Privilegios
        {
            get {
                if (_privilegios == null)
                {
                    _privilegios = new List<UsuarioPrivilegio>();
                }

                return _privilegios; }
            set { _privilegios = value; }
        }

        public virtual bool tienePrivilegio(string privilegio)
        {           
           var i = 0;
           var band = false;
           if (Privilegios != null)
           {
               if (Privilegios.Count > 1)
               {
                   while (!band && (i <= Privilegios.Count - 1))
                   {
                       if (Privilegios[i].Privilegio.Descripcion == privilegio  )
                       {
                           band = true;
                       }
                       i = i + 1;
                   }
               }
           }
           return band;       
        }       
       
    }
}
