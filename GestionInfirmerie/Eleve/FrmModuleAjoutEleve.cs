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
    public partial class FrmModuleAjoutEleve : Form
    {
        public FrmModuleAjoutEleve()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);
        }

        private void FrmModuleAjoutEleve_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestioninfirmiere_prodtest.Classe'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.classeTableAdapter.Fill(this.gestioninfirmiere_prodtest.Classe);

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

        #region Controle De Saisie
        private void txtBoxNom_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxNom.Text))
            {
                e.Cancel = true;
                txtBoxNom.Focus();
                errorProviderAjoutEleve.SetError(txtBoxNom, "Le texte doit être rempli");
            }
            else if(ContainNumbersRegex(txtBoxNom.Text))
            {
                e.Cancel = true;
                txtBoxNom.Focus();
                errorProviderAjoutEleve.SetError(txtBoxNom, "Le nom ne doit pas contenir de chiffres");
            }
            else
            {
                e.Cancel = false;
                errorProviderAjoutEleve.SetError(txtBoxNom, "");
            }
        }
        private void txtBoxPrenom_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxPrenom.Text))
            {
                e.Cancel = true;
                txtBoxPrenom.Focus();
                errorProviderAjoutEleve.SetError(txtBoxPrenom, "Le texte doit être rempli");
            }
            else if (ContainNumbersRegex(txtBoxPrenom.Text))
            {
                e.Cancel = true;
                txtBoxPrenom.Focus();
                errorProviderAjoutEleve.SetError(txtBoxPrenom, "Le nom ne doit pas contenir de chiffres");
            }
            else
            {
                e.Cancel = false;
                errorProviderAjoutEleve.SetError(txtBoxPrenom, "");
            }
        }

        private void telMere_Validating(object sender, CancelEventArgs e)
        {
            if (telRegex(telMere.Text))
            {
                e.Cancel = false;
                errorProviderAjoutEleve.SetError(telMere, "");

            }
            else
            {
                e.Cancel = true;
                telMere.Focus();
                errorProviderAjoutEleve.SetError(telMere, "Le numéro doit etre de forme 0611223344");
            }
        }

        private void telPere_Validating(object sender, CancelEventArgs e)
        {
            if (telRegex(telPere.Text))
            {
                e.Cancel = false;
                errorProviderAjoutEleve.SetError(telPere, "");
            }
            else
            {
                e.Cancel = true;
                telPere.Focus();
                errorProviderAjoutEleve.SetError(telPere, "Le numéro doit etre de forme 0611223344");
            }
        }

        private void telEleve_Validating(object sender, CancelEventArgs e)
        {
            if (telRegex(telEleve.Text))
            {
                e.Cancel = false;
                errorProviderAjoutEleve.SetError(telEleve, "");
            }
            else
            {
                e.Cancel = true;
                telEleve.Focus();
                errorProviderAjoutEleve.SetError(telEleve, "Le numéro doit etre de forme 0611223344");
            }
        }
        private bool ContainNumbersRegex(string name)
        {
            Regex regex = new Regex(@"\d");
            Match match = regex.Match(name);
            if(match.Success)
            {
                return true;
            }
            return false;
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
        
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                System.DateTime dt;
                System.DateTime dateNaissance = this.dateDeNaissance.SelectionStart.Date;
                dt = dateNaissance;
                string date = dt.ToString("yyyy-MM-dd");
                bool tieTem = false;
                if (tiersTemps.Checked == true)
                {
                    tieTem = true;
                }
                else if (tiersTemps2.Checked == true)
                {
                    tieTem = false;
                }

                int idClasse = Convert.ToInt32(listeClasse.SelectedValue);
                Classe uneClasse;
                uneClasse = new Classe(idClasse);
                GestionEleves.AjoutEleve(txtBoxNom.Text, txtBoxPrenom.Text, date, sante.Text, telEleve.Text, telPere.Text, telMere.Text, false, tieTem, uneClasse);
                FrmModuleListeEleve frm = new FrmModuleListeEleve();
                frm.Show();
                this.Hide();
                MessageBox.Show("Votre élève a bien été ajouté !");
            }
        }

    }
}
