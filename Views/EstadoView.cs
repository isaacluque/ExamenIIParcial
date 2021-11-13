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

namespace Ejercicio3.Views
{
    public partial class EstadoView : Form
    {
        public EstadoView()
        {
            InitializeComponent();
            rb_Abierto.Checked = false;
            rb_Cerrado.Checked = false;
            rb_EnEspera.Checked = false;
            rb_SinResolver.Checked = false;
            EstadoController controlador = new EstadoController(this);
            
        }
    }
}
