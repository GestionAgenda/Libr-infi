using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionInfirmerieBO; // Référence la couche BO
using GestionInfirmerieDAL;  // Référence la couche DAL
using System.Configuration;

namespace GestionInfirmerieBLL
{
    public class GestionClasses
    {
        public static List<Classe> ListeDesClasses()
        {
            return ClasseDAO.ListeDesClasses();
        }
        public static string ClasseEleve(int unId)
        {
            return ClasseDAO.EdtEleve(unId);
        }
        public static int IdClasseEleve(int unId)
        {
            return ClasseDAO.IdClasseEleve(unId);
        }
        public static void AjoutClasse(string nom, string lienEDT)
        {
            Classe uneClasse;
            uneClasse = new Classe(nom, lienEDT);
            ClasseDAO.AjoutClasse(uneClasse);
        }
        public static string EdtClasse(string nom)
        {
            return  ClasseDAO.EdtClasse(nom);
        }
        public static Classe infoClasse(int id)
        {
            return ClasseDAO.infoClasse(id);
        }
        public static void ModifClasse(Classe uneClasse)
        {
            ClasseDAO.ModifClasse(uneClasse);
        }
        public static bool DeleteClasse(Classe uneClasse)
        {
            
            if (ClasseDAO.ClasseSupprimable(uneClasse))
            {
                ClasseDAO.DeleteClasse(uneClasse);
                return true;
            }
            return false;
        }
        public static List<Eleve> GetUneClasse(int idClasse)
        {
            return ClasseDAO.GetListeEleve(idClasse);
        }
    }
}
