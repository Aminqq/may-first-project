
using System;

namespace FirstProject {

public class Mitglied {

        public String Name;
        public String Vorname;
        public String Geburstdatum;
        public String Sparte; // Abteilung / Sportverein

        public void Drucken() {
            
             Console.WriteLine("Name: \t\t" + Name);
             Console.WriteLine("Vorname: \t" + Vorname);
             Console.WriteLine("Geburstdatum: \t" + Geburstdatum);
             Console.WriteLine("Sparte: \t" + Sparte);
        }

    }

}