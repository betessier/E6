using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exo_noté
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            string reponseA, reponseB, reponseC, reponseD, reponseE, reponseF;
            // Question 1
            Console.WriteLine("Dans quel délai après le réveil fumez-vous votre première cigarette ? ");
            Console.WriteLine(" a) moins 5 de  minutes");
            Console.WriteLine(" b) 6 à 30 minutes");
            Console.WriteLine(" c) 31 à 60 minutes");
            Console.WriteLine(" d) après plus de 1 heure");
            Console.WriteLine(" Votre réponse :"); 
            reponseA = Console.ReadLine();
            if (reponseA == "a" )
            {
                score = score + 3;
            }
            if (reponseA == "b")
            {
                score = score + 2;
            }
            if (reponseA == "c")
            {
                score = score + 1;
            }
            if (reponseA == "d")
            {
                score = score + 0;
            }

             // Question 2
            Console.WriteLine("Trouvez-vous difficile de ne pas fumer dans les endroits interdits ? ");
            Console.WriteLine(" a) oui");
            Console.WriteLine(" b) non");
            Console.WriteLine(" Votre réponse :");
            reponseB = Console.ReadLine();
            if (reponseB == "a")
            {
                score = score + 1;
            }
            if (reponseB == "b")
            {
                score = score + 0;
            }
            
            // Question 3
            Console.WriteLine("Quelle cigarette trouvez vous la plus indispensable ? ");
            Console.WriteLine(" a) La première");
            Console.WriteLine(" b) une autre");
            Console.WriteLine(" Votre réponse :");
            reponseC = Console.ReadLine();
            if (reponseC == "a")
            {
                score = score + 1;
            }
            if (reponseC == "b")
            {
                score = score + 0;
            }

            // Question 4
            Console.WriteLine("Combien de cigarettes fumez-vous par jour ? ");
            Console.WriteLine(" a)10 ou moins");          
            Console.WriteLine(" b) 11 à 20");
            Console.WriteLine(" c) 21 à 30");
            Console.WriteLine(" d) 31 et plus");
            Console.WriteLine(" Votre réponse :"); 
            reponseD = Console.ReadLine();
            if (reponseD == "a")
            {
                score = score + 0;
            }
            if (reponseD == "b")
            {
                score = score + 1;
            }
            if (reponseD == "c")
            {
                score = score + 2;
            }
            if (reponseD == "d")
            {
                score = score + 3;
            }

            // Question 5
            Console.WriteLine("Fumez-vous de façon plus rapprochée dans la première heure après le réveil que pendant le reste de la journée ? ");
            Console.WriteLine(" a) oui");
            Console.WriteLine(" b) non");
            Console.WriteLine(" Votre réponse :");
            reponseE = Console.ReadLine();
            if (reponseE == "a")
            {
                score = score + 1;
            }
            if (reponseE == "b")
            {
                score = score + 0;
            }

            // Question 6
            Console.WriteLine("Fumez-vous même si une maladie vous oblige à rester au lit ? ");
            Console.WriteLine(" a) oui");
            Console.WriteLine(" b) non");
            Console.WriteLine(" Votre réponse :");
            reponseF = Console.ReadLine();
            if (reponseF == "a")
            {
                score = score + 1;
            }
            if (reponseF == "b")
            {
                score = score + 0;
            }
            
            Console.WriteLine("tu as un score de {0}", score);
            
            if (score == 1 || score == 2)
            {
                Console.WriteLine("pas de dependance");
            }
            if (score == 3 || score == 4)
            {
                Console.WriteLine( "dependance faible");
            }
            if (score == 5 || score == 6)
            {
                Console.WriteLine( "dependance moyenne");
            }
            if (score == 7 || score == 8)
            {
                Console.WriteLine( "dependance forte");
            }
            if (score == 9 || score == 10)
            {
                Console.WriteLine( "dependance tres forte");
            }
            Console.ReadLine();
              
        }
    }
}
