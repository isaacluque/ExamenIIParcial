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
    public class ViewsControllers
    {
        TSoporteView vistaTSoporte;

        public ViewsControllers(TSoporteView viewTSoporte)
        {
            vistaTSoporte = viewTSoporte;
            vistaTSoporte.rb_celulares.CheckedChanged += new EventHandler(MostrarPanelcelulares);
            vistaTSoporte.rb_Computo.CheckedChanged += new EventHandler(MostrarPanelComputo);
            vistaTSoporte.btn_aceptar.Click += new EventHandler(Aceptar);
        }

        private void MostrarPanelcelulares(Object sender, EventArgs e)
        {
            vistaTSoporte.pl_computo.Visible = false;
            vistaTSoporte.pl_celulares.Visible = true;
            vistaTSoporte.cb_Telefonos.Text = string.Empty;
            vistaTSoporte.pictureBox1.Visible = false;
            vistaTSoporte.rb_CambPantalla.Checked = false;
            vistaTSoporte.rb_LibRed.Checked = false;
            vistaTSoporte.rb_Desbloquear.Checked = false;
            vistaTSoporte.btn_aceptar.Enabled = true;
        }

        private void MostrarPanelComputo(Object sender, EventArgs e)
        {
            vistaTSoporte.pl_computo.Visible = true;
            vistaTSoporte.pl_celulares.Visible = false;
            vistaTSoporte.cb_Computadoras.Text = string.Empty;
            vistaTSoporte.pictureBox2.Visible = false;
            vistaTSoporte.rb_Mantenimiento.Checked = false;
            vistaTSoporte.rb_PromSoftware.Checked = false;
            vistaTSoporte.rb_Reparacion.Checked = false;
            vistaTSoporte.btn_aceptar.Enabled = true;
        }

        private void Aceptar(object sender, EventArgs e)
        {
            if(vistaTSoporte.cb_Telefonos.Text == string.Empty && vistaTSoporte.pl_celulares.Visible == true)
            {
                vistaTSoporte.errorProvider1.SetError(vistaTSoporte.cb_Telefonos, "Seleccione la marca de telefono");
            }
            else
            {
                vistaTSoporte.errorProvider1.SetError(vistaTSoporte.cb_Telefonos, null);
            }

            if (vistaTSoporte.cb_Computadoras.Text == string.Empty && vistaTSoporte.pl_computo.Visible == true)
            {
                vistaTSoporte.errorProvider1.SetError(vistaTSoporte.cb_Computadoras, "Seleccione la marca de su computadora");
            }
            else
            {
                vistaTSoporte.errorProvider1.SetError(vistaTSoporte.cb_Computadoras, null);
            }

            if (vistaTSoporte.rb_CambPantalla.Checked == false && vistaTSoporte.rb_LibRed.Checked == false && vistaTSoporte.rb_Desbloquear.Checked == false && vistaTSoporte.pl_celulares.Visible == true)
            {
                MessageBox.Show("Por favor seleccione una opción");
            }

            if(vistaTSoporte.rb_Mantenimiento.Checked == false && vistaTSoporte.rb_PromSoftware.Checked == false && vistaTSoporte.rb_Reparacion.Checked == false && vistaTSoporte.pl_computo.Visible == true)
            {
                MessageBox.Show("Por favor seleccione una opción");
            }

            TipoSoporteDAO tsoporteDAO = new TipoSoporteDAO();
            TipoSoporte tsoporte = new TipoSoporte();
            tsoporte.Soporte = Soporte();
            tsoporte.Marca = Marca();
            tsoporte.TipoDeSoporte = TipoSoporte();

            bool inserto = tsoporteDAO.InsertarTipoSoporte(tsoporte);

                
            if (inserto)
            {
                Deshabilitar();
                MessageBox.Show("Se inserto");
                MessageBox.Show("Por favor genere su ticket");
            }
            else
            {
                MessageBox.Show("No se inserto");
            }
            
        }

        public string Soporte()
        {
            string support = "";
            if(vistaTSoporte.rb_celulares.Checked == true)
            {
                support = "Reparación de Celulares";
            }
            else if(vistaTSoporte.rb_Computo.Checked == true)
            {
                support = "Equipo de Cómputo";
            }
            return support;
        }

        public string Marca()
        {
            int indice, indice2;
            string marca = "";

            indice = vistaTSoporte.cb_Computadoras.SelectedIndex;
            indice2 = vistaTSoporte.cb_Telefonos.SelectedIndex;

            if (indice == 0)
            {
                marca = "DELL";
            }
            else if (indice == 1)
            {
                marca = "HP";
            }
            else if (indice == 2)
            {
                marca = "Lenovo";
            }
            else if (indice2 == 0)
            {
                marca = "Samsung";
            }
            else if (indice2 == 1)
            {
                marca = "Iphone";
            }
            return marca;
        }

        public string TipoSoporte()
        {
            string tiposoporte = "";

            if (vistaTSoporte.rb_CambPantalla.Checked == true)
            {
                tiposoporte = "Cambio de pantalla";
            }
            else if (vistaTSoporte.rb_LibRed.Checked == true)
            {
                tiposoporte = "Liberar de red";
            }
            else if (vistaTSoporte.rb_Desbloquear.Checked == true)
            {
                tiposoporte = "Desbloquear";
            }
            else if (vistaTSoporte.rb_Mantenimiento.Checked == true)
            {
                tiposoporte = "Mantenimiento";
            }
            else if (vistaTSoporte.rb_PromSoftware.Checked == true)
            {
                tiposoporte = "Problema de software";
            }
            else if (vistaTSoporte.rb_Reparacion.Checked == true)
            {
                tiposoporte = "Reparación";
            }

            return tiposoporte;
        }

        private void Deshabilitar()
        {
            vistaTSoporte.rb_Computo.Checked = false;
            vistaTSoporte.rb_celulares.Checked = false;
            vistaTSoporte.btn_aceptar.Enabled = false;
            vistaTSoporte.pl_celulares.Visible = false;
            vistaTSoporte.pl_computo.Visible = false;
        }
    }
}
