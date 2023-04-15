using System;
using System.Windows.Forms;

namespace Sistema_de_Asistencias.Presentacion
{
    public partial class MenuPrincipal : MaterialSkin.Controls.MaterialForm
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            labelBienvenida.Dock = DockStyle.Fill;
        }

        private void buttonConsultas_Click(object sender, EventArgs e)
        {

        }

        private void buttonPersonal_Click(object sender, EventArgs e)
        {
            CUPersonal ControlPers = new CUPersonal();

            panelPrincipal.Controls.Clear();
            ControlPers.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(ControlPers);
        }

        private void buttonCambiarPanel_Click(object sender, EventArgs e)
        {
            if (panelIzquierdo.Visible == true)
            {
                panelIzquierdo.Visible = false;

                buttonCambiarPanel.Image = Sistema_de_Asistencias.Properties.Resources.ultima;
            }
            else
            {
                panelIzquierdo.Visible = true;
                buttonCambiarPanel.Image = Sistema_de_Asistencias.Properties.Resources.primera;

            }
        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            CUUsuario ContrilUser = new CUUsuario();
            panelPrincipal.Controls.Clear();
            ContrilUser.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(ContrilUser);
        }
    }
}
