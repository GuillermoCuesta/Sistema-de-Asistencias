using Sistema_de_Asistencias.Datos;
using Sistema_de_Asistencias.Logica;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Sistema_de_Asistencias.Presentacion
{
    public partial class CURegistro : Form
    {
        Personal parametros = new Personal();

        private ManualResetEvent evento = new ManualResetEvent(false);
        public CURegistro()
        {
            InitializeComponent();
            Show();
        }

        private static void buttonAddCargo_Click(object sender, EventArgs e)
        {
            CUCargo nuevo = new CUCargo();
            nuevo.Show();
        }

        public void limpiar()
        {
            textBoxNomApell.Text = "";
            textBoxIdent.Text = "";
            comboBoxPais.Text = "";
            comboBoxCargo.Text = "";
            textBoxSueldo.Text = "";
            comboBoxEstado.Text = "";
            textBoxCodigo.Text = "";
            pictureBoxUsuario.Image = null;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            limpiar();
            Close();
        }

        private void InsertarPersonal()
        {
            Personal parametros = new Personal();
            DPersonal funcion = new DPersonal();

            parametros.Nombre = textBoxNomApell.Text;
            parametros.Identificacion =Convert.ToInt32(textBoxIdent.Text);
            parametros.IdPais = comboBoxPais.SelectedIndex;
            parametros.IdCargo = comboBoxCargo.SelectedIndex;
            parametros.SueldoHora = Convert.ToDecimal(textBoxSueldo.Text);
            parametros.Estado = comboBoxEstado.Text;
            parametros.Codigo = Convert.ToInt32 (textBoxCodigo.Text);

            //using (MemoryStream ms = new MemoryStream())
            //{
            //    pictureBoxUsuario.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //    parametros.Foto = ms.ToArray();
            //}

            using (MemoryStream ms = new MemoryStream())
            {
                // Imagen original en formato JPEG
                pictureBoxUsuario.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                // Cargar la imagen original en un objeto Bitmap
                using (Bitmap bmpOriginal = new Bitmap(ms))
                {
                    // Crear un nuevo objeto Bitmap con una calidad menor (por ejemplo, calidad 50)
                    using (Bitmap bmpReducido = new Bitmap(bmpOriginal.Width, bmpOriginal.Height))
                    {
                        using (Graphics graphics = Graphics.FromImage(bmpReducido))
                        {
                            graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
                            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
                            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
                            graphics.DrawImage(bmpOriginal, 0, 0, bmpOriginal.Width, bmpOriginal.Height);
                        }

                        // Guardar el nuevo objeto Bitmap en un MemoryStream con calidad reducida
                        using (MemoryStream reducedMs = new MemoryStream())
                        {
                            bmpReducido.Save(reducedMs, System.Drawing.Imaging.ImageFormat.Jpeg);

                            // Asignar la imagen reducida a parametros.Foto
                            parametros.Foto = reducedMs.ToArray();
                        }
                    }
                }
            }




            funcion.InsertarPersonal(parametros);
        }


        private void buttonGuardarPersonal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNomApell.Text) && !string.IsNullOrEmpty(textBoxIdent.Text) && !string.IsNullOrEmpty(comboBoxPais.Text) && !string.IsNullOrEmpty(comboBoxCargo.Text) && !string.IsNullOrEmpty(textBoxSueldo.Text) && !string.IsNullOrEmpty(comboBoxEstado.Text) && !string.IsNullOrEmpty(textBoxCodigo.Text))
            {
                InsertarPersonal();
                limpiar();
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }

        }

        public void CargarCargos()
        {
            DCargo cargarC = new DCargo();
            DataTable dt = new DataTable();
            cargarC.cargarCargo(ref dt);
            comboBoxCargo.DataSource = dt;
            comboBoxCargo.ValueMember = "sueldoHora";
            comboBoxCargo.DisplayMember = "nombreCargo";
            limpiar();

            DPais cargarP = new DPais();
            DataTable parametros = new DataTable();
            cargarP.cargarPais(ref parametros);
            comboBoxPais.DataSource = parametros;
            comboBoxPais.DisplayMember = "nombre";
            limpiar();
        }

        private void CURegistro_Load(object sender, EventArgs e)
        {
            CargarCargos();
        }

        private void buttonAddCargo_Click_1(object sender, EventArgs e)
        {
            CUCargo nuevo = new CUCargo();
            nuevo.Owner = this;
            nuevo.Show();
        }

        private void textBoxSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarSueldo(e);
        }

        private void comboBoxCargo_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxCargo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string indice = Convert.ToString(comboBoxCargo.SelectedValue);

            textBoxSueldo.Text = indice;
        }

        public void EditarRegistro(Personal parametros)
        {
            this.parametros = parametros;
            using (MemoryStream ms = new MemoryStream(parametros.Foto))
            {
                // Crea una imagen a partir del MemoryStream
                Image imagen = Image.FromStream(ms);

                // Asigna la imagen al PictureBox
                pictureBoxUsuario.Image = imagen;
            }
            textBoxNomApell.Text = parametros.Nombre;
            textBoxIdent.Text = Convert.ToString(parametros.Identificacion);
            comboBoxPais.SelectedIndex = (int)parametros.IdPais;
            comboBoxCargo.SelectedIndex = (int)parametros.IdCargo;
            comboBoxEstado.Text = parametros.Estado;
            textBoxCodigo.Text = parametros.Codigo.ToString();
            textBoxSueldo.Text = parametros.SueldoHora.ToString();
        }

        private void buttonGuardarCamPersonal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNomApell.Text) && !string.IsNullOrEmpty(textBoxIdent.Text) && !string.IsNullOrEmpty(comboBoxPais.Text) && !string.IsNullOrEmpty(comboBoxCargo.Text) && !string.IsNullOrEmpty(textBoxSueldo.Text) && !string.IsNullOrEmpty(comboBoxEstado.Text) && !string.IsNullOrEmpty(textBoxCodigo.Text))
            {
                GuardarCambios();
                limpiar();
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
        }

        private void GuardarCambios()
        {
            DPersonal funcion = new DPersonal();

            this.parametros.Nombre = textBoxNomApell.Text;
            this.parametros.Identificacion = Convert.ToInt32 (textBoxIdent.Text);
            this.parametros.IdPais = comboBoxPais.SelectedIndex;
            this.parametros.IdCargo = comboBoxCargo.SelectedIndex;
            this.parametros.SueldoHora = Convert.ToDecimal(textBoxSueldo.Text);
            this.parametros.Estado = comboBoxEstado.Text;
            this.parametros.Codigo = Convert.ToInt32(textBoxCodigo.Text);
            // pictureBox1 es el nombre del PictureBox que contiene la imagen que quieres almacenar
            ImageConverter converter = new ImageConverter();

            this.parametros.Foto = (byte[])converter.ConvertTo(pictureBoxUsuario.Image, typeof(byte[]));

            funcion.EditarPersonal(this.parametros);
        }

        private void buttonTomarFoto_Click(object sender, EventArgs e)
        {
            CapturarFoto nuevaFoto = new CapturarFoto();
            DialogResult result = nuevaFoto.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBoxUsuario.Image = nuevaFoto.pictureBoxImagen.Image;
            }
        }


    }
}
