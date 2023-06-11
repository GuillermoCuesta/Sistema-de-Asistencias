using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_de_Asistencias.Logica
{
    public partial class Permiso
    {
        public int IdModulo { get; set; }
        public int IdUsuario { get; set; }

        public virtual Modulo IdModuloNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
