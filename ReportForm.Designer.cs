namespace GSB_visites
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.lbl_menu = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.cbxPraticien = new System.Windows.Forms.ComboBox();
            this.txtBilan = new System.Windows.Forms.RichTextBox();
            this.txtNumRapport = new System.Windows.Forms.TextBox();
            this.dgEchantillon = new System.Windows.Forms.DataGridView();
            this.lbl_numRapport = new System.Windows.Forms.Label();
            this.lbl_Praticien = new System.Windows.Forms.Label();
            this.lbl_MotifVisite = new System.Windows.Forms.Label();
            this.lbl_DateRapport = new System.Windows.Forms.Label();
            this.lbl_Bilan = new System.Windows.Forms.Label();
            this.lbl_OffreEchantillion = new System.Windows.Forms.Label();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.bdd_gsb_csharpDataSet = new GSB_visites.bdd_gsb_csharpDataSet();
            this.bddgsbcsharpDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEchantillon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_gsb_csharpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddgsbcsharpDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_menu
            // 
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_menu.Font = new System.Drawing.Font("Roboto Thin", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_menu.Location = new System.Drawing.Point(12, 9);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(270, 42);
            this.lbl_menu.TabIndex = 1;
            this.lbl_menu.Text = "Rapport de visite";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_user.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_user.Location = new System.Drawing.Point(236, 51);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(123, 23);
            this.lbl_user.TabIndex = 4;
            this.lbl_user.Text = "Nom Prénom";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(564, -26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 202);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(137, 174);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(194, 20);
            this.txtMotif.TabIndex = 7;
            // 
            // cbxPraticien
            // 
            this.cbxPraticien.FormattingEnabled = true;
            this.cbxPraticien.Location = new System.Drawing.Point(137, 121);
            this.cbxPraticien.Name = "cbxPraticien";
            this.cbxPraticien.Size = new System.Drawing.Size(160, 21);
            this.cbxPraticien.TabIndex = 8;
            this.cbxPraticien.Text = "Flament Elisabeth";
            this.cbxPraticien.SelectedIndexChanged += new System.EventHandler(this.cbxPraticien_SelectedIndexChanged);
            // 
            // txtBilan
            // 
            this.txtBilan.Location = new System.Drawing.Point(137, 205);
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(194, 173);
            this.txtBilan.TabIndex = 9;
            this.txtBilan.Text = "";
            // 
            // txtNumRapport
            // 
            this.txtNumRapport.Enabled = false;
            this.txtNumRapport.Location = new System.Drawing.Point(137, 95);
            this.txtNumRapport.Name = "txtNumRapport";
            this.txtNumRapport.Size = new System.Drawing.Size(77, 20);
            this.txtNumRapport.TabIndex = 11;
            // 
            // dgEchantillon
            // 
            this.dgEchantillon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEchantillon.Location = new System.Drawing.Point(369, 227);
            this.dgEchantillon.Name = "dgEchantillon";
            this.dgEchantillon.Size = new System.Drawing.Size(385, 151);
            this.dgEchantillon.TabIndex = 12;
            // 
            // lbl_numRapport
            // 
            this.lbl_numRapport.AutoSize = true;
            this.lbl_numRapport.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Italic);
            this.lbl_numRapport.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_numRapport.Location = new System.Drawing.Point(39, 95);
            this.lbl_numRapport.Name = "lbl_numRapport";
            this.lbl_numRapport.Size = new System.Drawing.Size(72, 17);
            this.lbl_numRapport.TabIndex = 13;
            this.lbl_numRapport.Text = "N°Rapport";
            // 
            // lbl_Praticien
            // 
            this.lbl_Praticien.AutoSize = true;
            this.lbl_Praticien.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Italic);
            this.lbl_Praticien.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Praticien.Location = new System.Drawing.Point(39, 121);
            this.lbl_Praticien.Name = "lbl_Praticien";
            this.lbl_Praticien.Size = new System.Drawing.Size(60, 17);
            this.lbl_Praticien.TabIndex = 14;
            this.lbl_Praticien.Text = "Praticien";
            // 
            // lbl_MotifVisite
            // 
            this.lbl_MotifVisite.AutoSize = true;
            this.lbl_MotifVisite.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Italic);
            this.lbl_MotifVisite.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_MotifVisite.Location = new System.Drawing.Point(39, 176);
            this.lbl_MotifVisite.Name = "lbl_MotifVisite";
            this.lbl_MotifVisite.Size = new System.Drawing.Size(92, 17);
            this.lbl_MotifVisite.TabIndex = 15;
            this.lbl_MotifVisite.Text = "Motif de visite";
            // 
            // lbl_DateRapport
            // 
            this.lbl_DateRapport.AutoSize = true;
            this.lbl_DateRapport.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Italic);
            this.lbl_DateRapport.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_DateRapport.Location = new System.Drawing.Point(39, 148);
            this.lbl_DateRapport.Name = "lbl_DateRapport";
            this.lbl_DateRapport.Size = new System.Drawing.Size(83, 17);
            this.lbl_DateRapport.TabIndex = 16;
            this.lbl_DateRapport.Text = "Date rapport";
            // 
            // lbl_Bilan
            // 
            this.lbl_Bilan.AutoSize = true;
            this.lbl_Bilan.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Italic);
            this.lbl_Bilan.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Bilan.Location = new System.Drawing.Point(39, 205);
            this.lbl_Bilan.Name = "lbl_Bilan";
            this.lbl_Bilan.Size = new System.Drawing.Size(37, 17);
            this.lbl_Bilan.TabIndex = 17;
            this.lbl_Bilan.Text = "Bilan";
            // 
            // lbl_OffreEchantillion
            // 
            this.lbl_OffreEchantillion.AutoSize = true;
            this.lbl_OffreEchantillion.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Italic);
            this.lbl_OffreEchantillion.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_OffreEchantillion.Location = new System.Drawing.Point(366, 207);
            this.lbl_OffreEchantillion.Name = "lbl_OffreEchantillion";
            this.lbl_OffreEchantillion.Size = new System.Drawing.Size(125, 17);
            this.lbl_OffreEchantillion.TabIndex = 18;
            this.lbl_OffreEchantillion.Text = "Offre d\'échantillons";
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(137, 384);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(77, 23);
            this.btnPre.TabIndex = 20;
            this.btnPre.Text = "Précedent";
            this.btnPre.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(211, 384);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(54, 23);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Suivant";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(263, 384);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(68, 23);
            this.btnNew.TabIndex = 22;
            this.btnNew.Text = "Nouveau";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(681, 397);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 32);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Fermer";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(303, 121);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(68, 21);
            this.btnDetails.TabIndex = 24;
            this.btnDetails.Text = "Détails";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(137, 148);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(194, 20);
            this.txtDate.TabIndex = 25;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(590, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 32);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bdd_gsb_csharpDataSet
            // 
            this.bdd_gsb_csharpDataSet.DataSetName = "bdd_gsb_csharpDataSet";
            this.bdd_gsb_csharpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bddgsbcsharpDataSetBindingSource
            // 
            this.bddgsbcsharpDataSetBindingSource.DataSource = this.bdd_gsb_csharpDataSet;
            this.bddgsbcsharpDataSetBindingSource.Position = 0;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.lbl_OffreEchantillion);
            this.Controls.Add(this.lbl_Bilan);
            this.Controls.Add(this.lbl_DateRapport);
            this.Controls.Add(this.lbl_MotifVisite);
            this.Controls.Add(this.lbl_Praticien);
            this.Controls.Add(this.lbl_numRapport);
            this.Controls.Add(this.dgEchantillon);
            this.Controls.Add(this.txtNumRapport);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.cbxPraticien);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_menu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEchantillon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_gsb_csharpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddgsbcsharpDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.ComboBox cbxPraticien;
        private System.Windows.Forms.RichTextBox txtBilan;
        private System.Windows.Forms.TextBox txtNumRapport;
        private System.Windows.Forms.DataGridView dgEchantillon;
        private System.Windows.Forms.Label lbl_numRapport;
        private System.Windows.Forms.Label lbl_Praticien;
        private System.Windows.Forms.Label lbl_MotifVisite;
        private System.Windows.Forms.Label lbl_DateRapport;
        private System.Windows.Forms.Label lbl_Bilan;
        private System.Windows.Forms.Label lbl_OffreEchantillion;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource bddgsbcsharpDataSetBindingSource;
        private bdd_gsb_csharpDataSet bdd_gsb_csharpDataSet;
    }
}