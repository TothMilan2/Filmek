using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek.Model
{
    public abstract class Fizetes:Film
    {
        private double osszeg;
        private string fizetesmod;
        private DateTime datum;

        public Fizetes(double osszeg, string fizetesmod, DateTime datum, string cim,int hossz, int korhatar, string mufaj) : base(cim,hossz,korhatar,mufaj)
        {
            this.osszeg = osszeg;
            this.fizetesmod = fizetesmod;
            this.datum = datum;
        }

        public double Osszeg { get => osszeg; set => osszeg = value; }
        public string Fizetesmod { get => fizetesmod; set => fizetesmod = value; }
        public DateTime Datum { get => datum; set => datum = value; }


        public override void FilmInfo()
        {
            Console.WriteLine("asd");
        }
    }
}
