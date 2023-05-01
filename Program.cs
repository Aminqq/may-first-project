using System;
using System.Collections.Generic;


namespace FirstProject {
    
    class Program{

        public Program() {

               Mitglied member = new Mitglied();

               // Mitglied hinzufügen
               member.Name = "Abdo";
               member.Vorname = "Bosch";
               member.Geburstdatum = "01.09.1994";
               member.Sparte = "Football";

               member.Drucken();

               List<String> list_member = new List<String>();

               list_member.Add(member.Name);
               list_member.Add(member.Vorname);
               list_member.Add(member.Geburstdatum);
               list_member.Add(member.Sparte);
 
               foreach (string name in list_member) {
            
                    Console.WriteLine(name);
        
                }

        }

    static void Main(string[]args) {

        new Program();
        System.Console.ReadKey();
    }
    
    }
   
        
}


