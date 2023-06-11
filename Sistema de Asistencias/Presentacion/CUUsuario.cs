﻿using Sistema_de_Asistencias.Datos;
using Sistema_de_Asistencias.Logica;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Sistema_de_Asistencias.Presentacion
{
    public partial class CUUsuario : UserControl
    {
        public CUUsuario()
        {
            InitializeComponent();
            MostrarUsuarios();
        }

        private int idUsuario;

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            CambiarVisibilidadRegistro();
        }

        private void limpiar()
        {
            textBoxNomApell.Clear();
            textBoxUsuario.Clear();
            textBoxContraseña.Clear();
            for (int i = 0; i < checkedListBoxPermisos.Items.Count; i++)
            {
                checkedListBoxPermisos.SetItemChecked(i, false);
            }
        }

        private void MostrarModulos()
        {
            DModulo funcion = new DModulo();
            DataTable dt = new DataTable();

            funcion.MostrarModulo(ref dt);
            checkedListBoxPermisos.DataSource = dt;
            checkedListBoxPermisos.DisplayMember = "modulo";
            checkedListBoxPermisos.ValueMember = "id_modulo";
        }

        private void ValidarPermisos()
        {
            DPermiso funcion = new DPermiso();
            DataTable dt = new DataTable();
            Permiso parametros = new Permiso();
            parametros.IdUsuario = idUsuario;

            funcion.MostrarPermisos(ref dt, parametros);

            foreach (DataRow row in dt.Rows)
            {
                int valorDf = Convert.ToInt32(row[0]); // Suponiendo que la columna de la DataTable es la primera (índice 0)

                // Comparar cada elemento del checkedListBoxPermisos con el valor de la DataTable
                for (int i = 0; i < checkedListBoxPermisos.Items.Count; i++)
                {
                    if (checkedListBoxPermisos.Items[i] is DataRowView dataRowView)
                    {
                        int valorCheckedListBox = Convert.ToInt32(dataRowView[checkedListBoxPermisos.ValueMember]);

                        // Comparar el valor del checkedListBoxPermisos con el valor de la DataTable
                        if (valorCheckedListBox == valorDf)
                        {
                            // Marcar la fila correspondiente en el checkedListBoxPermisos
                            checkedListBoxPermisos.SetItemChecked(i, true);
                        }
                    }
                }
            }


        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void buttonGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNomApell.Text) || string.IsNullOrEmpty(textBoxUsuario.Text) || string.IsNullOrEmpty(textBoxContraseña.Text) || string.IsNullOrEmpty(pictureBoxIcono.ToString()))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK);
            }
            else
            {
                InsertarUsuario();
                MostrarUsuarios();
                Limpiar();
            }
        }

        private void InsertarUsuario()
        {
            DUsuario funcion = new DUsuario();
            Usuario parametro = new Usuario();

            parametro.NombreApellido = textBoxNomApell.Text;
            parametro.Usuario1 = textBoxUsuario.Text;
            parametro.Contraseña = textBoxContraseña.Text;
            ImageConverter converter = new ImageConverter();
            parametro.Icono = (byte[])converter.ConvertTo(pictureBoxIcono.Image, typeof(byte[]));

            funcion.InsertarUsuario(parametro);
        }

        private void EditarUsuario()
        {
            DUsuario funcion = new DUsuario();
            Usuario parametro = new Usuario();

            parametro.IdUsuario = idUsuario;
            parametro.NombreApellido = textBoxNomApell.Text;
            parametro.Usuario1 = textBoxUsuario.Text;
            parametro.Contraseña = textBoxContraseña.Text;
            ImageConverter converter = new ImageConverter();
            parametro.Icono = (byte[])converter.ConvertTo(pictureBoxIcono.Image, typeof(byte[]));
            funcion.EditarUsuario(parametro);
        }

        private void Limpiar()
        {
            textBoxBuscarPers.Clear();
            textBoxNomApell.Clear();
            textBoxUsuario.Clear();
            textBoxContraseña.Clear();
            pictureBoxIcono.Image = null;
            dataGridViewUsuarios.CurrentCell = null;
            for (int i = 0; i < checkedListBoxPermisos.Items.Count; i++)
            {
                checkedListBoxPermisos.SetItemChecked(i, false);
            }

        }

        private void buttonGuardarCamUsuario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNomApell.Text) && !string.IsNullOrEmpty(textBoxUsuario.Text) && !string.IsNullOrEmpty(textBoxContraseña.Text) && pictureBoxIcono.Image != null)
            {
                EditarUsuario();
                MostrarUsuarios();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK);
            }
        }

        private void CambiarEstado()
        {
            DUsuario funcion = new DUsuario();
            Usuario parametro = new Usuario();

            try
            {
                parametro.IdUsuario = (int)dataGridViewUsuarios.SelectedCells[0].Value;
                funcion.CambiarEstado(parametro);
                MessageBox.Show("El estado de : " + dataGridViewUsuarios.SelectedCells[1].Value + " fue cambiado con exito.", "Cambio De Estado", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void buttonCambiarEstado_Click(object sender, EventArgs e)
        {
            CambiarEstado();
            MostrarUsuarios();
        }

        private void buttonIcono_Click(object sender, EventArgs e)
        {
            CargarIcono();
        }

        private void buttonEditarUsuario_Click(object sender, EventArgs e)
        {
            EditarUsuarioButton();
            MostrarUsuarios();
            MostrarModulos();
            ValidarPermisos();

            if (panelRegistro.Visible == false)
            {
                panelRegistro.Visible = true;
                buttonGuardarUsuario.Visible = true;
                buttonGuardarCamUsuario.Visible = true;
            }
        }

        private void CargarIcono()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog1.Title = "Seleccionar imagen";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string imagePath = openFileDialog1.FileName;
                Bitmap bitmap = new Bitmap(imagePath);
                // Mostrar la imagen en el PictureBox
                pictureBoxIcono.Image = bitmap;
            }
        }

        private void MostrarUsuarios()
        {
            DUsuario funcion = new DUsuario();
            DataTable dt = new DataTable();

            funcion.MostarUsuarios(ref dt);

            dataGridViewUsuarios.DataSource = dt;
            dataGridViewUsuarios.Columns[4].Visible = false;
            dataGridViewUsuarios.CurrentCell = null;

        }

        private void EditarUsuarioButton()
        {

            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                idUsuario = (int)dataGridViewUsuarios.SelectedCells[0].Value;
                textBoxNomApell.Text = (string)dataGridViewUsuarios.SelectedCells[1].Value;
                textBoxUsuario.Text = (string)dataGridViewUsuarios.SelectedCells[2].Value;
                textBoxContraseña.Text = (string)dataGridViewUsuarios.SelectedCells[3].Value;
                byte[] imagenBytes = (byte[])dataGridViewUsuarios.CurrentRow.Cells[4].Value;

                using (MemoryStream ms = new MemoryStream(imagenBytes))
                {
                    Image imagen = Image.FromStream(ms);
                    pictureBoxIcono.Image = imagen;
                }

            }
            else
            {
                MessageBox.Show("Seleccione un usuario primero", "Error", MessageBoxButtons.OK);
            }

        }

        private void CambiarVisibilidadRegistro()
        {
            if (panelRegistro.Visible == true)
            {
                panelRegistro.Visible = false;
                buttonGuardarUsuario.Visible = false;
                buttonGuardarCamUsuario.Visible = false;
            }
            else
            {
                panelRegistro.Visible = true;
                buttonGuardarUsuario.Visible = true;
                buttonGuardarCamUsuario.Visible = true;
            }
            limpiar();
            MostrarModulos();
        }

    }
}
