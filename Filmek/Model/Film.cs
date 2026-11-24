using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek.Model
{
    public abstract class Film
    {
        private string cim;
        private string hossz;
        private string rendezo;
        private int megjelenesEv;
        private int ertekeles;

        protected Film(string cim, string hossz, string rendezo, int megjelenesEv, int ertekeles)
        {
            this.cim = cim;
            this.hossz = hossz;
            this.rendezo = rendezo;
            this.megjelenesEv = megjelenesEv;
            this.ertekeles = ertekeles;
        }

        public string Cim { get => cim; set => cim = value; }
        public string Hossz { get => hossz; set => hossz = value; }
        public string Rendezo { get => rendezo; set => rendezo = value; }
        public int MegjelenesEv { get => megjelenesEv; set => megjelenesEv = value; }
        public int Ertekeles { get => ertekeles; set => ertekeles = value; }



        public abstract string FilmInfo();
    }
}
