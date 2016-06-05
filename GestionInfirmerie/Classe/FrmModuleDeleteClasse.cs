using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using GestionInfirmerieBLL;
using GestionInfirmerieBO;
using System.Configuration;
using System.Text.RegularExpressions;

namespace GestionInfirmerie
{

    public partial class FrmModuleDeleteClasse : Form
    {
        Classe uneClasse;
        string pathFile = "";
        OpenFileDialog fd = new OpenFileDialog();


        public FrmModuleDeleteClasse()
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

        
        
        private void btnEnregistrer_Click(object sender, EventArgs e )
        {
            uneClasse = GestionClasses.infoClasse(Int32.Parse(comboBoxClasse.SelectedValue.ToString()));
            if (GestionClasses.DeleteClasse(uneClasse))
            {
                MessageBox.Show("La classe a bien été supprimée !");
                
                //TODO :  Actualiser la liste à chaque suppression 
                //comboBoxClasse.SelectedItem = comboBoxClasse.Items[0];
                //refreshList(GestionClasses.ListeDesClasses());
            }
            else
            {
                MessageBox.Show("La classe n'est pas vide, elle ne peut pas être supprimée !");
            }
        }


        public void refreshList(List<Classe> list)
        {
            List<Classe> lesClasses = GestionClasses.ListeDesClasses();
            comboBoxClasse.DataSource = lesClasses;
            comboBoxClasse.DisplayMember = "libelleClasse";
            comboBoxClasse.ValueMember = "idClasse";
        }

        private void CopyFile()
        {

            // To move a file or folder to a new location:
            string destinationFile = @"E:\GestionInfirmerieWF1\pdfEdt\" + pathFile;
            System.IO.File.Copy(fd.FileName, destinationFile, true);

        }

        private void comboBoxClasse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }






        


    }
}
