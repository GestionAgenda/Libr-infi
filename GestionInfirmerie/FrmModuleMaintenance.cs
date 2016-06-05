using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using GestionInfirmerieBLL;
using GestionInfirmerieBO;
using GestionInfirmerieDAL;
using System.Configuration;
using System.Globalization;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.Data.SqlClient;

namespace GestionInfirmerie
{
    public partial class FrmModuleMaintenance : Form
    {
        public FrmModuleMaintenance()
        {
            InitializeComponent();
        }

        private void btnClasse_Click(object sender, EventArgs e)
        {
            FrmModuleGestionClasse frm = new FrmModuleGestionClasse();
            frm.Show();
            this.Hide();
        }

        private void btnSaveBdd_Click(object sender, EventArgs e)
        {
            bool save = false;
            DateTime uneDate = System.DateTime.Now;
            string stringDate;
            stringDate = String.Format("{0:D}", uneDate);
            SqlConnection connexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = connexion.CreateCommand();
            cmd.CommandText = string.Format(@"BACKUP DATABASE [gestioninfirmiere_prodtest] TO DISK = 'C:\\Users\\win7vitual\\Desktop\\Backup\\gestioninfirmiere_prodtest_" + stringDate + ".bak' ");
            try
            {
                cmd.ExecuteNonQuery();
                save = true;
            }
            catch (Exception ex)
            {
                if (ex.Message != null)
                {
                    save = false;
                }
            }
            connexion.Close();
            if (save == false)
            {
                MessageBox.Show("La base de données n'a pas été bien sauvegardé !");
            }
            else
            {
                MessageBox.Show("La base de données a bien été sauvegardé !");
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

        private void buttonArchivage_Click(object sender, EventArgs e)
        {
            FrmModuleArchivageMedicament frm = new FrmModuleArchivageMedicament();
            frm.Show();
            this.Hide();
        }

        private void buttonDesarchivage_Click(object sender, EventArgs e)
        {
            FrmModuleDesarchivageMedicament frm = new FrmModuleDesarchivageMedicament();
            frm.Show();
            this.Hide();
        }

        private void CSVImport_Click(object sender, EventArgs e)
        {




                // variables utilisées
                string extension;        // variable pour recuperer extension du fichier
                OpenFileDialog fd = new OpenFileDialog();
                List<Eleve> listImport = new List<Eleve>();
                bool TiersTps_eleve;
                bool Archive_eleve;
                Classe uneClasse;
                Eleve unEleve;
                int index = 0;
                string CheminPDF ;
                string pathFile="" ;




                fd.Filter = "PDF Files(*.csv)|*.csv";
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //Stockage du nom du fichier dans le textbox
                    pathFile = Path.GetFileName(fd.FileName);
                }

                // recup extension du fichier

                    var reader = new StreamReader(File.OpenRead(pathFile + "\\" + fd.FileName));
                    List<string> listNomEleve = new List<string>();
                    List<string> listPrenomEleve = new List<string>();
                    List<string> listDateNaissanceEleve = new List<string>();
                    List<string> listTelEleve = new List<string>();
                    List<string> listTelParentEleve = new List<string>();
                    List<string> listEtatSanteEleve = new List<string>();
                    List<bool> listTiersTempsEleve = new List<bool>();
                    List<bool> listArchiveEleve = new List<bool>();
                    List<Classe> listClasseEleve = new List<Classe>();

                    // lecture du fichier CSV
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        bool.TryParse(values[6].ToString(), out TiersTps_eleve);
                        bool.TryParse(values[7].ToString(), out Archive_eleve);
                        

                        //uneClasse = GestionClasses.GetUneClasse(Int32.Parse(values[8].ToString()));

                        // création de plusieurs listes pour reccueuillir les données
                        listNomEleve.Add(values[0]);
                        listPrenomEleve.Add(values[1]);
                        listDateNaissanceEleve.Add(values[2]);
                        listTelEleve.Add(values[3]);
                        listTelParentEleve.Add(values[4]);
                        listEtatSanteEleve.Add(values[5]);
                        listTiersTempsEleve.Add(TiersTps_eleve);
                        listArchiveEleve.Add(Archive_eleve);
                        
                        //listClasseEleve.Add(uneClasse);

                        // incrémentation d'un index à chaque fin de ligne
                        index++;
                    }

                    // création et ajout des élèves lus dans le fichier CSV
                    for (int i = 0; i < index; i++)
                    {
                        unEleve = new Eleve(listNomEleve[i], listPrenomEleve[i], listDateNaissanceEleve[i], listTelEleve[i], listTelParentEleve[i],listTelParentEleve[i], listEtatSanteEleve[i], listTiersTempsEleve[i], listArchiveEleve[i], listClasseEleve[i]);
                        listImport.Add(unEleve);
                    }

                    // appel de la méthode d'UPDATE de la liste des élèves dans la BDD
                    GestionEleves.UpdateEleveCSV(listImport);
                }
            }
        }
    

