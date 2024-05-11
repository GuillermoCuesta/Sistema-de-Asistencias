using Sistema_de_Asistencias.Datos;
using Sistema_de_Asistencias.Logica;
using System;
using System.Data;
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
        private string nombre;
        private int idPersonal;
        private int Contador;
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
                fechaRegistro = (DateTime)dt.Rows[0]["fechaEntrada"];
                horaRegistro = (TimeSpan)dt.Rows[0]["horaEntrada"];
                labelDatosEntrada.Text = $"Entrada registrada el {fechaRegistro.ToShortDateString()} a las {horaRegistro}";
                return true;
            }
            else
            {
                labelDatosEntrada.Text = "No se encuentran entradas registradas activas!";
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
                idPersonal = (Int32)dt.Rows[0]["idPersonal"];
                nombre = labelNombre.Text = dt.Rows[0]["nombre"].ToString();
                BuscarAsistencia();

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

            asistencia.IdPersonal = idPersonal;
            asistencia.FechaEntrada = DateTime.Now;
            asistencia.FechaSalida = DateTime.Now;
            asistencia.HoraEntrada = DateTime.Now.TimeOfDay;
            asistencia.HoraSalida = DateTime.Now.TimeOfDay;
            asistencia.Estado = "Entrada";
            asistencia.Horas = 0;
            asistencia.Observaciones = textBoxObservaciones.Text;

            if (funcion.InsertarAsistemcia(asistencia) == true)
            {
                MessageBox.Show($"La Entrada de {nombre}, ha sido registrada exitosamente a las {asistencia.HoraEntrada}", MessageBoxButtons.OK.ToString());
                Limpiar();
            }
        }

        private void InsertarSalida()
        {
            Asistencia asistencia = new Asistencia();
            DAsistencia funcion = new DAsistencia();

            asistencia.IdPersonal = idPersonal;
            asistencia.FechaSalida = DateTime.Now;
            asistencia.HoraSalida = DateTime.Now.TimeOfDay;
            asistencia.Horas = CalcularHorasTranscurridas();

            if (funcion.InsertarSalida(asistencia) == true)
            {
                MessageBox.Show($"La Salida de {nombre}, ha sido registrada exitosamente a las {asistencia.HoraSalida}", MessageBoxButtons.OK.ToString());
                Limpiar();
            }
        }

        private void Limpiar()
        {
            labelNombre.Text = "";
            textBoxIdentAsis.Clear();
            textBoxObservaciones.Clear();
            labelDatosEntrada.Text = "";
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
