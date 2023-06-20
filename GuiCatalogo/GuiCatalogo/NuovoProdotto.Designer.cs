namespace GuiCatalogo
{
    partial class NuovoProdotto
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
            lblTitolo = new Label();
            lblCodice = new Label();
            txtCodice = new TextBox();
            txtDenominazione = new TextBox();
            lblDenominazione = new Label();
            txtPrezzo = new TextBox();
            lblPrezzo = new Label();
            txtGiacenza = new TextBox();
            lblGiacenza = new Label();
            btnSalva = new Button();
            btnCancella = new Button();
            SuspendLayout();
            // 
            // lblTitolo
            // 
            lblTitolo.AutoSize = true;
            lblTitolo.Location = new Point(233, 22);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Size = new Size(93, 15);
            lblTitolo.TabIndex = 0;
            lblTitolo.Text = "Nuovo Prodotto";
            // 
            // lblCodice
            // 
            lblCodice.AutoSize = true;
            lblCodice.Location = new Point(136, 78);
            lblCodice.Name = "lblCodice";
            lblCodice.Size = new Size(44, 15);
            lblCodice.TabIndex = 1;
            lblCodice.Text = "Codice";
            // 
            // txtCodice
            // 
            txtCodice.Location = new Point(200, 78);
            txtCodice.Name = "txtCodice";
            txtCodice.Size = new Size(167, 23);
            txtCodice.TabIndex = 2;
            // 
            // txtDenominazione
            // 
            txtDenominazione.Location = new Point(200, 139);
            txtDenominazione.Name = "txtDenominazione";
            txtDenominazione.Size = new Size(167, 23);
            txtDenominazione.TabIndex = 4;
            // 
            // lblDenominazione
            // 
            lblDenominazione.AutoSize = true;
            lblDenominazione.Location = new Point(90, 139);
            lblDenominazione.Name = "lblDenominazione";
            lblDenominazione.Size = new Size(90, 15);
            lblDenominazione.TabIndex = 3;
            lblDenominazione.Text = "Denominazione";
            // 
            // txtPrezzo
            // 
            txtPrezzo.Location = new Point(200, 198);
            txtPrezzo.Name = "txtPrezzo";
            txtPrezzo.Size = new Size(167, 23);
            txtPrezzo.TabIndex = 6;
            // 
            // lblPrezzo
            // 
            lblPrezzo.AutoSize = true;
            lblPrezzo.Location = new Point(139, 198);
            lblPrezzo.Name = "lblPrezzo";
            lblPrezzo.Size = new Size(41, 15);
            lblPrezzo.TabIndex = 5;
            lblPrezzo.Text = "Prezzo";
            // 
            // txtGiacenza
            // 
            txtGiacenza.Location = new Point(200, 256);
            txtGiacenza.Name = "txtGiacenza";
            txtGiacenza.Size = new Size(167, 23);
            txtGiacenza.TabIndex = 8;
            // 
            // lblGiacenza
            // 
            lblGiacenza.AutoSize = true;
            lblGiacenza.Location = new Point(126, 256);
            lblGiacenza.Name = "lblGiacenza";
            lblGiacenza.Size = new Size(54, 15);
            lblGiacenza.TabIndex = 7;
            lblGiacenza.Text = "Giacenza";
            lblGiacenza.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(200, 313);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(75, 23);
            btnSalva.TabIndex = 9;
            btnSalva.Text = "Salva";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // btnCancella
            // 
            btnCancella.Location = new Point(292, 313);
            btnCancella.Name = "btnCancella";
            btnCancella.Size = new Size(75, 23);
            btnCancella.TabIndex = 10;
            btnCancella.Text = "Cancella";
            btnCancella.UseVisualStyleBackColor = true;
            btnCancella.Click += btnCancella_Click;
            // 
            // NuovoProdotto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 497);
            Controls.Add(btnCancella);
            Controls.Add(btnSalva);
            Controls.Add(txtGiacenza);
            Controls.Add(lblGiacenza);
            Controls.Add(txtPrezzo);
            Controls.Add(lblPrezzo);
            Controls.Add(txtDenominazione);
            Controls.Add(lblDenominazione);
            Controls.Add(txtCodice);
            Controls.Add(lblCodice);
            Controls.Add(lblTitolo);
            Name = "NuovoProdotto";
            Text = "Nuovo Prodotto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitolo;
        private Label lblCodice;
        private TextBox txtCodice;
        private TextBox txtDenominazione;
        private Label lblDenominazione;
        private TextBox txtPrezzo;
        private Label lblPrezzo;
        private TextBox txtGiacenza;
        private Label lblGiacenza;
        private Button btnSalva;
        private Button btnCancella;
    }
}