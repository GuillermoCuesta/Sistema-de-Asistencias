using Sistema_de_Asistencias.Datos;
using Sistema_de_Asistencias.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Asistencias.Presentacion
{
    public partial class TomarAsistencia : Form
    {
        public TomarAsistencia()
        {
            InitializeComponent();
        }

        private string identificacion;
        private int idPersonal;
        int Contador;
        DateTime fechaRegistro;
        TimeSpan horaRegistro;

        private void timerHora_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("hh:mm:ss");
            labelFecha.Text = DateTime.Now.ToShortDateString();
        }

        private bool BuscarAsistencia()
        {
            DataTable dt = new DataTable();
            DAsistencia funcion = new DAsistencia();

            funcion.BuscarAsistencias(ref dt, idPersonal);
            Contador = dt.Rows.Count;
            if (Contador > 0)
            {
                fechaRegistro = (DateTime)dt.Rows[0]["Fecha_entrada"];
                horaRegistro = (TimeSpan)dt.Rows[0]["Hora_entrada"];

                return true;
            }
            else
            {
                textBoxObservaciones.ReadOnly = true;
                return false;
            }
            
        }

        private void BuscarPersonalIdent()
        {
            DataTable dt = new DataTable();
            DPersonal funcion = new DPersonal();

            funcion.BuscarPersonalIdent(ref dt, textBoxIdentAsis.Text);

            if (dt.Rows.Count > 0)
            {
                identificacion = dt.Rows[0]["identificacion"].ToString();
                idPersonal = (Int32)dt.Rows[0]["id_personal"];
                labelNombre.Text = dt.Rows[0]["nombre"].ToString();
            }
        }

        private void InsertarAsistencia()
        {
            if (string.IsNullOrEmpty(textBoxObservaciones.Text))
            {
                textBoxObservaciones.Text = "Ninguna";
            }
            Asistencia asistencia = new Asistencia();
            DAsistencia funcion = new DAsistencia();

            asistencia.id_personal = idPersonal;
            asistencia.Fecha_entrada = DateTime.Now;
            asistencia.Fecha_salida = DateTime.Now;
            asistencia.Hora_entrada = DateTime.Now.TimeOfDay;
            asistencia.Hora_salida = DateTime.Now.TimeOfDay;
            asistencia.Estado = "Entrada";
            asistencia.Horas = 0;
            asistencia.Observaciones = textBoxObservaciones.Text;

            if(funcion.InsertarAsistemcia(asistencia) == true)
            {
                labelEstado.Text = "Entrada Registrada";
                textBoxIdentAsis.Clear();
            }
        }

        private void InsertarSalida()
        {

            Asistencia asistencia = new Asistencia();
            DAsistencia funcion = new DAsistencia();

            asistencia.id_personal = idPersonal;
            asistencia.Fecha_salida = DateTime.Now;
            asistencia.Hora_salida = DateTime.Now.TimeOfDay;
            asistencia.Horas = CalcularHorasTranscurridas();

            if (funcion.InsertarSalida(asistencia) == true)
            {
                labelEstado.Text = "Salida Registrada";
                textBoxIdentAsis.Clear();
            }
        }

        private int CalcularHorasTranscurridas()
        {
            DateTime fechaHoraRegistro = fechaRegistro.Date + horaRegistro;
            TimeSpan duracion = DateTime.Now - fechaHoraRegistro;

            int horas = (int)duracion.TotalHours;

            return horas;
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (BuscarAsistencia() == true)
            {
                InsertarSalida();
            }
            else
            {
                InsertarAsistencia();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            BuscarPersonalIdent();
        }
    }
}
