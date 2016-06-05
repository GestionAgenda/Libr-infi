using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionInfirmerieBO; // Référence la couche BO
using System.Data.SqlClient;

namespace GestionInfirmerieDAL
{
    public class MedicamentDAO
    {
        // Cette méthode retourne une List contenant les objets Medicaments contenus dans la table medicament
        public static Medicament GetMedicModifChoisi(int idMedic)
        {
            int idMedicament;
            string libelleMedicament;
            bool archiveMedicament;

            Medicament unMedicament;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT Id_medicament,Libelle_medicament,Archive_medicament FROM Medicament where Id_medicament=" + idMedic + " ORDER BY Libelle_medicament ASC ;";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                idMedicament = Int32.Parse(monReader["Id_medicament"].ToString());
                if (monReader["Libelle_medicament"] == DBNull.Value)
                {
                    libelleMedicament = default(string);
                }
                else
                {
                    libelleMedicament = monReader["Libelle_medicament"].ToString();
                }

                if (monReader["Archive_medicament"] == DBNull.Value)
                {
                    archiveMedicament = default(bool);
                }
                else
                {
                    string arcMedic = monReader["Archive_medicament"].ToString();
                    bool.TryParse(arcMedic, out archiveMedicament);
                }

                unMedicament = new Medicament(idMedicament, libelleMedicament, archiveMedicament);
                maConnexion.Close();

                return unMedicament;
            }

            // Fermeture de la connexion
            

            maConnexion.Close();
            return unMedicament = new Medicament(1, "", false);
        }

        // Cette méthode retourne une List contenant les objets Medicaments contenus dans la table medicament
        public static List<Medicament> GetListeMedicaments()
        {
            int idMedicament;
            string libelleMedicament;
            bool archiveMedicament;

            Medicament unMedicament;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Utilisateurs
            List<Medicament> lesMedicaments = new List<Medicament>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT Id_medicament,Libelle_medicament,Archive_medicament FROM Medicament ORDER BY Libelle_medicament ASC;";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                idMedicament = Int32.Parse(monReader["Id_medicament"].ToString());
                if (monReader["Libelle_medicament"] == DBNull.Value)
                {
                    libelleMedicament = default(string);
                }
                else
                {
                    libelleMedicament = monReader["Libelle_medicament"].ToString();
                }

                if (monReader["Archive_medicament"] == DBNull.Value)
                {
                    archiveMedicament = default(bool);
                }
                else
                {
                    string arcMedic = monReader["Archive_medicament"].ToString();
                    bool.TryParse(arcMedic, out archiveMedicament);
                }

                unMedicament = new Medicament(idMedicament, libelleMedicament, archiveMedicament);
                lesMedicaments.Add(unMedicament);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesMedicaments;
        }
        //Cette méthode modfie un élève dans la BD
        public static void ModifierMedicament(Medicament unMedicament)
        {




            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE Medicament SET Libelle_medicament='" + unMedicament.LibelleMedicament.Replace("'", "''") + "' Where Id_medicament=" + unMedicament.IdMedicament + ";";

            cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

        }

        public static void AjoutMedicament(Medicament unMedicament)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO Medicament(Libelle_Medicament, Archive_Medicament) values('" + unMedicament.LibelleMedicament.Replace("'", "''") + "',0);";
            // Fermeture de la connexion
            cmd.ExecuteNonQuery();
            maConnexion.Close();
        }


        public static bool MedicamentSupprimable(string lblMedicament)
        {
            //Connexion à la BDD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT Id_visite FROM Visite, Medicament where Libelle_medicament = '" + lblMedicament + "' And Medicament.Id_medicament = Visite.Id_visite ;";
            cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            SqlDataReader monReader = cmd.ExecuteReader();
            if (monReader.HasRows==false)
            {
                maConnexion.Close();
                return true;
            }
            else
            {
                maConnexion.Close();
                return false;
            }
        }

        public static void SupprimMedicament(string idMedicament)
        {
            //Connexion à la BDD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE MEDICAMENT WHERE Id_medicament = " + idMedicament + ";";
            // Fermeture de la connexion
            cmd.ExecuteNonQuery();
            maConnexion.Close();
        }
        public static void ArchiverMedicament(int idMedicament)
        {
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE Medicament SET Archive_medicament= 1 Where Id_medicament =" + idMedicament + ";";
            // Fermeture de la connexion
            cmd.ExecuteNonQuery();
            maConnexion.Close();
        }
        public static void DesarchiverMedicament(int idMedicament)
        {
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE Medicament SET Archive_medicament= 0 Where Id_medicament =" + idMedicament + ";";
            // Fermeture de la connexion
            cmd.ExecuteNonQuery();
            maConnexion.Close();
        }
        public static List<Medicament> GetListeMedicamentsArchiv()
        {
            int idMedicament;
            string libelleMedicament;
            bool archiveMedicament;

            Medicament unMedicament;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Utilisateurs
            List<Medicament> lesMedicaments = new List<Medicament>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT Id_medicament,Libelle_medicament,Archive_medicament FROM Medicament WHERE Archive_medicament=0 ORDER BY Libelle_medicament ASC;";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                idMedicament = Int32.Parse(monReader["Id_medicament"].ToString());
                if (monReader["Libelle_medicament"] == DBNull.Value)
                {
                    libelleMedicament = default(string);
                }
                else
                {
                    libelleMedicament = monReader["Libelle_medicament"].ToString();
                }

                if (monReader["Archive_medicament"] == DBNull.Value)
                {
                    archiveMedicament = default(bool);
                }
                else
                {
                    string arcMedic = monReader["Archive_medicament"].ToString();
                    bool.TryParse(arcMedic, out archiveMedicament);
                }

                unMedicament = new Medicament(idMedicament, libelleMedicament, archiveMedicament);
                lesMedicaments.Add(unMedicament);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesMedicaments;
        }
        public static List<Medicament> GetListeMedicamentsDesarchiv()
        {
            int idMedicament;
            string libelleMedicament;
            bool archiveMedicament;

            Medicament unMedicament;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Utilisateurs
            List<Medicament> lesMedicaments = new List<Medicament>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT Id_medicament,Libelle_medicament,Archive_medicament FROM Medicament WHERE Archive_medicament=1 ORDER BY Libelle_medicament ASC;";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                idMedicament = Int32.Parse(monReader["Id_medicament"].ToString());
                if (monReader["Libelle_medicament"] == DBNull.Value)
                {
                    libelleMedicament = default(string);
                }
                else
                {
                    libelleMedicament = monReader["Libelle_medicament"].ToString();
                }

                if (monReader["Archive_medicament"] == DBNull.Value)
                {
                    archiveMedicament = default(bool);
                }
                else
                {
                    string arcMedic = monReader["Archive_medicament"].ToString();
                    bool.TryParse(arcMedic, out archiveMedicament);
                }

                unMedicament = new Medicament(idMedicament, libelleMedicament, archiveMedicament);
                lesMedicaments.Add(unMedicament);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesMedicaments;
        }
    }
}
