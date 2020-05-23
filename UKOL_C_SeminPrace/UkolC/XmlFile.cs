using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace UkolC
{
    class XmlFile
    {
        internal string UlozDoXml(string filePath, string fileName, SeznamKouli sk)
        {
            StreamWriter sw = null;
            fileName += ".xml";

            try
            {
                sw = new StreamWriter(Path.Combine(filePath, fileName), false, Encoding.Default);
                XElement seznamKouli = new XElement("Seznam_kouli");
                for (int i = 0; i < sk.list_SeznamKouli.Count; i++)
                {
                    XElement koule = new XElement("Koule");
                    koule.SetAttributeValue("Cislo", sk.list_SeznamKouli[i].cislo);
                    koule.SetAttributeValue("Polomer", sk.list_SeznamKouli[i].polomer);
                    koule.SetAttributeValue("Popis", sk.list_SeznamKouli[i].popis);
                    seznamKouli.Add(koule);
                }
                sw.WriteLine(seznamKouli);
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
            return "Soubor " + fileName + " je úspěšne uložen.";
        }

        internal string ImortujZXml(SeznamKouli seznamKouli, string filePath, string fileName)
        {
            fileName += ".xml";
            using (XmlReader reader = XmlReader.Create(@Path.Combine(filePath, fileName)))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "Koule"))
                    {
                        if (reader.HasAttributes)
                        {
                            Koule k = new Koule(Convert.ToDouble(reader.GetAttribute("Polomer")), reader.GetAttribute("Popis"), Convert.ToUInt32(reader.GetAttribute("Cislo")));
                            seznamKouli.VlozitKouli(k);
                        }
                    }
                }
            }
            return "Soubor " + fileName + " je naimportován.";
        }
    }
}
