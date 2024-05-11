using Microsoft.Data.SqlClient;

namespace Sistema_de_Asistencias.Datos
{
    public class Conexion
    {

        public static string coneccion = @"Server=MEMO; Database=ASSISTANCE_MANAGEMENT_DB; User=sa; Password=2109; Trusted_Connection=False;";
        public static SqlConnection conectar = new SqlConnection(coneccion);

        public static void abrir()
        {
            if (conectar.State == System.Data.ConnectionState.Closed)
            {
                conectar.Open();
            }
        }

        public static void cerrar()
        {
            if (conectar.State == System.Data.ConnectionState.Open)
            {
                conectar.Close();
            }

        }
    }
}
