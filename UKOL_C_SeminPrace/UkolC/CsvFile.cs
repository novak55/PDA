using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UkolC
{
    class CsvFile
    {
        internal string UlozDoCsv(SeznamKouli seznamKouli, string filePath, string fileName)
        {
            StreamWriter sw = null;
            fileName += ".csv";
            try
            {
                sw = new StreamWriter(Path.Combine(filePath, fileName), false, Encoding.Default);
                for (int i = 0; i < seznamKouli.list_SeznamKouli.Count; i++)
                {
                    sw.WriteLine(seznamKouli.list_SeznamKouli[i].ToString());
                }

            }
            catch (IOException ex)
            {
                return String.Format("{0}\n\n{1}", "Při uložení došlo k chybě: ", ex.Message);
            }
            finally
            {
                if (sw != null)
                    sw.Close();
            }
            return "Soubor " + fileName + " je úspěšně uložen.";

        }

        internal string ImortujZCsv(SeznamKouli seznamKouli, string filePath, string fileName)
        {
            StreamReader sr = null;
            string ln;
            fileName += ".csv";
            try
            {
                sr = new StreamReader(Path.Combine(filePath, fileName), Encoding.Default);
                seznamKouli.OdstranitKoule(); 
                while ((ln = sr.ReadLine()) != null)
                    zpracujRadek(ln, seznamKouli);

            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }
            return "Soubor " + fileName + " je naimportován.";
        }

        private void zpracujRadek(string ln, SeznamKouli seznamKouli)
        {
            string[] radek = ln.Split(';');
            Koule k = new Koule(Convert.ToDouble(radek[1]), radek[2], Convert.ToUInt32(radek[0]));
            seznamKouli.VlozitKouli(k);
        }
    }
}
