using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VezbanjeBroj2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prvi broj");
            string unos = Console.ReadLine();
            int broj1 = int.Parse(unos);

            Console.WriteLine("Unesite drugi broj");
            unos = Console.ReadLine();
            int broj2 = int.Parse(unos);

            int zbir = broj1 + broj2;

            if (zbir > 10 && zbir < 20) //Prvi uslov
            {
                Console.WriteLine("Zbir je veci od 10 i manji od 20!!");
            }
            else if (zbir < 5) //Drugi uslov
            {
                Console.WriteLine("Manji od 5!");
            }
            else //Ako nista nije ispunjeno onda ovo
            {
                Console.WriteLine("Izmedju 5 i 10!");
            }
            int x = 5;
            int y = 5;
            if (x == y)
            {
                Console.WriteLine("Prva grana");

            } else if (x == y)
            {
                Console.WriteLine("Druga grana");

            } 
            Console.WriteLine($"ZBIR JE {broj1 + broj2}.");
            Console.ReadKey();

               

        }
    }
}
