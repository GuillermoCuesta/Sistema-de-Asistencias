using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_de_Asistencias.Logica
{
    public partial class Usuario
    {
        public Usuario()
        {
            Permiso = new HashSet<Permiso>();
        }

        public int IdUsuario { get; set; }
        public string NombreApellido { get; set; }
        public string Usuario1 { get; set; }
        public string Contraseña { get; set; }
        public byte[] Icono { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<Permiso> Permiso { get; set; }
    }
}
