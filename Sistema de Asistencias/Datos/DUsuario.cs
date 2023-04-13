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
    public class DUsuario
    {

        public bool InsertarUsuario(Usuario parametros)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insertarUsuario", Conexion.conectar);
                Conexion.abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", parametros.nombreApellido);
                cmd.Parameters.AddWithValue("@Usuario", parametros.usuario);
                cmd.Parameters.AddWithValue("@Contraseña", parametros.contraseña);
                cmd.Parameters.AddWithValue("@Imagen", parametros.icono);
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
                SqlCommand cmd = new SqlCommand("editarUsuario", Conexion.conectar);
                Conexion.abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_usuario", parametros.id_usuario);
                cmd.Parameters.AddWithValue("@Nombre", parametros.nombreApellido);
                cmd.Parameters.AddWithValue("@Usuario", parametros.usuario);
                cmd.Parameters.AddWithValue("@Contraseña", parametros.contraseña);
                cmd.Parameters.AddWithValue("@Imagen", parametros.icono);
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
                SqlCommand cmd = new SqlCommand("cambiarEstadoUsuario", Conexion.conectar);
                Conexion.abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_usuario", parametros.id_usuario);
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
                SqlDataAdapter ad = new SqlDataAdapter("mostrarUsuario", Conexion.conectar);
                Conexion.abrir();
                ad.SelectCommand.CommandType = CommandType.StoredProcedure;
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

    }
}

