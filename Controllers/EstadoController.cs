using Ejercicio3.Modelos.DAO;
using Ejercicio3.Modelos.Entidades;
using Ejercicio3.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3.Controllers
{
    public class EstadoController
    {
        EstadoView vistaEstado;

        public EstadoController(EstadoView viewEstado)
        {
            vistaEstado = viewEstado;

            vistaEstado.btn_aceptar.Click += new EventHandler(InsertarEstado);
        }

        private void InsertarEstado(object sender, EventArgs e)
        {
            if (vistaEstado.rb_Abierto.Checked == false && vistaEstado.rb_Cerrado.Checked == false && vistaEstado.rb_EnEspera.Checked == false && vistaEstado.rb_SinResolver.Checked == false)
            {
                MessageBox.Show("Por favor seleccione el Estado del Ticket");
                return;
            }

            EstadoTicketDAO estadoDAO = new EstadoTicketDAO();
            EstadoTicket estado = new EstadoTicket();

            estado.EstadoDeTicket = Estado();

            bool inserto = estadoDAO.InsertarEstadoTicket(estado);

            if (inserto)
            {
                Deshabilitar();
                MessageBox.Show("Estado insertado correctamente");
            }
            else
            {
                MessageBox.Show("Estado no se inserto");
            }
        }

        public string Estado()
        {
            string estadoticket = "";
            if (vistaEstado.rb_Abierto.Checked == true)
            {
                estadoticket = "Abierto";
            }
            else if (vistaEstado.rb_Cerrado.Checked == true)
            {
                estadoticket = "Cerrado";
            }
            else if (vistaEstado.rb_EnEspera.Checked == true)
            {
                estadoticket = "En espera";
            }
            else if (vistaEstado.rb_SinResolver.Checked == true)
            {
                estadoticket = "Sin resolver";
            }

            return estadoticket;
        }
        private void Deshabilitar()
        {
            vistaEstado.rb_Abierto.Checked = false;
            vistaEstado.rb_Cerrado.Checked = false;
            vistaEstado.rb_EnEspera.Checked = false;
            vistaEstado.rb_SinResolver.Checked = false;
            vistaEstado.btn_aceptar.Enabled = false;
        }
    }
}
