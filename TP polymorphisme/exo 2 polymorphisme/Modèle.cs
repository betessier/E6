using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_2_polymorphisme
{
    class Modèle
    {
        private string nom;
        private double prix;
        private List<Option> optionsModèle;

        public Modèle(string nom, double prix)
        {
            this.nom = nom;
            this.prix = prix;
            optionsModèle = new List<Option>();
        }
        public double GetPrix { get { return prix; } }
        public void AddOption(Option option)
        {
            optionsModèle.Add(option);
        }
        public bool PossèdeOption(string unlibelle)
        {
            for (int i = 0; i < optionsModèle.Count; i++)
            {
                if (optionsModèle[i].GetLibelle == unlibelle)
                {
                    return true;
                }
            }

            return false;
        }
        public Option this[int index]
        {
            get { return this.optionsModèle[index]; }
        }
        public int Count { get { return this.optionsModèle.Count; } }
        public new string ToString()
        {
            string b=string.Format("Modele : {0}   Prix :  {1}",nom,GetPrix);
            for (int i = 0; i < optionsModèle.Count; i++)
            {
                b = b + string.Format("\n{0}   {1} ", optionsModèle[i].GetLibelle, optionsModèle[i].GetPrix);
            }
            return b;
        }

    }
}
