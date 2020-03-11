using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdressageIP;

namespace exercice_2 {
    class Program {
        static void Main(string[] args) {
            AdresseIP ipA,IpB, IpC;
            ipA = new AdresseIP(172,10,15,17);
            IpB = new AdresseIP(255,255,0,0);
            IpC = new AdresseIP(172,10,0,0);
            Console.WriteLine(ipA);
            Console.WriteLine(IpB);
            Console.WriteLine(IpC);
            Console.ReadLine();
        }
    }
}
