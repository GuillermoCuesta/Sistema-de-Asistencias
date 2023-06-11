using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Asistencias.Datos
{
    public class DModulo
    {
        public async Task<DataTable> MostrarModuloAsync()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand("mostrarModulo", Conexion.conectar);
                Conexion.abrir();
                command.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    dt.Load(reader);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Conexion.cerrar();
            }
            return dt;
        }
    }
}
