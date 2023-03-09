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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            labelBienvenida.Dock= DockStyle.Fill;
        }

        private void buttonConsultas_Click(object sender, EventArgs e)
        {

        }

        private void buttonPersonal_Click(object sender, EventArgs e)
        {
            CUPersonal ControlPers = new CUPersonal();

            panelPrincipal.Controls.Clear();
            ControlPers.Dock= DockStyle.Fill;
            panelPrincipal.Controls.Add(ControlPers);
        }
    }
}
