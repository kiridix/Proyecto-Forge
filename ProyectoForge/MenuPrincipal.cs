using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoForge
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_MouseClick(object sender, MouseEventArgs e)
        {

        }
        public void cerrarMenu()
        {
            if (PanelMenu.Width == 150)
            {
                PanelMenu.Width = 67;
                picLogo.Visible = false;
            }
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelMenu_MouseHover(object sender, EventArgs e)
        {
            if (PanelMenu.Width == 67)
            {
                PanelMenu.Width = 150;
                picLogo.Visible = true;

            }
        }
    }
}
