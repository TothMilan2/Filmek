using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek.Model
{
    public class Jegy:Film
    {
        private int azonosito;
        private double ar;
        private bool kedvezmeny;

        public Jegy(int azonosito, double ar, bool kedvezmeny,string cim, int hossz, int korhatar, string mufaj) :base(cim, hossz, korhatar, mufaj)
        {
            this.azonosito = azonosito;
            this.ar = ar;
            this.kedvezmeny = kedvezmeny;
        }

        public int Azonosito { get => azonosito; set => azonosito = value; }
        public double Ar { get => ar; set => ar = value; }
        public bool Kedvezmeny { get => kedvezmeny; set => kedvezmeny = value; }


        public override void FilmInfo()
        {
            Console.WriteLine("jegy");
        }
    }
}
