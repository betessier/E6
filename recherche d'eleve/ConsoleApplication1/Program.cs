using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] eleves = new string[6] { "albert", "barnabé", "barth", "lisa", "homere", "marge" };
            int[] notes = new int[6] {11,9,8,15,5,12};
            Console.Write("Vous voulez la note de : ");
            string nom = Console.ReadLine();
            int position = PositionEleve(nom, eleves);
            if (position == -1)
            {
                Console.WriteLine(nom + " n'existe pas ");
            }
            else
            {
                Console.WriteLine(nom + " à pour note "+notes[position]);
            }
            Console.ReadLine();
        }
        static int PositionEleve(string nom, string[] eleve)
        {
            int position = -1, i = 0;
            bool valeur = false;
            while (!valeur && i < eleve.Length)
            {
                if (eleve[i] == nom)
                {
                    position = i;
                    valeur = true;
                }
                i++;
            }

            return position;
        }

    }
}
