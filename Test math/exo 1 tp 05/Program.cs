using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exo_1_tp_05
{
    class Program
    {
        static void Main(string[] args)
        {
           int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Min(a, b));   
            Console.ReadLine();
        }
        static int Min(int a,int b) 
            {
                if(a<b)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            }
    }
}
