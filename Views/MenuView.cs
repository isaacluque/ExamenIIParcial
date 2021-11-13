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
    public partial class MenuView : Form
    {
        public MenuView()
        {
            InitializeComponent();
            LoginEventsController control = new LoginEventsController(this);
        }

        TSoporteView Tsoporte;
        EstadoView Estado;
        TicketView Tikets;
        DetalleView Detalles;

        private void MenuView_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_maximizar.Visible = false;
            btn_minimizarVentana.Visible = true;
        }

        private void btn_minimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_maximizar.Visible = true;
            btn_minimizarVentana.Visible = false;
        }

        private void tsti_tiposSoporte_Click(object sender, EventArgs e)
        {
            if(Tsoporte == null)
            {
                Tsoporte = new TSoporteView();
                Tsoporte.MdiParent = this;
                Tsoporte.FormClosed += vista_FormClosed;
                Tsoporte.Show();
            }
            else
            {
                Tsoporte.Activate();
            }
        }

        private void vista_FormClosed(object sender, FormClosedEventArgs e)
        {
            Tsoporte = null;
        }

        private void tsti_estados_Click(object sender, EventArgs e)
        {
            if (Estado == null)
            {
                Estado = new EstadoView();
                Estado.MdiParent = this;
                Estado.FormClosed += Estado_FormClosed;
                Estado.Show();
            }
            else
            {
                Estado.Activate();
            }
        }

        private void Estado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Estado = null;
        }

        private void tsti_tickets_Click(object sender, EventArgs e)
        {
            if (Tikets == null)
            {
                Tikets = new TicketView();
                Tikets.MdiParent = this;
                Tikets.FormClosed += Tikets_FormClosed;
                Tikets.Show();
            }
            else
            {
                Tikets.Activate();
            }
        }

        private void Tikets_FormClosed(object sender, FormClosedEventArgs e)
        {
            Tikets = null;
        }

        private void tsti_detalles_Click(object sender, EventArgs e)
        {
            if (Detalles == null)
            {
                Detalles = new DetalleView();
                Detalles.MdiParent = this;
                Detalles.FormClosed += Detalles_FormClosed;
                Detalles.Show();
            }
            else
            {
                Detalles.Activate();
            }
        }

        private void Detalles_FormClosed(object sender, FormClosedEventArgs e)
        {
            Detalles = null;
        }
    }
}
