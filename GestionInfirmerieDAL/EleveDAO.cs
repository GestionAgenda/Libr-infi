using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionInfirmerieBO; // Référence la couche BO
using System.Data.SqlClient;

namespace GestionInfirmerieDAL
{
    public class EleveDAO
    {
        private static EleveDAO unEleveDAO;

        // Accesseur en lecture, renvoi une instance
        public static EleveDAO GetunEleveDAO()
        {
            if (unEleveDAO == null)
            {
                unEleveDAO = new EleveDAO();
            }
            return unEleveDAO;
        }


        // Cette méthode retourne une List contenant les objets Eleves contenus dans la table Identification
        public static List<Eleve> GetListeElevesSaisies(string nomPrenom)
        {
            string nomEleve;
            string prenomEleve;
            string libelleClasse;
            int idClasse;

            Eleve unEleve;
            Classe uneClasse;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Utilisateurs
            List<Eleve> lesEleves = new List<Eleve>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " Select top 18* From Eleve left outer join Classe on eleve.Id_classe=Classe.Id_classe where Eleve.Nom_eleve LIKE '%" + nomPrenom + "%' OR Eleve.Prenom_eleve LIKE '%" + nomPrenom + "%' Order By Eleve.Nom_eleve ASC 	;";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                idClasse = Int32.Parse(monReader["Id_classe"].ToString());
                if (monReader["Libelle_classe"] == DBNull.Value)
                {
                    libelleClasse = default(string);
                }
                else
                {
                    libelleClasse = monReader["Libelle_classe"].ToString();
                }

                if (monReader["Nom_eleve"] == DBNull.Value)
                {
                    nomEleve = default(string);
                }
                else
                {
                    nomEleve = monReader["Nom_eleve"].ToString();
                }

                if (monReader["Prenom_eleve"] == DBNull.Value)
                {
                    prenomEleve = default(string);
                }
                else
                {
                    prenomEleve = monReader["Prenom_eleve"].ToString();
                }
                uneClasse = new Classe(idClasse, libelleClasse);
                unEleve = new Eleve(nomEleve, prenomEleve, uneClasse);
                lesEleves.Add(unEleve);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesEleves;
        }

      
        // Cette méthode retourne une List contenant les objets Eleves contenus dans la table Identification
        public static List<Eleve> GetListeEleves()
        {
            string nomEleve;
            string prenomEleve;
            string libelleClasse;
            int idClasse;
            int idEleve;

            Eleve unEleve;
            Classe uneClasse;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Utilisateurs
            List<Eleve> lesEleves = new List<Eleve>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT TOP 18 Eleve.Id_classe,Eleve.Id_eleve, Libelle_classe,Nom_eleve,Prenom_eleve FROM Eleve,Classe where Eleve.Id_classe=Classe.Id_classe ORDER BY Nom_eleve ASC;";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                idClasse = Int32.Parse(monReader["Id_classe"].ToString());
                idEleve = Int32.Parse(monReader["Id_eleve"].ToString());
                if (monReader["Libelle_classe"] == DBNull.Value)
                {
                    libelleClasse = default(string);
                }
                else
                {
                    libelleClasse = monReader["Libelle_classe"].ToString();
                }

                if (monReader["Nom_eleve"] == DBNull.Value)
                {
                    nomEleve = default(string);
                }
                else
                {
                    nomEleve = monReader["Nom_eleve"].ToString();
                }

                if (monReader["Prenom_eleve"] == DBNull.Value)
                {
                    prenomEleve = default(string);
                }
                else
                {
                    prenomEleve = monReader["Prenom_eleve"].ToString();
                }
                uneClasse = new Classe(idClasse, libelleClasse);
                unEleve = new Eleve(idEleve,nomEleve, prenomEleve,uneClasse);
                lesEleves.Add(unEleve);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesEleves;
        }


        // Cette méthode retourne une List contenant les objets Eleves contenus dans la table Identification
        public static List<Eleve> GetToutEleves()
        {
            int idEleve;
            string nomEleve;
            string prenomEleve;
            string dateNaiEleve;
            string santeEleve;
            string telEleve;
            string telPereEleve;
            string telMereEleve;
            bool archivEleve;
            bool tiersTempsEleve;
            int idClasse;


            Eleve unEleve;
            Classe uneClasse;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Utilisateurs
            List<Eleve> lesEleves = new List<Eleve>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT TOP 18 * FROM Eleve,Classe where Eleve.Id_classe=Classe.Id_classe ORDER BY Nom_eleve ASC;";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {

                idClasse = Int32.Parse(monReader["Id_classe"].ToString());

                idEleve = Int32.Parse(monReader["Id_eleve"].ToString());
                if (monReader["Nom_eleve"] == DBNull.Value)
                {
                    nomEleve = default(string);
                }
                else
                {
                    nomEleve = monReader["Nom_eleve"].ToString();
                }


                if (monReader["Prenom_eleve"] == DBNull.Value)
                {
                    prenomEleve = default(string);
                }
                else
                {
                    prenomEleve = monReader["Prenom_eleve"].ToString();
                }

                if (monReader["DateNaissance_eleve"] == DBNull.Value)
                {
                    dateNaiEleve = default(string);
                }
                else
                {
                    dateNaiEleve = (monReader["DateNaissance_eleve"].ToString());
                }

                if (monReader["Sante_eleve"] == DBNull.Value)
                {
                    santeEleve = default(string);
                }
                else
                {
                    santeEleve = monReader["Sante_eleve"].ToString();
                }

                if (monReader["Tel_eleve"] == DBNull.Value)
                {
                    telEleve = default(string);
                }
                else
                {
                    telEleve = monReader["Tel_eleve"].ToString();
                }

                if (monReader["TelPere_eleve"] == DBNull.Value)
                {
                    telPereEleve = default(string);
                }
                else
                {
                    telPereEleve = monReader["TelPere_eleve"].ToString();
                }

                if (monReader["TelMere_eleve"] == DBNull.Value)
                {
                    telMereEleve = default(string);
                }
                else
                {
                    telMereEleve = monReader["Archive_eleve"].ToString();
                }

                if (monReader["Archive_eleve"] == DBNull.Value)
                {
                    archivEleve = default(bool);
                }
                else
                {
                    string arcEleve = monReader["Archive_eleve"].ToString();
                    bool.TryParse(arcEleve, out archivEleve);
                }

                if (monReader["Archive_eleve"] == DBNull.Value)
                {
                    tiersTempsEleve = default(bool);
                }
                else
                {
                    string tieTemEleve = monReader["TelMere_eleve"].ToString();
                    bool.TryParse(tieTemEleve, out tiersTempsEleve);
                }

                uneClasse = new Classe(idClasse);
                unEleve = new Eleve(idEleve, nomEleve, prenomEleve, dateNaiEleve, santeEleve, telEleve, telPereEleve, telMereEleve, archivEleve, tiersTempsEleve, uneClasse);
                lesEleves.Add(unEleve);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesEleves;
        }



        // Cette méthode retourne une List contenant les objets Eleves contenus dans la table Identification
        public static List<Eleve> GetToutElevesSaisies(string nomPrenom)
        {
            int idEleve;
            string nomEleve;
            string prenomEleve;
            string dateNaiEleve;
            string santeEleve;
            string telEleve;
            string telPereEleve;
            string telMereEleve;
            bool archivEleve;
            bool tiersTempsEleve;
            int idClasse;


            Eleve unEleve;
            Classe uneClasse;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Utilisateurs
            List<Eleve> lesEleves = new List<Eleve>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " Select top 18* From eleve left outer join classe on eleve.Id_classe=classe.Id_classe where eleve.Nom_eleve LIKE '%" + nomPrenom + "%' OR eleve.Prenom_eleve LIKE '%" + nomPrenom + "%'Order By eleve.Nom_eleve ASC 	;";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {

                idClasse = Int32.Parse(monReader["Id_classe"].ToString());

                idEleve = Int32.Parse(monReader["Id_eleve"].ToString());
                if (monReader["Nom_eleve"] == DBNull.Value)
                {
                    nomEleve = default(string);
                }
                else
                {
                    nomEleve = monReader["Nom_eleve"].ToString();
                }


                if (monReader["Prenom_eleve"] == DBNull.Value)
                {
                    prenomEleve = default(string);
                }
                else
                {
                    prenomEleve = monReader["Prenom_eleve"].ToString();
                }

                if (monReader["DateNaissance_eleve"] == DBNull.Value)
                {
                    dateNaiEleve = default(string);
                }
                else
                {
                    dateNaiEleve = (monReader["DateNaissance_eleve"].ToString());
                }

                if (monReader["Sante_eleve"] == DBNull.Value)
                {
                    santeEleve = default(string);
                }
                else
                {
                    santeEleve = monReader["Sante_eleve"].ToString();
                }

                if (monReader["Tel_eleve"] == DBNull.Value)
                {
                    telEleve = default(string);
                }
                else
                {
                    telEleve = monReader["Tel_eleve"].ToString();
                }

                if (monReader["TelPere_eleve"] == DBNull.Value)
                {
                    telPereEleve = default(string);
                }
                else
                {
                    telPereEleve = monReader["TelPere_eleve"].ToString();
                }

                if (monReader["TelMere_eleve"] == DBNull.Value)
                {
                    telMereEleve = default(string);
                }
                else
                {
                    telMereEleve = monReader["Archive_eleve"].ToString();
                }

                if (monReader["Archive_eleve"] == DBNull.Value)
                {
                    archivEleve = default(bool);
                }
                else
                {
                    string arcEleve = monReader["Archive_eleve"].ToString();
                    bool.TryParse(arcEleve, out archivEleve);
                }

                if (monReader["Archive_eleve"] == DBNull.Value)
                {
                    tiersTempsEleve = default(bool);
                }
                else
                {
                    string tieTemEleve = monReader["TelMere_eleve"].ToString();
                    bool.TryParse(tieTemEleve, out tiersTempsEleve);
                }
                uneClasse = new Classe(idClasse);
                unEleve = new Eleve(idEleve, nomEleve, prenomEleve, dateNaiEleve, santeEleve, telEleve, telPereEleve, telMereEleve, archivEleve, tiersTempsEleve, uneClasse);
                lesEleves.Add(unEleve);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesEleves;
        }

        //Cette méthode retourne un élève dans la BD
        public static Eleve InfoEleve(int idEleve)
        {
            string nomEleve;
            string prenomEleve;
            string dateNaiEleve;
            string santeEleve;
            string telEleve;
            string telPereEleve;
            string telMereEleve;
            bool archivEleve;
            bool tiersTempsEleve;
            int idClasse;
            string libelleClasse;



            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "Select Eleve.Id_classe, Classe.Libelle_Classe,Eleve.Id_eleve, Eleve.Nom_eleve, Eleve.Prenom_eleve, Eleve.DateNaissance_eleve, Eleve.Sante_eleve, Eleve.Tel_eleve, Eleve.TelPere_eleve, Eleve.TelMere_eleve, Eleve.Archive_eleve, Eleve.TiersTemps_eleve   From Eleve, Classe Where Classe.Id_classe=Eleve.Id_classe AND Id_eleve=" + idEleve + " ;";


            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
            
                idClasse = Int32.Parse(monReader["Id_classe"].ToString());
                idEleve = Int32.Parse(monReader["Id_eleve"].ToString());
                if (monReader["Nom_eleve"] == DBNull.Value)
                {
                    nomEleve = default(string);
                }
                else
                {
                    nomEleve = monReader["Nom_eleve"].ToString();
                }

                if (monReader["Libelle_classe"] == DBNull.Value)
                {
                    libelleClasse = default(string);
                }
                else
                {
                    libelleClasse = monReader["Libelle_classe"].ToString();
                }

                if (monReader["Prenom_eleve"] == DBNull.Value)
                {
                    prenomEleve = default(string);
                }
                else
                {
                    prenomEleve = monReader["Prenom_eleve"].ToString();
                }

                if (monReader["DateNaissance_eleve"] == DBNull.Value)
                {
                    dateNaiEleve = default(string);
                }
                else
                {
                    dateNaiEleve = (monReader["DateNaissance_eleve"].ToString());
                }

                if (monReader["Sante_eleve"] == DBNull.Value)
                {
                    santeEleve = default(string);
                }
                else
                {
                    santeEleve = monReader["Sante_eleve"].ToString();
                }

                if (monReader["Tel_eleve"] == DBNull.Value)
                {
                    telEleve = default(string);
                }
                else
                {
                    telEleve = monReader["Tel_eleve"].ToString();
                }

                if (monReader["TelPere_eleve"] == DBNull.Value)
                {
                    telPereEleve = default(string);
                }
                else
                {
                    telPereEleve = monReader["TelPere_eleve"].ToString();
                }

                if (monReader["TelMere_eleve"] == DBNull.Value)
                {
                    telMereEleve = default(string);
                }
                else
                {
                    telMereEleve = monReader["TelMere_eleve"].ToString();
                }

                if (monReader["Archive_eleve"] == DBNull.Value)
                {
                    archivEleve = default(bool);
                }
                else
                {
                    string arcEleve = monReader["Archive_eleve"].ToString();
                    bool.TryParse(arcEleve, out archivEleve);
                }

                if (monReader["TiersTemps_eleve"] == DBNull.Value)
                {
                    tiersTempsEleve = default(bool);
                }
                else
                {
                    string tieTemEleve = monReader["TiersTemps_eleve"].ToString();
                    bool.TryParse(tieTemEleve, out tiersTempsEleve);
                }
                Classe uneClasse;
                Eleve unEleve;
                uneClasse = new Classe(idClasse,libelleClasse);
                unEleve = new Eleve(idEleve, nomEleve, prenomEleve, dateNaiEleve,santeEleve,telEleve,telMereEleve,telPereEleve,archivEleve,tiersTempsEleve,uneClasse);
                maConnexion.Close();
                return unEleve;
                
            }
            // Fermeture de la connexion

            maConnexion.Close();
                

                return null;

    }


        //Cette méthode modfie un élève dans la BD
        public static void ModifieEleve(Eleve unEleve)
        {


            int tiersTemps = 0;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();
            if (unEleve.unTiers_Temps == true)
            {
                tiersTemps = 1;
            }
            else
            {
                tiersTemps = 0;
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE Eleve SET Nom_eleve='" + unEleve.unNom_eleve.Replace("'", "''") + "', Prenom_eleve='" + unEleve.unPrenom_eleve.Replace("'", "''") + "', DateNaissance_eleve='" + unEleve.uneDateNaissance_eleve + "',TiersTemps_eleve=" + tiersTemps + ", Sante_eleve='" + unEleve.uneSante_eleve.Replace("'", "''") + "', Tel_eleve='" + unEleve.unTel_eleve + "',TelPere_eleve='" + unEleve.unTel_Pere_eleve + "',TelMere_eleve='" + unEleve.unTel_Mere_eleve + "', Id_classe=" + unEleve.UneClasse.unId_classe + " Where Id_eleve=" + unEleve.unId_eleve + ";";


            cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();
            
        }

        //Cette méthode ajoute un élève dans la BD
        public static void AjoutEleve(Eleve unEleve)
        {

            int tierstemps;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            if (unEleve.unTiers_Temps == true)
            {
               tierstemps = 1;
            }
            else
            {
               tierstemps = 0;
            }
            cmd.CommandText = "INSERT INTO Eleve(Nom_eleve, Prenom_eleve, DateNaissance_eleve, Sante_eleve, TiersTemps_eleve, Tel_eleve, TelPere_eleve, TelMere_eleve, Archive_eleve, Id_classe) values('" + unEleve.unNom_eleve.Replace("'", "''") + "','" + unEleve.unPrenom_eleve.Replace("'", "''") + "','" + unEleve.uneDateNaissance_eleve + "','" + unEleve.uneSante_eleve.Replace("'", "''") + "'," + tierstemps + ",'" + unEleve.unTel_eleve + "','" + unEleve.unTel_Pere_eleve + "','" + unEleve.unTel_Mere_eleve + "',0," + unEleve.UneClasse.unId_classe + ");";
            //cmd.CommandText = "INSERT INTO Eleve(Nom_eleve, Prenom_eleve, DateNaissance_eleve, Sante_eleve, TiersTemps_eleve, Tel_eleve, TelPere_eleve, TelMere_eleve, Archive_eleve, Id_classe) values('cc','c','cc','cc',1,'cc','c','cc',0,1);";
            // Fermeture de la connexion
            cmd.ExecuteNonQuery();
            maConnexion.Close();


        }

        public static void SupprimEleve(int id)
        {
            //Connexion à la BDD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE Eleve Where Id_Eleve = "+id+" ;";
            // Fermeture de la connexion
            cmd.ExecuteNonQuery();
            maConnexion.Close();
        }

        public static bool EleveSupprimable(int idEleve)
        {
            //Connexion à la BDD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM Visite, Eleve where Eleve.Id_eleve = " + idEleve + " And Eleve.Id_eleve = Visite.Id_eleve ;";
            cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            SqlDataReader monReader = cmd.ExecuteReader();
            if (monReader.HasRows == false)
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
    }
}
