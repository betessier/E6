using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(avg(a, b));
            Console.ReadLine();
        }
        static double avg(int a, int b)
        {
            double avg;
            avg = a + b;
            avg = avg / 2;
            return avg;
        }
    }
}
