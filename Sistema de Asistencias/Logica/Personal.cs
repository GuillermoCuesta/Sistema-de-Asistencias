// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_de_Asistencias.Logica
{
    public class Personal
    {
        public int IdPersonal { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public int? IdPais { get; set; }
        public int? IdCargo { get; set; }
        public decimal? SueldoHora { get; set; }
        public string Estado { get; set; }
        public string Codigo { get; set; }
    }
}
