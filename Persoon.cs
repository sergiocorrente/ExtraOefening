using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ExtraOefening
{
    public class Persoon
    {
       public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Leeftijd { get; set; }

        public Persoon(string voornaam, string achternaam, string leeftijd) {
            Voornaam = voornaam;
            Achternaam = achternaam;
            Leeftijd = leeftijd;
        }

        public string Inhoud()
        {
            string resultaat = Achternaam + " " + Leeftijd;
            return resultaat;
        }
        public override string ToString()
        {
            return Voornaam;
        }


    }

}


