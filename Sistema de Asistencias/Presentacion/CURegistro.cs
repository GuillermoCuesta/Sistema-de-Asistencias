using Sistema_de_Asistencias.Datos;
using Sistema_de_Asistencias.Logica;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_de_Asistencias.Presentacion
{
    public partial class CURegistro : Form
    {
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

            funcion.InsertarPersonal(parametros);
        }

        private void buttonGuardarPersonal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNomApell.Text) && !string.IsNullOrEmpty(textBoxIdent.Text) && !string.IsNullOrEmpty(comboBoxPais.Text) && !string.IsNullOrEmpty(comboBoxCargo.Text) && !string.IsNullOrEmpty(textBoxSueldo.Text))
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
            string indice =Convert.ToString( comboBoxCargo.SelectedValue);

            textBoxSueldo.Text = indice;
        }

        public void EditarRegistro(Personal parametros)
        {
            textBoxNomApell.Text = parametros.Nombre;
            textBoxIdent.Text = parametros.Identificacion;
            comboBoxPais.SelectedIndex = (int)parametros.IdPais;
            comboBoxCargo.SelectedIndex = (int)parametros.IdCargo;
            textBoxEstado.Text = parametros.Estado;
            textBoxCodigo.Text = parametros.Codigo;
            textBoxSueldo.Text = parametros.SueldoHora.ToString();
        }

        private void buttonGuardarCamPersonal_Click(object sender, EventArgs e)
        {
            GuardarCambios();
        }

        private void GuardarCambios()
        {
            Personal parametros = new Personal();
            DPersonal funcion = new DPersonal();

            parametros.Nombre = textBoxNomApell.Text;
            parametros.Identificacion = textBoxIdent.Text;
            parametros.IdPais = comboBoxPais.SelectedIndex;
            parametros.IdCargo = comboBoxCargo.SelectedIndex;
            parametros.SueldoHora = Convert.ToDecimal(textBoxSueldo.Text);
            parametros.Estado = textBoxEstado.Text ;
            parametros.Codigo = textBoxCodigo.Text ;

            funcion.EditarPersonal(parametros);
        }
    }
}
