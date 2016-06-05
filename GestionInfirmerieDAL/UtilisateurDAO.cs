using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionInfirmerieBO; // Référence la couche BO
using System.Data.SqlClient;

namespace GestionInfirmerieDAL
{
     public class UtilisateurDAO
    {
        private static UtilisateurDAO unUtilisateurDAO;

        // Accesseur en lecture, renvoi une instance
        public static UtilisateurDAO GetunUtilisateurDAO()
        {
            if (unUtilisateurDAO == null)
            {
                unUtilisateurDAO = new UtilisateurDAO();
            }
            return unUtilisateurDAO;
        }

        public static bool GetLogins(string loginSaisie, string pwdSaisie)
        {
            bool trouve = false;
            string login;
            string pwd;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT Login_identification, Pwd_identification FROM Identification ;";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read() && trouve==false)
            {
                if (monReader["Login_identification"] == DBNull.Value)
                {
                    login = default(string);
                }
                else
                {
                    login = monReader["Login_identification"].ToString();
                }


                if (monReader["Pwd_identification"] == DBNull.Value)
                {
                    pwd = default(string);
                }
                else
                {
                    pwd = monReader["Pwd_identification"].ToString();
                }

                if (pwd == pwdSaisie && login == loginSaisie)
                {
                    trouve = true;
                }
            }
                // Fermeture de la connexion
                maConnexion.Close();
                return trouve;
                
        }



        // Cette méthode retourne une List contenant les objets Utilisateurs contenus dans la table Identification
        public static List<Utilisateur> GetUtilisateurs()
        {
            int id;
            string login;
            string pwd;
            int  typeDroits;
            Utilisateur unUtilisateur;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Utilisateurs
            List<Utilisateur> lesUtilisateurs = new List<Utilisateur>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM Identification";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["Id_identification"].ToString());
                if (monReader["Login_identification"] == DBNull.Value)
                {
                    login = default(string);
                }
                else
                {
                    login = monReader["Login_identification"].ToString();
                }

                  
                if (monReader["Pwd_identification"] == DBNull.Value)
                {
                    pwd = default(string);
                }
                else
                {
                    pwd = monReader["Pwd_identification"].ToString();
                }

                if (monReader["TypeDroits_identification"] == DBNull.Value)
                {
                    typeDroits = default(int);
                }
                else
                {
                    typeDroits = Int32.Parse(monReader["TypeDroits_identification"].ToString());
                }
                unUtilisateur = new Utilisateur(id, login,pwd,typeDroits);
                lesUtilisateurs.Add(unUtilisateur);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesUtilisateurs;
        }

        // Cette méthode insert un nouvel utilisateur passé en paramètre dans la BD
        public static int AjoutUtilisateur(Utilisateur unUtilisateur)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO Identification values('" + unUtilisateur.login + "','"+unUtilisateur.Pwd+"','"+unUtilisateur.TypeDroits+"')";

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }

        // Cette méthode modifie un utilisateur passé en paramètre dans la BD
        public static int UpdateUtilisateur(Utilisateur unUtilisateur)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE Identification SET Login_identification= '" + unUtilisateur.login + "', Pwd_identification= '" + unUtilisateur.Pwd + "',TypeDroits_identification = '" + unUtilisateur.TypeDroits + "' WHERE Id_identification = " + unUtilisateur.Id;

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }

        // Cette méthode supprime de la BD un utilisateur dont l'id est passé en paramètre
        public static int DeleteUtilisateur(int id)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM Identification WHERE Id_identification = " + id;

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nbEnr;
        }
    }
}
