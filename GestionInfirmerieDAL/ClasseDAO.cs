using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionInfirmerieBO; // Référence la couche BO
using System.Data.SqlClient;

namespace GestionInfirmerieDAL
{
    public class ClasseDAO
    {
        //Cette méthode  va cherche la classe d'un eleve dans la BD
        public static int IdClasseEleve(int unId)
        {

            int idClasse=0;


            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "Select Classe.Id_classe, Libelle_classe, LienEdt_classe  From Classe,Eleve Where Id_eleve=" + unId + " AND Classe.Id_classe=Eleve.ID_classe ";

            SqlDataReader monReader = cmd.ExecuteReader();
            while (monReader.Read())
            {
                idClasse = Int32.Parse(monReader["Id_classe"].ToString());

            }
            // Fermeture de la connexion
            maConnexion.Close();

            return idClasse;
        }
        //Cette méthode  va cherche la classe d'un eleve dans la BD
        public static string EdtEleve(int unId)
        {

            string libelleEdt=""; 


            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "Select Classe.Id_classe, Libelle_classe, LienEdt_classe  From Classe,Eleve Where Id_eleve="+unId+" AND Classe.Id_classe=Eleve.ID_classe ";

            SqlDataReader monReader = cmd.ExecuteReader();
            while (monReader.Read())
            {
                if (monReader["LienEdt_classe"] == DBNull.Value)
                {
                        libelleEdt = default(string);
                }
                else
                {
                        libelleEdt = monReader["LienEdt_classe"].ToString();
                }

            }
            // Fermeture de la connexion
            maConnexion.Close();

            return libelleEdt;
        }
        //Cette méthode  va chercher toutes les classes dans la BD
        public static void ToutesLesClassesEDT()
        {




            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "Select Id_classe, Libelle_classe, LienEdt_classe  From Classe ";




            // Fermeture de la connexion
            maConnexion.Close();

        }
        //Cette méthode  va chercher toutes les classes dans la BD
        public static List<Classe> ListeDesClasses()
        {
            int idClasse;
            string libelleClasse; 
            Classe uneClasse;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Utilisateurs
            List<Classe> lesClasses = new List<Classe>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "Select Id_classe, Libelle_classe  From Classe ";

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

                uneClasse = new Classe(idClasse, libelleClasse);
                lesClasses.Add(uneClasse);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesClasses;
        }
        public static void AjoutClasse(Classe uneClasse)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "INSERT INTO Classe(Libelle_classe, LienEdt_classe) values('" + uneClasse.unLibelle_classe.Replace("'", "''") + "','" + uneClasse.unLienEdt_classe.Replace("'", "''") + "');";
            // Fermeture de la connexion
            cmd.ExecuteNonQuery();
            maConnexion.Close();
        }
        public static void ModifClasse(Classe uneClasse)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "UPDATE Classe SET Libelle_classe='" + uneClasse.unLibelle_classe.Replace("'", "''") + "', LienEdt_classe='" + uneClasse.unLienEdt_classe.Replace("'", "''") + "' Where Id_Classe=" + uneClasse.unId_classe + ";";
            // Fermeture de la connexion
            cmd.ExecuteNonQuery();
            maConnexion.Close();

        }
        public static void SupprimeClasse(int id)
        {
            //Connexion à la BDD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE Classe Where Id_Classe = " + id + " ;";
            // Fermeture de la connexion
            cmd.ExecuteNonQuery();
            maConnexion.Close();
        }
        public static string EdtClasse(string nom)
        {

            string libelleEdt = "";


            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "Select Classe.Id_classe, Libelle_classe, LienEdt_classe  From Classe Where Nom_classe=" + nom ;

            SqlDataReader monReader = cmd.ExecuteReader();
            while (monReader.Read())
            {
                if (monReader["LienEdt_classe"] == DBNull.Value)
                {
                    libelleEdt = default(string);
                }
                else
                {
                    libelleEdt = monReader["LienEdt_classe"].ToString();
                }

            }
            // Fermeture de la connexion
            maConnexion.Close();

            return libelleEdt;
        }
        public static Classe infoClasse(int id)
        {

            string libelleEdt = "";
            string libelleClasse = "";
            Classe uneClasse;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "Select Classe.Id_classe, Libelle_classe, LienEdt_classe  From Classe Where Id_classe=" + id ;

            SqlDataReader monReader = cmd.ExecuteReader();
            while (monReader.Read())
            {
                if (monReader["LienEdt_classe"] == DBNull.Value)
                {
                    libelleEdt = default(string);
                }
                else
                {
                    libelleEdt = monReader["LienEdt_classe"].ToString();
                }

                if (monReader["Libelle_classe"] == DBNull.Value)
                {
                    libelleClasse = default(string);
                }
                else
                {
                    libelleClasse = monReader["Libelle_classe"].ToString();
                }
            }
            

            uneClasse = new Classe(id , libelleClasse ,libelleEdt);
            // Fermeture de la connexion
            maConnexion.Close();

            return uneClasse;
        }
        public static bool ClasseSupprimable(Classe uneClasse)
        {

            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT Id_eleve FROM Classe, Eleve where Eleve.Id_classe = '" + uneClasse.unId_classe + "' And Classe.Id_classe = Eleve.Id_eleve ;";
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
        public static void DeleteClasse(Classe uneClasse)
        {
            //Connexion à la BDD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE CLASSE WHERE Id_classe = '" + uneClasse.unId_classe + "';";
            // Fermeture de la connexion
            cmd.ExecuteNonQuery();
            maConnexion.Close();
        }
        public static List<Eleve> GetListeEleve(int id)
        {
            Eleve unEleve;
            Classe uneClasse;

            int idEleve;
            string nomEleve;
            string prenomEleve;
            string dateDeNaissance;
            string santeEleve;
            string numTel;
            string numTelPere;
            string numTelMere;
            string tiersTemps;
            string idClasse;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Utilisateurs
            List<Eleve> lesEleves = new List<Eleve>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " Select * From classe where idClasse="+id+";";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
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
                    numTel = default(string);
                }
                else
                {
                    numTel = monReader["Tel_eleve"].ToString();
                }
                if (monReader["TelPere_eleve"] == DBNull.Value)
                {
                    numTelPere = default(string);
                }
                else
                {
                    numTelPere = monReader["TelPere_eleve"].ToString();
                }
                if (monReader["TelMere_eleve"] == DBNull.Value)
                {
                    numTelMere = default(string);
                }
                else
                {
                    numTelMere = monReader["TelMere_eleve"].ToString();
                }
                if (monReader["Id_classe"] == DBNull.Value)
                {
                    idClasse = default(string);
                }
                else
                {
                    idClasse = monReader["Id_classe"].ToString();
                }
                if (monReader["DateNaissance_eleve"] == DBNull.Value)
                {
                    dateDeNaissance = default(string);
                }
                else
                {
                    dateDeNaissance = monReader["DateNaissance_eleve"].ToString();
                }


                //unELeve = new Eleve(idEleve, nomEleve, prenomEleve,dateDeNaissance, santeEleve, numTel, numTelPere, numTelMere, 0,tiersTemps, idClasse);
                //lesEleves.Add(unELeve);
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesEleves ;
        }
    }
}
