using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lagerverwaltung
{
    class Funktionen
    {
        ////Listen, Speichern, Laden, Löschen etc.

        //public static List<string> Lagername = new List<string>();
        //public static List<int> MaxBestand = new List<int>();
        //public static List<int> CurrBestand = new List<int>();

        //public static void DatenLaden(string dateiname)
        //{
        //    dateiname = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        //    dateiname = dateiname + @"\Lagerverwaltun\Lagerdaten.csv";

        //    if (File.Exists(dateiname))
        //    {
        //        StreamReader sr = File.OpenText(dateiname);
        //        while (!sr.EndOfStream)
        //        {
        //            string[] geleseneZeile = sr.ReadLine().Split(';');
        //            Lagername.Add(geleseneZeile[0]);
        //            MaxBestand.Add(Convert.ToInt32(geleseneZeile[1]));
        //            CurrBestand.Add(Convert.ToInt32(geleseneZeile[2]));

        //        }
        //        sr.Close();
        //    }
        //}

    }
}
