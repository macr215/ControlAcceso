using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlAcceso.Servicios;
using ControlAcceso.Entidades;
using GenericAccesoDatos;
namespace ControlAcceso
{
    public partial class FrmAdministrarUsuarios : BaseForm 
    {
        private UsuarioServicio servicioUsuario;
        private IList<Usuario> listaUsuarios;
        public FrmAdministrarUsuarios(AbstractFactory _factory):base (_factory )
        {
            InitializeComponent();
            servicioUsuario = new UsuarioServicio(SessionProvider, GlobalesControl._factoryDao);
        }
        public FrmAdministrarUsuarios()
           
        {
            InitializeComponent();
            servicioUsuario = new UsuarioServicio(SessionProvider, GlobalesControl._factoryDao);
        }

        private void FrmAdministrarUsuarios_Load(object sender, EventArgs e)
        {
            cargar();
        }

        public void cargar()
        {
            try
            {
                listaUsuarios = servicioUsuario.DevolverTodos();
                usuarioBindingSource.DataSource = listaUsuarios;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
         

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmUsuario v = new FrmUsuario(GlobalesControl._factory  );
            v.ShowDialog();
        }

        private void btnImprimirContrato_Click(object sender, EventArgs e)
        {
            if(usuarioBindingSource .Current !=null ){
                FrmAsignarPrivilegio v = new FrmAsignarPrivilegio(SessionProvider); ///FrmAsignarPrivilegio(GlobalesControl._factory);
           v.cargarUsuario((Usuario)usuarioBindingSource.Current);

            v.ShowDialog();
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            buscar("Nombre", TextBox1.Text);
        }

        public void buscar(string filtro, string Valor)
        {
            listaUsuarios = servicioUsuario.DevolverTodos();
            usuarioBindingSource.DataSource = listaUsuarios;
            IList<Usuario > evensQuery = null;
            switch (filtro)
            {

                case "Nombre":
                    evensQuery = (from num in listaUsuarios where num.Nombres .ToUpper().Contains(Valor.ToUpper()) select num).ToList();
                    //proveedoresL = evensQuery;
                    break;
               
                default:
                    break;
            }

            usuarioBindingSource.DataSource = evensQuery;

        }
    }
}
