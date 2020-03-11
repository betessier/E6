using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandeCourseLapin {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Choississez le début des numéros des dossards");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choississez le pas entre deux dossards");
            int pasChoisis = Convert.ToInt32(Console.ReadLine());

            Course marathon = new Course(42);
            marathon.Add(new Lapin( "jeannot",2));
            marathon.Add( new Lapin("panpan",6));
            marathon.Add(new Lapin("jelly",5));
            // Départ Course
            marathon.Départ();
            
            // Afficher la liste des inscrits
            foreach(Lapin l in marathon.Participer) {
                Console.WriteLine(l.ToString());
            }

            for(int i = 0;i < marathon.Count;i++) {
                Console.WriteLine(marathon[i].ToString());
            }


            // Gagnant
            Lapin Usain = marathon.Gagnant();
  
            Console.WriteLine("Le grand gagnant est : {0}",Usain.Surnom);
            Console.ReadLine();
        }
    }
}
