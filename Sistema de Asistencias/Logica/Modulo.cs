using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_de_Asistencias.Logica
{
    public partial class Modulo
    {
        public Modulo()
        {
            Permiso = new HashSet<Permiso>();
        }

        public int IdModulo { get; set; }
        public string Modulo1 { get; set; }

        public virtual ICollection<Permiso> Permiso { get; set; }
    }
}
