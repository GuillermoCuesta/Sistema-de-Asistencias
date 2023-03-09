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
    public partial class CURegistro : Form
    {
        public CURegistro()
        {
            InitializeComponent();
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
            InsertarPersonal();
            limpiar();
        }

        public void CargarCargos()
        {
            DCargo cargarC = new DCargo();
            DataTable dt = new DataTable();
            cargarC.cargarCargo(ref dt);
            comboBoxCargo.DataSource = dt;
            comboBoxCargo.DisplayMember = "nombre_cargo";
            limpiar();

            DPais cargarP = new DPais();
            DataTable parametros = new DataTable();
            cargarP.cargarPais(ref parametros);
            comboBoxPais.DataSource = parametros;
            comboBoxPais.DisplayMember = "nombre";
            limpiar();
        }

        private void InsertarCargos()
        {
            Cargo parametros = new Cargo();
            DCargo funcion = new DCargo();


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
    }
}
