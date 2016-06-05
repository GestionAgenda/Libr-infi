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
    public partial class FrmModuleMedicModif : Form
    {
        
        public FrmModuleMedicModif()
        {
            
            InitializeComponent();
            List<Medicament> lesMedicaments = GestionMedicaments.GetListeMedicaments();
            cBoxListeMedic.DataSource = lesMedicaments;
            cBoxListeMedic.DisplayMember = "LibelleMedicament";
            cBoxListeMedic.ValueMember = "IdMedicament";
            
            
        }
        private void FrmModuleMedicModif_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Medicament unMedicament;
                unMedicament = new Medicament(Int32.Parse(cBoxListeMedic.SelectedValue.ToString()), txtBoxModifMedic.Text);
                GestionMedicaments.ModifierMedicament(unMedicament);
                FrmModuleListeEleve frm = new FrmModuleListeEleve();
                frm.Show();
                this.Hide();
                MessageBox.Show("Votre médicament a bien été modifié !");
            }
        }

        private void cBoxListeMedic_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (GestionMedicaments.GetMedicaments(0).IdMedicament == 0)
                txtBoxModifMedic.Text = GestionMedicaments.GetMedicaments(1).LibelleMedicament;
            else
            {
                int idMed;
                int.TryParse(cBoxListeMedic.SelectedValue.ToString(), out idMed);
                txtBoxModifMedic.Text = GestionMedicaments.GetMedicaments(idMed).LibelleMedicament;
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

        private void FrmModuleMedicModif_Load_1(object sender, EventArgs e)
        {

        }

        #region Contrôles de saisies
        private void txtBoxModifMedic_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxModifMedic.Text))
            {
                e.Cancel = true;
                txtBoxModifMedic.Focus();
                errorProviderModifMedicament.SetError(txtBoxModifMedic, "Le nom du médicament doit être renseigné");
            }
            else
            {
                e.Cancel = false;
                errorProviderModifMedicament.SetError(txtBoxModifMedic, "");
            }
        } 
        #endregion
    }
}
