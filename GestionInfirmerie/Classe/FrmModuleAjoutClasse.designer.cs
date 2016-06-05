namespace GestionInfirmerie
{
    partial class FrmModuleAjoutClasse
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
            this.classeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestioninfirmiere_prodtest = new GestionInfirmerie.gestioninfirmiere_prodtest();
            this.lblTitrePage = new System.Windows.Forms.Label();
            this.lblTitreApplication = new System.Windows.Forms.Label();
            this.classeTableAdapter = new GestionInfirmerie.gestioninfirmiere_prodtestTableAdapters.ClasseTableAdapter();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lblMenuMaintenance = new System.Windows.Forms.Label();
            this.lblMenuSynthese = new System.Windows.Forms.Label();
            this.lblMenuGestion = new System.Windows.Forms.Label();
            this.lblMenuVisites = new System.Windows.Forms.Label();
            this.lblMenuEleve = new System.Windows.Forms.Label();
            this.errorProviderAjoutEleve = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelAjoutEleve = new System.Windows.Forms.Panel();
            this.CheminPDF = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxNomClasse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioninfirmiere_prodtest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAjoutEleve)).BeginInit();
            this.panelAjoutEleve.SuspendLayout();
            this.SuspendLayout();
            // 
            // classeBindingSource
            // 
            this.classeBindingSource.DataMember = "Classe";
            this.classeBindingSource.DataSource = this.gestioninfirmiere_prodtest;
            // 
            // gestioninfirmiere_prodtest
            // 
            this.gestioninfirmiere_prodtest.DataSetName = "gestioninfirmiere_prodtest";
            this.gestioninfirmiere_prodtest.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTitrePage
            // 
            this.lblTitrePage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitrePage.AutoSize = true;
            this.lblTitrePage.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitrePage.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitrePage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitrePage.Location = new System.Drawing.Point(652, 13);
            this.lblTitrePage.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblTitrePage.Name = "lblTitrePage";
            this.lblTitrePage.Size = new System.Drawing.Size(210, 50);
            this.lblTitrePage.TabIndex = 33;
            this.lblTitrePage.Text = "Ajout Classe";
            this.lblTitrePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreApplication
            // 
            this.lblTitreApplication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitreApplication.AutoSize = true;
            this.lblTitreApplication.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitreApplication.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreApplication.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitreApplication.Location = new System.Drawing.Point(83, 13);
            this.lblTitreApplication.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblTitreApplication.Name = "lblTitreApplication";
            this.lblTitreApplication.Size = new System.Drawing.Size(200, 50);
            this.lblTitreApplication.TabIndex = 32;
            this.lblTitreApplication.Text = "Libr\'Infi";
            this.lblTitreApplication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classeTableAdapter
            // 
            this.classeTableAdapter.ClearBeforeFill = true;
            // 
            // lineShape7
            // 
            this.lineShape7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lineShape7.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lineShape7.BorderWidth = 2;
            this.lineShape7.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 391;
            this.lineShape7.X2 = 391;
            this.lineShape7.Y1 = 128;
            this.lineShape7.Y2 = 78;
            // 
            // lineShape6
            // 
            this.lineShape6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lineShape6.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lineShape6.BorderWidth = 2;
            this.lineShape6.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 561;
            this.lineShape6.X2 = 561;
            this.lineShape6.Y1 = 130;
            this.lineShape6.Y2 = 78;
            // 
            // lineShape5
            // 
            this.lineShape5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lineShape5.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lineShape5.BorderWidth = 2;
            this.lineShape5.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 785;
            this.lineShape5.X2 = 742;
            this.lineShape5.Y1 = 129;
            this.lineShape5.Y2 = 80;
            // 
            // lineShape4
            // 
            this.lineShape4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lineShape4.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lineShape4.BorderWidth = 2;
            this.lineShape4.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 170;
            this.lineShape4.X2 = 215;
            this.lineShape4.Y1 = 128;
            this.lineShape4.Y2 = 80;
            // 
            // lineShape3
            // 
            this.lineShape3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape3.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lineShape3.BorderWidth = 2;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = -6;
            this.lineShape3.X2 = 944;
            this.lineShape3.Y1 = 129;
            this.lineShape3.Y2 = 129;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -3;
            this.lineShape1.X2 = 947;
            this.lineShape1.Y1 = 79;
            this.lineShape1.Y2 = 79;
            // 
            // lineShape2
            // 
            this.lineShape2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lineShape2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 472;
            this.lineShape2.X2 = 472;
            this.lineShape2.Y1 = 80;
            this.lineShape2.Y2 = -1;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1,
            this.lineShape3,
            this.lineShape4,
            this.lineShape5,
            this.lineShape6,
            this.lineShape7});
            this.shapeContainer1.Size = new System.Drawing.Size(942, 778);
            this.shapeContainer1.TabIndex = 58;
            this.shapeContainer1.TabStop = false;
            // 
            // lblMenuMaintenance
            // 
            this.lblMenuMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenuMaintenance.AutoSize = true;
            this.lblMenuMaintenance.BackColor = System.Drawing.SystemColors.Control;
            this.lblMenuMaintenance.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuMaintenance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMenuMaintenance.Location = new System.Drawing.Point(779, 90);
            this.lblMenuMaintenance.MinimumSize = new System.Drawing.Size(150, 30);
            this.lblMenuMaintenance.Name = "lblMenuMaintenance";
            this.lblMenuMaintenance.Size = new System.Drawing.Size(150, 30);
            this.lblMenuMaintenance.TabIndex = 63;
            this.lblMenuMaintenance.Text = "Maintenance";
            this.lblMenuMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenuMaintenance.Click += new System.EventHandler(this.lblMenuMaintenance_Click);
            // 
            // lblMenuSynthese
            // 
            this.lblMenuSynthese.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMenuSynthese.AutoSize = true;
            this.lblMenuSynthese.BackColor = System.Drawing.SystemColors.Control;
            this.lblMenuSynthese.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuSynthese.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMenuSynthese.Location = new System.Drawing.Point(581, 90);
            this.lblMenuSynthese.MinimumSize = new System.Drawing.Size(150, 30);
            this.lblMenuSynthese.Name = "lblMenuSynthese";
            this.lblMenuSynthese.Size = new System.Drawing.Size(150, 30);
            this.lblMenuSynthese.TabIndex = 62;
            this.lblMenuSynthese.Text = "Synthèse";
            this.lblMenuSynthese.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenuSynthese.Click += new System.EventHandler(this.lblMenuSynthese_Click);
            // 
            // lblMenuGestion
            // 
            this.lblMenuGestion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMenuGestion.AutoSize = true;
            this.lblMenuGestion.BackColor = System.Drawing.SystemColors.Control;
            this.lblMenuGestion.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuGestion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMenuGestion.Location = new System.Drawing.Point(400, 90);
            this.lblMenuGestion.MinimumSize = new System.Drawing.Size(150, 30);
            this.lblMenuGestion.Name = "lblMenuGestion";
            this.lblMenuGestion.Size = new System.Drawing.Size(150, 30);
            this.lblMenuGestion.TabIndex = 61;
            this.lblMenuGestion.Text = "Gestion";
            this.lblMenuGestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenuGestion.Click += new System.EventHandler(this.lblMenuGestion_Click);
            // 
            // lblMenuVisites
            // 
            this.lblMenuVisites.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMenuVisites.AutoSize = true;
            this.lblMenuVisites.BackColor = System.Drawing.SystemColors.Control;
            this.lblMenuVisites.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuVisites.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMenuVisites.Location = new System.Drawing.Point(220, 90);
            this.lblMenuVisites.MinimumSize = new System.Drawing.Size(150, 30);
            this.lblMenuVisites.Name = "lblMenuVisites";
            this.lblMenuVisites.Size = new System.Drawing.Size(152, 30);
            this.lblMenuVisites.TabIndex = 60;
            this.lblMenuVisites.Text = "Liste des visites";
            this.lblMenuVisites.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenuVisites.Click += new System.EventHandler(this.lblMenuVisites_Click);
            // 
            // lblMenuEleve
            // 
            this.lblMenuEleve.AutoSize = true;
            this.lblMenuEleve.BackColor = System.Drawing.SystemColors.Control;
            this.lblMenuEleve.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuEleve.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMenuEleve.Location = new System.Drawing.Point(19, 90);
            this.lblMenuEleve.MinimumSize = new System.Drawing.Size(150, 30);
            this.lblMenuEleve.Name = "lblMenuEleve";
            this.lblMenuEleve.Size = new System.Drawing.Size(152, 30);
            this.lblMenuEleve.TabIndex = 59;
            this.lblMenuEleve.Text = "Liste des élèves";
            this.lblMenuEleve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenuEleve.Click += new System.EventHandler(this.lblMenuEleve_Click);
            // 
            // errorProviderAjoutEleve
            // 
            this.errorProviderAjoutEleve.ContainerControl = this;
            // 
            // panelAjoutEleve
            // 
            this.panelAjoutEleve.Controls.Add(this.CheminPDF);
            this.panelAjoutEleve.Controls.Add(this.button2);
            this.panelAjoutEleve.Controls.Add(this.textBoxNomClasse);
            this.panelAjoutEleve.Controls.Add(this.label1);
            this.panelAjoutEleve.Controls.Add(this.lblIdentifiant);
            this.panelAjoutEleve.Controls.Add(this.btnEnregistrer);
            this.panelAjoutEleve.Location = new System.Drawing.Point(14, 146);
            this.panelAjoutEleve.Name = "panelAjoutEleve";
            this.panelAjoutEleve.Size = new System.Drawing.Size(916, 632);
            this.panelAjoutEleve.TabIndex = 64;
            // 
            // CheminPDF
            // 
            this.CheminPDF.Location = new System.Drawing.Point(278, 148);
            this.CheminPDF.Name = "CheminPDF";
            this.CheminPDF.ReadOnly = true;
            this.CheminPDF.Size = new System.Drawing.Size(296, 20);
            this.CheminPDF.TabIndex = 66;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(580, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 65;
            this.button2.Text = "Parcourir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxNomClasse
            // 
            this.textBoxNomClasse.Location = new System.Drawing.Point(278, 38);
            this.textBoxNomClasse.Name = "textBoxNomClasse";
            this.textBoxNomClasse.Size = new System.Drawing.Size(162, 20);
            this.textBoxNomClasse.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(135, 128);
            this.label1.MinimumSize = new System.Drawing.Size(200, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 50);
            this.label1.TabIndex = 62;
            this.label1.Text = "EDT :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.BackColor = System.Drawing.SystemColors.Control;
            this.lblIdentifiant.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentifiant.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblIdentifiant.Location = new System.Drawing.Point(135, 16);
            this.lblIdentifiant.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(200, 50);
            this.lblIdentifiant.TabIndex = 60;
            this.lblIdentifiant.Text = "Nom :";
            this.lblIdentifiant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnregistrer.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(187, 579);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(553, 37);
            this.btnEnregistrer.TabIndex = 58;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // FrmModuleAjoutClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 778);
            this.Controls.Add(this.panelAjoutEleve);
            this.Controls.Add(this.lblMenuMaintenance);
            this.Controls.Add(this.lblMenuSynthese);
            this.Controls.Add(this.lblMenuGestion);
            this.Controls.Add(this.lblMenuVisites);
            this.Controls.Add(this.lblMenuEleve);
            this.Controls.Add(this.lblTitrePage);
            this.Controls.Add(this.lblTitreApplication);
            this.Controls.Add(this.shapeContainer1);
            this.MinimumSize = new System.Drawing.Size(950, 805);
            this.Name = "FrmModuleAjoutClasse";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmModuleAjoutEleve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioninfirmiere_prodtest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAjoutEleve)).EndInit();
            this.panelAjoutEleve.ResumeLayout(false);
            this.panelAjoutEleve.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitrePage;
        private System.Windows.Forms.Label lblTitreApplication;
        private gestioninfirmiere_prodtest gestioninfirmiere_prodtest;
        private System.Windows.Forms.BindingSource classeBindingSource;
        private gestioninfirmiere_prodtestTableAdapters.ClasseTableAdapter classeTableAdapter;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label lblMenuMaintenance;
        private System.Windows.Forms.Label lblMenuSynthese;
        private System.Windows.Forms.Label lblMenuGestion;
        private System.Windows.Forms.Label lblMenuVisites;
        private System.Windows.Forms.Label lblMenuEleve;
        private System.Windows.Forms.ErrorProvider errorProviderAjoutEleve;
        private System.Windows.Forms.Panel panelAjoutEleve;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.TextBox textBoxNomClasse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox CheminPDF;
    }
}