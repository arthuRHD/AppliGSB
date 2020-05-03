namespace GSB_visites
{
    partial class HomeForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.logoGSB = new System.Windows.Forms.PictureBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.loginTxt = new System.Windows.Forms.TextBox();
            this.loginLbl = new System.Windows.Forms.Label();
            this.secretLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoGSB)).BeginInit();
            this.SuspendLayout();
            // 
            // logoGSB
            // 
            this.logoGSB.Image = ((System.Drawing.Image)(resources.GetObject("logoGSB.Image")));
            this.logoGSB.Location = new System.Drawing.Point(326, 93);
            this.logoGSB.Name = "logoGSB";
            this.logoGSB.Size = new System.Drawing.Size(337, 220);
            this.logoGSB.TabIndex = 0;
            this.logoGSB.TabStop = false;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(150, 242);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(98, 32);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "Se connecter";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(140, 205);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(122, 20);
            this.passwordTxt.TabIndex = 3;
            // 
            // loginTxt
            // 
            this.loginTxt.Location = new System.Drawing.Point(140, 177);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(122, 20);
            this.loginTxt.TabIndex = 4;
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginLbl.Location = new System.Drawing.Point(50, 179);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(34, 15);
            this.loginLbl.TabIndex = 5;
            this.loginLbl.Text = "Nom";
            // 
            // secretLbl
            // 
            this.secretLbl.AutoSize = true;
            this.secretLbl.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secretLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.secretLbl.Location = new System.Drawing.Point(50, 207);
            this.secretLbl.Name = "secretLbl";
            this.secretLbl.Size = new System.Drawing.Size(75, 15);
            this.secretLbl.TabIndex = 6;
            this.secretLbl.Text = "Code secret";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(48, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Interface de connexion";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secretLbl);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.loginTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.logoGSB);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeForm";
            this.ShowIcon = false;
            this.Text = "GSB - Compte-rendu de Visite";
            this.Enter += new System.EventHandler(this.loginBtn_Click);
            ((System.ComponentModel.ISupportInitialize)(this.logoGSB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoGSB;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox loginTxt;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Label secretLbl;
        private System.Windows.Forms.Label label1;
    }
}

