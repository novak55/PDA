using System.Collections.Generic;

namespace UkolC
{
    internal class MyComparer_KouleDlePolomer : IComparer<Koule>
    {
        private int smer;

        public MyComparer_KouleDlePolomer(string s)
        {
            this.smer = s == "asc" ? 1 : -1;
        }

        public int Compare(Koule x, Koule y)
        {
            return x.polomer.CompareTo(y.polomer) * smer;
        }
    }
}