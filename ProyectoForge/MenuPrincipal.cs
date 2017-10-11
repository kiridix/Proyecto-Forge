using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoForge
{
    public partial class MenuPrincipal : Form
    {
        public int menuOption = 0;
        public MenuPrincipal()
        {
            InitializeComponent();
            TabMain.SelectTab(0);
            cnbxLEmpresa.SelectedIndex = 3;

            
        }

        private void MainMenu_MouseClick(object sender, MouseEventArgs e)
        {
         
        }
       

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelMenu_MouseHover(object sender, EventArgs e)
        {
        
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnPostulantes_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btnEntrevistas_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnCurriculums_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnPostulantes_Click(object sender, EventArgs e)
        {
            menuOption = 1;
            SelectMenu(1);
            enableOptions();
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
            
        }

        private void tabPage1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void tabPage2_MouseClick(object sender, MouseEventArgs e)
        {
            
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
                case 1: TabMain.SelectTab(16);
                    break;
                case 5: TabMain.SelectTab(4);
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
        public void disableOptions()
        {
            btnCrear.Enabled = false;
            btnListar.Enabled = false;
        
        }
        public void enableOptions()
        {
            btnCrear.Enabled = true;
            btnListar.Enabled = true;
        }
        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            this.menuOption = 5;
            SelectMenu(2);
            enableOptions();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            switch (menuOption)
            {
                case 1:
                    TabMain.SelectTab(14);
                    dgvLP.DataSource = BD.Listar("postulante");
                    break;
                case 5:
                    TabMain.SelectTab(6);
                    break;
            }
        }

        private void btnCualidades_Click(object sender, EventArgs e)
        {
            TabMain.SelectTab(7);
            SelectMenu(3);
            disableOptions();
            dataGridACEstudio.DataSource = BD.Listar("estudio");
            listarConocimientos();



        }
        private string prepararDate(string[] dt)
        {
            string fecha;
            string[] aux = new string[2];
            string[] aux2 = new string[3];

            aux = dt;
            aux2 = aux[0].Split('/');
            if (Int32.Parse(aux2[1]) < 10)
            {
                aux2[1] = "0" + aux2[1];
            }
            fecha = aux2[2] + aux2[1] + aux2[0];
            return fecha;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string fecha;
            string fecVen;
            fecha = prepararDate(dtpAP.Value.ToString().Split(' '));
            fecVen = prepararDate(dtpFecvenAP.Value.ToString().Split(' '));  
           // BD.insertPersona(Int32.Parse(txtCiAP.Text), txtNombreAP.Text, txtApellidoAP.Text, fecha, txtTelefonoAP.Text );
           // BD.InsertarPostulante(Int32.Parse(txtCiAP.Text), cboxLicAP.Text, fecVen, Int32.Parse(txtSueldoEsperadoAP.Text), txtPaisDePreferenciaAP.Text , txtPuestoDePreferencia.Text, fecha, txtDireccionAp.Text, txtEmailAP.Text);
            clearCamposAP();
            Blink();


        }
        private async void Blink()
        {
            await Task.Delay(250);
            lblUserCreadoCorrectamente.Visible = true;
            await Task.Delay(250);
            lblUserCreadoCorrectamente.Visible = false;
            await Task.Delay(250);
            lblUserCreadoCorrectamente.Visible = true;
            await Task.Delay(250);
            lblUserCreadoCorrectamente.Visible = false;
            await Task.Delay(250);
            lblUserCreadoCorrectamente.Visible = true;
            await Task.Delay(1250);
            lblUserCreadoCorrectamente.Visible = false;
        }
        private void clearCamposAP()
        {
            txtCi.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            txtSueldoEsperado.Text = "";
            txtPuestoPreferencia.Text = "";
            txtPaisPreferencia.Text = "";
            cboxTipoLic.Text = "";
        }

        private void btnBuscarLP_Click(object sender, EventArgs e)
        {
            dgvLP.DataSource = BD.Listar("postulante");
        }

        private void dgvLP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void MostrarNombre(int ci)
        {
            MessageBox.Show(BD.Select("nombre", "persona", ci.ToString()));
        }
        private void btnVerLP_Click(object sender, EventArgs e)
        {
            
            int ci = (int)dgvLP.CurrentRow.Cells["ci"].Value;
            postulante p = new postulante(ci.ToString());
            cargarVistaPostulante(p);
            this.P = p;
            BD.listarConocimientos(cboxConocimientos, "conocimiento");
            BD.listarConocimientos(comboBox3, "estudio");
            dataGridView3.DataSource = BD.listarMasEstudios(Int32.Parse(BD.getIdPostulante(P.Ci)));
            dgvConocimientosVP.DataSource = BD.ListarMasConocimientos(Int32.Parse(BD.getIdPostulante(P.Ci).ToString()));
            TabMain.SelectTab(15);

        }
        private postulante p;
        private void cargarVistaPostulante(postulante p)
        {
            p.CargarPostulante();
            txtNombreVP.Text = p.Nombre + " " + p.Apellido ;
            txtCiVP.Text = p.Ci;
            txtFecNacVP.Text = p.FechaNac;
            txtEmailVP.Text = p.Email;
            txtDireccionVP.Text = p.Direccion;
            txtSueldoEsperadoVP.Text = p.SueldoEsperado.ToString();
            txtPaisPreferenciaVP.Text = p.PaisPreferncia;
            txtPuestoPreferenciaVP.Text = p.PuestoPreferencia;
            pictureBox2.Image = p.Foto;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            TabMain.SelectTab(4);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            TabMain.SelectTab(1);
            BD.listarConocimientos(cmbASEConocimientos, "conocimiento");
            BD.listarConocimientos(cmbASEEstudios, "estudio");
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
            menuOption = 4;
            TabMain.SelectTab(8);
            SelectMenu(4);
            disableOptions();
            BD.listarsolicitudescbox(cboxSolicitudes);

        }

        private void btnMSEAceptarE_Click(object sender, EventArgs e)
        {
            SelectMenu(4);

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
        private Empresa empresa;

        private void enableCualidadesSol()
        {
            cmbASEConocimientos.Enabled = true;
            cmbASEEstudios.Enabled = true;
            dataGridView1.Enabled = true;
            dataGridASEConocimientos.Enabled = true;
            btnAddConocimientoASE.Enabled = true;
            btnAddEstudiosASE.Enabled = true;
            btnDelConocimientoASE.Enabled = true;
            btnDelEstudioASE.Enabled = true;
            btnCrearASE.Enabled = true;
        }
        private void disableCualidadesSol()
        {
            cmbASEConocimientos.Enabled = false;
            cmbASEEstudios.Enabled = false;
            dataGridView1.Enabled = false;
            dataGridASEConocimientos.Enabled = false;
            btnAddConocimientoASE.Enabled = false;
            btnAddEstudiosASE.Enabled = false;
            btnDelConocimientoASE.Enabled = false;
            btnDelEstudioASE.Enabled = false;
            btnCrearASE.Enabled = false;
        }
        private void button16_Click_1(object sender, EventArgs e)
        {
            enableCualidadesSol();

                String nac = "";

                if (rbtnASEInter.Checked)
                {
                    nac = "Internacional";
            }else { 
                    nac = "Nacional";
                }

                BD.insertSolicitud(txtASENombreS.Text +" --- "+ Empresa.Nombre, nac, Int32.Parse(txtASESueldoMin.Text), Int32.Parse(txtASESueldoMax.Text), cmbASECondicionEmpleado.Text);

                listarSolicitudes();




                /*int rut = Int32.Parse(txtASENombreS.Text);
                int idsol = Int32.Parse(BDPruebaSol.getIdsol(Solicitud.));
                BDPruebaSol.insertarSolicitud(rut, idsol);*/

            }


        private void TabMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAENombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAERubro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAETelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAEDireccionFisica_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAERUT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAEEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAEDireccionFiscal_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbAETipoContrato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAEMonto_TextChanged(object sender, EventArgs e)
        {

        }
        private void quitarSelect()
        {
            btnPostulantes.BackColor = System.Drawing.Color.WhiteSmoke;
               btnEmpresas.BackColor = System.Drawing.Color.WhiteSmoke;
            btnCualidades.BackColor = System.Drawing.Color.WhiteSmoke;
            btnMatcheo.BackColor = System.Drawing.Color.WhiteSmoke;
        }
        private void SelectMenu(int op) {
            quitarSelect();
            switch (op){
                case 1: this.btnPostulantes.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
                    break;
                case 2: this.btnEmpresas.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
                    break;
                case 3: this.btnCualidades.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
                    break;
                case 4: this.btnMatcheo.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
                    break;
            }
        }

        private void lblTipoAP_Click(object sender, EventArgs e)
        {
                    }

        private void button17_Click(object sender, EventArgs e)
        {
            int ci = (int)dgvLP.CurrentRow.Cells["ci"].Value;
            BD.EliminarCualidadDePostulante("tiene", Int32.Parse(BD.getIdPostulante(ci.ToString())));
            BD.EliminarCualidadDePostulante("posee", Int32.Parse(BD.getIdPostulante(ci.ToString())));
            BD.deletePostulante(ci.ToString());
            BD.deletePersona(ci.ToString());
            dgvLP.DataSource = BD.Listar("postulante");
        }

        private void button19_Click(object sender, EventArgs e)
        {

                if (!String.IsNullOrWhiteSpace(txtAERUT.Text) && !String.IsNullOrWhiteSpace(txtAENombre.Text) && !String.IsNullOrWhiteSpace(txtAEDireccionFisica.Text) && !String.IsNullOrWhiteSpace(txtAEDireccionFiscal.Text) && !String.IsNullOrWhiteSpace(txtAETelefono.Text) && !String.IsNullOrWhiteSpace(txtAEEmail.Text) && !String.IsNullOrWhiteSpace(txtAERubro.Text))
                {

                    switch (BD.InsertEmpresa(Convert.ToInt32(txtAERUT.Text), txtAENombre.Text, txtAEDireccionFiscal.Text, txtAEDireccionFisica.Text, txtAETelefono.Text, txtAEEmail.Text, dateTimePickerAE.Value.Date, txtAERubro.Text))
                    {
                        case 0:
                            MessageBox.Show("La empresa se ha ingresado con éxito", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtAENombre.Text = null;
                            txtAERUT.Text = null;
                            txtAEDireccionFiscal.Text = null;
                            txtAEDireccionFisica.Text = null;
                            txtAETelefono.Text = null;
                            txtAEEmail.Text = null;
                            txtAERubro.Text = null;
                            break;
                        case 1:
                            MessageBox.Show("La persona con la cédula ingresada ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("¡No debe dejar campos vacíos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        private void btnBuscarEmpresa_Click(object sender, EventArgs e)
        {
            if (cnbxLEmpresa.Text != "listar todo")
            {
                dataGridLE.DataSource = BD.ListarEmpresa(cnbxLEmpresa.Text, txtBuscarLE.Text);
            }
            else
            {
                dataGridLE.DataSource = BD.Listar("empresa");
            }
        }

        private void btnBorrarEmpresa_Click(object sender, EventArgs e)
        {
            int rut = (int)dataGridLE.CurrentRow.Cells["rut"].Value;
            BD.BorrarEmpresa(rut);
        }

        private void AltapostulantePage_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearAP_Click(object sender, EventArgs e)
        {

            MessageBox.Show(dtpFechNac.Value.Date.ToString());

            BD.insertPersona(Int32.Parse(txtCi.Text), txtNombre.Text, txtApellido.Text, dtpFechNac.Value.Date, txtTelefono.Text);
            BD.InsertarPostulante(pictureBoxAP, Int32.Parse(txtCi.Text), cboxTipoLic.Text, dtpFechVen.Value.Date, Int32.Parse(txtSueldoEsperado.Text), txtPaisPreferencia.Text, txtPuestoPreferencia.Text, txtDireccion.Text, txtEmail.Text);
            clearCamposAP();
            Blink();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public Image foto;

        internal postulante P
        {
            get
            {
                return p;
            }

            set
            {
                p = value;
            }
        }

        internal Empresa Empresa { get => empresa; set => empresa = value; }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBoxAP.Image = Image.FromFile(dialog.FileName);
                this.foto = Image.FromFile(dialog.FileName);
            }
        }

        private void btnACAgregarConocimiento_Click(object sender, EventArgs e)
        {
            BD.insertConocimiento(txtACConocimiento.Text, txtDescripcionConcoimiento.Text);
            listarConocimientos();
            txtACConocimiento.Text = "";
            txtDescripcionConcoimiento.Text = "";
        }

        private void btnACEliminarConocimiento_Click(object sender, EventArgs e)
        {
            BD.EliminarConocimiento((int)dataGridACConocimientos.CurrentRow.Cells["idcon"].Value);
            BD.deleteConocimiento((string)dataGridACConocimientos.CurrentRow.Cells["nombre"].Value);
            listarConocimientos();
        }
        private void listarConocimientos()
        {
            dataGridACConocimientos.DataSource = BD.Listar("conocimiento");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int idcon = Int32.Parse(BD.getIdcon(cboxConocimientos, "idcon","conocimiento","nombre"));
            int idpos = Int32.Parse(BD.getIdPostulante(P.Ci));
            BD.insertarConocimiento(idcon, idpos);
            dgvConocimientosVP.DataSource = BD.ListarMasConocimientos(Int32.Parse(BD.getIdPostulante(P.Ci).ToString()));

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int idest = Int32.Parse(BD.getIdcon(comboBox3, "idestudio", "estudio", "nombre"));
            int id = Int32.Parse(BD.getIdPostulante(P.Ci));
            BD.insertarestudio(idest, id,dateTimePicker1,dateTimePickerME);
            dataGridView3.DataSource = BD.listarMasEstudios(id);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int idcon = (int)dgvConocimientosVP.CurrentRow.Cells["idcon"].Value;
            int idpos = Int32.Parse(BD.getIdPostulante(P.Ci));
            BD.BorrarconocimientoP(idcon, idpos);
            dgvConocimientosVP.DataSource = BD.ListarMasConocimientos(Int32.Parse(BD.getIdPostulante(P.Ci).ToString()));

        }

        private void dataGridACEstudio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void btnACAgregarEstudio_Click(object sender, EventArgs e)
        {
            BD.instertEstudio(txtACEstudio.Text);
            dataGridACEstudio.DataSource = BD.Listar("estudio");
        }

        private void btnACEliminarEstudio_Click(object sender, EventArgs e)
        {
            BD.deleteEstudio((string)dataGridACEstudio.CurrentRow.Cells["nombre"].Value);
            dataGridACEstudio.DataSource =  BD.Listar("estudio");
        }

        private void btnVerLE_Click(object sender, EventArgs e)
        {
            TabMain.SelectedIndex = 5;
            this.Empresa = new Empresa(dataGridLE.CurrentRow.Cells["rut"].Value.ToString());
            cargarVistaEmpresa();
            dataGridView2.DataSource = BD.Listarsol(Empresa.Nombre);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {


        }
        public void cargarVistaEmpresa()
        {
            txtMENombre.Text = this.Empresa.Nombre;
            txtMEEmail.Text = this.Empresa.Email;
            txtMEDireccionFiscal.Text = this.Empresa.Direccion_fiscal;
            txtMEDireccionFisica.Text = this.Empresa.Direccion_fisica;
            txtMERUT.Text = this.Empresa.RUT.ToString();
            txtMERubro.Text = this.Empresa.Rubro;
            txtMETelefono.Text = this.Empresa.Tel;

        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            int idestudio = (int)dataGridView3.CurrentRow.Cells["idestudio"].Value;
            int idpos = Int32.Parse(BD.getIdPostulante(P.Ci));
            BD.BorrarEstudioP(idestudio, idpos);
            dataGridView3.DataSource =  BD.listarMasEstudios(idpos);
        }

        private void button15_Click(object sender, EventArgs e)
        { }

        private void listarSolicitudes()
        {
            dataGridView2.DataSource = BD.Listar("solicitud");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            btnGuardarEmpresa.Visible = true;
            txtMERUT.Enabled = true;
            txtMEDireccionFiscal.Enabled = true;
            txtMEDireccionFisica.Enabled = true;
            txtMETelefono.Enabled = true;
            txtMEEmail.Enabled = true;
            txtMERubro.Enabled = true;
            dateTimePickerME.Enabled = true;
        }

        private void btnGuardarEmpresa_Click(object sender, EventArgs e)
        {
            btnGuardarEmpresa.Visible = false;
            btnGuardarEmpresa.Visible = false;
            txtMERUT.Enabled = false;
            txtMEDireccionFiscal.Enabled = false;
            txtMEDireccionFisica.Enabled = false;
            txtMETelefono.Enabled = false;
            txtMEEmail.Enabled = false;
            txtMERubro.Enabled = false;
            dateTimePickerME.Enabled = false;
        }

        private void btnMEEliminarSolicitud_Click(object sender, EventArgs e)
        {
            int idsol = (int)dataGridView2.CurrentRow.Cells["idsol"].Value;
            BD.deleteTienesol(idsol);
            BD.deletePoseesol(idsol);
            BD.deleteSolicitud(idsol);
            dataGridView2.DataSource = BD.Listarsol(Empresa.Nombre);
        }

        private void btnCrearASE_Click(object sender, EventArgs e)
        {
            TabMain.SelectTab(5);
            disableCualidadesSol();
            txtASENombreS.Text = "";
            txtASESueldoMin.Text = "";
            txtASESueldoMax.Text = "";
            cmbASECondicionEmpleado.Text = "";
            cmbASEEstudios.Text = "";
            cmbASEConocimientos.Text = "";
            dataGridView2.DataSource = BD.Listarsol(Empresa.Nombre);

        }

        private void btnAddConocimientoASE_Click(object sender, EventArgs e)
        {
            int idcon = Int32.Parse(BD.getIdcon(cmbASEConocimientos, "idcon", "conocimiento", "nombre"));
            int idsol = Int32.Parse(BD.getIdsolicitud(txtASENombreS.Text, Empresa.Nombre));
            BD.insertarConocimientosol(idcon, idsol);
            dataGridASEConocimientos.DataSource = BD.ListarMasConocimientosSol(idsol);
        }

        private void ListarEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void btnDelConocimientoASE_Click(object sender, EventArgs e)
        {
            int idsol = (int)dataGridView2.CurrentRow.Cells["idestudio"].Value;
        }

        private void btnAddEstudiosASE_Click(object sender, EventArgs e)
        {
            int idest = Int32.Parse(BD.getIdcon(cmbASEEstudios, "idestudio", "estudio", "nombre"));
            int idsol = Int32.Parse(BD.getIdsolicitud(txtASENombreS.Text, Empresa.Nombre));
            BD.insertarEstudioSol(idest, idsol);
            dataGridView1.DataSource = BD.listarEstudiosSol(idsol);

        }

        private void btnDelEstudioASE_Click(object sender, EventArgs e)
        {
            int idsol = Int32.Parse(BD.getIdsolicitud(txtASENombreS.Text, Empresa.Nombre));
            dataGridView1.DataSource = BD.listarEstudiosSol(idsol);
        }

        private void cboxSolicitudes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idsol = Int32.Parse(BD.getIdsol(cboxSolicitudes));

            string nombreCon = BD.getNomCon(idsol);
            int idcon = Int32.Parse(BD.getIdconsol(nombreCon));

            string nombreEst = BD.getNomEst(idsol);
           // int idest = Int32.Parse(BD.getIdestudio(nombreEst));



           
            DGVMATCHING.DataSource = BD.matching(idcon,0 );

        }
    }
    }


