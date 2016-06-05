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
using System.Text.RegularExpressions;




namespace GestionInfirmerie
{
    public partial class FrmModuleEditVisite : Form
    {
        int idDuneVisite;
        public FrmModuleEditVisite(int idVisite)
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            Visite uneVisite = GestionVisites.InfoVisite(idVisite);
            Eleve unEleve = GestionInfirmerieBLL.GestionEleves.InfoEleve(uneVisite.unEleve_Visite.unId_eleve);
            Prescrire unePrescription = GestionPrescrires.InfoPrescrire(idVisite);
            Medicament unMedicament = GestionMedicaments.GetMedicaments(unePrescription.unMedicament_prescrire.IdMedicament);
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);
            idDuneVisite = idVisite;
            labelclasse.Text= "Classe : "+ unEleve.UneClasse.unLibelle_classe;
            labelnom.Text = "Nom : " + unEleve.unNom_eleve + " " + unEleve.unPrenom_eleve;
            
            

            dateVisite.SelectionStart = Convert.ToDateTime(uneVisite.uneDate_Visite);
            dateVisite.SelectionEnd = Convert.ToDateTime(uneVisite.uneDate_Visite);
            motiftextBox.Text = uneVisite.unMotif_Visite;
            poulstextbox.Text = uneVisite.unPouls_Visite;
            
            comboBoxHeureSortie.Text = "00";
            comboBoxMinuteSortie.Text = "00";
            comboBoxHeureArrivee.Text = "00";
            comboBoxMinuteArrivee.Text = "00";
            comboBoxQuantite.Text = "0";
            List<Medicament> lesMedicaments = GestionMedicaments.GetListeMedicaments();
            comboBoxPrescrire.DataSource = lesMedicaments;
            comboBoxPrescrire.DisplayMember = "LibelleMedicament";
            comboBoxPrescrire.ValueMember = "IdMedicament";
            comboBoxPrescrire.Text = unMedicament.LibelleMedicament;
            comboBoxQuantite.Text = unePrescription.uneQuantite_medicament.ToString();
            comtextbox.Text = uneVisite.unCommentaire_Visite;
            string[] heureMinuteSortie=uneVisite.uneHeure_Sortie.Split(':');
            string[] heureMinuteArrivee = uneVisite.uneHeure_Arrive.Split(':');
            comboBoxHeureSortie.Text = heureMinuteSortie[0];
            comboBoxMinuteSortie.Text = heureMinuteSortie[1];
            comboBoxHeureArrivee.Text = heureMinuteArrivee[0];
            comboBoxMinuteArrivee.Text = heureMinuteArrivee[1];

            if (uneVisite.uneVisite_Hopital==true)
            {
                VHradioOui.Checked = true;
            }
            else if (uneVisite.unRetour_Domicile==true)
            {
                RDradioOui.Checked = true;
            }
            else
            {
                RRadioButton.Checked = true;
            }

            if (uneVisite.lesParents_Prevenus==true)
            {
                PPCheckBox.Checked = true;
            }
        }


        private void FrmModuleEditVisite_Load(object sender, EventArgs e)
        {

        }

        private void btnEditVisite_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                System.DateTime dt;
                System.DateTime dateVisite = this.dateVisite.SelectionStart.Date;
                dt = dateVisite;
                string date = dt.ToString("yyyy-MM-dd");

                bool vHopital = false;
                bool parentsP = false;
                bool retourDom = false;

                if (VHradioOui.Checked == true)
                {
                    vHopital = true;
                    retourDom = false;
                }
                else if (RDradioOui.Checked == true)
                {
                    vHopital = false;
                    retourDom = true;
                }
                else if (RRadioButton.Checked == true)
                {
                    retourDom = false;
                    vHopital = false;
                }

                if (PPCheckBox.Checked == true)
                {
                    parentsP = true;
                }

                Medicament unMedicament;
                unMedicament = new Medicament(Int32.Parse(comboBoxPrescrire.SelectedValue.ToString()));

                string heureSortie = comboBoxHeureSortie.Text + ":" + comboBoxMinuteSortie.Text;
                string heureArrivé = comboBoxHeureArrivee.Text + ":" + comboBoxMinuteArrivee.Text;
                GestionVisites.EditVisite(idDuneVisite, motiftextBox.Text, comtextbox.Text, heureArrivé, heureSortie, date, parentsP, vHopital, retourDom, poulstextbox.Text);
                Visite uneVisite = GestionVisites.InfoDerniereVisite();
                GestionPrescrires.ModifPrescription(uneVisite, Int32.Parse(comboBoxQuantite.Text), unMedicament);
                FrmModuleListeVisites frm = new FrmModuleListeVisites();
                frm.Show();
                this.Hide();
                MessageBox.Show("Votre visite a bien été modifiée !");
            }
        }


        #region Menu
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


        #region Controles de saisie
        private void motiftextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(motiftextBox.Text))
            {
                e.Cancel = true;
                motiftextBox.Focus();
                errorProviderAjoutVisite.SetError(motiftextBox, "Le motif doit être renseigné");
            }
            else
            {
                e.Cancel = false;
                errorProviderAjoutVisite.SetError(motiftextBox, "");
            }
        }
        private void poulstextbox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(poulstextbox.Text))
            {
                e.Cancel = true;
                poulstextbox.Focus();
                errorProviderAjoutVisite.SetError(poulstextbox, "Le pouls doit être renseigné");
            }
            else if(poulsRegex(poulstextbox.Text)==false)
            {
                e.Cancel = true;
                errorProviderAjoutVisite.SetError(poulstextbox, "Le format doit être de type 12/34");
            }
            else
            {
                e.Cancel = false;
                errorProviderAjoutVisite.SetError(poulstextbox, "");
            }
            
        }
        private void comboBoxQuantite_Validating(object sender, CancelEventArgs e)
        {

            if (regexQuantite(comboBoxQuantite.Text) == false)
            {
                e.Cancel = true;
                comboBoxQuantite.Focus();
                errorProviderAjoutVisite.SetError(comboBoxQuantite, "La quantité doit être comprise entre 0 et 5");
            }
            else if (string.IsNullOrEmpty(comboBoxQuantite.Text))
            {
                e.Cancel = true;
                comboBoxQuantite.Focus();
                errorProviderAjoutVisite.SetError(comboBoxQuantite, "La quantité doit être renseigné");
            }
            else
            {
                e.Cancel = false;
                errorProviderAjoutVisite.SetError(comboBoxQuantite, "");
            }
        }        
        private bool poulsRegex(string poulstextbox)
        {
            Regex regex = new Regex(@"^[0-9]{2}[\/][0-9]{2}$");
            Match match = regex.Match(poulstextbox);
            if(match.Success)
            {
                return true;
            }
            return false;
        }
        private void comboBoxHeureArrivee_Validating(object sender, CancelEventArgs e)
        {

            if (regexHeure(comboBoxHeureArrivee.Text) == false)
            {
                e.Cancel = true;
                comboBoxHeureArrivee.Focus();
                errorProviderAjoutVisite.SetError(comboBoxHeureArrivee, "Les heures doivent être comprises entre 0 et 24");
            }

            else
            {
                e.Cancel = false;
                errorProviderAjoutVisite.SetError(comboBoxHeureArrivee, "");
            }
        }
        private void comboBoxMinuteArrivee_Validating(object sender, CancelEventArgs e)
        {
            if (regexMinute(comboBoxMinuteArrivee.Text) == false)
            {
                e.Cancel = true;
                comboBoxMinuteArrivee.Focus();
                errorProviderAjoutVisite.SetError(comboBoxMinuteArrivee, "Les minutes doivent être comprises entre 0 et 59");
            }

            else
            {
                e.Cancel = false;
                errorProviderAjoutVisite.SetError(comboBoxMinuteArrivee, "");
            }
        }
        private void comboBoxHeureSortie_Validating(object sender, CancelEventArgs e)
        {
            if (regexHeure(comboBoxHeureSortie.Text) == false)
            {
                e.Cancel = true;
                comboBoxHeureSortie.Focus();
                errorProviderAjoutVisite.SetError(comboBoxHeureSortie, "Les heures doivent être comprises entre 0 et 24");
            }
            else
            {
                e.Cancel = false;
                errorProviderAjoutVisite.SetError(comboBoxHeureSortie, "");
            }

        }
        private void comboBoxMinuteSortie_Validating(object sender, CancelEventArgs e)
        {
            if (regexMinute(comboBoxMinuteSortie.Text) == false)
            {
                e.Cancel = true;
                comboBoxMinuteSortie.Focus();
                errorProviderAjoutVisite.SetError(comboBoxMinuteSortie, "Les minutes doivent être comprises entre 0 et 59");
            }

            else
            {
                e.Cancel = false;
                errorProviderAjoutVisite.SetError(comboBoxMinuteSortie, "");
            }
        }
        private bool regexQuantite(string chaine)
        {
            Regex regex = new Regex(@"^[0-5]{1}$");
            Match match = regex.Match(chaine);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
        private bool regexHeure(string chaine)
        {
            Regex regex = new Regex(@"^[0-1][0-9]$|^2[0-3]$");
            Match match = regex.Match(chaine);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
        private bool regexMinute(string chaine)
        {
            Regex regex = new Regex(@"^[0-5][0-9]$");
            Match match = regex.Match(chaine);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
        #endregion

    }
}
