using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionInfirmerieBO
{
    public class Utilisateur
    {
        private int Id_identification;
        private string Login_identification;
        private string Pwd_identification;
        private int TypeDroits_identification;

        public Utilisateur(string login, string pwd,int typeDroits)
        {
            Login_identification = login;
            Pwd_identification = pwd;
            TypeDroits_identification = typeDroits;
        }

        public Utilisateur(string login, string pwd)
        {
            Login_identification = login;
            Pwd_identification = pwd;
        }

        public Utilisateur(int IdIden, string NomIden,string PwdIden, int TypeDroitsIden)
        {
            Login_identification = NomIden;
            Id_identification = IdIden;
            Pwd_identification = PwdIden;
            TypeDroits_identification = TypeDroitsIden;
        }

        public string login
        {
            get { return Login_identification; }
            set { Login_identification = value; }
        }

        public int Id
        {
            get { return Id_identification; }
            set { Id_identification = value; }
        }

        public string Pwd
        {
            get { return Pwd_identification; }
            set { Pwd_identification = value; }
        }

        public int TypeDroits
        {
            get { return TypeDroits_identification; }
            set { TypeDroits_identification = value; }
        }
    }
}
