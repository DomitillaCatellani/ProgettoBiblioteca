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
            if (listBoxUtenti.SelectedIndex == -1) { commenti.Items.Add("seleziona un utente"); return; }
            Utente u = listBoxUtenti.Items[listBoxUtenti.SelectedIndex] as Utente;
            commenti.Items.Add(u.describe());
        }

        private void buttonDescriviLibro_Click(object sender, EventArgs e)
        {
            if (listBoxUtenti.SelectedIndex == -1) { commenti.Items.Add("seleziona un libro"); return; }
            Libro l = listBoxLibri.Items[listBoxLibri.SelectedIndex] as Libro;
            commenti.Items.Add(l.describe());
        }

        private void buttonPresta_Click(object sender, EventArgs e)
        {
            if (listBoxUtenti.SelectedIndex == -1 || listBoxLibri.SelectedIndex == -1) { commenti.Items.Add("seleziona un libro e un utente"); return; }

            Utente u = listBoxUtenti.Items[listBoxUtenti.SelectedIndex] as Utente;
            Libro l = listBoxLibri.Items[listBoxLibri.SelectedIndex] as Libro;
            if (l.presta(u))
            {
                commenti.Items.Add("Il libro è stato prestato con successo.");
            }
            else { commenti.Items.Add("Non puoi prestare questo libro all'utente selezionato."); }
        }

        private void listBoxLibri_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
