using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionInfirmerieBO; // Référence la couche BO
using System.Data.SqlClient;
namespace GestionInfirmerieDAL
{
    public class PrescrireDAO
    {
        public static void ModifPrescription(Prescrire unePrescription)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE Prescrire SET Quantite_medicament=" + unePrescription.uneQuantite_medicament + ", Id_medicament=" + unePrescription.unMedicament_prescrire.IdMedicament + " where Id_visite=" + unePrescription.uneVisite_Prescrire.unId_Visite + " ;";
            // Fermeture de la connexion
            cmd.ExecuteNonQuery();
            maConnexion.Close();
        }

        public static void AjoutPrescription(Prescrire unePrescription)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO Prescrire(Quantite_medicament, Id_visite, Id_medicament) values(" + unePrescription.uneQuantite_medicament + "," + unePrescription.uneVisite_Prescrire.unId_Visite + "," + unePrescription.unMedicament_prescrire.IdMedicament + ");";
            // Fermeture de la connexion
            cmd.ExecuteNonQuery();
            maConnexion.Close();
        }

        //Cette méthode retourne un élève dans la BD
        public static Prescrire InfoPrescrire(int idVisite)
        {
            Visite visite;
            Medicament medicament;
            int idMedicament;
            int quantiteMedicament;


             
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "Select * From Prescrire Where Id_visite=" + idVisite + " ;";


            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {

                idMedicament = Int32.Parse(monReader["Id_medicament"].ToString());
                idVisite = Int32.Parse(monReader["Id_visite"].ToString());
                if (monReader["Quantite_medicament"] == DBNull.Value)
                {
                    quantiteMedicament = default(int);
                }
                else
                {
                    quantiteMedicament = Int32.Parse(monReader["Quantite_medicament"].ToString());
                }
                medicament = new Medicament(idMedicament);
                visite = new Visite(idVisite);
                Prescrire prescription;
                prescription = new Prescrire(visite, medicament, quantiteMedicament);
                maConnexion.Close();
                return prescription;

            }
            // Fermeture de la connexion

            maConnexion.Close();


            return null;

        }
    }
}
