using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_de_Asistencias.Logica
{
    public partial class Cargo
    {
        public Cargo()
        {
            Personal = new HashSet<Personal>();
        }

        public int IdCargo { get; set; }
        public string NombreCargo { get; set; }
        public decimal? SueldoHora { get; set; }

        public virtual ICollection<Personal> Personal { get; set; }
    }
}
