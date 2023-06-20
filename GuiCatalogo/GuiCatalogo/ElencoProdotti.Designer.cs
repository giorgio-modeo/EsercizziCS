namespace GuiCatalogo
{
    partial class ElencoProdotti
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
            lblNumeroProdotti = new Label();
            lbxElenco = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblTitolo
            // 
            lblTitolo.AutoSize = true;
            lblTitolo.Location = new Point(356, 23);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Size = new Size(88, 15);
            lblTitolo.TabIndex = 0;
            lblTitolo.Text = "Elenco Prodotti";
            // 
            // lblNumeroProdotti
            // 
            lblNumeroProdotti.AutoSize = true;
            lblNumeroProdotti.Location = new Point(51, 80);
            lblNumeroProdotti.Name = "lblNumeroProdotti";
            lblNumeroProdotti.Size = new Size(140, 15);
            lblNumeroProdotti.TabIndex = 1;
            lblNumeroProdotti.Text = "Numero prodotti trovati: ";
            // 
            // lbxElenco
            // 
            lbxElenco.FormattingEnabled = true;
            lbxElenco.ItemHeight = 15;
            lbxElenco.Location = new Point(51, 112);
            lbxElenco.Name = "lbxElenco";
            lbxElenco.Size = new Size(467, 259);
            lbxElenco.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(51, 401);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ElencoProdotti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 535);
            Controls.Add(button1);
            Controls.Add(lbxElenco);
            Controls.Add(lblNumeroProdotti);
            Controls.Add(lblTitolo);
            Name = "ElencoProdotti";
            Text = "Elenco Prodotti";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitolo;
        private Label lblNumeroProdotti;
        private ListBox lbxElenco;
        private Button button1;
    }
}