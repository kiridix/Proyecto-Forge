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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MainMenu_MouseClick(object sender, MouseEventArgs e)
        {
            cerrarMenu();
        }
        public void cerrarMenu()
        {
                PanelMenu.Width = 88;
                picLogo.Visible = false;
        }
        public void abrirMenu()
        {
                PanelMenu.Width = 215;
                picLogo.Visible = true;

        }
        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelMenu_MouseHover(object sender, EventArgs e)
        {
            abrirMenu();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnPostulantes_MouseHover(object sender, EventArgs e)
        {
            abrirMenu();
        }

        private void btnEntrevistas_MouseHover(object sender, EventArgs e)
        {
            abrirMenu();
        }

        private void btnCurriculums_MouseHover(object sender, EventArgs e)
        {
            abrirMenu();
        }

        private void btnPostulantes_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            cerrarMenu();
        }

        private void tabPage1_MouseClick(object sender, MouseEventArgs e)
        {
            cerrarMenu();
        }

        private void tabPage2_MouseClick(object sender, MouseEventArgs e)
        {
            cerrarMenu();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrevistas_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }
    }
}
