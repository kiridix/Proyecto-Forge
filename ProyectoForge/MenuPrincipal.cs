using System;
using System.Windows.Forms;

namespace ProyectoForge
{
    public partial class MenuPrincipal : Form
    {
        public int menuOption = 0;
        public MenuPrincipal()
        {
            InitializeComponent();
            TabMain.SelectTab(2);
        }

        private void MainMenu_MouseClick(object sender, MouseEventArgs e)
        {
            cerrarMenu();
        }
        public void cerrarMenu()
        {
            PanelMenu.Width = 78;
            picLogo.Visible = false;
            Line1.Visible = false;
            Line2.Visible = false;
            btnCrear.Visible = false;
            btnEliminar.Visible = false;
            btnModificar.Visible = false;



        }
        public void abrirMenu()
        {
                PanelMenu.Width = 215;
                picLogo.Visible = true;
            Line1.Visible = true;
            Line2.Visible = true;
            btnCrear.Visible = true;
            btnEliminar.Visible = true;
            btnModificar.Visible = true;

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
            menuOption = 1;
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
            menuOption = 2;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void BajaSolicitudEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButtonSolicitudNacional_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            menuOption = 4;
        }

        private void btnCurriculums_Click(object sender, EventArgs e)
        {
            menuOption = 3;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            switch (menuOption)
            {
                case 4: TabMain.SelectTab(0);
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            switch (menuOption)
            {
                case 4:
                    TabMain.SelectTab(1);
                    break;
            }
        }

        private void tabPage1_MouseHover(object sender, EventArgs e)
        {
            cerrarMenu();

        }
    }
}
