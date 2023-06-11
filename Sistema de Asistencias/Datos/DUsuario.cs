using Microsoft.Data.SqlClient;
using Sistema_de_Asistencias.Logica;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_de_Asistencias.Datos
{
    public class DUsuario
    {

        public bool InsertarUsuario(Usuario parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("insertarUsuario", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", parametros.NombreApellido);
                cmd.Parameters.AddWithValue("@Usuario", parametros.Usuario1);
                cmd.Parameters.AddWithValue("@Contraseña", parametros.Contraseña);
                cmd.Parameters.AddWithValue("@Imagen", parametros.Icono);
                cmd.Parameters.AddWithValue("@Estado", "Activo");
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

        public bool EditarUsuario(Usuario parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("editarUsuario", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_usuario", parametros.IdUsuario);
                cmd.Parameters.AddWithValue("@Nombre", parametros.NombreApellido);
                cmd.Parameters.AddWithValue("@Usuario", parametros.Usuario1);
                cmd.Parameters.AddWithValue("@Contraseña", parametros.Contraseña);
                cmd.Parameters.AddWithValue("@Imagen", parametros.Icono);
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

        public bool CambiarEstado(Usuario parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("cambiarEstadoUsuario", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_usuario", parametros.IdUsuario);
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

        public void BuscarUsuario(ref DataTable dt, string buscador)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter ad = new SqlDataAdapter("buscarUsuario", Conexion.conectar);
                ad.SelectCommand.CommandType = CommandType.StoredProcedure;
                ad.SelectCommand.Parameters.AddWithValue("@Buscador", buscador);
                ad.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
            finally
            {
                Conexion.cerrar();
            }

        }

        public void MostarUsuarios(ref DataTable dt)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter ad = new SqlDataAdapter("mostrarUsuario", Conexion.conectar);
                ad.SelectCommand.CommandType = CommandType.StoredProcedure;
                ad.Fill(dt);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Conexion.cerrar();
            }
        }

    }
}

