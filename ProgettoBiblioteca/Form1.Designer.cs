namespace ProgettoBiblioteca
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxUtenti = new System.Windows.Forms.ListBox();
            this.listBoxLibri = new System.Windows.Forms.ListBox();
            this.buttonPresta = new System.Windows.Forms.Button();
            this.buttonDescriviUtente = new System.Windows.Forms.Button();
            this.buttonDescriviLibro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCommenti = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxUtenti
            // 
            this.listBoxUtenti.FormattingEnabled = true;
            this.listBoxUtenti.Location = new System.Drawing.Point(12, 25);
            this.listBoxUtenti.Name = "listBoxUtenti";
            this.listBoxUtenti.Size = new System.Drawing.Size(158, 147);
            this.listBoxUtenti.TabIndex = 0;
            this.listBoxUtenti.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxLibri
            // 
            this.listBoxLibri.FormattingEnabled = true;
            this.listBoxLibri.Location = new System.Drawing.Point(340, 25);
            this.listBoxLibri.Name = "listBoxLibri";
            this.listBoxLibri.Size = new System.Drawing.Size(158, 147);
            this.listBoxLibri.TabIndex = 1;
            this.listBoxLibri.SelectedIndexChanged += new System.EventHandler(this.listBoxLibri_SelectedIndexChanged);
            // 
            // buttonPresta
            // 
            this.buttonPresta.Location = new System.Drawing.Point(216, 178);
            this.buttonPresta.Name = "buttonPresta";
            this.buttonPresta.Size = new System.Drawing.Size(75, 23);
            this.buttonPresta.TabIndex = 2;
            this.buttonPresta.Text = "Presta";
            this.buttonPresta.UseVisualStyleBackColor = true;
            this.buttonPresta.Click += new System.EventHandler(this.buttonPresta_Click);
            // 
            // buttonDescriviUtente
            // 
            this.buttonDescriviUtente.Location = new System.Drawing.Point(53, 178);
            this.buttonDescriviUtente.Name = "buttonDescriviUtente";
            this.buttonDescriviUtente.Size = new System.Drawing.Size(75, 23);
            this.buttonDescriviUtente.TabIndex = 3;
            this.buttonDescriviUtente.Text = "Descrivi";
            this.buttonDescriviUtente.UseVisualStyleBackColor = true;
            this.buttonDescriviUtente.Click += new System.EventHandler(this.buttonDescriviUtente_Click);
            // 
            // buttonDescriviLibro
            // 
            this.buttonDescriviLibro.Location = new System.Drawing.Point(381, 178);
            this.buttonDescriviLibro.Name = "buttonDescriviLibro";
            this.buttonDescriviLibro.Size = new System.Drawing.Size(75, 23);
            this.buttonDescriviLibro.TabIndex = 4;
            this.buttonDescriviLibro.Text = "Descrivi";
            this.buttonDescriviLibro.UseVisualStyleBackColor = true;
            this.buttonDescriviLibro.Click += new System.EventHandler(this.buttonDescriviLibro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Utenti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Libri:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxCommenti
            // 
            this.textBoxCommenti.Location = new System.Drawing.Point(176, 25);
            this.textBoxCommenti.Multiline = true;
            this.textBoxCommenti.Name = "textBoxCommenti";
            this.textBoxCommenti.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCommenti.Size = new System.Drawing.Size(158, 147);
            this.textBoxCommenti.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 218);
            this.Controls.Add(this.textBoxCommenti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDescriviLibro);
            this.Controls.Add(this.buttonDescriviUtente);
            this.Controls.Add(this.buttonPresta);
            this.Controls.Add(this.listBoxLibri);
            this.Controls.Add(this.listBoxUtenti);
            this.Name = "Form1";
            this.Text = "Progetto Biblioteca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUtenti;
        private System.Windows.Forms.ListBox listBoxLibri;
        private System.Windows.Forms.Button buttonPresta;
        private System.Windows.Forms.Button buttonDescriviUtente;
        private System.Windows.Forms.Button buttonDescriviLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCommenti;
    }
}

