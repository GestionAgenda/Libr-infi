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
    public partial class FrmModuleListeModifierEleve : Form
    {
        public FrmModuleListeModifierEleve()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionEleves.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);

            //// Effacement de toutes les lignes
            dataGridViewListEleve2.Rows.Clear();

            //// On définit le nombre de lignes nécessaires en comptant le nombre d'éléments dans la liste
            dataGridViewListEleve2.Rows.Add(GestionEleves.GetToutEleves().Count);

            //// remplissage des lignes du datagridview
            for (int i = 0; i < GestionEleves.GetToutEleves().Count; i++)
            {
                dataGridViewListEleve2[0, i].Value = GestionEleves.GetToutEleves()[i].unNom_eleve;
                dataGridViewListEleve2[1, i].Value = GestionEleves.GetToutEleves()[i].unPrenom_eleve;
                dataGridViewListEleve2[2, i].Value = GestionEleves.GetListeEleves()[i].UneClasse.unLibelle_classe;
                dataGridViewListEleve2[4, i].Value = GestionEleves.GetToutEleves()[i].unId_eleve;
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

        private void txtBoxNomSaisieEleve_TextChanged(object sender, EventArgs e)
        {
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionEleves.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);

            //// Effacement de toutes les lignes
            dataGridViewListEleve2.Rows.Clear();
            if (GestionEleves.GetToutElevesSaisie(txtBoxNomSaisieEleve.Text).Count > 0)
            {
                //// On définit le nombre de lignes nécessaires en comptant le nombre d'éléments dans la liste
                dataGridViewListEleve2.Rows.Add(GestionEleves.GetToutElevesSaisie(txtBoxNomSaisieEleve.Text).Count);

                //// remplissage des lignes du datagridview
                for (int i = 0; i < GestionEleves.GetToutElevesSaisie(txtBoxNomSaisieEleve.Text).Count; i++)
                {
                    dataGridViewListEleve2[0, i].Value = GestionEleves.GetToutElevesSaisie(txtBoxNomSaisieEleve.Text)[i].unNom_eleve;
                    dataGridViewListEleve2[1, i].Value = GestionEleves.GetToutElevesSaisie(txtBoxNomSaisieEleve.Text)[i].unPrenom_eleve;
                    dataGridViewListEleve2[2, i].Value = GestionEleves.GetListeElevesSaisie(txtBoxNomSaisieEleve.Text)[i].UneClasse.unLibelle_classe;
                    dataGridViewListEleve2[4, i].Value = GestionEleves.GetToutElevesSaisie(txtBoxNomSaisieEleve.Text)[i].unId_eleve;
                }

            }
        }

        private void dataGridViewListEleve2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.ColumnIndex == 2 || e.ColumnIndex == 1 || e.ColumnIndex == 0)
            {
                FrmModuleModifierEleve frm = new FrmModuleModifierEleve(Int32.Parse(dataGridViewListEleve2[4, e.RowIndex].Value.ToString()));
                frm.Show();
                this.Hide();
            }
        }
    }
}
