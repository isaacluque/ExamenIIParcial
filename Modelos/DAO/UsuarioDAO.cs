using Ejercicio3.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;

namespace Ejercicio3.Modelos.DAO
{
    public class UsuarioDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool ValidarUsuario(Usuario user)
        {
            bool valido = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT 1 FROM USUARIO WHERE CORREO = @Correo AND CONTRASENA = @Contrasena;");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Correo", SqlDbType.NVarChar, 50).Value = user.CORREO;
                comando.Parameters.Add("@Contrasena", SqlDbType.NVarChar, 50).Value = user.CONTRASENA;
                valido = Convert.ToBoolean(comando.ExecuteScalar());
            }
            catch (Exception)
            {

            }
            return valido;
        }

        public bool CrearNuevoUsuario(Usuario usuario)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO USUARIO ");
                sql.Append(" VALUES (@Nombres, @Apellidos, @Correo, @Contraseña); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Nombres", SqlDbType.NVarChar, 50).Value = usuario.NOMBRES;
                comando.Parameters.Add("@Apellidos", SqlDbType.NVarChar, 50).Value = usuario.APELLIDOS;
                comando.Parameters.Add("@Correo", SqlDbType.NVarChar, 50).Value = usuario.CORREO;
                comando.Parameters.Add("@Contraseña", SqlDbType.NVarChar, 50).Value = encriptar_Contrasena(usuario.CONTRASENA);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
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
