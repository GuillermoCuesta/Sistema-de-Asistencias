﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sistema_de_Asistencias.Logica
{
    public partial class Pais
    {
        public Pais()
        {
            Personal = new HashSet<Personal>();
        }

        public int IdPais { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Personal> Personal { get; set; }
    }
}
