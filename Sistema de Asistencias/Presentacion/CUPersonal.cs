using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Asistencias.Logica;
using Sistema_de_Asistencias.Datos;

namespace Sistema_de_Asistencias.Presentacion
{
    public partial class CUPersonal : UserControl
    {
    

        public CUPersonal()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            CURegistro registro = new CURegistro();
            registro.Show();

        }

    }
}
