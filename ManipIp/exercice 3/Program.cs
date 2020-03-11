using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdressageIP;

namespace exercice_3 {
    class Program {
        static void Main(string[] args) {
            AdresseIP ipA,ipB;
            ipA = new AdresseIP(Console.ReadLine());
            Console.WriteLine(ipA);
            ipB = new AdresseIP(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(ipB);
            Console.ReadLine();
        }
    }
}
