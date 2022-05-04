using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratique
{
    class Article
    {
        //declaration des attributs
        private string IdArt;

        public string IdArt1
        {
            get { return IdArt; }
            set { IdArt = value; }
        }
        private string DesArt;

        public string DesArt1
        {
            get { return DesArt; }
            set { DesArt = value; }
        }
        private float PrixArt;

        public float PrixArt1
        {
            get { return PrixArt; }
            set { PrixArt = value; }
        }
        //constructeur

        public Article()
        {

        }
        //constructeur de modification et enregistrement
        public Article(string id, string des, float p)
        {
            this.IdArt = id;
            this.DesArt = des;
            this.PrixArt = p;
        }


    }
}
