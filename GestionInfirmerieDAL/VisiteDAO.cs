using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionInfirmerieBO; // Référence la couche BO
using System.Data.SqlClient;
namespace GestionInfirmerieDAL
{
    public class VisiteDAO
    {
        public static void AjoutVisite(Visite uneVisite)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();
            int parentsPrev = 0;
            int hopital = 0;
            int retourDom = 0;
            SqlCommand cmd = new SqlCommand();
            if (uneVisite.lesParents_Prevenus == true)
            {
                parentsPrev = 1;
            }
            if (uneVisite.uneVisite_Hopital == true)
            {
                hopital = 1;
            }
            if (uneVisite.unRetour_Domicile == true)
            {
                retourDom = 1;
            }
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO Visite(Motif_visite, Commentaire_visite, HeureArrivee_visite, HeureSortie_visite, Date_visite, ParentsPrevenus_visite, Hopital_visite, RetourDomicile_visite, Pouls_visite,Id_eleve) values('" + uneVisite.unMotif_Visite.Replace("'", "''") + "','" + uneVisite.unCommentaire_Visite.Replace("'", "''") + "','" + uneVisite.uneHeure_Arrive + "','" + uneVisite.uneHeure_Sortie + "','" + uneVisite.uneDate_Visite + "'," + parentsPrev + "," + hopital + "," + retourDom + ",'" + uneVisite.unPouls_Visite + "'," + uneVisite.unEleve_Visite.unId_eleve + ");";
            // Fermeture de la connexion
            cmd.ExecuteNonQuery();
            maConnexion.Close();
        }

        public static void modifVisite(Visite uneVisite)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();
            int parentsPrev = 0;
            int hopital = 0;
            int retourDom = 0;
            SqlCommand cmd = new SqlCommand();
            if (uneVisite.lesParents_Prevenus == true)
            {
                parentsPrev = 1;
            }
            if (uneVisite.uneVisite_Hopital == true)
            {
                hopital = 1;
            }
            if (uneVisite.unRetour_Domicile == true)
            {
                retourDom = 1;
            }
            cmd.Connection = maConnexion;
            cmd.CommandText = "Update Visite SET Motif_visite='" + uneVisite.unMotif_Visite.Replace("'", "''") + "', Commentaire_visite='" + uneVisite.unCommentaire_Visite.Replace("'", "''") + "', HeureArrivee_visite='" + uneVisite.uneHeure_Arrive + "', HeureSortie_visite='" + uneVisite.uneHeure_Sortie + "', Date_visite='" + uneVisite.uneDate_Visite + "', ParentsPrevenus_visite=" + parentsPrev + ", Hopital_visite=" + hopital + ", RetourDomicile_visite=" + retourDom + ", Pouls_visite='" + uneVisite.unPouls_Visite + "' where Id_visite=" + uneVisite.unId_Visite + " ;";
            // Fermeture de la connexion
            cmd.ExecuteNonQuery();
            maConnexion.Close();
        }

        public static List<Visite> ToutesLesVisites()
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();
            string dateVisite;
            string nomEleve;
            string prenomEleve;
            string libelleClasse;
            int idClasse;
            int idEleve;
            int idVisite;
            Eleve unEleve;
            Classe uneClasse;
            Visite uneVisite;

            List<Visite> lesVisites = new List<Visite>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "Select top 18* From Visite, Eleve left outer join Classe on Eleve.Id_classe=Classe.Id_classe where Eleve.Id_eleve=Visite.Id_eleve Order By Visite.Date_visite DESC;";
            // Fermeture de la connexion
            SqlDataReader monReader = cmd.ExecuteReader();


            // Remplissage de la liste
            while (monReader.Read())
            {
                idClasse = Int32.Parse(monReader["Id_classe"].ToString());
                idEleve= Int32.Parse(monReader["Id_eleve"].ToString());
                idVisite = Int32.Parse(monReader["Id_visite"].ToString());
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

                if (monReader["Date_visite"] == DBNull.Value)
                {
                    dateVisite = default(string);
                }
                else
                {
                    dateVisite = monReader["Date_visite"].ToString();
                }
                uneClasse = new Classe(idClasse, libelleClasse);
                unEleve = new Eleve(idEleve,nomEleve, prenomEleve, uneClasse);
                uneVisite = new Visite(idVisite, dateVisite, unEleve);
                lesVisites.Add(uneVisite);
            }


            maConnexion.Close();
            return lesVisites;
        }

        //Cette méthode retourne un élève dans la BD
        public static Visite InfoVisite(int idVisite)
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
            int idEleve;
            string libelleClasse;

            string motifVisite;
            string commentaireVisite;
            string heureArrivéVisite;
            string heureSortieVisite;
            string dateVisite;
            bool parentsPrevenu;
            bool hopitalVisite;
            bool retourDomicile;
            string poulsVisite;
            Visite uneVisite;



            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "Select *   From Visite, Eleve, Classe Where Visite.Id_eleve=Eleve.Id_eleve And Classe.Id_classe=Eleve.Id_classe AND Id_visite=" + idVisite + " ;";


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



                if (monReader["Motif_visite"] == DBNull.Value)
                {
                    motifVisite = default(string);
                }
                else
                {
                    motifVisite = monReader["Motif_visite"].ToString();
                }

                if (monReader["Commentaire_visite"] == DBNull.Value)
                {
                    commentaireVisite = default(string);
                }
                else
                {
                    commentaireVisite = monReader["Commentaire_visite"].ToString();
                }

                if (monReader["HeureArrivee_visite"] == DBNull.Value)
                {
                    heureArrivéVisite = default(string);
                }
                else
                {
                    heureArrivéVisite = String.Format("{0:t}", monReader["HeureArrivee_visite"]);
                }

                if (monReader["HeureSortie_visite"] == DBNull.Value)
                {
                    heureSortieVisite = default(string);
                }
                else
                {
                    heureSortieVisite = String.Format("{0:t}", monReader["HeureSortie_visite"]);
                } 	

                if (monReader["Date_visite"] == DBNull.Value)
                {
                    dateVisite = default(string);
                }
                else
                {
                    dateVisite = String.Format("{0:dd/MM/yyyy}", monReader["Date_visite"]);
                }

                if (monReader["ParentsPrevenus_visite"] == DBNull.Value)
                {
                    parentsPrevenu = default(bool);
                }
                else
                {
                    string parentsPrev = monReader["ParentsPrevenus_visite"].ToString();
                    bool.TryParse(parentsPrev, out parentsPrevenu);
                }

                if (monReader["Hopital_visite"] == DBNull.Value)
                {
                    hopitalVisite = default(bool);
                }
                else
                {
                    string hopitalVis = monReader["Hopital_visite"].ToString();
                    bool.TryParse(hopitalVis, out hopitalVisite);
                }

                if (monReader["RetourDomicile_visite"] == DBNull.Value)
                {
                    retourDomicile = default(bool);
                }
                else
                {
                    string retourDom = monReader["RetourDomicile_visite"].ToString();
                    bool.TryParse(retourDom, out retourDomicile);
                }

                if (monReader["Pouls_visite"] == DBNull.Value)
                {
                    poulsVisite = default(string);
                }
                else
                {
                    poulsVisite = monReader["Pouls_visite"].ToString();
                }
                Classe uneClasse;
                Eleve unEleve;
                uneClasse = new Classe(idClasse, libelleClasse);
                unEleve = new Eleve(idEleve, nomEleve, prenomEleve, dateNaiEleve, santeEleve, telEleve, telMereEleve, telPereEleve, archivEleve, tiersTempsEleve, uneClasse);
                uneVisite = new Visite(idVisite, motifVisite, commentaireVisite, heureArrivéVisite, heureSortieVisite, dateVisite, parentsPrevenu, hopitalVisite, retourDomicile, poulsVisite, unEleve);
                maConnexion.Close();
                return uneVisite;

            }
            // Fermeture de la connexion

            maConnexion.Close();


            return null;

        }

        //Cette méthode retourne un élève dans la BD
        public static Visite InfoDerniereVisite()
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
            int idEleve;
            int idVisite;
            string libelleClasse;

            string motifVisite;
            string commentaireVisite;
            string heureArrivéVisite;
            string heureSortieVisite;
            string dateVisite;
            bool parentsPrevenu;
            bool hopitalVisite;
            bool retourDomicile;
            string poulsVisite;
            Visite uneVisite;



            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBDD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "Select TOP 1 *  From Visite, Eleve, Classe Where Visite.Id_eleve=Eleve.Id_eleve And Classe.Id_classe=Eleve.Id_classe order by Visite.Id_visite desc;";


            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {

                idClasse = Int32.Parse(monReader["Id_classe"].ToString());
                idEleve = Int32.Parse(monReader["Id_eleve"].ToString());
                idVisite = Int32.Parse(monReader["Id_Visite"].ToString());
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



                if (monReader["Motif_visite"] == DBNull.Value)
                {
                    motifVisite = default(string);
                }
                else
                {
                    motifVisite = monReader["Motif_visite"].ToString();
                }

                if (monReader["Commentaire_visite"] == DBNull.Value)
                {
                    commentaireVisite = default(string);
                }
                else
                {
                    commentaireVisite = monReader["Commentaire_visite"].ToString();
                }

                if (monReader["HeureArrivee_visite"] == DBNull.Value)
                {
                    heureArrivéVisite = default(string);
                }
                else
                {
                    heureArrivéVisite = String.Format("{0:t}", monReader["HeureArrivee_visite"]);
                }

                if (monReader["HeureSortie_visite"] == DBNull.Value)
                {
                    heureSortieVisite = default(string);
                }
                else
                {
                    heureSortieVisite = String.Format("{0:t}", monReader["HeureSortie_visite"]);
                }

                if (monReader["Date_visite"] == DBNull.Value)
                {
                    dateVisite = default(string);
                }
                else
                {
                    dateVisite = String.Format("{0:dd/MM/yyyy}", monReader["Date_visite"]);
                }

                if (monReader["ParentsPrevenus_visite"] == DBNull.Value)
                {
                    parentsPrevenu = default(bool);
                }
                else
                {
                    string parentsPrev = monReader["ParentsPrevenus_visite"].ToString();
                    bool.TryParse(parentsPrev, out parentsPrevenu);
                }

                if (monReader["Hopital_visite"] == DBNull.Value)
                {
                    hopitalVisite = default(bool);
                }
                else
                {
                    string hopitalVis = monReader["Hopital_visite"].ToString();
                    bool.TryParse(hopitalVis, out hopitalVisite);
                }

                if (monReader["RetourDomicile_visite"] == DBNull.Value)
                {
                    retourDomicile = default(bool);
                }
                else
                {
                    string retourDom = monReader["RetourDomicile_visite"].ToString();
                    bool.TryParse(retourDom, out retourDomicile);
                }

                if (monReader["Pouls_visite"] == DBNull.Value)
                {
                    poulsVisite = default(string);
                }
                else
                {
                    poulsVisite = monReader["Pouls_visite"].ToString();
                }
                Classe uneClasse;
                Eleve unEleve;
                uneClasse = new Classe(idClasse, libelleClasse);
                unEleve = new Eleve(idEleve, nomEleve, prenomEleve, dateNaiEleve, santeEleve, telEleve, telMereEleve, telPereEleve, archivEleve, tiersTempsEleve, uneClasse);
                uneVisite = new Visite(idVisite, motifVisite, commentaireVisite, heureArrivéVisite, heureSortieVisite, dateVisite, parentsPrevenu, hopitalVisite, retourDomicile, poulsVisite, unEleve);
                maConnexion.Close();
                return uneVisite;

            }
            // Fermeture de la connexion

            maConnexion.Close();


            return null;

        }
    }
}
