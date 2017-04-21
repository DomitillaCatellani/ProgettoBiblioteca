using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoBiblioteca
{
    static class Seeder
    {
        static Random random = new Random();
        
        static List<string> nomiUtenti = new List<string>() { "Marco", "Lucia", "Stefano", "Sara", "Giacomo", "Rebecca"};
        static List<string> cognomiUtenti = new List<string>() { "Rossi", "Bianchi", "Manfredi", "Cipollari", "Tozzi", "Bartoli" };
        static List<string> codiceFiscaleUtenti = new List<string>() { "MSCMTT04L99F654O", "GBJTRD15M76M369G","DMTCTL23A00F371D","DNPNTR27M00F348T","SCFTRG30D03M162T"};
        static List<Genere> generi = new List<Genere> { Genere.avventura, Genere.fantasy, Genere.giallo, Genere.romantico, Genere.horror, Genere.novella, Genere.romanzo, Genere.storico };

        static List<string> titoliLibri = new List<string>() { "Il Mondo Nuovo","Io e te", "la casa nel mondo", "Il barone rampante", "I Promessi Sposi", "Piccole donne", "Lo Hobbit", "Il signore degli anelli"};

        public static Utente creaUtente()
        {
            return new Utente(nomiUtenti[random.Next(6)], cognomiUtenti[random.Next(6)], codiceFiscaleUtenti[random.Next(5)], new DateTime(1970 + random.Next(47), 1 + random.Next(11), 1 + random.Next(27)));
        }

        public static Libro creaLibro()
        {
            return new Libro(titoliLibri[random.Next(6)], nomiUtenti[random.Next(6)] + " " + cognomiUtenti[random.Next(6)], generi[random.Next(7)], random.Next(100000000, 999999999));
        }
    }
}