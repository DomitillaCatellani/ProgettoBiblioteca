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



        public Utente(string nome, string cognome, string codiceFiscale, DateTime nascita)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.codiceFiscale = codiceFiscale;
            this.nascita = nascita;
        }



        public override string ToString()
        {
            return nome + " " + cognome + " " + nascita;
        }
        


        public string describe()
        {
            return nome + " " + cognome + " " + codiceFiscale;
        }



        public List<Libro> listaLibri = new List<Libro>();



        public string describeLibri()
        {
            string risultato = "";

            int lunghezza = listaLibri.Count;

            for (int i = 0; i < lunghezza; i++)
            {
                risultato += listaLibri[i].describe() + Environment.NewLine;
            }

            return risultato;


        }
    }
}
