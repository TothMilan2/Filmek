using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek.Model
{
    public class Terem:Mozi
    {
        private int azonosito;
        private string terem_nev;
        private int ferohely;
        private string terem_tipus;

        public Terem(int azonosito, string terem_nev, int ferohely, string terem_tipus,string nev,string cim, int hossz, int korhatar, string mufaj) : base(nev,cim,hossz,korhatar,mufaj)
        {
            this.azonosito = azonosito;
            this.terem_nev = terem_nev;
            this.ferohely = ferohely;
            this.terem_tipus = terem_tipus;
        }

        public int Azonosito { get => azonosito; set => azonosito = value; }
        public string Nev1 { get => terem_nev; set => terem_nev = value; }
        public int Ferohely { get => ferohely; set => ferohely = value; }
        public string Terem_tipus { get => terem_tipus; set => terem_tipus = value; }



        public override void FilmInfo()
        {
            Console.WriteLine("as");
        }
    }
}
