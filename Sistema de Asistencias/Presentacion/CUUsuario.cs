using Sistema_de_Asistencias.Datos;
using Sistema_de_Asistencias.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Asistencias.Presentacion
{
    public partial class CUUsuario : UserControl
    {
        public CUUsuario()
        {
            InitializeComponent();
        }

        private int idUsuario;

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            CambiarVisibilidadRegistro();
        }

        private async void buttonActualizar_Click(object sender, EventArgs e)
        {
            await MostrarUsuarios();
        }

        private async void buttonGuardarCamUsuario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNomApell.Text) && !string.IsNullOrEmpty(textBoxUsuario.Text) && !string.IsNullOrEmpty(textBoxContraseña.Text) && pictureBoxIcono.Image != null)
            {
                await EditarUsuario();
                await ModificarPermisos();
                await MostrarUsuarios();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK);
            }
        }

        private async void buttonGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNomApell.Text) || string.IsNullOrEmpty(textBoxUsuario.Text) || string.IsNullOrEmpty(textBoxContraseña.Text) || string.IsNullOrEmpty(pictureBoxIcono.ToString()))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK);
            }
            else
            {
                await InsertarUsuarioAsync();
                await ModificarPermisos();
                await MostrarUsuarios();
                Limpiar();
            }
        }

        private async void buttonCambiarEstado_Click(object sender, EventArgs e)
        {
            await CambiarEstado();
            await MostrarUsuarios();
        }

        private void buttonIcono_Click(object sender, EventArgs e)
        {
            CargarIcono();
        }

        private async void buttonEditarUsuario_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            EditarUsuarioButton();
            await MostrarUsuarios();
            await MostrarModulos();
            ValidarPermisos();

            if (panelRegistro.Visible == false)
            {
                panelRegistro.Visible = true;
                buttonGuardarUsuario.Visible = true;
                buttonGuardarCamUsuario.Visible = true;
            }
        }

        private void LimpiarForm()
        {
            textBoxNomApell.Clear();
            textBoxUsuario.Clear();
            textBoxContraseña.Clear();

            for (int i = 0; i < checkedListBoxPermisos.Items.Count; i++)
            {
                checkedListBoxPermisos.SetItemChecked(i, false);
            }
        }

        private async Task MostrarModulos()
        {
            DModulo funcion = new DModulo();
            DataTable dt = await funcion.MostrarModuloAsync();

            checkedListBoxPermisos.DataSource = dt;
            checkedListBoxPermisos.DisplayMember = "modulo";
            checkedListBoxPermisos.ValueMember = "id_modulo";
        }

        private async void ValidarPermisos()
        {
            DPermiso funcion = new DPermiso();
            Permiso parametros = new Permiso();
            parametros.IdUsuario = idUsuario;

            DataTable dt = await funcion.MostrarPermisosAsync(parametros);

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

        private async Task InsertarUsuarioAsync()
        {
            DUsuario funcion = new DUsuario();
            Usuario parametro = new Usuario();

            parametro.NombreApellido = textBoxNomApell.Text;
            parametro.Usuario1 = textBoxUsuario.Text;
            parametro.Contraseña = textBoxContraseña.Text;
            ImageConverter converter = new ImageConverter();
            parametro.Icono = (byte[])converter.ConvertTo(pictureBoxIcono.Image, typeof(byte[]));

            await funcion.InsertarUsuarioAsync(parametro);
            idUsuario = await funcion.ObtenerUltimoUsuarioAsync();
            await ModificarPermisos();
        }

        private async Task EditarUsuario()
        {
            DUsuario funcion = new DUsuario();
            Usuario parametro = new Usuario();

            parametro.IdUsuario = idUsuario;
            parametro.NombreApellido = textBoxNomApell.Text;
            parametro.Usuario1 = textBoxUsuario.Text;
            parametro.Contraseña = textBoxContraseña.Text;
            ImageConverter converter = new ImageConverter();
            parametro.Icono = (byte[])converter.ConvertTo(pictureBoxIcono.Image, typeof(byte[]));
            await funcion.EditarUsuarioAsync(parametro);
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

        private async Task CambiarEstado()
        {
            DUsuario funcion = new DUsuario();
            Usuario parametro = new Usuario();

            try
            {
                parametro.IdUsuario = (int)dataGridViewUsuarios.SelectedCells[0].Value;
                await funcion.CambiarEstadoAsync(parametro);
                MessageBox.Show("El estado de : " + dataGridViewUsuarios.SelectedCells[1].Value + " fue cambiado con exito.", "Cambio De Estado", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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

        private async Task MostrarUsuarios()
        {
            DUsuario funcion = new DUsuario();

            DataTable dt = await funcion.MostarUsuariosAsync();

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

        private async void CambiarVisibilidadRegistro()
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
            Limpiar();
            await MostrarModulos();
        }



        private async Task ModificarPermisos()
        {
            DPermiso funcion = new DPermiso();
            Permiso permiso = new Permiso();
            permiso.IdUsuario = idUsuario;
            DataTable dt = new DataTable();

            dt = await funcion.MostrarPermisosAsync(permiso);

            List<string> valoresSeleccionados = new List<string>();

            foreach (var item in checkedListBoxPermisos.CheckedItems)
            {
                DataRowView row = item as DataRowView;
                string valueMember = row[checkedListBoxPermisos.ValueMember].ToString();
                valoresSeleccionados.Add(valueMember);
            }

            foreach (string valorSeleccionado in valoresSeleccionados)
            {
                bool existeEnDataTable = false;

                foreach (DataRow row in dt.Rows)
                {
                    if (row[0].ToString() == valorSeleccionado)
                    {
                        existeEnDataTable = true;
                        break;
                    }
                }

                if (!existeEnDataTable)
                {
                    // Llamar al método InsertarPermisos
                    Permiso nuevoPermiso = new Permiso();
                    nuevoPermiso.IdModulo = Convert.ToInt32(valorSeleccionado);
                    nuevoPermiso.IdUsuario = idUsuario;
                    await funcion.InsertarPermisosAsync(nuevoPermiso);
                }
            }

            foreach (DataRow row in dt.Rows)
            {
                string id_Modulo = row[0].ToString();

                if (!valoresSeleccionados.Contains(id_Modulo))
                {
                    // Llamar al método EliminarPermiso
                    Permiso permisoEliminar = new Permiso();
                    permisoEliminar.IdModulo = Convert.ToInt32(id_Modulo);
                    permisoEliminar.IdUsuario = idUsuario;
                    await funcion.EliminarPermisoAsync(permisoEliminar);
                }
            }
        }


    }
}
