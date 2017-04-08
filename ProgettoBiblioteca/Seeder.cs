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
        static List<string> codiceFiscaleUtenti = new List<string>() { "kugrshrd", "ku6gryutfhgu","7tyghjhgfd","jtrhyfhdgertgh","ju7tysdhgiyci"};
        
        static List<string> titoliLibri = new List<string>() { "Il Mondo Nuovo","Io e te", "la casa nel mondo", "Il barone rampante", "I Promessi Sposi", "Piccole donne", "Lo Hobbit", "Il signore degli anelli"};

        public static Utente creaUtente()
        {
            string nome = nomiUtenti[random.Next(6)];
            string cognome = cognomiUtenti[random.Next(6)];
            string codiceFiscale = codiceFiscaleUtenti[random.Next(5)];
            DateTime data = new DateTime(1970 + random.Next(47),1 + random.Next(11),1 + random.Next(27));
            return new Utente(nome, cognome, codiceFiscale, data);
        }

        public static Libro creaLibro()
        {
            string titolo = titoliLibri [random.Next(6)];
            string autore = nomiUtenti[random.Next(6)] + " " + cognomiUtenti[random.Next(6)];
            int ISBN = random.Next(10000, 99999);
            Genere genere = new Genere();
            return new Libro(titolo, autore, genere, ISBN);
        }
    }
}