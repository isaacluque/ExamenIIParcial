using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Ejercicio3.Modelos.DAO;
using Ejercicio3.Modelos.Entidades;
using Ejercicio3.Views;

namespace Ejercicio3
{
    public class LoginEventsController
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        LoginView vista;
        MenuView vistas;


        public LoginEventsController(LoginView view)
        {
            vista = view;
            vista.lbl_Titulo.Text = vista.lbl_inicioSesion.Text;
            vista.tmr_Abrir.Tick += new EventHandler(TimerAbrir);
            vista.tmr_Cerrar.Tick += new EventHandler(TimerCerrar);
            vista.btn_CrearCuenta.Click += new EventHandler(iniciar_TimerAbrir);
            vista.btn_cancelar.Click += new EventHandler(iniciar_TimerCerrar);
            vista.btn_cerrar.Click += new EventHandler(Cerrar);
            vista.btn_minimizar.Click += new EventHandler(Minimizar);
            vista.panel1.MouseDown += new MouseEventHandler(mover_Ventana);
            vista.btn_ver.Click += new EventHandler(mostrar);
            vista.btn_ocultar.Click += new EventHandler(ocultar);
            vista.txt_Contrasena.Enter += new EventHandler(evento_enter);
            vista.txt_Contrasena.Leave += new EventHandler(evento_leave);
            vista.txt_ConfirmarContrasena.Enter += new EventHandler(evento_enter_confirmascontraseña);
            vista.txt_ConfirmarContrasena.Leave += new EventHandler(evento_leave_confirmascontraseña);
            vista.txt_Nombre.Enter += new EventHandler(evento_enter_Nombre);
            vista.txt_Nombre.Leave += new EventHandler(evento_leave_Nombre);
            vista.txt_Apellido.Enter += new EventHandler(evento_enter_Apellido);
            vista.txt_Apellido.Leave += new EventHandler(evento_leave_Apellido);
            vista.txt_correo.Enter += new EventHandler(evento_enter_correo);
            vista.txt_correo.Leave += new EventHandler(evento_leave_correo);
            vista.txt_ConfirmarCorreo.Enter += new EventHandler(evento_enter_ConfirmarCorreo);
            vista.txt_ConfirmarCorreo.Leave += new EventHandler(evento_leave_ConfirmarCorreo);
            vista.txt_usuario.Enter += new EventHandler(evento_enter_usuario);
            vista.txt_usuario.Leave += new EventHandler(evento_leave_usuario);
            vista.txt_pass.Enter += new EventHandler(evento_enter_pass);
            vista.txt_pass.Leave += new EventHandler(evento_leave_pass);
        }
        public LoginEventsController(MenuView views)
        {
            vistas = views;
            vistas.btn_cerrar.Click += new EventHandler(Cerrar);
            vistas.btn_minimizar.Click += new EventHandler(Minimizar2);
            vistas.panel2.MouseDown += new MouseEventHandler(mover_Ventana2);
        }


        private void TimerAbrir(object sender, EventArgs e)
        {
            if (vista.Pl_Registrer.Width < 350)
            {
                vista.lbl_Titulo.Text = vista.lbl_Registrarse.Text;
                vista.Pl_Registrer.Width = vista.Pl_Registrer.Width + 50;
            }
                

            else vista.tmr_Abrir.Stop();
        }

        private void TimerCerrar(object sender, EventArgs e)
        {
            if (vista.Pl_Registrer.Width > 0)
            {
                vista.lbl_Titulo.Text = vista.lbl_inicioSesion.Text;
                vista.Pl_Registrer.Width = vista.Pl_Registrer.Width - 50;
            }
            else vista.tmr_Cerrar.Stop();
        }

        private void iniciar_TimerAbrir(object sender, EventArgs e)
        {
            vista.tmr_Abrir.Start();
            
        }

        private void iniciar_TimerCerrar(object sender, EventArgs e)
        {
            vista.tmr_Cerrar.Start();
            Cancelar();
        }

        private void Cancelar()
        {
            vista.txt_Nombre.Text="Nombres";
            vista.txt_Apellido.Text="Apellidos";
            vista.txt_correo.Text="Correo";
            vista.txt_ConfirmarCorreo.Text = "Confirmar correo";
            vista.txt_Contrasena.Text = "Contraseña";
            vista.txt_ConfirmarContrasena.Text = "Confirmar contraseña";
        }

        private void Cerrar(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar(object sender, EventArgs e)
        {
            vista.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void Minimizar2(object sender, EventArgs e)
        {
            vistas.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void mover_Ventana2(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(vistas.Handle, 0x112, 0xf012, 0);
        }

        private void mover_Ventana(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(vista.Handle, 0x112, 0xf012, 0);
        }

        private void mostrar(object sender, EventArgs e)
        {
            if (vista.txt_Contrasena.Text=="Contraseña" && vista.txt_ConfirmarContrasena.Text=="Confirmar contraseña")
            {
                return;
            }
            else
            {
                vista.txt_Contrasena.PasswordChar = '\0';
                vista.txt_ConfirmarContrasena.PasswordChar = '\0';
                vista.btn_ver.Visible = false;
                vista.btn_ocultar.Visible = true;
            }
            
        }

        private void ocultar(object sender, EventArgs e)
        {
            vista.txt_Contrasena.PasswordChar = '*';
            vista.txt_ConfirmarContrasena.PasswordChar = '*';
            vista.btn_ocultar.Visible = false;
            vista.btn_ver.Visible = true;  
        }

        private void evento_enter(object sender, EventArgs e)
        {
            if(vista.txt_Contrasena.Text == "Contraseña")
            {
                vista.txt_Contrasena.Text = "";
            }
            if(vista.txt_Contrasena.Text == "")
            {
                vista.txt_Contrasena.PasswordChar = '*';
            }
        }

        private void evento_leave(object sender, EventArgs e)
        {
            if (vista.txt_Contrasena.Text == "")
            {
                vista.txt_Contrasena.Text = "Contraseña";
                vista.txt_Contrasena.PasswordChar = '\0';
            }
        }

        private void evento_enter_confirmascontraseña(object sender, EventArgs e)
        {
            if (vista.txt_ConfirmarContrasena.Text == "Confirmar contraseña")
            {
                vista.txt_ConfirmarContrasena.Text = "";
            }
            if (vista.txt_ConfirmarContrasena.Text == "")
            {
                vista.txt_ConfirmarContrasena.PasswordChar = '*';
            }
        }

        private void evento_leave_confirmascontraseña(object sender, EventArgs e)
        {
            if (vista.txt_ConfirmarContrasena.Text == "")
            {
                vista.txt_ConfirmarContrasena.Text = "Confirmar contraseña";
                vista.txt_ConfirmarContrasena.PasswordChar = '\0';
            }
        }

        private void evento_enter_Nombre(object sender, EventArgs e)
        {
            if (vista.txt_Nombre.Text == "Nombres")
            {
                vista.txt_Nombre.Text = "";
            }
        }

        private void evento_leave_Nombre(object sender, EventArgs e)
        {
            if (vista.txt_Nombre.Text == "")
            {
                vista.txt_Nombre.Text = "Nombres";
            }
        }

        private void evento_enter_Apellido(object sender, EventArgs e)
        {
            if (vista.txt_Apellido.Text == "Apellidos")
            {
                vista.txt_Apellido.Text = "";
            }
        }

        private void evento_leave_Apellido(object sender, EventArgs e)
        {
            if (vista.txt_Apellido.Text == "")
            {
                vista.txt_Apellido.Text = "Apellidos";
            }
        }

        private void evento_enter_correo(object sender, EventArgs e)
        {
            if (vista.txt_correo.Text == "Correo")
            {
                vista.txt_correo.Text = "";
            }
        }

        private void evento_leave_correo(object sender, EventArgs e)
        {
            if (vista.txt_correo.Text == "")
            {
                vista.txt_correo.Text = "Correo";
            }
        }

        private void evento_enter_ConfirmarCorreo(object sender, EventArgs e)
        {
            if (vista.txt_ConfirmarCorreo.Text == "Confirmar correo")
            {
                vista.txt_ConfirmarCorreo.Text = "";
            }
        }

        private void evento_leave_ConfirmarCorreo(object sender, EventArgs e)
        {
            if (vista.txt_ConfirmarCorreo.Text == "")
            {
                vista.txt_ConfirmarCorreo.Text = "Confirmar correo";
            }
        }

        private void evento_enter_usuario(object sender, EventArgs e)
        {
            if (vista.txt_usuario.Text == "CORREO")
            {
                vista.txt_usuario.Text = "";
            }
        }

        private void evento_leave_usuario(object sender, EventArgs e)
        {
            if (vista.txt_usuario.Text == "")
            {
                vista.txt_usuario.Text = "CORREO";
            }
        }

        private void evento_enter_pass(object sender, EventArgs e)
        {
            if (vista.txt_pass.Text == "CONTRASEÑA")
            {
                vista.txt_pass.Text = "";
                vista.txt_pass.PasswordChar = '*';
            }
        }

        private void evento_leave_pass(object sender, EventArgs e)
        {
            if (vista.txt_pass.Text == "")
            {
                vista.txt_pass.Text = "CONTRASEÑA";
                vista.txt_pass.PasswordChar = '\0';
            }
        }
    }
}
