using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoBiblioteca
{
    class Libro
    {
        public string titolo { get; set; }
        public string autore { get; set; }
        Genere genere { get; set; }
        public int ISBN { get; set; } 
        public bool inPrestito { get { return inPrestito; } }
        
        public Libro (string titolo, string autore/*, genere*/, int  ISBN)
        { 
            //costruttore
        }

        public void presta (Utente u)
        {
            //funzione presta
        }

    }
}
