using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenericAccesoDatos;
namespace ControlAcceso
{
    public partial class BaseForm : Form
    {
        private readonly bool _isStandAlone = true;
        private ISessionProvider _sessionProvider;
        private AbstractFactory _factory;//sessionfactory 
        public BaseForm()
        {
            InitializeComponent();
        }
        
        public BaseForm(AbstractFactory factory)
        {
            InitializeComponent();
           _factory =factory;
        }

          

        public BaseForm(ISessionProvider sessionProvider)
        {
            InitializeComponent();

            if (sessionProvider != null)
                _isStandAlone = false;
            this._sessionProvider = sessionProvider;
        }


        public ISessionProvider SessionProvider
        {
            get
            {
                if (_sessionProvider == null)
                    _sessionProvider = _factory.getSessionprovider();
            
                return _sessionProvider;
            }
        }




        public bool IsStandAlone
        {
            get
            {
                return _isStandAlone;
            }
        }

        private void BaseF_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isStandAlone & _sessionProvider != null)
                _sessionProvider.Dispose();
        }

    
        private string _permiso;

        public string permiso
        {
            get
            {
                return _permiso;
            }
            set
            {
                _permiso = value;
            }
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
   
    
    }
 }

