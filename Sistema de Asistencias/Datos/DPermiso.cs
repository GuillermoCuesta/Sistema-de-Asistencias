using Microsoft.Data.SqlClient;
using Sistema_de_Asistencias.Logica;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Asistencias.Datos
{
    public class DPermiso
    {
        public async Task<bool> InsertarPermisosAsync(Permiso parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("insertarPermiso", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_modulo", parametros.IdModulo);
                cmd.Parameters.AddWithValue("@id_usuario", parametros.IdUsuario);
                await cmd.ExecuteNonQueryAsync();
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

        public async Task<DataTable> MostrarPermisosAsync(Permiso parametros)
        {
            DataTable dt = new DataTable();
            try
            {
                Conexion.abrir();
                SqlCommand command = new SqlCommand("mostrarPermiso", Conexion.conectar);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id_usuario", parametros.IdUsuario);
                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    dt.Load(reader);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
            finally
            {
                Conexion.cerrar();
            }
            return dt;
        }

        public async Task<bool> EliminarPermisoAsync(Permiso parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("eliminarPermiso", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_usuario", parametros.IdUsuario);
                cmd.Parameters.AddWithValue("@id_modulo", parametros.IdModulo);
                await cmd.ExecuteNonQueryAsync();
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
