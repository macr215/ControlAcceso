using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlAcceso.Entidades;
using ControlAcceso.Servicios;
using ControlAcceso.InterfacesDao;
using System.Collections;
using GenericAccesoDatos;

namespace ControlAcceso
{
    public partial class FrmAsignarPrivilegio : BaseForm 
    {
        private Usuario usuarioL;
        private IPrivilegioDao daoPrivilegio;
        private List <Privilegio> listaPrivilegiosSinAsignar = new  List <Privilegio>();
        private List <Privilegio> listaPrivilegiosAsignados = new  List <Privilegio>();
        private List <Privilegio> NuevaListaPrivilegios = new  List <Privilegio>();
        private UsuarioServicio servicioUsuario;
        public FrmAsignarPrivilegio(AbstractFactory _factory):base (_factory )
        { 
            InitializeComponent();
            servicioUsuario = new UsuarioServicio(SessionProvider, GlobalesControl._factoryDao);
            daoPrivilegio = GlobalesControl._factoryDao.getPrivilegioDAO(SessionProvider);
        }

        public FrmAsignarPrivilegio(ISessionProvider s)
            : base(s)
        {
            InitializeComponent();
            servicioUsuario = new UsuarioServicio(s, GlobalesControl._factoryDao);
            daoPrivilegio = GlobalesControl._factoryDao.getPrivilegioDAO(s);
        }

        public void cargarUsuario(Usuario u)
        {
            usuarioL = u;
            this.txtnombrecuenta.Text = u.NombreCuenta;
            this.txtNombres.Text = u.Nombres;
            this.ComboBox1.Text = u.Estado;
            List<object > privilegiosL;
            privilegiosL = (List<object>)daoPrivilegio.DevolverxPropiedadQuery("p.Privilegio.Descripcion", " p.Privilegio.Descripcion,p.Privilegio.Id from Usuario u join u.Privilegios p ", new object[]
            {
                "u.NombreCuenta",
                "=",
                u.NombreCuenta 
            });
           
             foreach (var item in privilegiosL)           
            {
                // Me.ListView2.Items.Add(privilegiosL(i)(0))
                // Me.ListView2.Items(i).SubItems.Add(privilegiosL(i)(1))
                Privilegio p = new Privilegio();
                p.Descripcion = ((object []) item ) [0].ToString ();
                p.Id = Convert.ToInt32(((object[])item)[1]);
                listaPrivilegiosAsignados.Add(p);
                NuevaListaPrivilegios.Add(p);
            }

            privilegioBindingSource1.DataSource = NuevaListaPrivilegios; // listaPrivilegiosAsignados

            IList<Privilegio> privilegios2L;
            privilegios2L = daoPrivilegio.DevolverTodos();
            for (int i = 0; i <= privilegios2L.Count - 1; i++)
            {
                if (!BuscarExiste(privilegios2L[i].Descripcion, privilegiosL))
                    // Me.ListView1.Items.Add(privilegios2L.Item(i).Nombre)
                    // Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(privilegios2L.Item(i).Id)
                    listaPrivilegiosSinAsignar.Add(privilegios2L[i]);
            }
            privilegioBindingSource.DataSource = listaPrivilegiosSinAsignar;
        }

        public bool  BuscarExiste(string priv, IList<object > lista)
        {
            bool existe = false;
            foreach (var item in lista )   
          {
                if ((priv == ((object [])  item )[0].ToString ()))
                {
                    existe = true;
                    //return existe;
                }
            }
            return existe;
        }


        public void activar(bool valor)
        {
            
            this.GroupBox1.Enabled = valor;
            this.txtNombres.Enabled = valor;
            this.txtnombrecuenta.Enabled = valor;
            this.btnGuardar.Enabled = valor;
        }

        private void btnAgrgar_Click(object sender, EventArgs e)
        {   
                if (privilegioBindingSource.Current != null)
                {
                    NuevaListaPrivilegios.Add((Privilegio)privilegioBindingSource.Current);
                    listaPrivilegiosSinAsignar.Remove((Privilegio)privilegioBindingSource.Current);
                    privilegioBindingSource.ResetBindings(false);
                    privilegioBindingSource1.ResetBindings(false);
                }
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {              
                if (privilegioBindingSource1.Current != null)
                {
                    listaPrivilegiosSinAsignar.Add((Privilegio)privilegioBindingSource1.Current);
                    NuevaListaPrivilegios.Remove((Privilegio)privilegioBindingSource1.Current);
                    privilegioBindingSource.ResetBindings(false);
                    privilegioBindingSource1.ResetBindings(false);
                }            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string valido = "";
            valido = Validar();
            if (valido == "")
            {
                try
                {
                    usuarioL.Estado = ComboBox1.Text;
                    servicioUsuario.ActualizarPrivilegios(listaPrivilegiosAsignados, NuevaListaPrivilegios, usuarioL);
                    btnGuardar.Enabled = false;
                    MessageBox.Show("Los datos se guardaron corretamente", "Aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {                    
                    MessageBox.Show ("Error:"+ ex.Message );
                }
             }
            else
            {
                MessageBox.Show("Faltan datos: \n" + valido, "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string Validar()
        {
            string resultado = "";
            if (txtnombrecuenta.Text == "")
            {
                resultado = "Nombre de Cuenta \n";
            }
            if (txtNombres.Text == "")
            {
                resultado =  resultado + "Nombres \n";
            }
            if (ComboBox1.Text  == "")
            {
                resultado = resultado + "Estado \n";
            }

            return resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox1.Text.Length >=4)
            {
                try
                {
                    usuarioL .Password = Seguridad.cifrar(textBox1.Text);
                    servicioUsuario.actualizar(usuarioL);
                    MessageBox.Show("Contraseña actualizada");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al guradar la contraseña");
                }
            }
            else MessageBox.Show("La contraseña debe tener minimo 4 caracteres");
        }

        private void FrmAsignarPrivilegio_Load(object sender, EventArgs e)
        {

        }
    }
}
