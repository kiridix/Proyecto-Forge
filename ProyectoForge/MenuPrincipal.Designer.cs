namespace ProyectoForge
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnEntrevistas = new System.Windows.Forms.Button();
            this.btnCurriculums = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPostulantes = new System.Windows.Forms.Button();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelMenu.Controls.Add(this.picLogo);
            this.PanelMenu.Controls.Add(this.btnEntrevistas);
            this.PanelMenu.Controls.Add(this.btnCurriculums);
            this.PanelMenu.Controls.Add(this.panel2);
            this.PanelMenu.Controls.Add(this.btnPostulantes);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(215, 520);
            this.PanelMenu.TabIndex = 3;
            this.PanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenu_Paint);
            this.PanelMenu.MouseHover += new System.EventHandler(this.PanelMenu_MouseHover);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::ProyectoForge.Properties.Resources.fb_forge;
            this.picLogo.Location = new System.Drawing.Point(0, 14);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(215, 86);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // btnEntrevistas
            // 
            this.btnEntrevistas.FlatAppearance.BorderSize = 0;
            this.btnEntrevistas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEntrevistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrevistas.Image = global::ProyectoForge.Properties.Resources.icons8_Profile_50;
            this.btnEntrevistas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrevistas.Location = new System.Drawing.Point(12, 250);
            this.btnEntrevistas.Name = "btnEntrevistas";
            this.btnEntrevistas.Size = new System.Drawing.Size(200, 48);
            this.btnEntrevistas.TabIndex = 3;
            this.btnEntrevistas.Text = "                         Entrevistas";
            this.btnEntrevistas.UseVisualStyleBackColor = true;
            this.btnEntrevistas.MouseHover += new System.EventHandler(this.btnEntrevistas_MouseHover);
            // 
            // btnCurriculums
            // 
            this.btnCurriculums.FlatAppearance.BorderSize = 0;
            this.btnCurriculums.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCurriculums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurriculums.Image = global::ProyectoForge.Properties.Resources.icons8_Resume_50;
            this.btnCurriculums.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurriculums.Location = new System.Drawing.Point(12, 366);
            this.btnCurriculums.Name = "btnCurriculums";
            this.btnCurriculums.Size = new System.Drawing.Size(200, 48);
            this.btnCurriculums.TabIndex = 2;
            this.btnCurriculums.Text = "                         Curriculums";
            this.btnCurriculums.UseVisualStyleBackColor = true;
            this.btnCurriculums.MouseHover += new System.EventHandler(this.btnCurriculums_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 8);
            this.panel2.TabIndex = 1;
            // 
            // btnPostulantes
            // 
            this.btnPostulantes.FlatAppearance.BorderSize = 0;
            this.btnPostulantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPostulantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostulantes.Image = global::ProyectoForge.Properties.Resources.icons8_User_50;
            this.btnPostulantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPostulantes.Location = new System.Drawing.Point(12, 137);
            this.btnPostulantes.Name = "btnPostulantes";
            this.btnPostulantes.Size = new System.Drawing.Size(200, 48);
            this.btnPostulantes.TabIndex = 0;
            this.btnPostulantes.Text = "                          Postulantes";
            this.btnPostulantes.UseVisualStyleBackColor = true;
            this.btnPostulantes.Click += new System.EventHandler(this.btnPostulantes_Click);
            this.btnPostulantes.MouseHover += new System.EventHandler(this.btnPostulantes_MouseHover);
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(215, 0);
            this.PanelHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(805, 8);
            this.PanelHeader.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ProyectoForge.Properties.Resources.icons8_Exit_50;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(988, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 25);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(951, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Salir";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.PanelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuPrincipal";
            this.Text = "l";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseClick);
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button btnEntrevistas;
        private System.Windows.Forms.Button btnCurriculums;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPostulantes;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}