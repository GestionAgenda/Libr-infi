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
    public partial class FrmModuleConnexion : Form
    {

        public FrmModuleConnexion()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);
            
        }

        private void connexion_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (GestionUtilisateurs.ChercherLogins(txtBoxIdentifiant.Text, txtBoxMDP.Text)==false )
            {
                MessageBox.Show("Votre mot de passe et/ou votre identifiant est erroné, veuillez recommencer !", "Erreur de connexion");
            }
            else
            {
                FrmModuleListeEleve frm = new FrmModuleListeEleve();
                frm.Show();
                this.Hide();

            }
        }

        //Permet de "cliquer" sur connexion sans avoir le focus dessus
        // (Ne fonctionne pas encore)
        #region Raccourci clavier
        private void txtBoxIdentifiant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConnexion_Click(sender, e);
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txtBoxMDP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConnexion_Click(sender, e);
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private void txtBoxMDP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!txtBoxMDP.AcceptsReturn)
                {
                    btnConnexion.PerformClick();
                }
            }
        }
        #endregion
    }
}
