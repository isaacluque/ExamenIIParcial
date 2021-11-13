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
    public partial class TSoporteView : Form
    {
        public TSoporteView()
        {
            InitializeComponent();
            ViewsControllers controlador = new ViewsControllers(this);
            pl_celulares.Visible = false;
            pl_computo.Visible = false;
            rb_celulares.Checked = false;
            rb_Computo.Checked = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            btn_aceptar.Enabled = false;
        }

        private void cb_Computadoras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Computadoras.Text == "DELL")
            {
                pictureBox2.Visible = true;
                pictureBox2.Image = Properties.Resources.DELL;
            }
            else if (cb_Computadoras.Text == "HP")
            {
                pictureBox2.Visible = true;
                pictureBox2.Image = Properties.Resources.HP;
            }
            else if (cb_Computadoras.Text == "Lenovo")
            {
                pictureBox2.Visible = true;
                pictureBox2.Image = Properties.Resources.Lenovo;
            }
        }

        private void cb_Telefonos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_Telefonos.Text == "Samsumg")
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.Samsumg;
            }
            else if (cb_Telefonos.Text == "Iphone")
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.Iphone;
            }
        }
    }
}
