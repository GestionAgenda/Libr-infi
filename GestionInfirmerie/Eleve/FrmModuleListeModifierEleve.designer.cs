
namespace GestionInfirmerie
{
    partial class FrmModuleListeModifierEleve
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
            this.lblTitreApplication = new System.Windows.Forms.Label();
            this.lblTitrePage = new System.Windows.Forms.Label();
            this.lblMenuEleve = new System.Windows.Forms.Label();
            this.lblMenuVisites = new System.Windows.Forms.Label();
            this.lblMenuGestion = new System.Windows.Forms.Label();
            this.lblMenuSynthese = new System.Windows.Forms.Label();
            this.lblMenuMaintenance = new System.Windows.Forms.Label();
            this.classeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestioninfirmiere_prodtest = new GestionInfirmerie.gestioninfirmiere_prodtest();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.classeTableAdapter = new GestionInfirmerie.gestioninfirmiere_prodtestTableAdapters.ClasseTableAdapter();
            this.dataGridViewListEleve2 = new System.Windows.Forms.DataGridView();
            this.txtBoxNomSaisieEleve = new System.Windows.Forms.TextBox();
            this.lblNomSaisieEleve = new System.Windows.Forms.Label();
            this.ColumnNomEleve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBoutonDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnIdEleve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioninfirmiere_prodtest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListEleve2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitreApplication
            // 
            this.lblTitreApplication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitreApplication.AutoSize = true;
            this.lblTitreApplication.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitreApplication.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreApplication.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitreApplication.Location = new System.Drawing.Point(12, 9);
            this.lblTitreApplication.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblTitreApplication.Name = "lblTitreApplication";
            this.lblTitreApplication.Size = new System.Drawing.Size(200, 50);
            this.lblTitreApplication.TabIndex = 4;
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
            this.lblTitrePage.Location = new System.Drawing.Point(554, 9);
            this.lblTitrePage.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblTitrePage.Name = "lblTitrePage";
            this.lblTitrePage.Size = new System.Drawing.Size(377, 50);
            this.lblTitrePage.TabIndex = 5;
            this.lblTitrePage.Text = "Modification d\'un élève";
            this.lblTitrePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMenuEleve
            // 
            this.lblMenuEleve.AutoSize = true;
            this.lblMenuEleve.BackColor = System.Drawing.SystemColors.Control;
            this.lblMenuEleve.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuEleve.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMenuEleve.Location = new System.Drawing.Point(12, 91);
            this.lblMenuEleve.MinimumSize = new System.Drawing.Size(150, 30);
            this.lblMenuEleve.Name = "lblMenuEleve";
            this.lblMenuEleve.Size = new System.Drawing.Size(152, 30);
            this.lblMenuEleve.TabIndex = 11;
            this.lblMenuEleve.Text = "Liste des élèves";
            this.lblMenuEleve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenuEleve.Click += new System.EventHandler(this.lblMenuEleve_Click);
            // 
            // lblMenuVisites
            // 
            this.lblMenuVisites.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMenuVisites.AutoSize = true;
            this.lblMenuVisites.BackColor = System.Drawing.SystemColors.Control;
            this.lblMenuVisites.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuVisites.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMenuVisites.Location = new System.Drawing.Point(213, 91);
            this.lblMenuVisites.MinimumSize = new System.Drawing.Size(150, 30);
            this.lblMenuVisites.Name = "lblMenuVisites";
            this.lblMenuVisites.Size = new System.Drawing.Size(152, 30);
            this.lblMenuVisites.TabIndex = 12;
            this.lblMenuVisites.Text = "Liste des visites";
            this.lblMenuVisites.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenuVisites.Click += new System.EventHandler(this.lblMenuVisites_Click);
            // 
            // lblMenuGestion
            // 
            this.lblMenuGestion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMenuGestion.AutoSize = true;
            this.lblMenuGestion.BackColor = System.Drawing.SystemColors.Control;
            this.lblMenuGestion.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuGestion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMenuGestion.Location = new System.Drawing.Point(393, 91);
            this.lblMenuGestion.MinimumSize = new System.Drawing.Size(150, 30);
            this.lblMenuGestion.Name = "lblMenuGestion";
            this.lblMenuGestion.Size = new System.Drawing.Size(150, 30);
            this.lblMenuGestion.TabIndex = 13;
            this.lblMenuGestion.Text = "Gestion";
            this.lblMenuGestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenuGestion.Click += new System.EventHandler(this.lblMenuGestion_Click);
            // 
            // lblMenuSynthese
            // 
            this.lblMenuSynthese.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMenuSynthese.AutoSize = true;
            this.lblMenuSynthese.BackColor = System.Drawing.SystemColors.Control;
            this.lblMenuSynthese.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuSynthese.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMenuSynthese.Location = new System.Drawing.Point(574, 91);
            this.lblMenuSynthese.MinimumSize = new System.Drawing.Size(150, 30);
            this.lblMenuSynthese.Name = "lblMenuSynthese";
            this.lblMenuSynthese.Size = new System.Drawing.Size(150, 30);
            this.lblMenuSynthese.TabIndex = 14;
            this.lblMenuSynthese.Text = "Synthèse";
            this.lblMenuSynthese.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenuSynthese.Click += new System.EventHandler(this.lblMenuSynthese_Click);
            // 
            // lblMenuMaintenance
            // 
            this.lblMenuMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenuMaintenance.AutoSize = true;
            this.lblMenuMaintenance.BackColor = System.Drawing.SystemColors.Control;
            this.lblMenuMaintenance.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuMaintenance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMenuMaintenance.Location = new System.Drawing.Point(772, 91);
            this.lblMenuMaintenance.MinimumSize = new System.Drawing.Size(150, 30);
            this.lblMenuMaintenance.Name = "lblMenuMaintenance";
            this.lblMenuMaintenance.Size = new System.Drawing.Size(150, 30);
            this.lblMenuMaintenance.TabIndex = 15;
            this.lblMenuMaintenance.Text = "Maintenance";
            this.lblMenuMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenuMaintenance.Click += new System.EventHandler(this.lblMenuMaintenance_Click);
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
            // lineShape7
            // 
            this.lineShape7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lineShape7.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lineShape7.BorderWidth = 2;
            this.lineShape7.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 383;
            this.lineShape7.X2 = 383;
            this.lineShape7.Y1 = 129;
            this.lineShape7.Y2 = 79;
            // 
            // lineShape6
            // 
            this.lineShape6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lineShape6.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lineShape6.BorderWidth = 2;
            this.lineShape6.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 553;
            this.lineShape6.X2 = 553;
            this.lineShape6.Y1 = 131;
            this.lineShape6.Y2 = 79;
            // 
            // lineShape5
            // 
            this.lineShape5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lineShape5.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lineShape5.BorderWidth = 2;
            this.lineShape5.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 777;
            this.lineShape5.X2 = 734;
            this.lineShape5.Y1 = 130;
            this.lineShape5.Y2 = 81;
            // 
            // lineShape4
            // 
            this.lineShape4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lineShape4.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lineShape4.BorderWidth = 2;
            this.lineShape4.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 162;
            this.lineShape4.X2 = 207;
            this.lineShape4.Y1 = 129;
            this.lineShape4.Y2 = 81;
            // 
            // lineShape3
            // 
            this.lineShape3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape3.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lineShape3.BorderWidth = 2;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = -14;
            this.lineShape3.X2 = 936;
            this.lineShape3.Y1 = 130;
            this.lineShape3.Y2 = 130;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -11;
            this.lineShape1.X2 = 939;
            this.lineShape1.Y1 = 80;
            this.lineShape1.Y2 = 80;
            // 
            // lineShape2
            // 
            this.lineShape2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lineShape2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 464;
            this.lineShape2.X2 = 464;
            this.lineShape2.Y1 = 81;
            this.lineShape2.Y2 = 0;
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
            this.shapeContainer1.Size = new System.Drawing.Size(934, 673);
            this.shapeContainer1.TabIndex = 36;
            this.shapeContainer1.TabStop = false;
            // 
            // classeTableAdapter
            // 
            this.classeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewListEleve2
            // 
            this.dataGridViewListEleve2.AllowUserToAddRows = false;
            this.dataGridViewListEleve2.AllowUserToDeleteRows = false;
            this.dataGridViewListEleve2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewListEleve2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListEleve2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNomEleve,
            this.ColumnPrenom,
            this.ColumnClasse,
            this.clmnBoutonDetails,
            this.clmnIdEleve});
            this.dataGridViewListEleve2.Location = new System.Drawing.Point(20, 196);
            this.dataGridViewListEleve2.Name = "dataGridViewListEleve2";
            this.dataGridViewListEleve2.ReadOnly = true;
            this.dataGridViewListEleve2.Size = new System.Drawing.Size(893, 447);
            this.dataGridViewListEleve2.TabIndex = 39;
            this.dataGridViewListEleve2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListEleve2_CellClick);
            // 
            // txtBoxNomSaisieEleve
            // 
            this.txtBoxNomSaisieEleve.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxNomSaisieEleve.Location = new System.Drawing.Point(121, 158);
            this.txtBoxNomSaisieEleve.Name = "txtBoxNomSaisieEleve";
            this.txtBoxNomSaisieEleve.Size = new System.Drawing.Size(792, 20);
            this.txtBoxNomSaisieEleve.TabIndex = 38;
            this.txtBoxNomSaisieEleve.TextChanged += new System.EventHandler(this.txtBoxNomSaisieEleve_TextChanged);
            // 
            // lblNomSaisieEleve
            // 
            this.lblNomSaisieEleve.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNomSaisieEleve.AutoSize = true;
            this.lblNomSaisieEleve.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomSaisieEleve.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNomSaisieEleve.Location = new System.Drawing.Point(15, 154);
            this.lblNomSaisieEleve.Name = "lblNomSaisieEleve";
            this.lblNomSaisieEleve.Size = new System.Drawing.Size(80, 25);
            this.lblNomSaisieEleve.TabIndex = 37;
            this.lblNomSaisieEleve.Text = "Nom :";
            // 
            // ColumnNomEleve
            // 
            this.ColumnNomEleve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNomEleve.FillWeight = 178F;
            this.ColumnNomEleve.HeaderText = "Nom";
            this.ColumnNomEleve.Name = "ColumnNomEleve";
            this.ColumnNomEleve.ReadOnly = true;
            this.ColumnNomEleve.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnPrenom
            // 
            this.ColumnPrenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPrenom.FillWeight = 178F;
            this.ColumnPrenom.HeaderText = "Prénom";
            this.ColumnPrenom.Name = "ColumnPrenom";
            this.ColumnPrenom.ReadOnly = true;
            this.ColumnPrenom.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnClasse
            // 
            this.ColumnClasse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnClasse.FillWeight = 178F;
            this.ColumnClasse.HeaderText = "Classe";
            this.ColumnClasse.Name = "ColumnClasse";
            this.ColumnClasse.ReadOnly = true;
            this.ColumnClasse.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmnBoutonDetails
            // 
            this.clmnBoutonDetails.HeaderText = "Modifier élève";
            this.clmnBoutonDetails.Name = "clmnBoutonDetails";
            this.clmnBoutonDetails.ReadOnly = true;
            this.clmnBoutonDetails.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnBoutonDetails.Text = "Modifier";
            this.clmnBoutonDetails.UseColumnTextForButtonValue = true;
            // 
            // clmnIdEleve
            // 
            this.clmnIdEleve.HeaderText = "clmnIdEleve";
            this.clmnIdEleve.Name = "clmnIdEleve";
            this.clmnIdEleve.ReadOnly = true;
            this.clmnIdEleve.Visible = false;
            // 
            // FrmModuleListeModifierEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 673);
            this.Controls.Add(this.dataGridViewListEleve2);
            this.Controls.Add(this.txtBoxNomSaisieEleve);
            this.Controls.Add(this.lblNomSaisieEleve);
            this.Controls.Add(this.lblMenuMaintenance);
            this.Controls.Add(this.lblMenuSynthese);
            this.Controls.Add(this.lblMenuGestion);
            this.Controls.Add(this.lblMenuVisites);
            this.Controls.Add(this.lblMenuEleve);
            this.Controls.Add(this.lblTitrePage);
            this.Controls.Add(this.lblTitreApplication);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "FrmModuleListeModifierEleve";
            this.Text = "FrmModuleModifierEleve";
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioninfirmiere_prodtest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListEleve2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitreApplication;
        private System.Windows.Forms.Label lblTitrePage;
        private System.Windows.Forms.Label lblMenuEleve;
        private System.Windows.Forms.Label lblMenuVisites;
        private System.Windows.Forms.Label lblMenuGestion;
        private System.Windows.Forms.Label lblMenuSynthese;
        private System.Windows.Forms.Label lblMenuMaintenance;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private gestioninfirmiere_prodtest gestioninfirmiere_prodtest;
        private System.Windows.Forms.BindingSource classeBindingSource;
        private gestioninfirmiere_prodtestTableAdapters.ClasseTableAdapter classeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewListEleve2;
        private System.Windows.Forms.TextBox txtBoxNomSaisieEleve;
        private System.Windows.Forms.Label lblNomSaisieEleve;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomEleve;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClasse;
        private System.Windows.Forms.DataGridViewButtonColumn clmnBoutonDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnIdEleve;
    }
}