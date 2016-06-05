namespace GestionInfirmerie
{
    partial class FrmModuleAddVisite
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
            this.comtextbox = new System.Windows.Forms.RichTextBox();
            this.labelcom = new System.Windows.Forms.Label();
            this.labeldate = new System.Windows.Forms.Label();
            this.classeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestioninfirmiere_prodtest = new GestionInfirmerie.gestioninfirmiere_prodtest();
            this.labelclasse = new System.Windows.Forms.Label();
            this.labelnom = new System.Windows.Forms.Label();
            this.btnAddVisite = new System.Windows.Forms.Button();
            this.lblTitrePage = new System.Windows.Forms.Label();
            this.lblTitreApplication = new System.Windows.Forms.Label();
            this.dateVisite = new System.Windows.Forms.MonthCalendar();
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
            this.labelvisitehopital = new System.Windows.Forms.Label();
            this.VHradioOui = new System.Windows.Forms.RadioButton();
            this.labelparprev = new System.Windows.Forms.Label();
            this.labelmotif = new System.Windows.Forms.Label();
            this.motiftextBox = new System.Windows.Forms.TextBox();
            this.labelHeureA = new System.Windows.Forms.Label();
            this.labelHeureS = new System.Windows.Forms.Label();
            this.labelretourdom = new System.Windows.Forms.Label();
            this.RDradioOui = new System.Windows.Forms.RadioButton();
            this.labelprescrire = new System.Windows.Forms.Label();
            this.labelquantite = new System.Windows.Forms.Label();
            this.comboBoxPrescrire = new System.Windows.Forms.ComboBox();
            this.medicamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestioninfirmiereprodtestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelpouls = new System.Windows.Forms.Label();
            this.poulstextbox = new System.Windows.Forms.TextBox();
            this.comboBoxQuantite = new System.Windows.Forms.ComboBox();
            this.eleveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eleveTableAdapter = new GestionInfirmerie.gestioninfirmiere_prodtestTableAdapters.EleveTableAdapter();
            this.medicamentTableAdapter = new GestionInfirmerie.gestioninfirmiere_prodtestTableAdapters.MedicamentTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.RRadioButton = new System.Windows.Forms.RadioButton();
            this.PPCheckBox = new System.Windows.Forms.CheckBox();
            this.comboBoxHeureSortie = new System.Windows.Forms.ComboBox();
            this.comboBoxHeureArrivee = new System.Windows.Forms.ComboBox();
            this.comboBoxMinuteSortie = new System.Windows.Forms.ComboBox();
            this.comboBoxMinuteArrivee = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProviderAjoutVisite = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioninfirmiere_prodtest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioninfirmiereprodtestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAjoutVisite)).BeginInit();
            this.SuspendLayout();
            // 
            // comtextbox
            // 
            this.comtextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comtextbox.Location = new System.Drawing.Point(245, 559);
            this.comtextbox.Name = "comtextbox";
            this.comtextbox.Size = new System.Drawing.Size(619, 162);
            this.comtextbox.TabIndex = 53;
            this.comtextbox.Text = "";
            // 
            // labelcom
            // 
            this.labelcom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelcom.AutoSize = true;
            this.labelcom.BackColor = System.Drawing.SystemColors.Control;
            this.labelcom.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcom.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelcom.Location = new System.Drawing.Point(3, 578);
            this.labelcom.MinimumSize = new System.Drawing.Size(200, 50);
            this.labelcom.Name = "labelcom";
            this.labelcom.Size = new System.Drawing.Size(219, 50);
            this.labelcom.TabIndex = 52;
            this.labelcom.Text = "Commentaire : ";
            this.labelcom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labeldate
            // 
            this.labeldate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeldate.AutoSize = true;
            this.labeldate.BackColor = System.Drawing.SystemColors.Control;
            this.labeldate.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labeldate.Location = new System.Drawing.Point(31, 243);
            this.labeldate.MinimumSize = new System.Drawing.Size(200, 50);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(200, 50);
            this.labeldate.TabIndex = 44;
            this.labeldate.Text = "Date :";
            this.labeldate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // labelclasse
            // 
            this.labelclasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelclasse.AutoSize = true;
            this.labelclasse.BackColor = System.Drawing.SystemColors.Control;
            this.labelclasse.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelclasse.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelclasse.Location = new System.Drawing.Point(521, 177);
            this.labelclasse.MinimumSize = new System.Drawing.Size(200, 50);
            this.labelclasse.Name = "labelclasse";
            this.labelclasse.Size = new System.Drawing.Size(200, 50);
            this.labelclasse.TabIndex = 40;
            this.labelclasse.Text = "Classe :";
            this.labelclasse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelnom
            // 
            this.labelnom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelnom.AutoSize = true;
            this.labelnom.BackColor = System.Drawing.SystemColors.Control;
            this.labelnom.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnom.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelnom.Location = new System.Drawing.Point(52, 177);
            this.labelnom.MinimumSize = new System.Drawing.Size(200, 50);
            this.labelnom.Name = "labelnom";
            this.labelnom.Size = new System.Drawing.Size(200, 50);
            this.labelnom.TabIndex = 36;
            this.labelnom.Text = "Nom :";
            this.labelnom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddVisite
            // 
            this.btnAddVisite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddVisite.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVisite.Location = new System.Drawing.Point(199, 852);
            this.btnAddVisite.Name = "btnAddVisite";
            this.btnAddVisite.Size = new System.Drawing.Size(553, 37);
            this.btnAddVisite.TabIndex = 34;
            this.btnAddVisite.Text = "Ajouter Visite";
            this.btnAddVisite.UseVisualStyleBackColor = true;
            this.btnAddVisite.Click += new System.EventHandler(this.btnAddVisite_Click);
            // 
            // lblTitrePage
            // 
            this.lblTitrePage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitrePage.AutoSize = true;
            this.lblTitrePage.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitrePage.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitrePage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitrePage.Location = new System.Drawing.Point(724, 13);
            this.lblTitrePage.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblTitrePage.Name = "lblTitrePage";
            this.lblTitrePage.Size = new System.Drawing.Size(200, 50);
            this.lblTitrePage.TabIndex = 33;
            this.lblTitrePage.Text = "Ajout Visite";
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
            // dateVisite
            // 
            this.dateVisite.Location = new System.Drawing.Point(222, 231);
            this.dateVisite.Name = "dateVisite";
            this.dateVisite.TabIndex = 56;
            this.dateVisite.Validating += new System.ComponentModel.CancelEventHandler(this.dateVisite_Validating);
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
            this.lineShape7.X1 = 412;
            this.lineShape7.X2 = 412;
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
            this.lineShape6.X1 = 582;
            this.lineShape6.X2 = 582;
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
            this.lineShape5.X1 = 806;
            this.lineShape5.X2 = 763;
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
            this.lineShape4.X1 = 191;
            this.lineShape4.X2 = 236;
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
            this.lineShape3.X2 = 986;
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
            this.lineShape1.X2 = 989;
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
            this.lineShape2.X1 = 493;
            this.lineShape2.X2 = 493;
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
            this.shapeContainer1.Size = new System.Drawing.Size(984, 892);
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
            this.lblMenuMaintenance.Location = new System.Drawing.Point(821, 90);
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
            this.lblMenuSynthese.Location = new System.Drawing.Point(602, 90);
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
            this.lblMenuGestion.Location = new System.Drawing.Point(421, 90);
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
            this.lblMenuVisites.Location = new System.Drawing.Point(241, 90);
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
            // labelvisitehopital
            // 
            this.labelvisitehopital.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelvisitehopital.AutoSize = true;
            this.labelvisitehopital.BackColor = System.Drawing.SystemColors.Control;
            this.labelvisitehopital.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvisitehopital.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelvisitehopital.Location = new System.Drawing.Point(3, 724);
            this.labelvisitehopital.MinimumSize = new System.Drawing.Size(200, 50);
            this.labelvisitehopital.Name = "labelvisitehopital";
            this.labelvisitehopital.Size = new System.Drawing.Size(219, 50);
            this.labelvisitehopital.TabIndex = 64;
            this.labelvisitehopital.Text = "Visite Hopital : ";
            this.labelvisitehopital.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VHradioOui
            // 
            this.VHradioOui.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VHradioOui.AutoSize = true;
            this.VHradioOui.Location = new System.Drawing.Point(259, 747);
            this.VHradioOui.Name = "VHradioOui";
            this.VHradioOui.Size = new System.Drawing.Size(41, 17);
            this.VHradioOui.TabIndex = 65;
            this.VHradioOui.Text = "Oui";
            this.VHradioOui.UseVisualStyleBackColor = true;
            // 
            // labelparprev
            // 
            this.labelparprev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelparprev.AutoSize = true;
            this.labelparprev.BackColor = System.Drawing.SystemColors.Control;
            this.labelparprev.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelparprev.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelparprev.Location = new System.Drawing.Point(290, 787);
            this.labelparprev.MinimumSize = new System.Drawing.Size(200, 50);
            this.labelparprev.Name = "labelparprev";
            this.labelparprev.Size = new System.Drawing.Size(257, 50);
            this.labelparprev.TabIndex = 67;
            this.labelparprev.Text = "Parents Prévenus :";
            this.labelparprev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelmotif
            // 
            this.labelmotif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelmotif.AutoSize = true;
            this.labelmotif.BackColor = System.Drawing.SystemColors.Control;
            this.labelmotif.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmotif.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelmotif.Location = new System.Drawing.Point(508, 243);
            this.labelmotif.MinimumSize = new System.Drawing.Size(200, 50);
            this.labelmotif.Name = "labelmotif";
            this.labelmotif.Size = new System.Drawing.Size(200, 50);
            this.labelmotif.TabIndex = 70;
            this.labelmotif.Text = "Motif :";
            this.labelmotif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // motiftextBox
            // 
            this.motiftextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.motiftextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.motiftextBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motiftextBox.Location = new System.Drawing.Point(664, 259);
            this.motiftextBox.MaxLength = 15;
            this.motiftextBox.Name = "motiftextBox";
            this.motiftextBox.Size = new System.Drawing.Size(200, 32);
            this.motiftextBox.TabIndex = 71;
            this.motiftextBox.Validating += new System.ComponentModel.CancelEventHandler(this.motiftextBox_Validating);
            // 
            // labelHeureA
            // 
            this.labelHeureA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHeureA.AutoSize = true;
            this.labelHeureA.BackColor = System.Drawing.SystemColors.Control;
            this.labelHeureA.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeureA.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelHeureA.Location = new System.Drawing.Point(462, 419);
            this.labelHeureA.MinimumSize = new System.Drawing.Size(200, 50);
            this.labelHeureA.Name = "labelHeureA";
            this.labelHeureA.Size = new System.Drawing.Size(213, 50);
            this.labelHeureA.TabIndex = 72;
            this.labelHeureA.Text = "Heure Arrivee :";
            this.labelHeureA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHeureS
            // 
            this.labelHeureS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHeureS.AutoSize = true;
            this.labelHeureS.BackColor = System.Drawing.SystemColors.Control;
            this.labelHeureS.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeureS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelHeureS.Location = new System.Drawing.Point(475, 472);
            this.labelHeureS.MinimumSize = new System.Drawing.Size(200, 50);
            this.labelHeureS.Name = "labelHeureS";
            this.labelHeureS.Size = new System.Drawing.Size(200, 50);
            this.labelHeureS.TabIndex = 74;
            this.labelHeureS.Text = "Heure Sortie :";
            this.labelHeureS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelretourdom
            // 
            this.labelretourdom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelretourdom.AutoSize = true;
            this.labelretourdom.BackColor = System.Drawing.SystemColors.Control;
            this.labelretourdom.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelretourdom.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelretourdom.Location = new System.Drawing.Point(364, 724);
            this.labelretourdom.MinimumSize = new System.Drawing.Size(200, 50);
            this.labelretourdom.Name = "labelretourdom";
            this.labelretourdom.Size = new System.Drawing.Size(235, 50);
            this.labelretourdom.TabIndex = 76;
            this.labelretourdom.Text = "Retour Domicile:";
            this.labelretourdom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RDradioOui
            // 
            this.RDradioOui.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RDradioOui.AutoSize = true;
            this.RDradioOui.Location = new System.Drawing.Point(605, 747);
            this.RDradioOui.Name = "RDradioOui";
            this.RDradioOui.Size = new System.Drawing.Size(41, 17);
            this.RDradioOui.TabIndex = 77;
            this.RDradioOui.Text = "Oui";
            this.RDradioOui.UseVisualStyleBackColor = true;
            // 
            // labelprescrire
            // 
            this.labelprescrire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelprescrire.AutoSize = true;
            this.labelprescrire.BackColor = System.Drawing.SystemColors.Control;
            this.labelprescrire.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprescrire.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelprescrire.Location = new System.Drawing.Point(8, 472);
            this.labelprescrire.MinimumSize = new System.Drawing.Size(200, 50);
            this.labelprescrire.Name = "labelprescrire";
            this.labelprescrire.Size = new System.Drawing.Size(200, 50);
            this.labelprescrire.TabIndex = 79;
            this.labelprescrire.Text = "Prescrire :";
            this.labelprescrire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelquantite
            // 
            this.labelquantite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelquantite.AutoSize = true;
            this.labelquantite.BackColor = System.Drawing.SystemColors.Control;
            this.labelquantite.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelquantite.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelquantite.Location = new System.Drawing.Point(7, 419);
            this.labelquantite.MinimumSize = new System.Drawing.Size(200, 50);
            this.labelquantite.Name = "labelquantite";
            this.labelquantite.Size = new System.Drawing.Size(200, 50);
            this.labelquantite.TabIndex = 81;
            this.labelquantite.Text = "Quantité :";
            this.labelquantite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxPrescrire
            // 
            this.comboBoxPrescrire.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.medicamentBindingSource, "Id_medicament", true));
            this.comboBoxPrescrire.DataSource = this.medicamentBindingSource;
            this.comboBoxPrescrire.DisplayMember = "Libelle_medicament";
            this.comboBoxPrescrire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrescrire.FormattingEnabled = true;
            this.comboBoxPrescrire.Location = new System.Drawing.Point(214, 494);
            this.comboBoxPrescrire.Name = "comboBoxPrescrire";
            this.comboBoxPrescrire.Size = new System.Drawing.Size(200, 21);
            this.comboBoxPrescrire.TabIndex = 84;
            this.comboBoxPrescrire.ValueMember = "Id_medicament";
            // 
            // medicamentBindingSource
            // 
            this.medicamentBindingSource.DataMember = "Medicament";
            this.medicamentBindingSource.DataSource = this.gestioninfirmiereprodtestBindingSource;
            // 
            // gestioninfirmiereprodtestBindingSource
            // 
            this.gestioninfirmiereprodtestBindingSource.DataSource = this.gestioninfirmiere_prodtest;
            this.gestioninfirmiereprodtestBindingSource.Position = 0;
            // 
            // labelpouls
            // 
            this.labelpouls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelpouls.AutoSize = true;
            this.labelpouls.BackColor = System.Drawing.SystemColors.Control;
            this.labelpouls.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpouls.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelpouls.Location = new System.Drawing.Point(508, 294);
            this.labelpouls.MinimumSize = new System.Drawing.Size(200, 50);
            this.labelpouls.Name = "labelpouls";
            this.labelpouls.Size = new System.Drawing.Size(200, 50);
            this.labelpouls.TabIndex = 85;
            this.labelpouls.Text = "Pouls :";
            this.labelpouls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // poulstextbox
            // 
            this.poulstextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.poulstextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.poulstextbox.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poulstextbox.Location = new System.Drawing.Point(664, 309);
            this.poulstextbox.MaxLength = 15;
            this.poulstextbox.Name = "poulstextbox";
            this.poulstextbox.Size = new System.Drawing.Size(200, 32);
            this.poulstextbox.TabIndex = 86;
            this.poulstextbox.Validating += new System.ComponentModel.CancelEventHandler(this.poulstextbox_Validating);
            // 
            // comboBoxQuantite
            // 
            this.comboBoxQuantite.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxQuantite.FormattingEnabled = true;
            this.comboBoxQuantite.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxQuantite.Location = new System.Drawing.Point(213, 441);
            this.comboBoxQuantite.Name = "comboBoxQuantite";
            this.comboBoxQuantite.Size = new System.Drawing.Size(200, 21);
            this.comboBoxQuantite.TabIndex = 87;
            this.comboBoxQuantite.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxQuantite_Validating);
            // 
            // eleveBindingSource
            // 
            this.eleveBindingSource.DataMember = "Eleve";
            this.eleveBindingSource.DataSource = this.gestioninfirmiereprodtestBindingSource;
            // 
            // eleveTableAdapter
            // 
            this.eleveTableAdapter.ClearBeforeFill = true;
            // 
            // medicamentTableAdapter
            // 
            this.medicamentTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(664, 724);
            this.label1.MinimumSize = new System.Drawing.Size(200, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 50);
            this.label1.TabIndex = 90;
            this.label1.Text = "Rien";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RRadioButton
            // 
            this.RRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RRadioButton.AutoSize = true;
            this.RRadioButton.Checked = true;
            this.RRadioButton.Location = new System.Drawing.Point(825, 747);
            this.RRadioButton.Name = "RRadioButton";
            this.RRadioButton.Size = new System.Drawing.Size(41, 17);
            this.RRadioButton.TabIndex = 91;
            this.RRadioButton.TabStop = true;
            this.RRadioButton.Text = "Oui";
            this.RRadioButton.UseVisualStyleBackColor = true;
            // 
            // PPCheckBox
            // 
            this.PPCheckBox.AutoSize = true;
            this.PPCheckBox.Location = new System.Drawing.Point(582, 811);
            this.PPCheckBox.Name = "PPCheckBox";
            this.PPCheckBox.Size = new System.Drawing.Size(42, 17);
            this.PPCheckBox.TabIndex = 92;
            this.PPCheckBox.Text = "Oui";
            this.PPCheckBox.UseVisualStyleBackColor = true;
            // 
            // comboBoxHeureSortie
            // 
            this.comboBoxHeureSortie.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxHeureSortie.FormattingEnabled = true;
            this.comboBoxHeureSortie.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBoxHeureSortie.Location = new System.Drawing.Point(692, 494);
            this.comboBoxHeureSortie.Name = "comboBoxHeureSortie";
            this.comboBoxHeureSortie.Size = new System.Drawing.Size(52, 21);
            this.comboBoxHeureSortie.TabIndex = 93;
            this.comboBoxHeureSortie.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxHeureSortie_Validating);
            // 
            // comboBoxHeureArrivee
            // 
            this.comboBoxHeureArrivee.FormattingEnabled = true;
            this.comboBoxHeureArrivee.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBoxHeureArrivee.Location = new System.Drawing.Point(692, 441);
            this.comboBoxHeureArrivee.Name = "comboBoxHeureArrivee";
            this.comboBoxHeureArrivee.Size = new System.Drawing.Size(52, 21);
            this.comboBoxHeureArrivee.TabIndex = 94;
            this.comboBoxHeureArrivee.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxHeureArrivee_Validating);
            // 
            // comboBoxMinuteSortie
            // 
            this.comboBoxMinuteSortie.FormattingEnabled = true;
            this.comboBoxMinuteSortie.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBoxMinuteSortie.Location = new System.Drawing.Point(775, 494);
            this.comboBoxMinuteSortie.Name = "comboBoxMinuteSortie";
            this.comboBoxMinuteSortie.Size = new System.Drawing.Size(52, 21);
            this.comboBoxMinuteSortie.TabIndex = 95;
            this.comboBoxMinuteSortie.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxMinuteSortie_Validating);
            // 
            // comboBoxMinuteArrivee
            // 
            this.comboBoxMinuteArrivee.FormattingEnabled = true;
            this.comboBoxMinuteArrivee.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBoxMinuteArrivee.Location = new System.Drawing.Point(775, 441);
            this.comboBoxMinuteArrivee.Name = "comboBoxMinuteArrivee";
            this.comboBoxMinuteArrivee.Size = new System.Drawing.Size(52, 21);
            this.comboBoxMinuteArrivee.TabIndex = 96;
            this.comboBoxMinuteArrivee.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxMinuteArrivee_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(749, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 98;
            this.label3.Text = "H";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(749, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 99;
            this.label4.Text = "H";
            this.label4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(834, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "M";
            this.label2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(834, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 101;
            this.label5.Text = "M";
            this.label5.Visible = false;
            // 
            // errorProviderAjoutVisite
            // 
            this.errorProviderAjoutVisite.ContainerControl = this;
            // 
            // FrmModuleAddVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 892);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxMinuteArrivee);
            this.Controls.Add(this.comboBoxMinuteSortie);
            this.Controls.Add(this.comboBoxHeureArrivee);
            this.Controls.Add(this.comboBoxHeureSortie);
            this.Controls.Add(this.PPCheckBox);
            this.Controls.Add(this.RRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxQuantite);
            this.Controls.Add(this.poulstextbox);
            this.Controls.Add(this.comboBoxPrescrire);
            this.Controls.Add(this.labelquantite);
            this.Controls.Add(this.labelprescrire);
            this.Controls.Add(this.RDradioOui);
            this.Controls.Add(this.labelretourdom);
            this.Controls.Add(this.labelHeureS);
            this.Controls.Add(this.labelHeureA);
            this.Controls.Add(this.motiftextBox);
            this.Controls.Add(this.labelmotif);
            this.Controls.Add(this.labelparprev);
            this.Controls.Add(this.VHradioOui);
            this.Controls.Add(this.labelvisitehopital);
            this.Controls.Add(this.lblMenuMaintenance);
            this.Controls.Add(this.lblMenuSynthese);
            this.Controls.Add(this.lblMenuGestion);
            this.Controls.Add(this.lblMenuVisites);
            this.Controls.Add(this.lblMenuEleve);
            this.Controls.Add(this.dateVisite);
            this.Controls.Add(this.comtextbox);
            this.Controls.Add(this.labelcom);
            this.Controls.Add(this.labeldate);
            this.Controls.Add(this.labelclasse);
            this.Controls.Add(this.labelnom);
            this.Controls.Add(this.btnAddVisite);
            this.Controls.Add(this.lblTitrePage);
            this.Controls.Add(this.lblTitreApplication);
            this.Controls.Add(this.labelpouls);
            this.Controls.Add(this.shapeContainer1);
            this.MinimumSize = new System.Drawing.Size(950, 805);
            this.Name = "FrmModuleAddVisite";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmModuleAddVisite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioninfirmiere_prodtest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioninfirmiereprodtestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAjoutVisite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox comtextbox;
        private System.Windows.Forms.Label labelcom;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.Label labelclasse;
        private System.Windows.Forms.Label labelnom;
        private System.Windows.Forms.Button btnAddVisite;
        private System.Windows.Forms.Label lblTitrePage;
        private System.Windows.Forms.Label lblTitreApplication;
        private System.Windows.Forms.MonthCalendar dateVisite;
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
        private System.Windows.Forms.Label labelvisitehopital;
        private System.Windows.Forms.RadioButton VHradioOui;
        private System.Windows.Forms.Label labelparprev;
        private System.Windows.Forms.Label labelmotif;
        private System.Windows.Forms.TextBox motiftextBox;
        private System.Windows.Forms.Label labelHeureA;
        private System.Windows.Forms.Label labelHeureS;
        private System.Windows.Forms.Label labelretourdom;
        private System.Windows.Forms.RadioButton RDradioOui;
        private System.Windows.Forms.Label labelprescrire;
        private System.Windows.Forms.Label labelquantite;
        private System.Windows.Forms.ComboBox comboBoxPrescrire;
        private System.Windows.Forms.Label labelpouls;
        private System.Windows.Forms.TextBox poulstextbox;
        private System.Windows.Forms.ComboBox comboBoxQuantite;
        private System.Windows.Forms.BindingSource gestioninfirmiereprodtestBindingSource;
        private System.Windows.Forms.BindingSource eleveBindingSource;
        private gestioninfirmiere_prodtestTableAdapters.EleveTableAdapter eleveTableAdapter;
        private System.Windows.Forms.BindingSource medicamentBindingSource;
        private gestioninfirmiere_prodtestTableAdapters.MedicamentTableAdapter medicamentTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RRadioButton;
        private System.Windows.Forms.CheckBox PPCheckBox;
        private System.Windows.Forms.ComboBox comboBoxHeureSortie;
        private System.Windows.Forms.ComboBox comboBoxHeureArrivee;
        private System.Windows.Forms.ComboBox comboBoxMinuteSortie;
        private System.Windows.Forms.ComboBox comboBoxMinuteArrivee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProviderAjoutVisite;
    }
}