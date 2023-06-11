using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_de_Asistencias.Logica
{
    public partial class Personal
    {
        public Personal()
        {
            Asistencia = new HashSet<Asistencia>();
        }

        public int IdPersonal { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public int IdPais { get; set; }
        public int IdCargo { get; set; }
        public decimal? SueldoHora { get; set; }
        public string Estado { get; set; }
        public string Codigo { get; set; }
        public byte[] Foto { get; set; }

        public virtual Cargo IdCargoNavigation { get; set; }
        public virtual Pais IdPaisNavigation { get; set; }
        public virtual ICollection<Asistencia> Asistencia { get; set; }
    }
}
