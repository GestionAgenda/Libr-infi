﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionInfirmerie
{
    public partial class FrmModuleGestionEleve : Form
    {
        public FrmModuleGestionEleve()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            FrmModuleAjoutEleve frm = new FrmModuleAjoutEleve();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmModuleListeModifierEleve frm = new FrmModuleListeModifierEleve();
            frm.Show();
            this.Hide();
        }

        private void FrmModuleGestionEleve_Load(object sender, EventArgs e)
        {

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
