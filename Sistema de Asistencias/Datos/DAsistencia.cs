using Microsoft.Data.SqlClient;
using Sistema_de_Asistencias.Logica;
using System;
using System.Data;
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
                cmd.Parameters.AddWithValue("@Idpersonal", parametros.IdPersonal);
                cmd.Parameters.AddWithValue("@FechaEntrada", parametros.FechaEntrada);
                cmd.Parameters.AddWithValue("@FechaSalida", parametros.FechaSalida);
                cmd.Parameters.AddWithValue("@HoraEntrada", parametros.HoraEntrada);
                cmd.Parameters.AddWithValue("@HoraSalida", parametros.HoraSalida);
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
                cmd.Parameters.AddWithValue("@Idpersonal", parametros.IdPersonal);
                cmd.Parameters.AddWithValue("@FechaSalida", parametros.FechaSalida);
                cmd.Parameters.AddWithValue("@HoraSalida", parametros.HoraSalida);
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
