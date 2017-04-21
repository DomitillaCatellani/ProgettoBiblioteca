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
            string answer;
            if (this.inPrestito) { answer = "il libro è in prestito"; } else { answer = "il libro è disponibile al prestito"; }
            return "Titolo: " + titolo + Environment.NewLine + "Autore: " + autore + Environment.NewLine + "Genere: " + genere + Environment.NewLine + "ISBN: " + ISBN + Environment.NewLine + answer;
        }
        
        public void presta (Utente u)
        {
            if (inPrestito) { throw new Exception("il libro è già in prestito."); }
            u.listaLibri.Add(this);
            _inPrestito = true;
        }

        public override string ToString()
        {
            return titolo + " - " + autore;
        }
    }
}