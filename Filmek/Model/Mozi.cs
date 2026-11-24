using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek.Model
{
    public abstract class Mozi:Film
    {
        private string nev;
        

        public Mozi(string nev, string cim,int hossz, int korhatar, string mufaj) : base(cim,hossz,korhatar,mufaj)
        {
            this.nev = nev;
           
        }

        public string Nev { get => nev; set => nev = value; }

        public override void FilmInfo()
        {
            Console.WriteLine("asd");
        }
        
    }
}
