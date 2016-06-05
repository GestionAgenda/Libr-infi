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
    public partial class FrmModuleListeVisites : Form
    {
        public FrmModuleListeVisites()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionEleves.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);

                //// Effacement de toutes les lignes
                dataGridViewListEleve.Rows.Clear();

                //// On définit le nombre de lignes nécessaires en comptant le nombre d'éléments dans la liste
                dataGridViewListEleve.Rows.Add(GestionVisites.ToutesLesVisites().Count);

                //// remplissage des lignes du datagridview
                for (int i = 0; i < GestionVisites.ToutesLesVisites().Count; i++)
                {
                    dataGridViewListEleve[0, i].Value = GestionVisites.ToutesLesVisites()[i].unEleve_Visite.unNom_eleve;
                    dataGridViewListEleve[1, i].Value = GestionVisites.ToutesLesVisites()[i].unEleve_Visite.unPrenom_eleve;
                    dataGridViewListEleve[2, i].Value = GestionVisites.ToutesLesVisites()[i].unEleve_Visite.UneClasse.unLibelle_classe;
                    dataGridViewListEleve[3, i].Value = GestionVisites.ToutesLesVisites()[i].uneDate_Visite;
                    dataGridViewListEleve[5, i].Value = GestionVisites.ToutesLesVisites()[i].unId_Visite;
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
        private void clmnBoutonDetails_Click(object sender, EventArgs e)
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
            dataGridViewListEleve.Rows.Clear();
            if (GestionEleves.GetToutElevesSaisie(txtBoxNomSaisieEleve.Text).Count > 0)
            {
                //// On définit le nombre de lignes nécessaires en comptant le nombre d'éléments dans la liste
                dataGridViewListEleve.Rows.Add(GestionEleves.GetToutElevesSaisie(txtBoxNomSaisieEleve.Text).Count);

                //// remplissage des lignes du datagridview
                for (int i = 0; i < GestionEleves.GetToutElevesSaisie(txtBoxNomSaisieEleve.Text).Count; i++)
                {
                    dataGridViewListEleve[0, i].Value = GestionEleves.GetToutElevesSaisie(txtBoxNomSaisieEleve.Text)[i].unNom_eleve;
                    dataGridViewListEleve[1, i].Value = GestionEleves.GetToutElevesSaisie(txtBoxNomSaisieEleve.Text)[i].unPrenom_eleve;
                    dataGridViewListEleve[2, i].Value = GestionEleves.GetListeElevesSaisie(txtBoxNomSaisieEleve.Text)[i].UneClasse.unLibelle_classe;
                    dataGridViewListEleve[5, i].Value = GestionEleves.GetToutElevesSaisie(txtBoxNomSaisieEleve.Text)[i].unId_eleve;
                }
                
            }
           
        }

        private void dataGridViewListEleve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si l'utilisateur clique sur une des 5 premières colonnes, on ouvre le formulaire
            if (e.ColumnIndex == 3 || e.ColumnIndex == 2 || e.ColumnIndex == 1 || e.ColumnIndex == 0 || e.ColumnIndex == 4)
            {
                FrmModuleDetailsVisite frm = new FrmModuleDetailsVisite(Int32.Parse(dataGridViewListEleve[5, e.RowIndex].Value.ToString()));
                frm.Show();
                this.Hide();
            }
        }


    }
}
