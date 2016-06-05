using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionInfirmerieBO; // Référence la couche BO
using GestionInfirmerieDAL;  // Référence la couche DAL
using System.Configuration;

namespace GestionInfirmerieBLL
{
    public class GestionMedicaments
    {
        public static List<Medicament> GetListeMedicaments()
        {
            return MedicamentDAO.GetListeMedicaments();
        }

        public static Medicament GetMedicaments(int idMedic)
        {
            return MedicamentDAO.GetMedicModifChoisi(idMedic);
        }

        public static void ModifierMedicament(Medicament unMedicament)
        {
            MedicamentDAO.ModifierMedicament(unMedicament);
        }

        public static void AjouterMedicament(string unLibelle, bool uneArchive)
        {
            Medicament unMedicament;
            unMedicament = new Medicament(unLibelle, uneArchive);
            MedicamentDAO.AjoutMedicament(unMedicament);
        }
        public static void SupprimerMedicament(string lblMedicament)
        {

            MedicamentDAO.SupprimMedicament(lblMedicament);
        }
        public static bool MedicamentSupprimable(string idMed)
        {

            return MedicamentDAO.MedicamentSupprimable(idMed);
        }
        public static void ArchivMedicament(int idMed)
        {

            MedicamentDAO.ArchiverMedicament(idMed);
        }
        public static void DesarchivMedicament(int idMed)
        {

            MedicamentDAO.DesarchiverMedicament(idMed);
        }
        public static List<Medicament> GetListeMedicamentArchive()
        {
            return MedicamentDAO.GetListeMedicamentsArchiv();
        }
        public static  List<Medicament> GetListeMedicamentDesarchive()
        {
            return MedicamentDAO.GetListeMedicamentsDesarchiv();
        }   
    }
}
