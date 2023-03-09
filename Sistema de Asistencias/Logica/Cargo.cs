using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_de_Asistencias.Logica
{
    public class Cargo
    {
        public int IdCargo { get; set; }
        public string NombreCargo { get; set; }
        public decimal? SueldoHora { get; set; }
    }
}
