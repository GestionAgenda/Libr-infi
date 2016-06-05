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
    public partial class FrmModuleGestion : Form
    {
        public FrmModuleGestion()
        {
            InitializeComponent();
        }

        private void btnEleve_Click(object sender, EventArgs e)
        {
            FrmModuleGestionEleve frm = new FrmModuleGestionEleve();
            frm.Show();
            this.Hide();
        }

        private void btnMedicament_Click(object sender, EventArgs e)
        {
            FrmModuleGestionMedicament frm = new FrmModuleGestionMedicament();
            frm.Show();
            this.Hide();

        }
        
        private void btnVisite_Click(object sender, EventArgs e)
        {
            FrmModuleAddVisite frm = new FrmModuleAddVisite(1);
            frm.Show();
            this.Hide();
        }
        private void FrmModuleGestion_Load(object sender, EventArgs e)
        {

        }

        //lien vers les autres pages de l'appli
        #region Menus
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

        #endregion
       


             


    }
}
