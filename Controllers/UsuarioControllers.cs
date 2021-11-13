using Ejercicio3.Modelos.DAO;
using Ejercicio3.Modelos.Entidades;
using Ejercicio3.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3.Controllers
{
    public class UsuarioControllers
    {
        LoginView vista;

        public UsuarioControllers(LoginView view)
        {
            vista = view;

            vista.btn_Aceptar.Click += new EventHandler(ValidarUsuario);
            vista.btn_Registrarse.Click += new EventHandler(Registrarse);
        }

        private void ValidarUsuario(Object sender, EventArgs e)
        {
            bool esValido = false;

            UsuarioDAO userDAO = new UsuarioDAO();

            Usuario user = new Usuario();

            user.CORREO = vista.txt_usuario.Text;
            user.CONTRASENA = encriptar_Contrasena(vista.txt_pass.Text);

            esValido = userDAO.ValidarUsuario(user);

            if (esValido)
            {
                MenuView Menu = new MenuView();
                vista.Hide();
                Menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }
        }

        private void Registrarse(object sender, EventArgs e)
        {
            string correo = vista.txt_correo.Text + vista.lbl_correo.Text;
            if(vista.txt_ConfirmarCorreo.Text != correo)
            {
                vista.errorProvider1.SetError(vista.txt_ConfirmarCorreo, "Los correos no coinciden.");
                vista.txt_ConfirmarCorreo.Focus();
                return;
            }

            if (vista.txt_ConfirmarContrasena.Text != vista.txt_Contrasena.Text)
            {
                vista.errorProvider1.SetError(vista.txt_ConfirmarContrasena, "Las contraseñas no coinciden.");
                vista.txt_ConfirmarContrasena.Focus();
                return;
            }

            if (vista.txt_Nombre.Text == "Nombres" || vista.txt_Apellido.Text == "Apellidos" || vista.txt_correo.Text=="Correo" || vista.txt_ConfirmarCorreo.Text == "Confirmar correo" ||vista.txt_Contrasena.Text == "Contraseña" || vista.txt_ConfirmarContrasena.Text == "Confirmar contraseña")
            {
                MessageBox.Show("Ingrese sus datos");
                return;
            }

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            Usuario usuario = new Usuario();


            usuario.NOMBRES = vista.txt_Nombre.Text;
            usuario.APELLIDOS = vista.txt_Apellido.Text;
            usuario.CORREO = vista.txt_ConfirmarCorreo.Text;
            usuario.CONTRASENA = vista.txt_ConfirmarContrasena.Text;

            bool insertar = usuarioDAO.CrearNuevoUsuario(usuario);

            if (insertar)
            {
                limpiar();
                MessageBox.Show("Registro Existoso", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo registrar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiar()
        {
            vista.txt_Nombre.Text = "Nombres";
            vista.txt_Apellido.Text = "Apellidos";
            vista.txt_correo.Text = "Correo";
            vista.txt_ConfirmarCorreo.Text = "Confirmar correo";
            vista.txt_Contrasena.Text = "Contraseña";
            vista.txt_ConfirmarContrasena.Text = "Confirmar contraseña";
        }
        public static string encriptar_Contrasena(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}
