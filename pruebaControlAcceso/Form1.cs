using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlAcceso;
using ControlAcceso.Entidades;
using ControlAcceso.Servicios;
//using ControlAccesoWindowsForm;
namespace pruebaControlAcceso
{
    public partial class Form1 : ControlAcceso.BaseForm
    {
        private UsuarioServicio servicio;
        private IList<Usuario> lista;
        public Form1()
        {
            InitializeComponent();
            Globales.cargar();
            

            servicio = new UsuarioServicio(GlobalesControl._factory.getSessionprovider(), GlobalesControl._factoryDao);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globales.cargar();
            FrmAdministrarUsuarios v = new FrmAdministrarUsuarios(GlobalesControl._factory);
          //  v.MdiParent = this;
            v.Show();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            
            lista= servicio.DevolverTodos();
            dataGridView1.DataSource = lista;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            foreach (var item in lista)
            {
                if (! item.Password.Contains("$2a"))
                {
                    var pdescifrado = Seguridad.descifrar(item.Password);
                    var npassword = Seguridad.cifrar(pdescifrado);
                    item.Password = npassword;
                    servicio.Guardar(item);

                }
            }
        }
    }
}
