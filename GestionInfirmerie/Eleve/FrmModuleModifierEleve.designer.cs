
namespace GestionInfirmerie
{
    partial class FrmModuleModifierEleve
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
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.txtBoxPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioBoxTTOuiMod = new System.Windows.Forms.RadioButton();
            this.radioBoxTTNonMod = new System.Windows.Forms.RadioButton();
            this.comboBoxClasse = new System.Windows.Forms.ComboBox();
            this.classeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestioninfirmiere_prodtest = new GestionInfirmerie.gestioninfirmiere_prodtest();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBoxSante = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.telEleve = new System.Windows.Forms.TextBox();
            this.telMere = new System.Windows.Forms.TextBox();
            this.telPere = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonModifMod = new System.Windows.Forms.Button();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.monthCalendarDateNaiMod = new System.Windows.Forms.MonthCalendar();
            this.classeTableAdapter = new GestionInfirmerie.gestioninfirmiere_prodtestTableAdapters.ClasseTableAdapter();
            this.lblIdEleve = new System.Windows.Forms.Label();
            this.errorProviderModifEleve = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioninfirmiere_prodtest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModifEleve)).BeginInit();
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
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(76, 171);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(316, 20);
            this.txtBoxNom.TabIndex = 16;
            this.txtBoxNom.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxNom_Validating);
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.Location = new System.Drawing.Point(561, 171);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(361, 20);
            this.txtBoxPrenom.TabIndex = 17;
            this.txtBoxPrenom.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxPrenom_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(475, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(17, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tiers temps :";
            // 
            // radioBoxTTOuiMod
            // 
            this.radioBoxTTOuiMod.AutoSize = true;
            this.radioBoxTTOuiMod.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBoxTTOuiMod.Location = new System.Drawing.Point(108, 212);
            this.radioBoxTTOuiMod.Name = "radioBoxTTOuiMod";
            this.radioBoxTTOuiMod.Size = new System.Drawing.Size(48, 20);
            this.radioBoxTTOuiMod.TabIndex = 21;
            this.radioBoxTTOuiMod.TabStop = true;
            this.radioBoxTTOuiMod.Text = "Oui";
            this.radioBoxTTOuiMod.UseVisualStyleBackColor = true;
            // 
            // radioBoxTTNonMod
            // 
            this.radioBoxTTNonMod.AutoSize = true;
            this.radioBoxTTNonMod.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBoxTTNonMod.Location = new System.Drawing.Point(162, 212);
            this.radioBoxTTNonMod.Name = "radioBoxTTNonMod";
            this.radioBoxTTNonMod.Size = new System.Drawing.Size(52, 20);
            this.radioBoxTTNonMod.TabIndex = 22;
            this.radioBoxTTNonMod.TabStop = true;
            this.radioBoxTTNonMod.Text = "Non";
            this.radioBoxTTNonMod.UseVisualStyleBackColor = true;
            // 
            // comboBoxClasse
            // 
            this.comboBoxClasse.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.classeBindingSource, "Id_classe", true));
            this.comboBoxClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClasse.FormattingEnabled = true;
            this.comboBoxClasse.Location = new System.Drawing.Point(561, 214);
            this.comboBoxClasse.Name = "comboBoxClasse";
            this.comboBoxClasse.Size = new System.Drawing.Size(361, 21);
            this.comboBoxClasse.TabIndex = 23;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Classe :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Date de naissance :";
            // 
            // richTextBoxSante
            // 
            this.richTextBoxSante.Location = new System.Drawing.Point(561, 257);
            this.richTextBoxSante.Name = "richTextBoxSante";
            this.richTextBoxSante.Size = new System.Drawing.Size(361, 140);
            this.richTextBoxSante.TabIndex = 27;
            this.richTextBoxSante.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(475, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Santé :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Tel élève :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 448);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Tel maman :";
            // 
            // telEleve
            // 
            this.telEleve.Location = new System.Drawing.Point(145, 409);
            this.telEleve.Name = "telEleve";
            this.telEleve.Size = new System.Drawing.Size(245, 20);
            this.telEleve.TabIndex = 31;
            this.telEleve.Validating += new System.ComponentModel.CancelEventHandler(this.telEleve_Validating);
            // 
            // telMere
            // 
            this.telMere.Location = new System.Drawing.Point(145, 448);
            this.telMere.Name = "telMere";
            this.telMere.Size = new System.Drawing.Size(245, 20);
            this.telMere.TabIndex = 32;
            this.telMere.Validating += new System.ComponentModel.CancelEventHandler(this.telMere_Validating);
            // 
            // telPere
            // 
            this.telPere.Location = new System.Drawing.Point(561, 409);
            this.telPere.Name = "telPere";
            this.telPere.Size = new System.Drawing.Size(244, 20);
            this.telPere.TabIndex = 33;
            this.telPere.Validating += new System.ComponentModel.CancelEventHandler(this.telPere_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(475, 409);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Tel papa :";
            // 
            // buttonModifMod
            // 
            this.buttonModifMod.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifMod.Location = new System.Drawing.Point(247, 502);
            this.buttonModifMod.Name = "buttonModifMod";
            this.buttonModifMod.Size = new System.Drawing.Size(466, 23);
            this.buttonModifMod.TabIndex = 35;
            this.buttonModifMod.Text = "Modifier l\'élève";
            this.buttonModifMod.UseVisualStyleBackColor = true;
            this.buttonModifMod.Click += new System.EventHandler(this.buttonModifMod_Click);
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
            this.shapeContainer1.Size = new System.Drawing.Size(934, 535);
            this.shapeContainer1.TabIndex = 36;
            this.shapeContainer1.TabStop = false;
            // 
            // monthCalendarDateNaiMod
            // 
            this.monthCalendarDateNaiMod.Location = new System.Drawing.Point(157, 235);
            this.monthCalendarDateNaiMod.Name = "monthCalendarDateNaiMod";
            this.monthCalendarDateNaiMod.TabIndex = 37;
            // 
            // classeTableAdapter
            // 
            this.classeTableAdapter.ClearBeforeFill = true;
            // 
            // lblIdEleve
            // 
            this.lblIdEleve.AutoSize = true;
            this.lblIdEleve.Location = new System.Drawing.Point(439, 212);
            this.lblIdEleve.Name = "lblIdEleve";
            this.lblIdEleve.Size = new System.Drawing.Size(0, 13);
            this.lblIdEleve.TabIndex = 38;
            this.lblIdEleve.Visible = false;
            // 
            // errorProviderModifEleve
            // 
            this.errorProviderModifEleve.ContainerControl = this;
            // 
            // FrmModuleModifierEleve
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 535);
            this.Controls.Add(this.lblIdEleve);
            this.Controls.Add(this.monthCalendarDateNaiMod);
            this.Controls.Add(this.buttonModifMod);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.telPere);
            this.Controls.Add(this.telMere);
            this.Controls.Add(this.telEleve);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBoxSante);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxClasse);
            this.Controls.Add(this.radioBoxTTNonMod);
            this.Controls.Add(this.radioBoxTTOuiMod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxPrenom);
            this.Controls.Add(this.txtBoxNom);
            this.Controls.Add(this.lblMenuMaintenance);
            this.Controls.Add(this.lblMenuSynthese);
            this.Controls.Add(this.lblMenuGestion);
            this.Controls.Add(this.lblMenuVisites);
            this.Controls.Add(this.lblMenuEleve);
            this.Controls.Add(this.lblTitrePage);
            this.Controls.Add(this.lblTitreApplication);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "FrmModuleModifierEleve";
            this.Text = "FrmModuleModifierEleve";
            this.Load += new System.EventHandler(this.FrmModuleModifierEleve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioninfirmiere_prodtest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModifEleve)).EndInit();
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
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.TextBox txtBoxPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioBoxTTOuiMod;
        private System.Windows.Forms.RadioButton radioBoxTTNonMod;
        private System.Windows.Forms.ComboBox comboBoxClasse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBoxSante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox telEleve;
        private System.Windows.Forms.TextBox telMere;
        private System.Windows.Forms.TextBox telPere;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonModifMod;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.MonthCalendar monthCalendarDateNaiMod;
        private gestioninfirmiere_prodtest gestioninfirmiere_prodtest;
        private System.Windows.Forms.BindingSource classeBindingSource;
        private gestioninfirmiere_prodtestTableAdapters.ClasseTableAdapter classeTableAdapter;
        private System.Windows.Forms.Label lblIdEleve;
        private System.Windows.Forms.ErrorProvider errorProviderModifEleve;
    }
}