using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GestionInfirmerieBO; // Référence la couche BO
using GestionInfirmerieDAL;  // Référence la couche DAL
using System.Configuration;


namespace GestionInfirmerieBLL
{
        public class GestionUtilisateurs
    {
        private static GestionUtilisateurs uneGestionUtilisateurs; // objet BLL

        // Accesseur en lecture
        public static GestionUtilisateurs GetGestionUtilisateurs()
        {
            if (uneGestionUtilisateurs == null)
            {
                uneGestionUtilisateurs = new GestionUtilisateurs();
            }
            return uneGestionUtilisateurs;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBDD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetUtilisateurs() de la DAL
        public static List<Utilisateur> GetUtilisateurs()
        {
            return UtilisateurDAO.GetUtilisateurs();
        }


        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetUtilisateurs() de la DAL
        public static bool ChercherLogins(string login, string pwd)
        {
            return UtilisateurDAO.GetLogins(login,pwd);
        }

        // Méthode qui créer un nouvel objet Utilisateur à partir de son id et de son nom et qui le renvoi en l'ajoutant à la
        // BD avec la méthode AjoutUtilisateur de la DAL
        public static int CreerUtilisateur(string login, string pwd, int typeDroits)
        {
            Utilisateur ut;
            ut = new Utilisateur(login,pwd,typeDroits);
            return UtilisateurDAO.AjoutUtilisateur(ut);
        }

        // Méthode qui modifie un nouvel Utilisateur avec la méthode UpdateUtilisateur de la DAL
        public static int ModifierUtilisateur(int id, string login, string pwd, int typeDroits)
        {
            Utilisateur ut;
            ut = new Utilisateur(id, login, pwd, typeDroits);
            return UtilisateurDAO.UpdateUtilisateur(ut);
        }

        // Méthode qui supprime un Utilisateur avec la méthode DeleteUtilisateur de la DAL
        public static int SupprimerUtilisateur(int id)
        {
            return UtilisateurDAO.DeleteUtilisateur(id);
        }
    }
}
