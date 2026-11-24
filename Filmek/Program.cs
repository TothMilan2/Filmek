using Filmek.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek
{
    
    internal class Program

    {
        public static List<Film> Filmek = new List<Film>();
        static void Main(string[] args)
        {
            Console.WriteLine("helo");


            Console.WriteLine("Adj meg egy új filmet: ");
            Console.WriteLine("Cím: ");
            string cim = Console.ReadLine();
            Console.WriteLine("Hossz: ");
            string hossz = Console.ReadLine();
            Console.WriteLine("Korhatár: ");
            string korhatar = Console.ReadLine();
            Console.WriteLine("Műfaj: ");
            string mufaj = Console.ReadLine();

            

            
        }
    }
}
