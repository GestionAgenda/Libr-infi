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
    public partial class FrmModuleDetailsVisite : Form
    {
        int idDuneVisite;
        public FrmModuleDetailsVisite(int idVisite)
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            string resultHopital;
            string resultDom;
            string resultParentsPrev;
            idDuneVisite = idVisite;
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);
            Visite uneVisite = GestionVisites.InfoVisite(idDuneVisite);
            labelclasse.Text = "Classe : " + uneVisite.unEleve_Visite.UneClasse.unLibelle_classe;
            labelnom.Text = "Nom : " + uneVisite.unEleve_Visite.unNom_eleve + " " + uneVisite.unEleve_Visite.unPrenom_eleve;
            labeldate.Text = "Date : " + uneVisite.uneDate_Visite;
            labelmotif.Text = "Motif : " + uneVisite.unMotif_Visite;
            labelpouls.Text = "Pouls : " + uneVisite.unPouls_Visite;
            labelHeureA.Text = "Heure arrivée : " + uneVisite.uneHeure_Arrive;
            labelHeureS.Text = "Heure sortie : " + uneVisite.uneHeure_Sortie;
            labelcom.Text = "Commentaire : " + uneVisite.unCommentaire_Visite;
            Prescrire unePrescrip = GestionPrescrires.InfoPrescrire(idDuneVisite);

            //Vérifie si une prescription a été faite 
            if (GestionPrescrires.InfoPrescrire(idDuneVisite)==null)
            {
                labelprescrire.Text = "Prescription : Aucun médicament";
                labelquantite.Text = "";
            }
            else
            {
                Medicament unMedicament = GestionMedicaments.GetMedicaments(unePrescrip.unMedicament_prescrire.IdMedicament);
                labelprescrire.Text = "Prescription : " + unMedicament.LibelleMedicament;
                labelquantite.Text = "Quantité : " + unePrescrip.uneQuantite_medicament;
            }
            
            if (uneVisite.uneVisite_Hopital == true)
            {
                resultHopital = "Oui";
            }
            else
            {
                resultHopital = "Non";
            }

            labelvisitehopital.Text = "Visite hopital : " + resultHopital;

            if (uneVisite.lesParents_Prevenus == true)
            {
                resultParentsPrev = "Oui";
            }
            else
            {
                resultParentsPrev = "Non";
            }

            labelparprev.Text = "Parents prévenus : " + resultParentsPrev;


            if (uneVisite.unRetour_Domicile == true)
            {
                resultDom = "Oui";
            }
            else
            {
                resultDom = "Non";
            }

            labelretourdom.Text = "Retour domicile : " + resultDom;
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

        private void FrmModuleDetailsVisite_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioninfirmiere_prodtest.Medicament'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.medicamentTableAdapter.Fill(this.gestioninfirmiere_prodtest.Medicament);

        }

        private void btnModifVisite_Click(object sender, EventArgs e)
        {
            FrmModuleEditVisite frm = new FrmModuleEditVisite(idDuneVisite);
            frm.Show();
            this.Hide();
        }

        
    }
}
