using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionInfirmerie
{
    public partial class FrmModuleGestionMedicament : Form
    {
        public FrmModuleGestionMedicament()
        {
            InitializeComponent();
        }

        private void btnMedicament_Click(object sender, EventArgs e)
        {
            FrmModuleMedicModif frm = new FrmModuleMedicModif();
            frm.Show();
            this.Hide();
        }

        private void btnEleve_Click(object sender, EventArgs e)
        {
            
            FrmModuleAjoutMedicament frm = new FrmModuleAjoutMedicament();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmModuleSupprimerMedicament frm = new FrmModuleSupprimerMedicament();
            frm.Show();
            this.Hide();

        }

        private void lblMenuEleve_Click_1(object sender, EventArgs e)
        {
            FrmModuleListeEleve frm = new FrmModuleListeEleve();
            frm.Show();
            this.Hide();
        }

        private void lblMenuVisites_Click_1(object sender, EventArgs e)
        {
            FrmModuleListeVisites frm = new FrmModuleListeVisites();
            frm.Show();
            this.Hide();
        }

        private void lblMenuGestion_Click_1(object sender, EventArgs e)
        {
            FrmModuleGestion frm = new FrmModuleGestion();
            frm.Show();
            this.Hide();
        }

        private void lblMenuSynthese_Click_1(object sender, EventArgs e)
        {
            FrmModuleSynthese frm = new FrmModuleSynthese();
            frm.Show();
            this.Hide();
        }

        private void lblMenuMaintenance_Click_1(object sender, EventArgs e)
        {
            FrmModuleMaintenance frm = new FrmModuleMaintenance();
            frm.Show();
            this.Hide();
        }
    }
}
