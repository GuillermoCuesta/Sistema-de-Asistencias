namespace Sistema_de_Asistencias.Logica
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string nombreApellido { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public byte[] icono { get; set; }
        public string estado { get; set; }
    }
}
