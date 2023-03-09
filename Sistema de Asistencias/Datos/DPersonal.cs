using Microsoft.Data.SqlClient;
using Sistema_de_Asistencias.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Asistencias.Datos
{
    internal class DPersonal
    {
        public bool InsertarPersonal(Personal parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("inseratarPersonal", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombres", parametros.Nombre);
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
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("editarPersonal", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_personal", parametros.IdPersonal);
                cmd.Parameters.AddWithValue("@nombres", parametros.Nombre);
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

        public bool EliminarPersonal(Personal parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("eliminarPersonal", Conexion.conectar);
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
                ad.SelectCommand.Parameters.AddWithValue("@Desde", desde);
                ad.SelectCommand.Parameters.AddWithValue("@hasta", hasta);
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

    }
}
