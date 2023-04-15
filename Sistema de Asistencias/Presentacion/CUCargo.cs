using Sistema_de_Asistencias.Datos;
using Sistema_de_Asistencias.Logica;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_de_Asistencias.Presentacion
{
    public partial class CUCargo : Form
    {
        int IDCargo = 0;
        public CUCargo()
        {
            InitializeComponent();
            Show();
        }

        private void buttonRegresarCargo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InsertaCargos()
        {
            if (!string.IsNullOrEmpty(textBoxCargoNew.Text))
            {
                if (!string.IsNullOrEmpty(textBoxSueldoNew.Text))
                {
                    Cargo parametros = new Cargo();
                    DCargo funcion = new DCargo();

                    parametros.NombreCargo = textBoxCargoNew.Text;
                    parametros.SueldoHora = Convert.ToDecimal(textBoxSueldoNew.Text);

                    if (funcion.InsertarCargo(parametros) == true)
                    {
                        textBoxCargoNew.Clear();
                        textBoxSueldoNew.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se pude insertar al cargo", "Cargo no Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Agrege el Sueldo", "Falta el Suelto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Agrege el Cargo", "Falta el Cargo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void buttonRegresarCargo_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGuardarCarg_Click(object sender, EventArgs e)
        {
            InsertaCargos();
        }

        private void textBoxSueldoNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.ValidarSueldo(e);
        }

        public void CargarCargos()
        {
            DCargo cargarC = new DCargo();
            DataTable dt = new DataTable();
            cargarC.BuscarCargo(ref dt, textBoxCargoNew.Text);
            ListadoCargos.DataSource = dt;
        }

        private void textBoxCargoNew_TextChanged(object sender, EventArgs e)
        {
            CargarCargos();
        }

        private void ListadoCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDCargo = Convert.ToInt32(ListadoCargos.SelectedCells[0].Value);
            textBoxCargoNew.Text = ListadoCargos.SelectedCells[1].Value.ToString();
            textBoxSueldoNew.Text = ListadoCargos.SelectedCells[2].Value.ToString();
        }

        private void buttonGuardarCCarg_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCargoNew.Text))
            {
                if (!string.IsNullOrEmpty(textBoxSueldoNew.Text))
                {
                    DCargo funcion = new DCargo();
                    Cargo parametros = new Cargo();

                    parametros.IdCargo = IDCargo;
                    parametros.NombreCargo = textBoxCargoNew.Text;
                    parametros.SueldoHora = Convert.ToDecimal(textBoxSueldoNew.Text);

                    if (funcion.EditarCargo(parametros) == true)
                    {
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se pude insertar al cargo", "Cargo no Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Agrege el Sueldo", "Falta el Suelto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Agrege el Cargo", "Falta el Cargo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void limpiar()
        {
            textBoxCargoNew.Clear();
            textBoxSueldoNew.Clear();
        }


        private void CUCargo_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ListadoCargos.Visible == true)
            {
                ListadoCargos.Visible = false;

                Width = MinimumSize.Width;
                Height = MinimumSize.Height;
                buttonPanelCargo.Image = Sistema_de_Asistencias.Properties.Resources.ultima;

                CenterToScreen();
            }
            else
            {
                ListadoCargos.Visible = true;
                Width = MaximumSize.Width;
                Height = MaximumSize.Height;
                buttonPanelCargo.Image = Sistema_de_Asistencias.Properties.Resources.primera;
                CenterToScreen();

            }


        }
    }

}