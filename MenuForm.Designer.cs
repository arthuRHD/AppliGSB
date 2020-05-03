namespace GSB_visites
{
    partial class MenuForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.lbl_menu = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenuCR = new System.Windows.Forms.Button();
            this.btnMenuVisiteur = new System.Windows.Forms.Button();
            this.btnMenuPracticien = new System.Windows.Forms.Button();
            this.btnMenuMedicament = new System.Windows.Forms.Button();
            this.btnMenuQuit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip_btnMenuCR = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_btnMenuVisiteur = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_btnMenuPraticien = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_btnMenuMedicament = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_btnMenuQuitter = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_menu
            // 
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_menu.Font = new System.Drawing.Font("Roboto Thin", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu.Location = new System.Drawing.Point(12, 9);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(448, 42);
            this.lbl_menu.TabIndex = 0;
            this.lbl_menu.Text = "Gestion des comptes rendus";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnMenuCR);
            this.flowLayoutPanel1.Controls.Add(this.btnMenuVisiteur);
            this.flowLayoutPanel1.Controls.Add(this.btnMenuPracticien);
            this.flowLayoutPanel1.Controls.Add(this.btnMenuMedicament);
            this.flowLayoutPanel1.Controls.Add(this.btnMenuQuit);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(28, 86);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(75, 352);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnMenuCR
            // 
            this.btnMenuCR.BackColor = System.Drawing.Color.White;
            this.btnMenuCR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuCR.BackgroundImage")));
            this.btnMenuCR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenuCR.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCR.ForeColor = System.Drawing.Color.DimGray;
            this.btnMenuCR.Location = new System.Drawing.Point(3, 3);
            this.btnMenuCR.Name = "btnMenuCR";
            this.btnMenuCR.Size = new System.Drawing.Size(67, 63);
            this.btnMenuCR.TabIndex = 0;
            this.btnMenuCR.UseVisualStyleBackColor = false;
            this.btnMenuCR.Click += new System.EventHandler(this.btnMenuCR_Click);
            // 
            // btnMenuVisiteur
            // 
            this.btnMenuVisiteur.BackColor = System.Drawing.Color.White;
            this.btnMenuVisiteur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuVisiteur.BackgroundImage")));
            this.btnMenuVisiteur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenuVisiteur.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuVisiteur.ForeColor = System.Drawing.Color.DimGray;
            this.btnMenuVisiteur.Location = new System.Drawing.Point(3, 72);
            this.btnMenuVisiteur.Name = "btnMenuVisiteur";
            this.btnMenuVisiteur.Size = new System.Drawing.Size(67, 63);
            this.btnMenuVisiteur.TabIndex = 1;
            this.btnMenuVisiteur.UseVisualStyleBackColor = false;
            this.btnMenuVisiteur.Click += new System.EventHandler(this.btnMenuVisiteur_Click);
            // 
            // btnMenuPracticien
            // 
            this.btnMenuPracticien.BackColor = System.Drawing.Color.White;
            this.btnMenuPracticien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuPracticien.BackgroundImage")));
            this.btnMenuPracticien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenuPracticien.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPracticien.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnMenuPracticien.Location = new System.Drawing.Point(3, 141);
            this.btnMenuPracticien.Name = "btnMenuPracticien";
            this.btnMenuPracticien.Size = new System.Drawing.Size(67, 63);
            this.btnMenuPracticien.TabIndex = 2;
            this.btnMenuPracticien.UseVisualStyleBackColor = false;
            this.btnMenuPracticien.Click += new System.EventHandler(this.btnMenuPracticien_Click);
            // 
            // btnMenuMedicament
            // 
            this.btnMenuMedicament.BackColor = System.Drawing.Color.White;
            this.btnMenuMedicament.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuMedicament.BackgroundImage")));
            this.btnMenuMedicament.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenuMedicament.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMedicament.ForeColor = System.Drawing.Color.DimGray;
            this.btnMenuMedicament.Location = new System.Drawing.Point(3, 210);
            this.btnMenuMedicament.Name = "btnMenuMedicament";
            this.btnMenuMedicament.Size = new System.Drawing.Size(67, 63);
            this.btnMenuMedicament.TabIndex = 3;
            this.btnMenuMedicament.UseVisualStyleBackColor = false;
            this.btnMenuMedicament.Click += new System.EventHandler(this.btnMenuMedicament_Click);
            // 
            // btnMenuQuit
            // 
            this.btnMenuQuit.BackColor = System.Drawing.Color.White;
            this.btnMenuQuit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuQuit.BackgroundImage")));
            this.btnMenuQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenuQuit.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuQuit.ForeColor = System.Drawing.Color.DimGray;
            this.btnMenuQuit.Location = new System.Drawing.Point(3, 279);
            this.btnMenuQuit.Name = "btnMenuQuit";
            this.btnMenuQuit.Size = new System.Drawing.Size(67, 63);
            this.btnMenuQuit.TabIndex = 4;
            this.btnMenuQuit.UseVisualStyleBackColor = false;
            this.btnMenuQuit.Click += new System.EventHandler(this.btnMenuQuit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(564, -25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 202);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_user.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(417, 51);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(123, 23);
            this.lbl_user.TabIndex = 3;
            this.lbl_user.Text = "Nom Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Comptes rendus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Visiteurs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Praticiens";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Médicaments";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quitter";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbl_menu);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.ShowIcon = false;
            this.Text = "GSB - Menu";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnMenuCR;
        private System.Windows.Forms.Button btnMenuVisiteur;
        private System.Windows.Forms.Button btnMenuPracticien;
        private System.Windows.Forms.Button btnMenuMedicament;
        private System.Windows.Forms.Button btnMenuQuit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip_btnMenuCR;
        private System.Windows.Forms.ToolTip toolTip_btnMenuVisiteur;
        private System.Windows.Forms.ToolTip toolTip_btnMenuPraticien;
        private System.Windows.Forms.ToolTip toolTip_btnMenuMedicament;
        private System.Windows.Forms.ToolTip toolTip_btnMenuQuitter;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}