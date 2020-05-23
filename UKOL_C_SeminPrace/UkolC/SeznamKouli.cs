using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UkolC
{

    class SeznamKouli
    {
        [XmlIgnore()]
        public List<Koule> list_SeznamKouli { get; set; }

        public SeznamKouli()
        {
            list_SeznamKouli = new List<Koule>();
        }


        public void VlozitKouli(Koule k)
        {
            bool existuje = false;
            for (int i = 0; i < list_SeznamKouli.Count; i++)
            {
                if(list_SeznamKouli[i].cislo == k.cislo) { existuje = true; break; }
            }
//            existuje = list_SeznamKouli.Contains(k); // nevím proč ale nefunguje
            if (existuje == false)
                list_SeznamKouli.Add(k);
            else
                throw new MyException_KouleExistujiciCislo("Nelze vložit kouli se stejným pořadovým číslem!");
        }

        public void SeraditDlePolomeru(string smer = "asc")
        {
            list_SeznamKouli.Sort(new MyComparer_KouleDlePolomer(smer));
        }

        public void OdstranitKouli(int idKoule)
        {
            list_SeznamKouli.RemoveAt(idKoule);
        }

        public Koule GetKouleByIndex(int idKoule)
        {
            return list_SeznamKouli[idKoule]; 
        }

        internal void OdstranitKoule()
        {
            list_SeznamKouli.Clear();
        }
    }
}
