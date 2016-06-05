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
    public class GestionSynthese
    {
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBDD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        public static float GetTempsMoyVis(DateTime dateDebut, DateTime dateFin)

        {
            return SyntheseDAO.GetTempsMoyVis(dateDebut, dateFin);
        }


        public static float GetNbTotVisite(DateTime dateDebut, DateTime dateFin)
        {
            return SyntheseDAO.GetNbTotVisite(dateDebut, dateFin);
        }


        public static float GetNbTotEleve()
        {
            return SyntheseDAO.GetNbTotEleve( );
        }


        public static float GetTotalMedic(DateTime dateDebut, DateTime dateFin)
        {
            return SyntheseDAO.GetTotalMedic( dateDebut, dateFin);
        }

        public static float GetMedicM(DateTime dateDebut, DateTime dateFin)
        {
            return SyntheseDAO.GetMedicM(dateDebut, dateFin);
        }

        public static float GetVisiteMoyEleve(DateTime dateDebut, DateTime dateFin)
        {
            return SyntheseDAO.GetVisiteMoyEleve(dateDebut, dateFin);
        }
      

    }
}
