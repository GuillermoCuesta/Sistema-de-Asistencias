using Sistema_de_Asistencias.Datos;
using Sistema_de_Asistencias.Logica;
using System;
using System.Data;
using System.Drawing;
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
            parametros.Identificacion = textBoxIdent.Text;
            parametros.IdPais = comboBoxPais.SelectedIndex;
            parametros.IdCargo = comboBoxCargo.SelectedIndex;
            parametros.SueldoHora = Convert.ToDecimal(textBoxSueldo.Text);
            parametros.Estado = comboBoxEstado.Text;
            parametros.Codigo = textBoxCodigo.Text;

            using (MemoryStream ms = new MemoryStream())
            {
                pictureBoxUsuario.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                parametros.foto = ms.ToArray();
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
            comboBoxCargo.DisplayMember = "nombre_cargo";
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
            using (MemoryStream ms = new MemoryStream(parametros.foto))
            {
                // Crea una imagen a partir del MemoryStream
                Image imagen = Image.FromStream(ms);

                // Asigna la imagen al PictureBox
                pictureBoxUsuario.Image = imagen;
            }
            textBoxNomApell.Text = parametros.Nombre;
            textBoxIdent.Text = parametros.Identificacion;
            comboBoxPais.SelectedIndex = (int)parametros.IdPais;
            comboBoxCargo.SelectedIndex = (int)parametros.IdCargo;
            comboBoxEstado.Text = parametros.Estado;
            textBoxCodigo.Text = parametros.Codigo;
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
            this.parametros.Identificacion = textBoxIdent.Text;
            this.parametros.IdPais = comboBoxPais.SelectedIndex;
            this.parametros.IdCargo = comboBoxCargo.SelectedIndex;
            this.parametros.SueldoHora = Convert.ToDecimal(textBoxSueldo.Text);
            this.parametros.Estado = comboBoxEstado.Text;
            this.parametros.Codigo = textBoxCodigo.Text;
            // pictureBox1 es el nombre del PictureBox que contiene la imagen que quieres almacenar
            ImageConverter converter = new ImageConverter();

            this.parametros.foto = (byte[])converter.ConvertTo(pictureBoxUsuario.Image, typeof(byte[]));

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
