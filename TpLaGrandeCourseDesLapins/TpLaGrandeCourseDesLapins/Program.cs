using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TpLaGrandeCourseDesLapins {
    class Program {
        static void Main ()
        {
            List<Lapin> mesLapins = new List<Lapin>();
            mesLapins.Add(new Lapin("Georges",45));
            mesLapins.Add(new Lapin("michel",87));
            mesLapins.Add(new Lapin("paul",1));
            for (int i = 0; i < 100; i++) 
            {
                for (int j = 0; j < mesLapins.Count; j++) 
                {
                    mesLapins[j].Avancer();
                }
            }
            for (int k = 0; k < mesLapins.Count; k++) {
                Console.WriteLine(mesLapins[k].ToString());
            }
            Lapin gagnant = (Lapin)mesLapins[0];
            foreach (Lapin lapin in mesLapins) {
            }
            Console.ReadLine();
        }
    }
}
