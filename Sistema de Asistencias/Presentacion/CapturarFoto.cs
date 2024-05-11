using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Sistema_de_Asistencias.Presentacion
{
    public partial class CapturarFoto : Form
    {

        private string imagenes = @"C:\Users\gscue\source\repos\Sistema de Asistencias\imagenes";
        private bool dispositivos;
        private FilterInfoCollection misDispositivos;
        private VideoCaptureDevice miCamara;



        public CapturarFoto()
        {
            InitializeComponent();
        }

        private void CapturarFoto_Load(object sender, EventArgs e)
        {
            CargarDispositivos();
        }

        public void CargarDispositivos()
        {
            misDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (misDispositivos.Count > 0)
            {
                dispositivos = true;

                for (int i = 0; i < misDispositivos.Count; i++)
                    comboBoxDispositivos.Items.Add(misDispositivos[i].Name.ToString());

                comboBoxDispositivos.Text = misDispositivos[0].Name.ToString();
            }
            else
            {
                dispositivos = false;
            }
        }

        public void Actualizar(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            image.RotateFlip(RotateFlipType.Rotate180FlipNone);

            pictureBoxVideo.Invoke((MethodInvoker)delegate {
                pictureBoxVideo.Image = image;
                pictureBoxVideo.SizeMode = PictureBoxSizeMode.StretchImage;
            });
        }


        private void buttonGrabar_Click(object sender, EventArgs e)
        {
            CerrarCamara();
            int i = comboBoxDispositivos.SelectedIndex;
            string nombreVideo = misDispositivos[i].MonikerString;
            miCamara = new VideoCaptureDevice(nombreVideo);
            miCamara.NewFrame += new NewFrameEventHandler(Actualizar);
            miCamara.Start();
        }

        private void CerrarCamara()
        {
            if (miCamara != null && miCamara.IsRunning)
            {
                miCamara.SignalToStop();
                miCamara = null;
            }
        }

        private void CapturarFoto_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarCamara();
        }

        private void buttonCapturar_Click(object sender, EventArgs e)
        {
            if (miCamara != null && miCamara.IsRunning)
            {
                pictureBoxImagen.Image = pictureBoxVideo.Image;
            }
        }
        public event EventHandler EventoOcurrido;
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            pictureBoxImagen.Image.Save("Foto.jpeg", ImageFormat.Jpeg);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
