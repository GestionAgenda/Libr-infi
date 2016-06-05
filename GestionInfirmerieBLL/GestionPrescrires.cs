using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionInfirmerieBO; // Référence la couche BO
using GestionInfirmerieDAL;  // Référence la couche DAL
using System.Configuration;

namespace GestionInfirmerieBO
{
    public class GestionPrescrires
    {
        public static void AjoutPrescription(Visite uneVisite, int quantite, Medicament unMedicament)
        {
            Prescrire unePrescription = new Prescrire(uneVisite,  unMedicament, quantite);
            PrescrireDAO.AjoutPrescription(unePrescription);
        }

        public static void ModifPrescription(Visite uneVisite, int quantite, Medicament unMedicament)
        {
            Prescrire unePrescription = new Prescrire(uneVisite,  unMedicament, quantite);
            PrescrireDAO.ModifPrescription(unePrescription);
        }

        public static Prescrire InfoPrescrire(int idVisite)
        {
            return PrescrireDAO.InfoPrescrire(idVisite);
        }

    }
}
