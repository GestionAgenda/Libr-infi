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
    public partial class FrmModuleModifierEleve : Form
    {
        public FrmModuleModifierEleve(int idEleve, string mode)
        {
                if (mode == "CREATE")
                {
                    // Code spécifique modification
                }
                else
                {
                    // Code spécifique modification
                }
        }

        public FrmModuleModifierEleve(int idEleve)
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);
            Eleve unEleve = GestionInfirmerieBLL.GestionEleves.InfoEleve(idEleve);
            txtBoxNom.Text = unEleve.unNom_eleve;
            lblIdEleve.Text = idEleve.ToString();
            txtBoxPrenom.Text = unEleve.unPrenom_eleve;
            comboBoxClasse.Text = unEleve.UneClasse.unLibelle_classe;
            richTextBoxSante.Text = unEleve.uneSante_eleve;
            telEleve.Text = unEleve.unTel_eleve;
            telMere.Text = unEleve.unTel_Mere_eleve;
            telPere.Text = unEleve.unTel_Pere_eleve;
            monthCalendarDateNaiMod.SelectionStart= Convert.ToDateTime(unEleve.uneDateNaissance_eleve);
            monthCalendarDateNaiMod.SelectionEnd = Convert.ToDateTime(unEleve.uneDateNaissance_eleve);
            //condition Tiers Temps
            if (unEleve.unTiers_Temps==true)
            {
                radioBoxTTOuiMod.Checked = true;
            }
            
            else
            {
                radioBoxTTNonMod.Checked=true;
            }
                

        }

        private void FrmModuleModifierEleve_Load(object sender, EventArgs e)
        {
           List<Classe> lesClasses=GestionClasses.ListeDesClasses();
           comboBoxClasse.DataSource = lesClasses;
           comboBoxClasse.DisplayMember = "unLibelle_classe";
           comboBoxClasse.ValueMember = "unId_classe";
           comboBoxClasse.SelectedValue = GestionClasses.IdClasseEleve(Int32.Parse(lblIdEleve.Text));
        }

        private void buttonModifMod_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                System.DateTime dt;
                System.DateTime dateNaissance = this.monthCalendarDateNaiMod.SelectionStart.Date;
                dt = dateNaissance;
                string date = dt.ToString("yyyy-MM-dd");
                bool tieTem = false;
                if (radioBoxTTOuiMod.Checked == true)
                {
                    tieTem = true;
                }
                else if (radioBoxTTNonMod.Checked == true)
                {
                    tieTem = false;
                }

                int idClasse = Convert.ToInt32(comboBoxClasse.SelectedValue);
                Classe uneClasse;
                uneClasse = new Classe(idClasse);
                Eleve unEleve = new Eleve(Int32.Parse(lblIdEleve.Text), txtBoxNom.Text, txtBoxPrenom.Text, date, richTextBoxSante.Text, telEleve.Text, telPere.Text, telMere.Text, false, tieTem, uneClasse);
                GestionEleves.ModifieEleve(unEleve);
            
                FrmModuleListeEleve frm = new FrmModuleListeEleve();
                frm.Show();
                this.Hide();
                MessageBox.Show("Votre élève a bien été modifié !");
            }
        }

        #region Controles de saisie
        private void txtBoxNom_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxNom.Text))
            {
                e.Cancel = true;
                txtBoxNom.Focus();
                errorProviderModifEleve.SetError(txtBoxNom, "Le texte doit être rempli");
            }
            else
            {
                e.Cancel = false;
                errorProviderModifEleve.SetError(txtBoxNom, "");
            }
        }

        private void txtBoxPrenom_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxPrenom.Text))
            {
                e.Cancel = true;
                txtBoxPrenom.Focus();
                errorProviderModifEleve.SetError(txtBoxPrenom, "Le texte doit être rempli");
            }
            else
            {
                e.Cancel = false;
                errorProviderModifEleve.SetError(txtBoxPrenom, "");
            }
        }

        private void telMere_Validating(object sender, CancelEventArgs e)
        {
            if (telRegex(telMere.Text))
            {
                e.Cancel = false;
                errorProviderModifEleve.SetError(telMere, "");

            }
            else
            {
                e.Cancel = true;
                telMere.Focus();
                errorProviderModifEleve.SetError(telMere, "Le numéro doit etre de forme 0611223344");
            }
        }

        private void telPere_Validating(object sender, CancelEventArgs e)
        {
            if (telRegex(telPere.Text))
            {
                e.Cancel = false;
                errorProviderModifEleve.SetError(telPere, "");
            }
            else
            {

                e.Cancel = true;
                telPere.Focus();
                errorProviderModifEleve.SetError(telPere, "Le numéro doit etre de forme 0611223344");
            }
        }

        private void telEleve_Validating(object sender, CancelEventArgs e)
        {
            if (telRegex(telEleve.Text))
            {
                e.Cancel = false;
                errorProviderModifEleve.SetError(telEleve, "");
            }
            else
            {

                e.Cancel = true;
                telEleve.Focus();
                errorProviderModifEleve.SetError(telEleve, "Le numéro doit etre de forme 0611223344");

            }
        }

        private bool telRegex(string numTel)
        {

            Regex regex = new Regex(@"^0[1-9]{1}[0-9]{8}$");
            Match match = regex.Match(numTel);
            if (match.Success)
            {
                return true;
            }
            return false;
        }  
        #endregion

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
       
    }
}
