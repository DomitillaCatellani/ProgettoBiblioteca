using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoBiblioteca
{
    class Utente
    {
        public string nome { get; set; } 
        public string cognome { get; set; }
        public string codiceFiscale { get; set; }
        public DateTime nascita { get; set; }

        public Utente (string nome, string cognome, string codiceFiscale, DateTime nascita)
        {
            //costruttore
        }

        public override string ToString()
        {
            return nome + " " + cognome + " " + nascita;
        }

        public string describe (/*nome, cognome, codice fiscale*/)
        {
            return "tutto";
        }

        //lista libriPosseduti

         /*public string describeLibri ()
        {
            describe di ogni libro

            return tutto;
        }*/
    }
}
