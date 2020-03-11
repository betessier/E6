using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombreUnité = 0 ,nombreDixaine = 0 ,nombreCentaine = 1 ;
            for (int i = 0; i == 9 ; i = i + 1 )
            {
                nombreUnité = nombreUnité + 1;
                Console.Write(nombreUnité);
                
            }
            for (int i = 0; i == 9; i = i + 1)
            {
                nombreDixaine = nombreDixaine + 1;
                Console.Write(nombreDixaine);
            }

            for (int i = 1; i == 4; i = i + 1)
            {
                nombreCentaine = nombreCentaine + 1;
                Console.Write(nombreCentaine);

            }
            
             Console.ReadLine();
        }
    }
}
