using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UkolC
{
    class Koule : IComparable<Koule>
    {
        [XmlIgnore()]
        public double polomer;
        public string popis;
        public uint cislo { get; private set; }

        public Koule() { }

        public Koule(double polomer, string popis, uint cislo)
        {
            this.polomer = polomer;
            this.popis = popis;
            this.cislo = cislo;
        }

        public int CompareTo(Koule x)
        {
            return cislo.CompareTo(x.cislo);
        }

        public override string ToString()
        {
            return String.Format("{0};{1};{2}", cislo, polomer, popis);
        }

        public double GetPolomer() { return polomer; }
        public string GetPopis() { return popis; }
        public uint GetCislo() { return cislo; }
    }
}
