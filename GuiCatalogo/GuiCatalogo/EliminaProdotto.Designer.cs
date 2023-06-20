namespace GuiCatalogo
{
    partial class EliminaProdotto
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
            pnlModifica = new Panel();
            btnCancella = new Button();
            btnSalva = new Button();
            txtGiacenza = new TextBox();
            lblGiacenza = new Label();
            txtPrezzo = new TextBox();
            lblPrezzo = new Label();
            txtDenominazione = new TextBox();
            lblDenominazione = new Label();
            txtCodice = new TextBox();
            lblCodice = new Label();
            lblTitolo = new Label();
            pnlRicerca = new Panel();
            btnCerca = new Button();
            txtCodiceRicerca = new TextBox();
            lblCodiceRicerca = new Label();
            pnlModifica.SuspendLayout();
            pnlRicerca.SuspendLayout();
            SuspendLayout();
            // 
            // pnlModifica
            // 
            pnlModifica.Controls.Add(btnCancella);
            pnlModifica.Controls.Add(btnSalva);
            pnlModifica.Controls.Add(txtGiacenza);
            pnlModifica.Controls.Add(lblGiacenza);
            pnlModifica.Controls.Add(txtPrezzo);
            pnlModifica.Controls.Add(lblPrezzo);
            pnlModifica.Controls.Add(txtDenominazione);
            pnlModifica.Controls.Add(lblDenominazione);
            pnlModifica.Controls.Add(txtCodice);
            pnlModifica.Controls.Add(lblCodice);
            pnlModifica.Location = new Point(57, 176);
            pnlModifica.Name = "pnlModifica";
            pnlModifica.Size = new Size(447, 316);
            pnlModifica.TabIndex = 5;
            // 
            // btnCancella
            // 
            btnCancella.Location = new Point(287, 264);
            btnCancella.Name = "btnCancella";
            btnCancella.Size = new Size(75, 23);
            btnCancella.TabIndex = 20;
            btnCancella.Text = "Cancella";
            btnCancella.UseVisualStyleBackColor = true;
            btnCancella.Click += btnCancella_Click;
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(195, 264);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(75, 23);
            btnSalva.TabIndex = 19;
            btnSalva.Text = "Elimina";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // txtGiacenza
            // 
            txtGiacenza.Enabled = false;
            txtGiacenza.Location = new Point(195, 207);
            txtGiacenza.Name = "txtGiacenza";
            txtGiacenza.ReadOnly = true;
            txtGiacenza.Size = new Size(167, 23);
            txtGiacenza.TabIndex = 18;
            // 
            // lblGiacenza
            // 
            lblGiacenza.AutoSize = true;
            lblGiacenza.Location = new Point(121, 207);
            lblGiacenza.Name = "lblGiacenza";
            lblGiacenza.Size = new Size(54, 15);
            lblGiacenza.TabIndex = 17;
            lblGiacenza.Text = "Giacenza";
            lblGiacenza.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtPrezzo
            // 
            txtPrezzo.Enabled = false;
            txtPrezzo.Location = new Point(195, 149);
            txtPrezzo.Name = "txtPrezzo";
            txtPrezzo.ReadOnly = true;
            txtPrezzo.Size = new Size(167, 23);
            txtPrezzo.TabIndex = 16;
            // 
            // lblPrezzo
            // 
            lblPrezzo.AutoSize = true;
            lblPrezzo.Location = new Point(134, 149);
            lblPrezzo.Name = "lblPrezzo";
            lblPrezzo.Size = new Size(41, 15);
            lblPrezzo.TabIndex = 15;
            lblPrezzo.Text = "Prezzo";
            // 
            // txtDenominazione
            // 
            txtDenominazione.Enabled = false;
            txtDenominazione.Location = new Point(195, 90);
            txtDenominazione.Name = "txtDenominazione";
            txtDenominazione.ReadOnly = true;
            txtDenominazione.Size = new Size(167, 23);
            txtDenominazione.TabIndex = 14;
            // 
            // lblDenominazione
            // 
            lblDenominazione.AutoSize = true;
            lblDenominazione.Location = new Point(85, 90);
            lblDenominazione.Name = "lblDenominazione";
            lblDenominazione.Size = new Size(90, 15);
            lblDenominazione.TabIndex = 13;
            lblDenominazione.Text = "Denominazione";
            // 
            // txtCodice
            // 
            txtCodice.Enabled = false;
            txtCodice.Location = new Point(195, 29);
            txtCodice.Name = "txtCodice";
            txtCodice.ReadOnly = true;
            txtCodice.Size = new Size(167, 23);
            txtCodice.TabIndex = 12;
            // 
            // lblCodice
            // 
            lblCodice.AutoSize = true;
            lblCodice.Location = new Point(131, 29);
            lblCodice.Name = "lblCodice";
            lblCodice.Size = new Size(44, 15);
            lblCodice.TabIndex = 11;
            lblCodice.Text = "Codice";
            // 
            // lblTitolo
            // 
            lblTitolo.AutoSize = true;
            lblTitolo.Location = new Point(243, 20);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Size = new Size(96, 15);
            lblTitolo.TabIndex = 4;
            lblTitolo.Text = "Elimina Prodotto";
            // 
            // pnlRicerca
            // 
            pnlRicerca.Controls.Add(btnCerca);
            pnlRicerca.Controls.Add(txtCodiceRicerca);
            pnlRicerca.Controls.Add(lblCodiceRicerca);
            pnlRicerca.Location = new Point(57, 56);
            pnlRicerca.Name = "pnlRicerca";
            pnlRicerca.Size = new Size(447, 100);
            pnlRicerca.TabIndex = 3;
            // 
            // btnCerca
            // 
            btnCerca.Location = new Point(328, 40);
            btnCerca.Name = "btnCerca";
            btnCerca.Size = new Size(75, 23);
            btnCerca.TabIndex = 2;
            btnCerca.Text = "Cerca";
            btnCerca.UseVisualStyleBackColor = true;
            btnCerca.Click += btnCerca_Click;
            // 
            // txtCodiceRicerca
            // 
            txtCodiceRicerca.Location = new Point(214, 41);
            txtCodiceRicerca.Name = "txtCodiceRicerca";
            txtCodiceRicerca.Size = new Size(100, 23);
            txtCodiceRicerca.TabIndex = 1;
            // 
            // lblCodiceRicerca
            // 
            lblCodiceRicerca.AutoSize = true;
            lblCodiceRicerca.Location = new Point(46, 41);
            lblCodiceRicerca.Name = "lblCodiceRicerca";
            lblCodiceRicerca.Size = new Size(165, 15);
            lblCodiceRicerca.TabIndex = 0;
            lblCodiceRicerca.Text = "Inserisci il codice del prodotto";
            // 
            // EliminaProdotto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 512);
            Controls.Add(pnlModifica);
            Controls.Add(lblTitolo);
            Controls.Add(pnlRicerca);
            Name = "EliminaProdotto";
            Text = "Elimina Prodotto";
            pnlModifica.ResumeLayout(false);
            pnlModifica.PerformLayout();
            pnlRicerca.ResumeLayout(false);
            pnlRicerca.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlModifica;
        private Button btnCancella;
        private Button btnSalva;
        private TextBox txtGiacenza;
        private Label lblGiacenza;
        private TextBox txtPrezzo;
        private Label lblPrezzo;
        private TextBox txtDenominazione;
        private Label lblDenominazione;
        private TextBox txtCodice;
        private Label lblCodice;
        private Label lblTitolo;
        private Panel pnlRicerca;
        private Button btnCerca;
        private TextBox txtCodiceRicerca;
        private Label lblCodiceRicerca;
    }
}