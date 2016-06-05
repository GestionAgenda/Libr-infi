using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionInfirmerieBO
{
    public class Eleve
    {
        #region Attributs et Accesseurs

        private Classe uneClasse;

        public Classe UneClasse
        {
            get { return uneClasse; }
            set { uneClasse = value; }
        }

        private int Id_eleve;
        public int unId_eleve
        {
            get { return Id_eleve; }
            set { Id_eleve = value; }
        }

        private string Nom_eleve;
        public string unNom_eleve
        {
            get { return Nom_eleve; }
            set { Nom_eleve = value; }
        }   

        private string Prenom_eleve;
        public string unPrenom_eleve
        {
            get { return Prenom_eleve; }
            set { Prenom_eleve = value; }
        }


        private string DateNaissance_eleve;
        public string uneDateNaissance_eleve
        {
            get { return DateNaissance_eleve; }
            set { DateNaissance_eleve = value; }
        }


        private string Sante_eleve;
        public string uneSante_eleve
        {
            get { return Sante_eleve; }
            set { Sante_eleve = value; }
        } 


        private string Tel_eleve;
        public string unTel_eleve
        {
            get { return Tel_eleve; }
            set { Tel_eleve = value; }
        }


        private string Tel_Pere_eleve;
        public string unTel_Pere_eleve
        {
            get { return Tel_Pere_eleve; }
            set { Tel_Pere_eleve = value; }
        }
        private string Tel_Mere_eleve;
        public string unTel_Mere_eleve
        {
            get { return Tel_Mere_eleve; }
            set { Tel_Mere_eleve = value; }
       }


        private bool Archive_eleve;
        public bool uneArchive_eleve
        {
            get { return Archive_eleve; }
            set { Archive_eleve = value; }
        }
        
        private bool Tiers_Temps;
        public bool  unTiers_Temps
        {
            get { return Tiers_Temps; }
            set { Tiers_Temps = value; }
        }
        // création de la référence à Classe


        #endregion

        
        #region Constructeurs

        public Eleve(int leId_eleve, string leNom_eleve, string lePrenom_eleve, string laDateNaissance_eleve, string laSante_eleve, string leTel_eleve, string leTelPere_eleve, string leTelMere_eleve, bool laArchive_eleve, bool leTiersTemps_eleve, Classe laClasse)
            {
                // Initialisation des attributs.
                this.Id_eleve = leId_eleve;
                this.Nom_eleve = leNom_eleve;
                this.Prenom_eleve = lePrenom_eleve;
                this.DateNaissance_eleve= laDateNaissance_eleve;
                this.Sante_eleve= laSante_eleve;
                this.Tel_eleve = leTel_eleve;
                this.Tel_Pere_eleve= leTelPere_eleve;
                this.Tel_Mere_eleve= leTelMere_eleve;
                this.Archive_eleve=  laArchive_eleve;
                this.Tiers_Temps= leTiersTemps_eleve;
                this.uneClasse=laClasse;
            }
        public Eleve(string leNom_eleve, string lePrenom_eleve, string laDateNaissance_eleve, string laSante_eleve, string leTel_eleve, string leTelPere_eleve, string leTelMere_eleve, bool laArchive_eleve, bool leTiersTemps_eleve, Classe laClasse)
        {
            // Initialisation des attributs.
            this.Nom_eleve = leNom_eleve;
            this.Prenom_eleve = lePrenom_eleve;
            this.DateNaissance_eleve = laDateNaissance_eleve;
            this.Sante_eleve = laSante_eleve;
            this.Tel_eleve = leTel_eleve;
            this.Tel_Pere_eleve = leTelPere_eleve;
            this.Tel_Mere_eleve = leTelMere_eleve;
            this.Archive_eleve = laArchive_eleve;
            this.Tiers_Temps = leTiersTemps_eleve;
            this.uneClasse = laClasse;
        }

        public Eleve(string leNom_eleve, string lePrenom_eleve, Classe laClasse)
        {
            this.Nom_eleve = leNom_eleve;
            this.Prenom_eleve = lePrenom_eleve;

            this.uneClasse = laClasse;
        }

        public Eleve(int leId_eleve, string leNom_eleve, string lePrenom_eleve, Classe laClasse)
        {
            this.Nom_eleve = leNom_eleve;
            this.Prenom_eleve = lePrenom_eleve;
            this.Id_eleve = unId_eleve;
            this.uneClasse = laClasse;
        }

        public Eleve(int leId_eleve)
        {
            this.Id_eleve = leId_eleve;
        }
        #endregion


    }
}
