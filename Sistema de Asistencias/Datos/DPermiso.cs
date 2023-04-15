using Microsoft.Data.SqlClient;
using Sistema_de_Asistencias.Logica;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_de_Asistencias.Datos
{
    public class DPermiso
    {
        public bool InsertarPermisos(Permiso parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("insertarPermiso", Conexion.conectar);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_modulo", parametros.id_modulo);
                cmd.Parameters.AddWithValue("@id_usuario", parametros.id_usuario);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally { Conexion.cerrar(); }
        }

        public void MostrarPermisos(ref DataTable dt, Permiso parametros)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter ad = new SqlDataAdapter("mostrarPermiso", Conexion.conectar);
                ad.SelectCommand.CommandType = CommandType.StoredProcedure;
                ad.SelectCommand.Parameters.AddWithValue("@id_usuario", parametros.id_usuario);
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

        public bool EliminarPermiso(ref DataTable dt, Permiso parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("eliminarPermiso", Conexion.conectar);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
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
    }
}
