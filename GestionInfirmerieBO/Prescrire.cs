using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionInfirmerieBO;

namespace GestionInfirmerieBO
{
    public class Prescrire
    {

        private int quantite_medicament;
        public int uneQuantite_medicament
        {
            get { return quantite_medicament; }
            set { quantite_medicament = value; }
        }
        private Visite visite_prescrire;
        public Visite uneVisite_Prescrire
        {
            get { return visite_prescrire; }
            set {  visite_prescrire = value; }
        }

        private Medicament medicament_prescrire;
        public Medicament unMedicament_prescrire
        {
            get { return medicament_prescrire; }
            set {  medicament_prescrire = value; }
        }
        public Prescrire(Visite laVisite, Medicament leMedicament, int laQuantite)
        {
            this.medicament_prescrire = leMedicament;
            this.visite_prescrire = laVisite;
            this.quantite_medicament = laQuantite;
            
        }
    }
}
