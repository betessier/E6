using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TpLaGrandeCourseDesLapins {
    class Lapin 
    {
        private string surnom;
        private int age, position;
        private static Random aleatoire = new Random();
        public Lapin(string surnom, int age)
        {
            this.position = 0;
            this.surnom = surnom;
            this.age = age;
        }
        public void Avancer() 
        {
            int i = Lapin.aleatoire.Next(0,6);
            this.position = this.position + i;
        }
        public string ToString() 
        {
           return string.Format("Nom : {0} Age : {1} position {2}", this.surnom,this.age,this.position);
        }
        public int Position()
        {
            return this.position;
        }
    }
}
