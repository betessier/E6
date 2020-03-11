using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Document:Database
    {
        private string titre;
        private int durée;
        private bool enStock;
        private string commentaire;

        public Document(string titre, int durée, bool enStock, string commentaire)
        {
            this.Titre = titre;
            this.Durée = durée;
            this.enStock = enStock;
            this.commentaire = commentaire;
        }

        public string Commentaire { get => commentaire; set => commentaire = value; }
        public bool EnStock { get => enStock; set => enStock = value; }
        public int Durée { get => durée; set => durée = value; }
        public string Titre { get => titre; set => titre = value; }

        public virtual string  Afficher()
        {
            return string.Format("titre : {0}  \ndurée : {1}  \nen stock : {2}  \ncommentaire :  {3}",Titre,Durée,enStock,commentaire);
        }
    }
}
