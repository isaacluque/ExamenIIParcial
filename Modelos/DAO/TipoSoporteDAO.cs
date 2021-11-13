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
    public class TipoSoporteDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();
        public bool InsertarTipoSoporte(TipoSoporte tsoporte)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO TipoSoporte ");
                sql.Append(" VALUES (@Soporte, @Marca, @TipoDeSoporte); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Soporte", SqlDbType.NVarChar, 100).Value = tsoporte.Soporte;
                comando.Parameters.Add("@Marca", SqlDbType.NVarChar, 100).Value = tsoporte.Marca;
                comando.Parameters.Add("@TipoDeSoporte", SqlDbType.NVarChar, 100).Value = tsoporte.TipoDeSoporte;
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
