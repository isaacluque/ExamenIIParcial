using Ejercicio3.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Modelos.DAO
{
    public class EstadoTicketDAO:Conexion
    {
        SqlCommand comando = new SqlCommand();
        
        public bool InsertarEstadoTicket(EstadoTicket eTicket)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO EstadoTicket ");
                sql.Append(" VALUES (@EstadoDeTicket);");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@EstadoDeTicket", SqlDbType.NVarChar, 100).Value = eTicket.EstadoDeTicket;
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
