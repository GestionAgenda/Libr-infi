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
    public partial class FrmModuleDesarchivageMedicament : Form
    {
        public FrmModuleDesarchivageMedicament()
        {
            InitializeComponent();
            List<Medicament> lesMedicaments = GestionMedicaments.GetListeMedicamentDesarchive();
            cBoxListeMedic.DataSource = lesMedicaments;
            cBoxListeMedic.DisplayMember = "LibelleMedicament";
            cBoxListeMedic.ValueMember = "IdMedicament";
        }

        private void FrmModuleSupprimerMedicament_Load(object sender, EventArgs e)
        {
          
        }

        private void btnArchiver_Click(object sender, EventArgs e)
        {
            GestionMedicaments.DesarchivMedicament(Int32.Parse(cBoxListeMedic.SelectedValue.ToString()));
            FrmModuleListeEleve frm = new FrmModuleListeEleve();
            frm.Show();
            this.Hide();
            MessageBox.Show("Votre médicament a bien été desarchivé !");
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
