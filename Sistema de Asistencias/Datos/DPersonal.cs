using Microsoft.Data.SqlClient;
using Sistema_de_Asistencias.Logica;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_de_Asistencias.Datos
{
    internal class DPersonal
    {

        public bool InsertarPersonal(Personal parametros)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand("insertarPersonal", Conexion.conectar);
                Conexion.abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@id_pais", parametros.IdPais);
                cmd.Parameters.AddWithValue("@id_cargo", parametros.IdCargo);
                cmd.Parameters.AddWithValue("@sueldoHora", parametros.SueldoHora);
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                Conexion.cerrar();
            }

        }

        public bool EditarPersonal(Personal parametros)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand("editarPersonal", Conexion.conectar);
                Conexion.abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_personal", parametros.IdPersonal);
                cmd.Parameters.AddWithValue("@nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@id_pais", parametros.IdPais);
                cmd.Parameters.AddWithValue("@id_cargo", parametros.IdCargo);
                cmd.Parameters.AddWithValue("@sueldoHora", parametros.SueldoHora);
                cmd.Parameters.AddWithValue("@estado", parametros.Estado);
                cmd.Parameters.AddWithValue("@codigo", parametros.Codigo);
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                Conexion.cerrar();
            }

        }

        public bool EliminarPersonal(Personal parametros)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand("eliminarPersonal", Conexion.conectar);
                Conexion.abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_personal", parametros.IdPersonal);
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                Conexion.cerrar();
            }

        }

        public void BuscarPersonal(ref DataTable dt, int desde, int hasta, string buscador)
        {
            try
            {
                SqlDataAdapter ad = new SqlDataAdapter("buscarPersonal", Conexion.conectar);
                ad.SelectCommand.CommandType = CommandType.StoredProcedure;
                //ad.SelectCommand.Parameters.AddWithValue("@Desde", desde);
                //ad.SelectCommand.Parameters.AddWithValue("@hasta", hasta);
                ad.SelectCommand.Parameters.AddWithValue("@Buscador", buscador);


                ad.Fill(dt);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.StackTrace);
            }

        }

        public void MostarPersonal(ref DataTable dt, int desde, int hasta)
        {
            try
            {
                SqlDataAdapter ad = new SqlDataAdapter("mostrarPersonal", Conexion.conectar);
                ad.SelectCommand.CommandType = CommandType.StoredProcedure;
                ad.SelectCommand.Parameters.AddWithValue("@Desde", desde);
                ad.SelectCommand.Parameters.AddWithValue("@hasta", hasta);
                ad.Fill(dt);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.StackTrace);
            }
        }

        public void ContarPersonal(ref int contador)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select Count(id_personal) from Personal", Conexion.conectar);
                Conexion.abrir();

                contador = (int)cmd.ExecuteScalar();
            }
            catch (Exception)
            {

                contador = 0;
            }
            finally { Conexion.cerrar(); }
        }

    }
}
