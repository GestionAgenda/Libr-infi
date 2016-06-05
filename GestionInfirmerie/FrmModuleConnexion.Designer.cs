namespace GestionInfirmerie
{
    partial class FrmModuleConnexion
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lblTitreApplication = new System.Windows.Forms.Label();
            this.lblTitrePage = new System.Windows.Forms.Label();
            this.txtBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.txtBoxMDP = new System.Windows.Forms.TextBox();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblMDP = new System.Windows.Forms.Label();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(592, 428);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lineShape2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 300;
            this.lineShape2.X2 = 300;
            this.lineShape2.Y1 = 81;
            this.lineShape2.Y2 = 0;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -3;
            this.lineShape1.X2 = 594;
            this.lineShape1.Y1 = 80;
            this.lineShape1.Y2 = 80;
            // 
            // lblTitreApplication
            // 
            this.lblTitreApplication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitreApplication.AutoSize = true;
            this.lblTitreApplication.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitreApplication.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreApplication.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitreApplication.Location = new System.Drawing.Point(56, 9);
            this.lblTitreApplication.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblTitreApplication.Name = "lblTitreApplication";
            this.lblTitreApplication.Size = new System.Drawing.Size(200, 50);
            this.lblTitreApplication.TabIndex = 1;
            this.lblTitreApplication.Text = "Libr\'Infi";
            this.lblTitreApplication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitrePage
            // 
            this.lblTitrePage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitrePage.AutoSize = true;
            this.lblTitrePage.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitrePage.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitrePage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitrePage.Location = new System.Drawing.Point(351, 9);
            this.lblTitrePage.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblTitrePage.Name = "lblTitrePage";
            this.lblTitrePage.Size = new System.Drawing.Size(200, 50);
            this.lblTitrePage.TabIndex = 2;
            this.lblTitrePage.Text = "Connexion";
            this.lblTitrePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxIdentifiant
            // 
            this.txtBoxIdentifiant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxIdentifiant.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxIdentifiant.Location = new System.Drawing.Point(305, 162);
            this.txtBoxIdentifiant.MaxLength = 15;
            this.txtBoxIdentifiant.Name = "txtBoxIdentifiant";
            this.txtBoxIdentifiant.Size = new System.Drawing.Size(275, 32);
            this.txtBoxIdentifiant.TabIndex = 3;
            // 
            // txtBoxMDP
            // 
            this.txtBoxMDP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxMDP.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMDP.Location = new System.Drawing.Point(305, 287);
            this.txtBoxMDP.MaxLength = 15;
            this.txtBoxMDP.Name = "txtBoxMDP";
            this.txtBoxMDP.PasswordChar = '*';
            this.txtBoxMDP.Size = new System.Drawing.Size(275, 32);
            this.txtBoxMDP.TabIndex = 4;
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.BackColor = System.Drawing.SystemColors.Control;
            this.lblIdentifiant.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentifiant.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblIdentifiant.Location = new System.Drawing.Point(99, 146);
            this.lblIdentifiant.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(200, 50);
            this.lblIdentifiant.TabIndex = 5;
            this.lblIdentifiant.Text = "Identifiant :";
            this.lblIdentifiant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMDP
            // 
            this.lblMDP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMDP.AutoSize = true;
            this.lblMDP.BackColor = System.Drawing.SystemColors.Control;
            this.lblMDP.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMDP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMDP.Location = new System.Drawing.Point(73, 271);
            this.lblMDP.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblMDP.Name = "lblMDP";
            this.lblMDP.Size = new System.Drawing.Size(208, 50);
            this.lblMDP.TabIndex = 6;
            this.lblMDP.Text = "Mot de passe :";
            this.lblMDP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConnexion.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.Location = new System.Drawing.Point(27, 371);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(553, 37);
            this.btnConnexion.TabIndex = 7;
            this.btnConnexion.Text = "Se connecter";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // FrmModuleConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(592, 428);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.lblMDP);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.txtBoxMDP);
            this.Controls.Add(this.txtBoxIdentifiant);
            this.Controls.Add(this.lblTitrePage);
            this.Controls.Add(this.lblTitreApplication);
            this.Controls.Add(this.shapeContainer1);
            this.MinimumSize = new System.Drawing.Size(600, 455);
            this.Name = "FrmModuleConnexion";
            this.Text = "Page de connexion";
            this.Load += new System.EventHandler(this.connexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label lblTitreApplication;
        private System.Windows.Forms.Label lblTitrePage;
        private System.Windows.Forms.TextBox txtBoxIdentifiant;
        private System.Windows.Forms.TextBox txtBoxMDP;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblMDP;
        private System.Windows.Forms.Button btnConnexion;
    }
}

