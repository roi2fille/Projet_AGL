using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratique
{
    class Agent
    {
        private int IdAgent;

        public int IdAgent1
        {
            get { return IdAgent; }
            set { IdAgent = value; }
        }
        private string Nom;

        public string Nom1
        {
            get { return Nom; }
            set { Nom = value; }
        }
        private string postnom;

        public string Postnom
        {
            get { return postnom; }
            set { postnom = value; }
        }
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        private char genre;

        public char Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        private string grade;

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        private string telephone;

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        //constructeur initial
        public Agent()
        {

        }
        //constructeur de suppression
        public Agent(int id)
        {
            this.IdAgent = id;
        }
        //constructeur de modification et enregistrement
        public Agent(int id, string n, string postnom, string pre, char g, string gr, string telephone)
        {
            this.IdAgent = id;
            this.Nom = n;
            this.postnom = postnom;
            this.prenom = pre;
            this.genre = g;
            this.grade = gr;
            this.telephone = telephone;

        }
    }
}
