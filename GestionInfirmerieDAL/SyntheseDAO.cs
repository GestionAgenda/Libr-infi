using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionInfirmerieBO; // Référence la couche BO
using GestionInfirmerieDAL;  // Référence la couche DAL
using System.Data.SqlClient;

namespace GestionInfirmerieDAL
{
    public class SyntheseDAO
    {



        // Cette méthode retourne le nombre total de médicament
        public static int GetTotalMedic(DateTime dateDebut, DateTime dateFin)
        {

            int nbTotalMedic = 0;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT Quantite_medicament As totalMedic From Prescrire, Visite where Visite.Id_visite=Prescrire.Id_visite AND Visite.Date_visite BETWEEN'" + dateDebut + "'AND '" + dateFin + "';;";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Retourne le nombre total de médicaments sur une année scolaire
            while (monReader.Read())
            {
                nbTotalMedic = nbTotalMedic+ Int32.Parse(monReader["totalMedic"].ToString());

            }


            maConnexion.Close();

            return nbTotalMedic;
        }

        // Cette méthode retourne le nombre total d'élèves dans l'établissemment
        public static float GetNbTotEleve()
        {

            float nbTotalEleve = 1;


            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT count(Id_eleve) as nbTotEleve FROM Eleve ;";

            SqlDataReader monReader = cmd.ExecuteReader();

            // retourne la valeur
            while (monReader.Read())
            {

                nbTotalEleve = Int32.Parse(monReader["nbTotEleve"].ToString());
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return nbTotalEleve;


        }

        // Cette méthode retourne le nombre total de visites médicales
        public static float GetNbTotVisite(DateTime dateDebut, DateTime dateFin)
        {

            float nbTotalVisite = 1;


            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT count(Id_visite) as nbTotVisite FROM Visite where Visite.Date_visite BETWEEN'" + dateDebut + "'AND '" + dateFin + "';";

            SqlDataReader monReader = cmd.ExecuteReader();

            // retourne la valeur
            while (monReader.Read())
            {

                nbTotalVisite = Int32.Parse(monReader["nbTotVisite"].ToString());
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return nbTotalVisite;


        }

        // Cette méthode retourne le nombre total d'élèves dans l'établissemment
        public static float GetVisiteMoyEleve(DateTime dateDebut, DateTime dateFin)
        {
            float moyenne = GetNbTotVisite(dateDebut, dateFin) / GetNbTotEleve();
            return moyenne;
        }


        //   Cette méthode retourne le temps moyen d'une visite
        public static float GetTempsMoyVis(DateTime dateDebut, DateTime dateFin)
        {
            //On initialise la valeur tMoyVisite

            float tMoyVisite = 0.00F;
            
            float tTotalVisite = 0;
            
            List<Visite> lesVisites = new List<Visite>();
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "Select DATEDIFF(mi,HeureArrivee_Visite, HeureSortie_Visite) AS tTotalVisite FROM Visite Where Date_visite BETWEEN'" + dateDebut + "'AND '" + dateFin + "';";

            SqlDataReader monReader = cmd.ExecuteReader();



            // Remplissage de la liste
            while (monReader.Read())
            {
                if (monReader.HasRows)
                {
                    tTotalVisite = tTotalVisite+Int32.Parse(monReader["tTotalVisite"].ToString());
                }
                else
                {

                }
                


            }
            // Fermeture de la connexion
            maConnexion.Close();
            if (GetNbTotVisite(dateDebut, dateFin) == 0)
            {
                tMoyVisite = 0;
            }
            else
            {

                tMoyVisite = tTotalVisite / GetNbTotVisite(dateDebut, dateFin);
            }
            return tMoyVisite;
        }


        //   Cette méthode retourne le temps moyen d'une visite
        public static float GetMedicM(DateTime dateDebut, DateTime dateFin)
        {
            //On initialise la valeur tMoyVisite

            float nbMoyMedicV = 0.00F;
           
            int quantiteMed = 0;
            
            
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT Quantite_medicament FROM Prescrire,Visite WHERE Prescrire.Id_visite=Visite.Id_visite AND Visite.Date_visite BETWEEN'" + dateDebut + "'AND '" + dateFin + "'; ";

            SqlDataReader monReader = cmd.ExecuteReader();



            // Remplissage de la liste
            if (monReader.HasRows)
            {
                while (monReader.Read())
                {

                    quantiteMed = quantiteMed + Int32.Parse(monReader["Quantite_medicament"].ToString());



                }
            }

            // Fermeture de la connexion
            maConnexion.Close();
            if (GetNbTotVisite(dateDebut, dateFin) == 0)
            {
                nbMoyMedicV = 0;
            }
            else
            {
                nbMoyMedicV = quantiteMed / GetNbTotVisite(dateDebut, dateFin);
            }
            return nbMoyMedicV;
        }

    }
}