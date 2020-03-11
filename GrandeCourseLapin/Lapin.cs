using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandeCourseLapin {
    class Lapin {
        private static int comptage;
        private static int pas;
        private static Random aleatoire;
        private string surnom;
        private int age;
        private int position;
        private int dossard;

        public static void PasEtStart(int start, int pasChoisis)
        {
            Lapin.comptage = start;
            Lapin.pas = pasChoisis;
        }

        public Lapin(string surnom,int age) {
            this.surnom = surnom;
            this.age = age;
            this.position = 0;
            Lapin.aleatoire = new Random();
            this.dossard = Lapin.comptage + Lapin.pas;
            Lapin.comptage = Lapin.comptage + Lapin.pas;
        }

        public string Surnom {
            get {
                return this.surnom;
            }

            set {
                this.surnom = value;
            }
        }

        public int Age {
            get {
                return this.age;
            }

            set {
                this.age = value;
            }
        }

        public int Position {
            get {
                return this.position;
            }
        }

        public void Avancer() {
            this.position = this.position + Lapin.aleatoire.Next(0,5);
        }
        public string ToString() {
            return string.Format("Un lapin nommé {0} agé de {1} ans et dont la position est {2} et a pour numéro de dossard {3}.",this.surnom, this.age, this.position, this.dossard);
        }
    }
}
