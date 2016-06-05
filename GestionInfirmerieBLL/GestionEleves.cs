using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionInfirmerieBO; // Référence la couche BO
using GestionInfirmerieDAL;  // Référence la couche DAL
using System.Configuration;
using System.Text.RegularExpressions;//Regex


namespace GestionInfirmerieBLL
{
    public class GestionEleves
    {
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBDD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        public static List<Eleve> GetListeEleves()
        {
            return EleveDAO.GetListeEleves();
        }
        public static void ModifieEleve(Eleve unEleve)
        {
            EleveDAO.ModifieEleve(unEleve);
        }
        public static List<Eleve> GetListeElevesSaisie(string nomPrenomSaisie)
        {
            return EleveDAO.GetListeElevesSaisies(nomPrenomSaisie);
        }
        public static List<Eleve> GetToutEleves()
        {
            return EleveDAO.GetToutEleves();
        }
        public static List<Eleve> GetToutElevesSaisie(string nomPrenom)
        {
            return EleveDAO.GetToutElevesSaisies(nomPrenom);
        }
        public static Eleve InfoEleve(int idEleve)
        {
            return EleveDAO.InfoEleve(idEleve);
        }
        public static void AjoutEleve(string nom, string prenom, string dateDeNaissance, string sante, string telEleve, string telPere, string telMere, bool archive, bool tiersTemps, Classe uneClasse)
        {
            Eleve el;
            el = new Eleve(nom, prenom, dateDeNaissance, sante, telEleve, telPere, telMere, archive, tiersTemps, uneClasse);
            EleveDAO.AjoutEleve(el);
        }
        public static void SupprimerEleve(int id)
        {
            EleveDAO.SupprimEleve(id);
        }
        public static bool EleveSupprimable(int idEl)
        {
            return EleveDAO.EleveSupprimable(idEl);
        }
        public static bool ControleNom(string nom)
        {
            System.Text.RegularExpressions.Regex myRegex = new Regex("[0-9]");
            if (!myRegex.IsMatch(nom))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ControleTel(string num)
        {
            System.Text.RegularExpressions.Regex myRegex = new Regex("^(01|02|03|04|05|06|07|08|09)[00-99]{8}");
            if (myRegex.IsMatch(num))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void UpdateEleveCSV(List<Eleve> listImport)
        {
            
        }
    }
}
