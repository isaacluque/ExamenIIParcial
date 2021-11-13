using Ejercicio3.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
            LoginEventsController controlador = new LoginEventsController(this);
            UsuarioControllers registrarusuario = new UsuarioControllers(this);
        }

    }
}
