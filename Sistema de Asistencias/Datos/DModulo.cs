using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_de_Asistencias.Datos
{
    public class DModulo
    {
        public void MostrarModulo(ref DataTable dt)
        {
            try
            {
                SqlDataAdapter ad = new SqlDataAdapter("mostrarModulo", Conexion.conectar);
                Conexion.abrir();
                ad.SelectCommand.CommandType = CommandType.StoredProcedure;
                ad.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Conexion.cerrar();
            }
        }
    }
}
