using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdressageIP;

namespace exercice_4 {
    class Program {
        static void Main(string[] args) {
            AdresseIP[] adresse= new AdresseIP[3];
            adresse[0] = new AdresseIP(172, 10, 15, 17);
            adresse[1] = new AdresseIP(255, 255, 0, 0);
            adresse[2] = new AdresseIP(172, 10, 0, 0);
        }
    }
}
