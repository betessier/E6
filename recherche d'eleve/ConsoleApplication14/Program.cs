using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14 {
    class Program {
        static void Main(string[] args) {
            string[] eleves = new string[6] { "albert", "barnabé", "barth", "lisa", "homere", "marge" };
            Console.Write("Quel est le prénom à rechercher : ");
            string nom = Console.ReadLine();
            int position = PositionEleve(nom, eleves);
            if (position == -1) {
                Console.WriteLine(nom + " n'est pas dans le tableau ");
            }
            else {
                Console.WriteLine(nom + " se trouve dans le poste {0} du tableau", position + 1);
            }
            Console.ReadLine();
        }
        static int PositionEleve(string nom, string[] eleve) {
            int position = -1, i = 0;
            bool valeur = false;
            while (!valeur && i < eleve.Length) {
                if (eleve[i] == nom) {
                    position = i;
                    valeur = true;
                }
                i++;
            }

            return position;
        }

    }
}
