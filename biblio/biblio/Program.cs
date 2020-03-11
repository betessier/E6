using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dllBibliothèque;

namespace GestionBibliothèque {
    class Program {
        static void Main(string[] args) {
            Bibliotheque b = new Bibliotheque("bibliotheque.txt");
            char choix = ' ';
            while (choix != 'z') {
                choix = Menu();
                Traiter(choix, b);
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static char Menu() {
            char choix;
            Console.WriteLine("0 : Caractéristiques de la bibliothèque");
            Console.WriteLine("1 : Liste des livres");
            Console.WriteLine("2 : Liste des auteurs");
            Console.WriteLine("3 : Liste des livres avec leur auteur");
            Console.WriteLine("4 : Rechercher un livre par sa position");
            Console.WriteLine("5 : Rechercher un livre par son titre");
            Console.WriteLine("6 : Créer un Livre et son auteur");
            Console.WriteLine("7 : Créer un Livre en choisissant son auteur");
            Console.WriteLine("8 : Supprimer un Livre");
            Console.WriteLine("9 : Liste des Livres parus avant");
            Console.WriteLine("a : Liste des livres d'un genre");
            Console.WriteLine("b : Liste des livres d'un auteur");
            Console.WriteLine("y : Enregistrer les modifications");
            Console.WriteLine("z : Quitter \n");
            Console.Write("Votre choix : ");

            choix = Console.ReadLine()[0];
            return choix;
        }

        private static void Traiter(char choix, Bibliotheque b) {
            Console.WriteLine("");
            switch (choix) {
                case '0':
                    CaracteristiqueBibliotheque(b);
                    break;
                case '1':
                    AfficherLivres(b);
                    break;
                case '2':
                    AfficherAuteurs(b);
                    break;
                case '3':
                    AfficherLivresAuteur(b);
                    break;
                case '4':
                    RechercheLivrePosition(b);
                    break;
                case '5':
                    RechercheLivreTitre(b);
                    break;
                case '6':
                    CreerLivreAuteur(b);
                    break;
                case '7':
                    CreerLivreChoixAuteur(b);
                    break;
                case '8':
                    SupprimerLivre(b);
                    break;
                case '9':
                    ListeLivreDateParution(b);
                    break;
                case 'a':
                    ListeLivreGenre(b);
                    break;
                case 'b':
                    ListeLivreAuteur(b);
                    break;
                case 'y':
                    EnregistrerBibliotheque(b);
                    break;
            }
            if (choix != 'z') {
                Console.Write("continuer...");
            }
        }

        // option 'y' Sauvegarder la bibliothèque dans le fichier texte
        private static void EnregistrerBibliotheque(Bibliotheque b) {
        }

        // option 'b' liste des livres pour un auteur sélectionné par l'utilisateur
        private static void ListeLivreAuteur(Bibliotheque b) {
        }

        // option 'a' liste des livres pour un genre
        private static void ListeLivreGenre(Bibliotheque b) {
        }

        // option '9' liste des livres antérieurs à une date de parution 
        private static void ListeLivreDateParution(Bibliotheque b) {
        }

        // option '8' suppression d'un livre dans une liste proposée
        private static void SupprimerLivre(Bibliotheque b) {
        }

        // option '7' ajout d'un livre à la bibliothèque en choisissant parmi les auteurs déjà existants
        private static void CreerLivreChoixAuteur(Bibliotheque b){
             for (int i = 0; i < b.GetCountAuteurs(); i++) {
                Auteur auteur = b.GetAuteur(i);
                Console.WriteLine("{0}/{1}", auteur.GetNom(), auteur.GetPrenom());
             }
            Console.WriteLine("chaississez lauteur");
            string choix = Console.ReadLine();
            Auteur unAuteur = choix;
            Console.WriteLine("Entrez le titre du livre");
            string titre = Console.ReadLine();
            Console.WriteLine("Entrez le genre du livre");
            string genre = Console.ReadLine();
            Console.WriteLine("Entrez la date de parution du livre");
            int dateParution = Convert.ToInt32(Console.ReadLine());
            b.AjouterLivre(titre, genre, unAuteur ,dateParution);
        }

        // option '6' ajout d'un nouveau livre à la bibliothèque avec un nouvel auteur
        private static void CreerLivreAuteur(Bibliotheque b) {
            Console.WriteLine("Entrez le nom de l'auteur");
            string nomAuteur = Console.ReadLine();
            Console.WriteLine("Entrez le prénom de l'auteur");
            string prenomAuteur = Console.ReadLine();
            Console.WriteLine("Entrez l'année de naissance de l'auteur");
            int anneeNaissance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez l'année de décès de l'auteur");
            int anneeDeces = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez le titre du livre");
            string titre = Console.ReadLine();
            Console.WriteLine("Entrez le genre du livre");
            string genre = Console.ReadLine();
            Console.WriteLine("Entrez la date de parution du livre");
            int dateParution = Convert.ToInt32(Console.ReadLine());
            Auteur auteur = new Auteur(anneeNaissance,anneeDeces,nomAuteur,prenomAuteur);
            b.AjouterLivre(titre,genre,auteur,dateParution);

        }

        // option '5' Recherche d'un livre par son titre
        private static void RechercheLivreTitre(Bibliotheque b) {
            Console.WriteLine("Entrez le titre du livre souhaité");
            string titre = Console.ReadLine();
            if (b.GetLivre(titre) == null) {
                Console.WriteLine("livre non compris dans cette liste");
            }
            else {
                Console.WriteLine(b.GetLivre(titre));
            }
        }

        // option '4' Recherche d'un livre par sa position
        private static void RechercheLivrePosition(Bibliotheque b) {
            Console.WriteLine("Entrez la position du livre souhaité : ");
            int position = Convert.ToInt32(Console.ReadLine());
            if (position <= b.GetCountLivres() ){
                Console.WriteLine(b.GetLivre(position));
            }
        }

        // option '3' Liste des livres avec leurs auteurs
        private static void AfficherLivresAuteur(Bibliotheque b) {
            for (int i = 0; i < b.GetCountLivres(); i++) {
                Livre livre = b.GetLivre(i) ;
                Auteur auteur = b.GetLivre(i).GetAuteur();
                Console.WriteLine(livre.GetTitre() + "\t" + livre.GetGenre() + "\t" + livre.GetAnneeSortie() + "\t" + auteur.GetNom() + "\t" + auteur.GetPrenom());
            }
        }

        // option '2' Liste des auteurs avec leur age
        private static void AfficherAuteurs(Bibliotheque b) {
            for (int i = 0; i < b.GetCountAuteurs(); i++) {
                Auteur auteur = b.GetAuteur(i);
                int age = auteur.GetAnneeDeces() - auteur.GetAnneeNaissance();
                Console.WriteLine("{0}/{1}/{2}/{3}/{4}",auteur.GetNom(),auteur.GetPrenom(),auteur.GetAnneeNaissance(),auteur.GetAnneeDeces(),age);
            }
        }

        // option '0' caractéristiques de la bibliothèque
        private static void CaracteristiqueBibliotheque(Bibliotheque b) {
            Console.WriteLine("La bibliothèque contient {0} livres.",b.GetCountLivres());
            Console.WriteLine("La bibliothèque contient {0} Auteurs.",b.GetCountAuteurs());
            Console.WriteLine("et provient du fichier {0}.",b.GetFichier());
        }

        // option '1' Liste des livres 
        private static void AfficherLivres(Bibliotheque b) {
            for (int i = 0; i < b.GetCountLivres(); i++) {
                Livre livre = b.GetLivre(i);
                Console.WriteLine(livre.GetTitre()+"\t"+livre.GetGenre()+"\t"+livre.GetAnneeSortie());
            }
        }
    }
}
