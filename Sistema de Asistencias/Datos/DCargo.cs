

using Microsoft.Data.SqlClient;
using Sistema_de_Asistencias.Logica;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_de_Asistencias.Datos
{
    public class DCargo
    {
        public bool InsertarCargo(Cargo parametros)

        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("insertarCargo", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cargo", parametros.NombreCargo);
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

        public bool EditarCargo(Cargo parametros)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("editarCargo", Conexion.conectar);
                Conexion.abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cargo", parametros.IdCargo);
                cmd.Parameters.AddWithValue("@cargo", parametros.NombreCargo);
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

        public void BuscarCargo(ref DataTable dt, string buscador)
        {
            try
            {
                SqlDataAdapter ad = new SqlDataAdapter("buscarCargos", Conexion.conectar);
                Conexion.abrir();
                ad.SelectCommand.CommandType = CommandType.StoredProcedure;
                ad.SelectCommand.Parameters.AddWithValue("@buscador", buscador);

                ad.Fill(dt); 
            }
            catch (Exception e)
            {

                MessageBox.Show(e.StackTrace);
            }

        }

        public void cargarCargo(ref DataTable dt)
        {
            try
            {
                SqlDataAdapter ad = new SqlDataAdapter("cargarCargo", Conexion.conectar);
                Conexion.abrir();
                ad.SelectCommand.CommandType = CommandType.StoredProcedure;
                ad.Fill(dt);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.StackTrace);
                Console.WriteLine("que estara pasando");
            }

        }

    }
}
