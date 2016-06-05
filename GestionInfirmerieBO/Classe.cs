using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionInfirmerieBO
{
    public class Classe
    {
        private int Id_classe;
        private string Libelle_classe;
        private string LienEdt_classe;


        public int unId_classe
        {
            get { return Id_classe; }
            set { Id_classe = value; }
        }



        public string unLibelle_classe

        {
            get { return Libelle_classe; }
            set { Libelle_classe = value; }
        }

        

        public string unLienEdt_classe

        {
            get { return LienEdt_classe; }
            set { LienEdt_classe = value; }
        }


        #region constructeur

        public Classe(int leIdClasse, string leLibelleClasse, string leLienEDTClasse)
        {
            // Initialisation des attributs.
            this.Id_classe = leIdClasse;
            this.Libelle_classe = leLibelleClasse;
            this.LienEdt_classe = leLienEDTClasse;
        }

        public Classe(int leIdClasse, string leLibelleClasse)
        {
            // Initialisation des attributs.
            this.Id_classe = leIdClasse;
            this.Libelle_classe = leLibelleClasse;
        }

        public Classe(int leIdClasse)
        {
            this.Id_classe = leIdClasse;
        }

        public Classe(string leLibelleClasse, string leLienEDTClasse)
        {
            this.Libelle_classe = leLibelleClasse;
            this.LienEdt_classe = leLienEDTClasse;
        }
        #endregion
    }
}
