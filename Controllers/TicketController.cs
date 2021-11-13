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
    public class TicketController
    {
        TicketView vistaticket;
        DetalleView vistaDetalle;
        TicketDAO ticketDAO = new TicketDAO();
        Ticket ticket = new Ticket();

        public TicketController(TicketView viewticket)
        {
            vistaticket = viewticket;

            vistaticket.btn_GenTicket.Click += new EventHandler(CrearTicket);
        }

        public TicketController(DetalleView viewDetalle)
        {
            vistaDetalle = viewDetalle;

            viewDetalle.Load += new EventHandler(Load);
        }

        private void CrearTicket(object sender, EventArgs e)
        {
            vistaticket.lbl_ticket.Text = GenTicket();
            ticket.NumeroTicket = vistaticket.lbl_ticket.Text;

            bool inserto = ticketDAO.InsertarTicket(ticket);

            if (inserto)
            {
                vistaticket.btn_GenTicket.Enabled = false;
                MessageBox.Show("Ticket ingresado");
            }
            else
            {
                MessageBox.Show("Ticket no ingresado");
            }
        }

        public string GenTicket()
        {
            string ticket;
            char letra1, letra2, letra3;
            int num1, num2, num3, num4;

            Random alea = new Random();
            num1 = alea.Next(65, 91);
            num2 = alea.Next(97, 123);
            num3 = alea.Next(97, 123);
            num4 = alea.Next(1, 100);

            letra1 = Convert.ToChar(num1);
            letra2 = Convert.ToChar(num2);
            letra3 = Convert.ToChar(num3);

            ticket = letra1.ToString() + letra2.ToString() + letra3.ToString() + num4;

            return ticket;
        }

        private void Load(object sender, EventArgs e)
        {
            ListarTicket();
        }

        private void ListarTicket()
        {
            vistaDetalle.dgv_DetalleTicket.DataSource = ticketDAO.GetTicket();
        }
       
    }
}
