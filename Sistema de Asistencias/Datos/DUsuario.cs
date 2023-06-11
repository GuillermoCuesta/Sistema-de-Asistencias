using Microsoft.Data.SqlClient;
using Sistema_de_Asistencias.Logica;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Asistencias.Datos
{
    public class DUsuario
    {

        public async Task<bool> InsertarUsuarioAsync(Usuario parametros)
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

        public async Task<bool> EditarUsuarioAsync(Usuario parametros)
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

        public async Task<bool> CambiarEstadoAsync(Usuario parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("cambiarEstadoUsuario", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
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

        public async Task<DataTable> BuscarUsuarioAsync(string buscador)
        {
            DataTable dt = new DataTable();
            try
            {
                Conexion.abrir();
                SqlCommand command = new SqlCommand("buscarUsuario", Conexion.conectar);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Buscador", buscador);
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

        public async Task<DataTable> MostarUsuariosAsync()
        {
            DataTable dt = new DataTable();
            try
            {
                Conexion.abrir();
                SqlCommand command = new SqlCommand("mostrarUsuario", Conexion.conectar);
                command.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    dt.Load(reader);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Conexion.cerrar();
            }
            return dt;
        }


        public async Task<int> ObtenerUltimoUsuarioAsync()
        {
            int idUsuario = 0;
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("SELECT MAX(ID_USUARIO) FROM USUARIO;", Conexion.conectar);
                cmd.CommandType = CommandType.Text;
                idUsuario = (int)await cmd.ExecuteScalarAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Conexion.cerrar();
            }
            return idUsuario;
        }


    }
}

