using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_de_Asistencias.Logica
{
    public partial class Asistencia
    {
        public int IdAsistencia { get; set; }
        public int IdPersonal { get; set; }
        public DateTime? FechaEntrada { get; set; }
        public DateTime? FechaSalida { get; set; }
        public TimeSpan? HoraEntrada { get; set; }
        public TimeSpan? HoraSalida { get; set; }
        public string Estado { get; set; }
        public decimal? Horas { get; set; }
        public string Observaciones { get; set; }

        public virtual Personal IdPersonalNavigation { get; set; }
    }
}
