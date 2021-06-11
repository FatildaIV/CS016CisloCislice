using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS016CisloCislice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte cislo(cislo): ");           
            int cislo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadejte Rad(cislo): ");
            int rad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadejte Zaklad(cislo): ");
            int zaklad = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Cislice v cisle {0} na radu {1} je {2}", cislo, rad, Cislice(cislo, rad, zaklad));
            Console.ReadKey();
        }
        static int Cislice(int cislo, int rad)
        {
            if (rad == 0) return (cislo % 10);
            return (Cislice(cislo / 10, rad - 1));
        }
        static int Cislice(int cislo, int rad, int zaklad)
        {
            if (rad == 0) return (cislo % zaklad);
            return (Cislice(cislo / zaklad, rad - 1, zaklad));
        }
    }
}
