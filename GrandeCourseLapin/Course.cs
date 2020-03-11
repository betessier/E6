﻿using System.Collections.Generic;

namespace GrandeCourseLapin {
    class Course {
        private int distance;
        private List<Lapin> participer;

        public void Départ() {
            for(int j = 0;j < this.distance;j++) {
                for(int i = 0;i < this.participer.Count;i++) {
                    this.participer[i].Avancer();
                }
            }
        }

        public Lapin Gagnant() {
            Lapin gagnant = this.participer[0];
            foreach(Lapin lapin in this.participer) {
                if(lapin.Position > gagnant.Position) {
                    gagnant = lapin;
                }
            }
            return gagnant;
        }

        public Course(int distance) {
            this.distance = distance;
            this.participer = new List<Lapin>();
        }

        public void Add(Lapin nouveauParticipant) {
            this.participer.Add(nouveauParticipant);
        }

        public void RemoveAt(int position) {
            if(position > -1 && position < this.participer.Count) {
                this.participer.RemoveAt(position);
            }
        }

        public List<Lapin> GetParticiper() {
            return this.participer;
        }

        public List<Lapin> Participer {
            get {
                return participer;
            }
        }

        public Lapin this[int position] {
            get {
                return this.participer[position];
            }
        }
        public int Count {
            get {
                return this.participer.Count;
            }
        }
    }
}
