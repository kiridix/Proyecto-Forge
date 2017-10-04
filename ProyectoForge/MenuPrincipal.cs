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



        }
        public void abrirMenu()
        {
                PanelMenu.Width = 215;
                picLogo.Visible = true;
            Line1.Visible = true;
            Line2.Visible = true;
            btnCrear.Visible = true;

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
                case 1: TabMain.SelectTab(13);
                    break;
                case 2: TabMain.SelectTab(12);
                    break;
                case 4: TabMain.SelectTab(0);
                    break;
                case 5: TabMain.SelectTab(3);
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            switch (menuOption)
            {
                case 2:
                    TabMain.SelectTab(10);
                    break;
                case 4:
                    TabMain.SelectTab(1);
                    break;
            }
        }

        private void tabPage1_MouseHover(object sender, EventArgs e)
        {
            cerrarMenu();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            switch (menuOption)
            {
                case 2:
                    TabMain.SelectTab(11);
                    break;
                case 4:
                    TabMain.SelectTab(2);
                    break;
                case 5:
                    TabMain.SelectTab(4);
                    break;
            }
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            this.menuOption = 5;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            switch (menuOption)
            {
                case 1:
                    TabMain.SelectTab(14);
                    break;
                case 3: TabMain.SelectTab(9);
                    break;
                case 5:
                    TabMain.SelectTab(5);
                    break;
            }
        }

        private void btnCualidades_Click(object sender, EventArgs e)
        {
            this.menuOption = 6;
            TabMain.SelectTab(6);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
          //  BD.InsertarPostulante(Int32.Parse(txtCiAP.Text), 123, 25000, "Uruguay", "Desarrollo", "palermo 5605", "Matiasmartineeez@gmail.com");
                }

        private void btnBuscarLP_Click(object sender, EventArgs e)
        {
        //    dgvLP.DataSource = BD.ListarPostulantes();
        }

        private void dgvLP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVerLP_Click(object sender, EventArgs e)
        {
            TabMain.SelectTab(15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            TabMain.SelectTab(4);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            TabMain.SelectTab(0);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            TabMain.SelectTab(12);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            TabMain.SelectTab(11);
        }

        private void btnMatcheo_Click(object sender, EventArgs e)
        {
            TabMain.SelectTab(7);
        }

        private void btnMSEAceptarE_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            TabMain.SelectTab(12);
        }

        private void btnModificarME_Click(object sender, EventArgs e)
        {
            TabMain.SelectTab(15);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            TabMain.SelectTab(15);
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            TabMain.SelectTab(4);
        }
    }
}
