using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek.Model
{
    public class Szek
    {
        private int sor;
        private int szam;
        private string kategoria;

        public Szek(int sor, int szam, string kategoria)
        {
            this.sor = sor;
            this.szam = szam;
            this.kategoria = kategoria;
        }

        public int Sor { get => sor; set => sor = value; }
        public int Szam { get => szam; set => szam = value; }
        public string Kategoria { get => kategoria; set => kategoria = value; }
    }
}
