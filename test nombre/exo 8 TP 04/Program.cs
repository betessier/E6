using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exo_8_TP_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre, i;
            i = 12;
            Console.WriteLine(" saisir un nombre");
            nombre = Convert.ToInt32(Console.ReadLine());
            while (nombre != 12)
            {
                if (nombre < 12) 
                {
                    Console.WriteLine("plus grand");
                }
            }
            Console.ReadLine();
        }
    }
}
