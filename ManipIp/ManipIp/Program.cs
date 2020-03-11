using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdressageIP;

namespace ManipIp {
    class Program {
        static void Main(string[] args) {
            AdresseIP ipA, ipB, ipC;
            ipA = new AdresseIP(0,0,0,3);
            ipB = new AdresseIP(128,0,16,45);
            ipC = new AdresseIP(192,15,61,35);
            Console.WriteLine(ipA);
            Console.WriteLine("{0} {1} {2} {3}", ipA.GetOctet1(), ipA.GetOctet2(), ipA.GetOctet3(), ipA.GetOctet4());
            Console.WriteLine(ipA.ToString());
            Console.WriteLine(ipA.Masque());
            Console.WriteLine(ipA.ClasseReseau());
            Console.WriteLine(ipA.AdresseIpBinaire());
            Console.WriteLine(ipB);
            Console.WriteLine("{0} {1} {2} {3}", ipB.GetOctet1(), ipB.GetOctet2(), ipB.GetOctet3(), ipB.GetOctet4());
            Console.WriteLine(ipB.ToString());
            Console.WriteLine(ipB.Masque());
            Console.WriteLine(ipB.ClasseReseau());
            Console.WriteLine(ipB.AdresseIpBinaire());
            Console.WriteLine(ipC);
            Console.WriteLine("{0} {1} {2} {3}", ipC.GetOctet1(), ipC.GetOctet2(), ipC.GetOctet3(), ipC.GetOctet4());
            Console.WriteLine(ipC.ToString());
            Console.WriteLine(ipC.Masque());
            Console.WriteLine(ipC.ClasseReseau());
            Console.WriteLine(ipC.AdresseIpBinaire());
            Console.ReadLine();
        }
    }
}
