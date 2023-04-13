using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
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
