using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiCatalogo
{
    public partial class EliminaProdotto : Form
    {
        public Prodotto Prodotto { get; set; }
        public List<Prodotto> Lista { get; set; }

        private string path = @"..\..\..\files\prodotti.dat";
        public EliminaProdotto()
        {
            InitializeComponent();
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            Lista = MyLibrary.LeggiFileOggetti(path);

            int codice = Convert.ToInt32(txtCodiceRicerca.Text);

            foreach (var item in Lista)
            {
                if (item.Codice == codice)
                    Prodotto = item;
            }

            if (Prodotto == null)
                MessageBox.Show("Prodotto non trovato", "Modifica Prodotto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                txtCodice.Text = Prodotto.Codice.ToString();
                txtDenominazione.Text = Prodotto.Denominazione;
                txtPrezzo.Text = Prodotto.Prezzo.ToString();
                txtGiacenza.Text = Prodotto.Giacenza.ToString();
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sicuro di voler eliminare i seguenti dati?", "Elimina prodotto", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Lista.Remove(Prodotto);
                MyLibrary.ScriviFileOggetti(path, Lista);
                CancellaForm();
                MessageBox.Show("Operazione andata a buon fine", "Elimina prodotto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CancellaForm()
        {
            Prodotto = null;
            txtCodice.Text = string.Empty;
            txtCodiceRicerca.Text = string.Empty;
            txtDenominazione.Text = string.Empty;
            txtGiacenza.Text = string.Empty;
            txtPrezzo.Text = string.Empty;
        }

        private void btnCancella_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sicuro di voler eliminare i seguenti dati?", "Elimina prodotto", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                CancellaForm();
        }
    }
}
