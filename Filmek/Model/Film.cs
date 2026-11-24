using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek.Model
{
    public abstract class Film
    {
        private static string cim;
        private static int hossz;
        private static int korhatar;
        private static string mufaj;


        public string Cim { get => cim; set => cim = value; }
        public int Hossz { get => hossz; set => hossz = value; }
        public int Korhatar { get => korhatar; set => korhatar = value; }
        public string Mufaj { get => mufaj; set => mufaj = value; }

        public Film(string cim, int hossz, int korhatar, string mufaj)
        {
            this.Cim = cim;
            this.Hossz = hossz;
            this.Korhatar = korhatar;
            this.Mufaj = mufaj;
        }
 

       

        public abstract void FilmInfo();
    }
}
