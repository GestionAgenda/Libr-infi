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
    public partial class FrmModuleAjoutClasse : Form
    {
        string pathFile = "";
        OpenFileDialog fd = new OpenFileDialog();


        public FrmModuleAjoutClasse()
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

        //Liens vers les autres pages
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

        
        //Méthode executée lors du clic sur le bouton enregistrer
        private void btnEnregistrer_Click(object sender, EventArgs e )
        {

            if (CheminPDF.Text == "")
            {
                MessageBox.Show("L'emploi du temps doit être spécifié");
            }
            else
            {
                string nomClasse = textBoxNomClasse.Text;
                CopyFile();


                //TODO : terminer la méthode pour finaliser l'ajout d'une classe
                GestionClasses.AjoutClasse(nomClasse, pathFile);
                MessageBox.Show("La classe a bien été ajoutée !");
            }

        }

        //Permet de 
        private void CopyFile()
        {
            // To move a file or folder to a new location:
            string destinationFile = @"E:\GestionInfirmerieWF1\pdfEdt\" + pathFile;
            System.IO.File.Copy(fd.FileName, destinationFile, true);
        }

        //Méthode executée lors du parcours de fichier, récupère l'adresse du PDF
        private void button2_Click(object sender, EventArgs e)
        {
            fd.Filter = "PDF Files(*.pdf)|*.pdf";
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Stockage du nom du fichier dans le textbox
                CheminPDF.Text = Path.GetFileNameWithoutExtension(fd.FileName);
                pathFile = Path.GetFileName(fd.FileName);
            }
        }
    }
}
