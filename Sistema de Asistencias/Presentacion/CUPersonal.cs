using Sistema_de_Asistencias.Datos;
using Sistema_de_Asistencias.Logica;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Sistema_de_Asistencias.Presentacion
{
    public partial class CUPersonal : UserControl
    {

        int IDCargo = 0;
        int desde = 1;
        int hasta = 5;
        int PagActual = 1;
        int IDPersonal;
        private int itemsPagina = 5;
        string Estado;
        decimal totalPaginas;
        private int contador;

        public CUPersonal()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            CURegistro registro = new CURegistro();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            ReiniciarPaginado();
            MostrarPersonal();
            Paginar();
        }

        private void buttonAdelante_Click(object sender, EventArgs e)
        {
            if (PagActual < totalPaginas)
            {
                desde += 5;
                hasta += 5;
                PagActual += 1;
                Paginar();
                MostrarPersonal();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DPersonal funcion = new DPersonal();
            DataTable dt = new DataTable();
            funcion.BuscarPersonal(ref dt, Convert.ToInt32(labelNumerador.Text), Convert.ToInt32(labelDenominador.Text), textBoxBuscarPers.Text);
            dataGridView1.DataSource = dt;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EliminarPersonal();
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            EditarPersonal();
        }
        private void EliminarPersonal()
        {
            try
            {
                IDPersonal = (int)dataGridView1.SelectedCells[0].Value;

                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el archivo?", "Eliminar archivo", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Código para eliminar el archivo
                    DPersonal funcion = new DPersonal();
                    Personal parametros = new Personal();

                    parametros.IdPersonal = IDPersonal;
                    funcion.EliminarPersonal(parametros);

                    MostrarPersonal();
                    MessageBox.Show(dataGridView1.SelectedCells[1].Value + " Fue eliminado con exito.");
                }
                else
                {
                    // Código para cancelar la operación
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }

        private void MostrarPersonal()
        {
            DPersonal funcion = new DPersonal();
            DataTable dt = new DataTable();

            funcion.MostarPersonal(ref dt, desde, hasta);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;

            Metodos.DiseñoEliminados(ref dataGridView1);
        }

        private void EditarPersonal()
        {
            try
            {
                CURegistro EditRegistro = new CURegistro();
                DPersonal funcion = new DPersonal();
                Personal parametros = new Personal();

                parametros.IdPersonal = (int)dataGridView1.SelectedCells[0].Value;
                parametros.Nombre = (string)dataGridView1.SelectedCells[1].Value;
                parametros.Identificacion = (string)dataGridView1.SelectedCells[2].Value;
                parametros.SueldoHora = (decimal?)dataGridView1.SelectedCells[3].Value;
                parametros.IdCargo = (int)dataGridView1.SelectedCells[5].Value;
                parametros.Estado = (string)dataGridView1.SelectedCells[6].Value;
                parametros.Codigo = (string)dataGridView1.SelectedCells[7].Value;
                parametros.IdPais = (int)dataGridView1.SelectedCells[8].Value;

                //if (dataGridView1.SelectedCells[9].Value.ToString() != "")
                //{
                try
                {
                    parametros.Foto = (byte[])(dataGridView1.SelectedCells[9].Value);
                }
                catch (Exception e)
                {
                    Image imgDefault = Properties.Resources.usuario2; // Cargar imagen predeterminada desde recursos
                    using (var ms = new MemoryStream())
                    {
                        imgDefault.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Guardar imagen en memoria
                        parametros.Foto = ms.ToArray(); // Asignar la imagen como un array de bytes al parámetro
                    }
                }
                //}
                EditRegistro.EditarRegistro(parametros);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("Seleccione el personal primero", "Error");
            }


        }

        private void dataGridView1_AllowUserToOrderColumnsChanged(object sender, EventArgs e)
        {
            Metodos.DiseñoEliminados(ref dataGridView1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Metodos.DiseñoEliminados(ref dataGridView1);
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            if (PagActual > 1)
            {
                desde -= 5;
                hasta -= 5;
                PagActual -= 1;
                Paginar();
                MostrarPersonal();
            }
        }

        private void Contar()
        {
            DPersonal funcion = new DPersonal();
            funcion.ContarPersonal(ref contador);
        }

        private void Paginar()
        {
            try
            {
                Contar();
                labelNumerador.Text = PagActual.ToString();
                decimal numero = (decimal)contador / itemsPagina;
                totalPaginas = Math.Round(numero, 0, MidpointRounding.AwayFromZero);
                labelDenominador.Text = totalPaginas.ToString();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        private void ReiniciarPaginado()
        {
            desde = 1;
            hasta = 5;

            PagActual = 1;

            Paginar();
        }
    }
}
