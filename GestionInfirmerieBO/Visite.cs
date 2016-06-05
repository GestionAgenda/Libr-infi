using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionInfirmerieBO;

namespace GestionInfirmerieBO
{
    public class Visite
    {
        private int id_Visite;
        public int unId_Visite
        {
            get { return id_Visite; }
            set { id_Visite = value; }
        }

     

        private string motif_Visite;
        public string unMotif_Visite
        {
            get { return motif_Visite; }
            set { motif_Visite = value; }
        }

        private string commentaire_Visite;
        public string unCommentaire_Visite
        {
            get { return commentaire_Visite; }
            set { commentaire_Visite = value; }
        }

        private string heure_Arrive;
        public string uneHeure_Arrive
        {
            get { return heure_Arrive; }
            set { heure_Arrive = value; }
        }
        private string heure_Sortie;
        public string uneHeure_Sortie
        {
            get { return heure_Sortie; }
            set { heure_Sortie=value; }
        }
        private string date_Visite;
        public string uneDate_Visite
        {
            get { return date_Visite; }
            set { date_Visite = value; }
        }
        private bool parents_Prevenus;
        public bool lesParents_Prevenus 
        {
            get { return parents_Prevenus; }
            set { parents_Prevenus = value; }
        }
        private bool visite_Hopital;
        public bool uneVisite_Hopital
        {
            get { return visite_Hopital; }
            set { visite_Hopital = value; }
        }
        private bool retour_Domicile;
        public bool unRetour_Domicile
        {
            get { return retour_Domicile; }
            set { retour_Domicile = value; }
        }
        private string pouls_Visite;
        public string unPouls_Visite
        {
            get { return pouls_Visite; }
            set { pouls_Visite = value; }
        }
        private Eleve eleve_Visite;
        public Eleve unEleve_Visite
        {
            get { return eleve_Visite; }
            set {  eleve_Visite = value; }
        }
        public Visite(int leId_Visite, string leMotif_Visite,string leCommentaire_Visite, string laHeure_Arrive, string laHeure_Sortie, string laDate_Visite, bool lesParents_Prevenus, bool laVisite_Hopital, bool leRetour_Domicile, string lePouls_Visite, Eleve leEleve)
        {
            this.id_Visite = leId_Visite;
            this.motif_Visite = leMotif_Visite;
            this.commentaire_Visite = leCommentaire_Visite;
            this.heure_Arrive = laHeure_Arrive;
            this.heure_Sortie = laHeure_Sortie;
            this.date_Visite = laDate_Visite;
            this.parents_Prevenus = lesParents_Prevenus;
            this.visite_Hopital = laVisite_Hopital;
            this.retour_Domicile = leRetour_Domicile;
            this.pouls_Visite = lePouls_Visite;
            this.eleve_Visite = leEleve;
            
        }
        public Visite(string leMotif_Visite, string leCommentaire_Visite, string laHeure_Arrive, string laHeure_Sortie, string laDate_Visite, bool lesParents_Prevenus, bool laVisite_Hopital, bool leRetour_Domicile, string lePouls_Visite, Eleve leEleve)
        {
            this.motif_Visite = leMotif_Visite;
            this.commentaire_Visite = leCommentaire_Visite;
            this.heure_Arrive = laHeure_Arrive;
            this.heure_Sortie = laHeure_Sortie;
            this.date_Visite = laDate_Visite;
            this.parents_Prevenus = lesParents_Prevenus;
            this.visite_Hopital = laVisite_Hopital;
            this.retour_Domicile = leRetour_Domicile;
            this.pouls_Visite = lePouls_Visite;
            this.eleve_Visite = leEleve;
            
        }
        public Visite(string leMotif_Visite, string leCommentaire_Visite, string laHeure_Arrive, string laHeure_Sortie, string laDate_Visite, bool lesParents_Prevenus, bool laVisite_Hopital, bool leRetour_Domicile, string lePouls_Visite)
        {
            this.motif_Visite = leMotif_Visite;
            this.commentaire_Visite = leCommentaire_Visite;
            this.heure_Arrive = laHeure_Arrive;
            this.heure_Sortie = laHeure_Sortie;
            this.date_Visite = laDate_Visite;
            this.parents_Prevenus = lesParents_Prevenus;
            this.visite_Hopital = laVisite_Hopital;
            this.retour_Domicile = leRetour_Domicile;
            this.pouls_Visite = lePouls_Visite;

        }
        public Visite(int idVisite, string leMotif_Visite, string leCommentaire_Visite, string laHeure_Arrive, string laHeure_Sortie, string laDate_Visite, bool lesParents_Prevenus, bool laVisite_Hopital, bool leRetour_Domicile, string lePouls_Visite)
        {
            this.id_Visite=idVisite;
            this.motif_Visite = leMotif_Visite;
            this.commentaire_Visite = leCommentaire_Visite;
            this.heure_Arrive = laHeure_Arrive;
            this.heure_Sortie = laHeure_Sortie;
            this.date_Visite = laDate_Visite;
            this.parents_Prevenus = lesParents_Prevenus;
            this.visite_Hopital = laVisite_Hopital;
            this.retour_Domicile = leRetour_Domicile;
            this.pouls_Visite = lePouls_Visite;

        }
        public Visite(int leId_Visite)
        {
            this.id_Visite = leId_Visite;
        }

        public Visite(int leId_Visite, string laDate_Visite,Eleve leEleveVisite)
        {
            this.id_Visite = leId_Visite;
            this.date_Visite = laDate_Visite;
            this.unEleve_Visite = leEleveVisite;
            
        }
    }
}
