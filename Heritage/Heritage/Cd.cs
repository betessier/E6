using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Cd:Document
    {
        private string artiste;
        private int nombrePiste;

        public Cd(string artiste,int nombrePiste, string titre, int durée, bool enStock, string commentaire) : base(titre, durée, enStock, commentaire)
        {
            this.artiste = artiste;
            this.nombrePiste = nombrePiste;
        }
        public override string  Afficher()
        {
            return string.Format("titre : {0}  \ndurée : {1}  \nen stock : {2}  \ncommentaire :  {3}  \nartiste : {4} \nnombre de piste  : {5}", Titre, Durée, EnStock, Commentaire,artiste,nombrePiste);
        }
    }
}
