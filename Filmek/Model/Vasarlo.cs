using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek.Model
{
     public class Vasarlo:Film
    {
        private static string nev;
        private static string email;

        public string Nev { get => nev; set => nev = value; }
        public string Email { get => email; set => email = value; }


        public Vasarlo(string nev, string email, string cim, int hossz, int korhatar, string mufaj) : base(cim, hossz, korhatar, mufaj)
        {
            Nev = nev;
            Email = email;
        }



        public override void FilmInfo() {

            Console.WriteLine("helo");
        
        }
    }
}
