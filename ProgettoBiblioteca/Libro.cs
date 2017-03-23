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
        public Genere genere { get; set; }
        public int ISBN { get; set; }

        private bool _inPrestito;
        public bool inPrestito { get { return _inPrestito; } }
        
        public Libro (string titolo, string autore, Genere genere, int ISBN)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.genere = genere;
            this.ISBN = ISBN;
        }        

        public string describe()
        {
            return "Titolo: " + titolo + ", autore: " + autore + ", genere: " + genere + ", ISBN: " + ISBN;
        }
        
        public bool presta (Utente u)
        {
            if (inPrestito) { return false; }
            u.listaLibri.Add(this);
            _inPrestito = true;
            return true;
        }

        public override string ToString()
        {
            return ISBN + " " + titolo;
        }


    }
}
