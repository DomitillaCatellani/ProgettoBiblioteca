﻿using System;
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
            return nome + " " + cognome;
        }

        public string describe()
        {
            string descrizione = "";

            if (this.listaLibri.Count != 0) { descrizione = "Libri: " + Environment.NewLine + describeLibri(); }

            return "Nome: " + nome + Environment.NewLine + "Cognome: "+ cognome + Environment.NewLine+ "Codice fiscale: " + codiceFiscale + Environment.NewLine + Environment.NewLine + descrizione ;
        }

        public List<Libro> listaLibri = new List<Libro>();
        
        public string describeLibri()
        {
            if (listaLibri.Count == 0) { return ""; }
            string risultato = "";
            int lunghezza = listaLibri.Count;
            risultato += listaLibri[0].describe();
            for (int i = 1; i < lunghezza; i++)
            {
                risultato += Environment.NewLine +Environment.NewLine + listaLibri[i].describe();
            }
            return risultato;
        }
    }
}
