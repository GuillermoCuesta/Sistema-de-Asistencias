using Microsoft.Data.SqlClient;
using Sistema_de_Asistencias.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Asistencias.Datos
{
    public class DAsistencia
    {
        public void BuscarAsistencias(ref DataTable dt, int Idpersonal)
        {
            try
            {
                SqlDataAdapter ad = new SqlDataAdapter("buscarAsistencias", Conexion.conectar);
                Conexion.abrir();
                ad.SelectCommand.CommandType = CommandType.StoredProcedure;
                ad.SelectCommand.Parameters.AddWithValue("@Idpersonal", Idpersonal);
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

        public bool InsertarAsistemcia(Asistencia parametros)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insertarAsistencia", Conexion.conectar);
                Conexion.abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idpersonal", parametros.id_personal);
                cmd.Parameters.AddWithValue("@FechaEntrada", parametros.Fecha_entrada);
                cmd.Parameters.AddWithValue("@FechaSalida", parametros.Fecha_salida);
                cmd.Parameters.AddWithValue("@HoraEntrada", parametros.Hora_entrada);
                cmd.Parameters.AddWithValue("@HoraSalida", parametros.Hora_salida);
                cmd.Parameters.AddWithValue("@Estado", parametros.Estado);
                cmd.Parameters.AddWithValue("@Horas", parametros.Horas);
                cmd.Parameters.AddWithValue("@Observaciones", parametros.Observaciones);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Console.WriteLine(e.Message);
                return false;   
            }
            finally
            {
                Conexion.cerrar();
            }
        }

        public bool InsertarSalida(Asistencia parametros)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insertarSalida", Conexion.conectar);
                Conexion.abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idpersonal", parametros.id_personal);
                cmd.Parameters.AddWithValue("@FechaSalida", parametros.Fecha_salida);
                cmd.Parameters.AddWithValue("@HoraSalida", parametros.Hora_salida);
                cmd.Parameters.AddWithValue("@Horas", parametros.Horas);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
                return false;
            }
            finally
            {
                Conexion.cerrar();
            }
        }
    }
}
