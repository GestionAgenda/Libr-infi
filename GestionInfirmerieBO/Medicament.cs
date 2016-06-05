using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionInfirmerieBO
{
    public class Medicament
    {
        private int idMedicament;
        private string libelleMedicament;
        private bool archiveMedicament;
        public Medicament(int unIdMedicament,string unLibelleMedicament,bool uneArchiveMedicament)
        {
            idMedicament = unIdMedicament;
            libelleMedicament = unLibelleMedicament;
            archiveMedicament = uneArchiveMedicament;
        }

        public Medicament(string unLibelleMedicament, bool uneArchiveMedicament)
        {
            libelleMedicament = unLibelleMedicament;
            archiveMedicament = uneArchiveMedicament;
        }
        public Medicament(int unIdMedicament, string unLibelleMedicament)
        {
            idMedicament = unIdMedicament;
            libelleMedicament = unLibelleMedicament;
        }
        public Medicament(int unIdMedicament)
        {
            idMedicament = unIdMedicament;
        }
        public int IdMedicament
        {
            get { return idMedicament; }
            set { idMedicament = value; }
        }

        public string LibelleMedicament
        {
            get { return libelleMedicament; }
            set { libelleMedicament = value; }
        }

        public bool ArchiveMedicament
        {
            get { return archiveMedicament; }
            set { archiveMedicament = value; }
        }
    }
}
