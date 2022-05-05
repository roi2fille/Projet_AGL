using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratique
{
    class Client
    {
        private string IdCl;

        public string IdCl1
        {
            get { return IdCl; }
            set { IdCl = value; }
        }
        private string NomCl;

        public string NomCl1
        {
            get { return NomCl; }
            set { NomCl = value; }
        }
        private string EmailCl;

        public string EmailCl1
        {
            get { return EmailCl; }
            set { EmailCl = value; }
        }
        private string PhoneCl;

        public string PhoneCl1
        {
            get { return PhoneCl; }
            set { PhoneCl = value; }
        }
        //constructeur initial
        public Client()
        {

        }
        //constructeur de modification
        public Client(string id, string nom, string email, string phone) 
        {
            this.IdCl = id;
            this.NomCl = nom;
            this.EmailCl = email;
            this.PhoneCl = phone;
        }
        //constructeur de suppression
        public Client(string id)
        {
            this.IdCl = id;
        }
    }
}
