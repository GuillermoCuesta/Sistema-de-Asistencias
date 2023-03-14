using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_de_Asistencias.Logica
{
    public class Metodos
    {
        public static void ValidarSueldo(KeyPressEventArgs e)
        {
            //Condición que solo nos permite ingresar datos de tipo texto
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            // condicion que permite no dar salto de línea cuando se oprime Enter.
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            //Condición que no permite ingresar datos de tipo texto
            else if (char.IsLetter(e.KeyChar)) { e.Handled = true; }
            //Condición que nos permite utilizar la tecla backspace
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //Condición que nos permite utilizar la tecla de espacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }

        }

        public static void DiseñoListado(ref DataGridView ListadoCargo)
        {
            ListadoCargo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ListadoCargo.BackgroundColor = Color.FromArgb(0, 136, 204);
            ListadoCargo.EnableHeadersVisualStyles = false;
            ListadoCargo.BorderStyle = BorderStyle.FixedSingle;
            ListadoCargo.CellBorderStyle = DataGridViewCellBorderStyle.None;
            ListadoCargo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            DataGridViewCellStyle cabecera = new DataGridViewCellStyle();
            cabecera.Font = new Font("Segeo UI", 10, FontStyle.Bold);

        }

        public static void DiseñoEliminados(ref DataGridView ListadoCargo)
        {
            foreach (DataGridViewRow row in ListadoCargo.Rows)
            {
                string estado;
                estado = row.Cells["estado"].Value.ToString();
                if (estado == "Eliminado")
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }
    }
}
