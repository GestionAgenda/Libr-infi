using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionInfirmerieBO; // Référence la couche BO
using GestionInfirmerieDAL;  // Référence la couche DAL
using System.Configuration;

namespace GestionInfirmerieBO
{
    public class GestionVisites
    {
        public static void AjoutVisite(string motifVisite, string commentaireVisite, string heureArriveVisite, string heureSortieVisite, string dateVisite, bool parentsPrevenus, bool visiteHopital, bool retourDomicile , string poulsVisite, Eleve unEleve)
        {
            Visite vis;
            vis = new Visite(motifVisite, commentaireVisite, heureArriveVisite, heureSortieVisite, dateVisite, parentsPrevenus, visiteHopital, retourDomicile, poulsVisite, unEleve);
            VisiteDAO.AjoutVisite(vis);
        }

        public static void EditVisite(int idDuneVisite, string motifVisite, string commentaireVisite, string heureArriveVisite, string heureSortieVisite, string dateVisite, bool parentsPrevenus, bool visiteHopital, bool retourDomicile , string poulsVisite)
        {
            Visite vis;
            vis = new Visite(idDuneVisite, motifVisite, commentaireVisite, heureArriveVisite, heureSortieVisite, dateVisite, parentsPrevenus, visiteHopital, retourDomicile, poulsVisite);
            VisiteDAO.modifVisite(vis);
        }
        public static List<Visite> ToutesLesVisites()
        {
            return VisiteDAO.ToutesLesVisites();
        }

        public static Visite InfoVisite(int idVisite)
        {
            return VisiteDAO.InfoVisite(idVisite);
        }

        public static Visite InfoDerniereVisite()
        {
            return VisiteDAO.InfoDerniereVisite();
        }
    }
}
