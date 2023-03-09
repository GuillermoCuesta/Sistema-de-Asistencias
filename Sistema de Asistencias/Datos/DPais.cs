using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Asistencias.Datos
{
    public class DPais
    {
        public void MostarPais(ref DataTable dt)
        {
            try
            {
                SqlDataAdapter ad = new SqlDataAdapter("mostrarPais", Conexion.conectar);
                ad.SelectCommand.CommandType = CommandType.StoredProcedure;
                ad.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
        }

        public void cargarPais(ref DataTable dt)
        {
            try
            {
                SqlDataAdapter ad = new SqlDataAdapter("cargarPais", Conexion.conectar);
                ad.SelectCommand.CommandType = CommandType.StoredProcedure;
                ad.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
                Console.WriteLine("que estara pasando 2");

            }

        }

    }
}
