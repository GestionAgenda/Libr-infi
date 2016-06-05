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
    public partial class FrmDetailsEleve : Form
    {
        public FrmDetailsEleve(int idEleve)
        {

            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionEleves.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);
            Eleve unEleve = GestionInfirmerieBLL.GestionEleves.InfoEleve(idEleve);
            DateTime Date=Convert.ToDateTime(unEleve.uneDateNaissance_eleve);
            string uneDate = Date.ToString("d");
            
            TimeSpan span = DateTime.Now.Subtract(Date);
            if (unEleve.unTiers_Temps == true)
            {
                radioOuiTT.Checked = true;
            }
            else
            {
                radioNonTT.Checked = true ;
            }
            
            lblAgeEleve.Text = "Age : " + span.Days / 365;
            lblDateNaissance.Text = "Date de naissance : "+uneDate;
            lblSante.Text = "Sante : " + unEleve.uneSante_eleve;
            lblNomEleve.Text = "Nom : " + unEleve.unNom_eleve + " " + unEleve.unPrenom_eleve;
            lblTelEleve.Text = "Tel élève : " + unEleve.unTel_eleve;
            lblTelMere.Text = "Tel mère : " + unEleve.unTel_Mere_eleve;
            lblNumPere.Text = "Tel père : " + unEleve.unTel_Pere_eleve;
            lblClasseEleve.Text = "Classe : " + unEleve.UneClasse.unLibelle_classe;
            lblIdEleve.Text = idEleve.ToString();
            
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

        private void btnModifEleve_Click(object sender, EventArgs e)
        {
            FrmModuleModifierEleve frm = new FrmModuleModifierEleve(Int32.Parse(lblIdEleve.Text));
            frm.Show();
            this.Hide();
        }

        private void btnSupprimerEleve_Click(object sender, EventArgs e)
        {
            if (GestionEleves.EleveSupprimable(Int32.Parse(lblIdEleve.Text)) == true)
            {
                GestionEleves.SupprimerEleve(Int32.Parse(lblIdEleve.Text));
                FrmModuleListeEleve frm = new FrmModuleListeEleve();
                frm.Show();
                this.Hide();
                MessageBox.Show("Votre élève a bien été supprimé !");
            }
            else
            {
                MessageBox.Show("Votre élève n'est pas supprimable puisqu'il est relié à une visite, archivez-le !");
            }
        }

        private void btnEdt_Click(object sender, EventArgs e)
        {
            string unEdt = "";
            unEdt = GestionClasses.ClasseEleve(Int32.Parse(lblIdEleve.Text));
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(@"E:\GestionInfirmerieWF1\pdfEdt\" + unEdt + ".pdf", "");
            System.Diagnostics.Process.Start(psi);
        }

    }
}
