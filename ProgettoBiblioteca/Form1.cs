using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoBiblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++) { listBoxUtenti.Items.Add(Seeder.creaUtente()); }
            for (int i = 0; i < 20; i++) { listBoxLibri.Items.Add(Seeder.creaLibro()); }
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDescriviUtente_Click(object sender, EventArgs e)
        {
            if (listBoxUtenti.SelectedIndex == -1) { MessageBox.Show("Seleziona un utente!", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            Utente u = listBoxUtenti.Items[listBoxUtenti.SelectedIndex] as Utente;
            textBoxCommenti.Text = u.describe();
        }

        private void buttonDescriviLibro_Click(object sender, EventArgs e)
        {
            if (listBoxLibri.SelectedIndex == -1) { MessageBox.Show ("Seleziona un libro!", "Attenzione!", MessageBoxButtons.OK,MessageBoxIcon.Exclamation ); return; }
            Libro l = listBoxLibri.Items[listBoxLibri.SelectedIndex] as Libro;
            textBoxCommenti.Text = l.describe();
        }

        private void buttonPresta_Click(object sender, EventArgs e)
        {
            if (listBoxUtenti.SelectedIndex == -1 || listBoxLibri.SelectedIndex == -1) { MessageBox.Show("Seleziona un libro e un utente!", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

            Utente u = listBoxUtenti.Items[listBoxUtenti.SelectedIndex] as Utente;
            Libro l = listBoxLibri.Items[listBoxLibri.SelectedIndex] as Libro;

            if (u.listaLibri.Count == 6) { MessageBox.Show("l'utente ha raggiunto il massimo numero di libri.", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

            try
            {
                l.presta(u);
                textBoxCommenti.Text = "Il libro è stato prestato con successo.";
            }
            catch
            {
                textBoxCommenti.Text = "Il libro è già in prestito.";
            }
        }

        private void listBoxLibri_SelectedIndexChanged(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }
    }
}
