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
    public partial class FrmModuleSupprimerMedicament : Form
    {
        public FrmModuleSupprimerMedicament()
        {
            InitializeComponent();
        }

        private void FrmModuleSupprimerMedicament_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioninfirmiere_prodtest.Medicament'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.medicamentTableAdapter.Fill(this.gestioninfirmiere_prodtest.Medicament);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // a retenir pour changer les labels correspondant à l'objet séléctionné dans le combobox
            // lblMedicament.Text = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lblMedicament = comboBox1.Text;
            if (GestionMedicaments.MedicamentSupprimable(lblMedicament) == true)
            {
                GestionMedicaments.SupprimerMedicament(lblMedicament);
                FrmModuleListeEleve frm = new FrmModuleListeEleve();
                frm.Show();
                this.Hide();
                MessageBox.Show("Votre médicament a bien été supprimé !");
            }
            else
            {
                MessageBox.Show("Votre médicament n'est pas supprimable puisqu'il est relié à une visite, archivez-le !");
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


    }
}
