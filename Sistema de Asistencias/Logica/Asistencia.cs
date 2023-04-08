using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Asistencias.Logica
{
    public class Asistencia
    {
        public int id_asistencia { get; set; }
        public int id_personal { get; set; }
        public DateTime Fecha_entrada { get; set; }  
        public DateTime Fecha_salida { get; set; }
        public TimeSpan Hora_entrada { get; set; }
        public TimeSpan Hora_salida { get; set; }
        public string Estado { get; set; }
        public int Horas { get; set; }
        public string Observaciones { get; set; }
    }
}
