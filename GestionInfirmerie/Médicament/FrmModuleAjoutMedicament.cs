using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionInfirmerieBLL;
using GestionInfirmerieBO;
using System.Configuration;

namespace GestionInfirmerie
{
    public partial class FrmModuleAjoutMedicament : Form
    {
        public FrmModuleAjoutMedicament()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);
        }

        private void btnAjoutMedic_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                GestionMedicaments.AjouterMedicament(txtBoxAjoutMedic.Text, false);
                FrmModuleListeEleve frm = new FrmModuleListeEleve();
                frm.Show();
                this.Hide();
                MessageBox.Show("Votre médicament a bien été ajouté !");
            }
        }

        private void lblMenuEleve_Click(object sender, EventArgs e)
        {
            FrmModuleListeEleve frm = new FrmModuleListeEleve();
            frm.Show();
            this.Hide();
        }

        private void lblMenuVisites_Click(object sender, EventArgs e)
        {
            FrmModuleListeVisites frm = new FrmModuleListeVisites();
            frm.Show();
            this.Hide();
        }

        private void lblMenuGestion_Click(object sender, EventArgs e)
        {
            FrmModuleGestion frm = new FrmModuleGestion();
            frm.Show();
            this.Hide();
        }

        private void lblMenuSynthese_Click(object sender, EventArgs e)
        {
            FrmModuleSynthese frm = new FrmModuleSynthese();
            frm.Show();
            this.Hide();
        }

        private void lblMenuMaintenance_Click(object sender, EventArgs e)
        {
            FrmModuleMaintenance frm = new FrmModuleMaintenance();
            frm.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblTitrePage_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxAjoutMedic_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAjoutMedic_Click(object sender, EventArgs e)
        {

        }

        private void FrmModuleAjoutMedicament_Load(object sender, EventArgs e)
        {

        }

        private void lineShape7_Click(object sender, EventArgs e)
        {

        }

        private void lineShape6_Click(object sender, EventArgs e)
        {

        }

        private void lineShape4_Click(object sender, EventArgs e)
        {

        }

        private void lineShape3_Click(object sender, EventArgs e)
        {

        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void lineShape2_Click(object sender, EventArgs e)
        {

        }
        #region Contrôles de saisies
        private void txtBoxAjoutMedic_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxAjoutMedic.Text))
            {
                e.Cancel = true;
                txtBoxAjoutMedic.Focus();
                errorProviderAjoutMedicament.SetError(txtBoxAjoutMedic, "Le nom du médicament doit être renseigné");
            }
            else
            {
                e.Cancel = false;
                errorProviderAjoutMedicament.SetError(txtBoxAjoutMedic, "");
            }
        } 
        #endregion
    }
}
