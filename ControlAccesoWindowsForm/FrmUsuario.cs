using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using  System.Security.Cryptography;
using System.Text;
using System.IO;
using ControlAcceso.Entidades ;
using ControlAcceso.InterfacesDao;
using ControlAcceso.DaoImplementacionHibernate;
using ControlAcceso.Servicios ;
using GenericAccesoDatos;
namespace ControlAcceso
{
    public partial class FrmUsuario : BaseForm 
    {
        private Usuario usuario1;
        private IPrivilegioDao  daoPrivilegio;
        private UsuarioServicio servicioUsuario;
        public FrmUsuario(AbstractFactory _factory):base (_factory )
        
        {
            InitializeComponent();
            servicioUsuario = new UsuarioServicio (SessionProvider ,GlobalesControl._factoryDao );
            daoPrivilegio = GlobalesControl._factoryDao.getPrivilegioDAO(SessionProvider);
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            cargar_privilegios();
        }

        public bool  comprobar_contraseñas()
        {
            bool band = false;
            if (this.txtcontraseña.Text == this.txtcontraseña2.Text)
                band = true;
            else
                band = false;
            return band;
        }

        /// <summary>
        ///     ''' Cifra el texto indicado usando las claves en formato XML
        ///     ''' </summary>
      //  private static byte[] cifrar(string texto, string xmlKeys)
             private static byte[] cifrar(string texto)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

        //    rsa.FromXmlString(xmlKeys);

            byte[] datosEnc = rsa.Encrypt(Encoding.Default.GetBytes(texto), false);

            return datosEnc;
        }
        /// <summary>
        ///     ''' Descifra el array de bytes usando las claves en formato XML
        ///     ''' </summary>
        private static string descifrar(byte[] datosEnc, string xmlKeys)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            rsa.FromXmlString(xmlKeys);

            byte[] datos = rsa.Decrypt(datosEnc, false);

            string res = Encoding.Default.GetString(datos);

            return res;
        }

        public void ESTABLECER_PRIVILEGIOS()
        {
            usuario1.Privilegios.Clear();
            if (!( this.ListView2.Items.Count == 0))
            {
                for (int index = 0; index <= this.ListView2.Items.Count - 1; index++)
                {
                    UsuarioPrivilegio up = new UsuarioPrivilegio();
                    up.Privilegio = daoPrivilegio.DevolverPorId(Convert .ToInt32 ( this.ListView2.Items[index].SubItems[1].Text));
                    usuario1.Privilegios.Add(up);
                }
            }
        }

        public void cargar_privilegios()
        {
            try
            {
                IList<Privilegio> privilegiosL;
                privilegiosL = daoPrivilegio.DevolverTodos();
                for (int i = 0; i <= privilegiosL.Count - 1; i++)
                {
                    this.ListView1.Items.Add(privilegiosL[i].Descripcion);
                    this.ListView1.Items[i].SubItems.Add(privilegiosL[i].Id.ToString());
                }
            }
            catch (System.Exception ex)
            {
                
                throw ex;
            }
           
           
        }

        public void activar(bool valor)
        {
            this.ListView1.Enabled = valor;
            this.ListView2.Enabled = valor;
            this.GroupBox1.Enabled = valor;
            this.txtcontraseña.Enabled = valor;
            this.txtcontraseña2.Enabled = valor;
            this.txtNombres.Enabled = valor;
            this.txtnombrecuenta.Enabled = valor;
            this.btnGuardar.Enabled = valor;
            this.ListView1.Enabled = valor;
            this.ListView2.Enabled = valor;
        }

        private void btnAgrgar_Click(object sender, System.EventArgs e)
        {
           
            if (this.ListView1.SelectedItems.Count != 0)
            {
                this.ListView2.Items.Add(this.ListView1.SelectedItems[0].Text);
                this.ListView2.Items[this.ListView2.Items.Count - 1].SubItems.Add(this.ListView1.SelectedItems[0].SubItems[1].Text);
                this.ListView1.Items.Remove(this.ListView1.SelectedItems[0]);
            }
            
        }

        private void btnquitar_Click(object sender, System.EventArgs e)
        {
          
                    if (this.ListView2.SelectedIndices.Count != 0)
                    {
                        this.ListView1.Items.Add(this.ListView2.SelectedItems[0].Text);
                        this.ListView1.Items[this.ListView1.Items.Count - 1].SubItems.Add(this.ListView2.SelectedItems[0].SubItems[1].Text);
                        this.ListView2.Items.Remove(this.ListView2.SelectedItems[0]);
                    }


        }

        private void Button3_Click(object sender, System.EventArgs e)
        {
            Close();

        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            string valido = "";
            valido = Validar();
            string respuestas = "";
            if (valido == "")
            {
                if (comprobar_contraseñas())
                {
                    if (!(this.ListView2.Items.Count == 0))
                    {
                                               
                        
                        this.usuario1.Nombres = this.txtNombres.Text;
                        this.usuario1.NombreCuenta = this.txtnombrecuenta.Text;
                        this.usuario1.Password = Seguridad.cifrar(txtcontraseña.Text);
                        this.ESTABLECER_PRIVILEGIOS();
                        respuestas = servicioUsuario.CrearUsuario(usuario1);
                        if (respuestas == "OK")
                            this.activar(false);
                        else
                            MessageBox.Show("Error: " + respuestas);
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coiciden" + valido, "CONTRASEÑA NO COINCIDE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Complete los Datos: " + valido, "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                resultado = resultado + "Nombres \n";
            }
            if (txtcontraseña .Text == "")
            {
                resultado = resultado + "Constraseña \n";
            }
            if (txtcontraseña2.Text == "")
            {
                resultado = resultado + "Repertir Contraseña \n";
            }


            return resultado;
        }

        private void Button4_Click(object sender, System.EventArgs e)
        {
            activar(true);
            usuario1 = new Usuario();
        }

              
       
    }


 }

