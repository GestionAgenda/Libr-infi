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
   
    public partial class FrmModuleEditClasse : Form
    {
        Classe uneClasse;
        string pathFile = "";
        OpenFileDialog fd = new OpenFileDialog();


        public FrmModuleEditClasse()
        {
            InitializeComponent();


            textBoxNomClasse.Text =  "";
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


            uneClasse.unLienEdt_classe = CheminPDF.Text;
            uneClasse.unLibelle_classe = textBoxNomClasse.Text;
            CopyFile();

            GestionClasses.ModifClasse(uneClasse);
            MessageBox.Show("La classe a bien été modifiée !");
        }

        private void CopyFile()
        {

            // To move a file or folder to a new location:
            string destinationFile = @"E:\GestionInfirmerieWF1\pdfEdt\" + pathFile;
            System.IO.File.Copy(fd.FileName, destinationFile, true);

        }

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



        private void comboBoxClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            uneClasse=GestionClasses.infoClasse(Int32.Parse(comboBoxClasse.SelectedValue.ToString()));
            textBoxNomClasse.Text = comboBoxClasse.Text;
            CheminPDF.Text = uneClasse.unLienEdt_classe;

        }


        


    }
}
