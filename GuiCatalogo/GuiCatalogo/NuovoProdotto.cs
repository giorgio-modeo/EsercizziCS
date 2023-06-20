using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiCatalogo
{
    public partial class NuovoProdotto : Form
    {
        public NuovoProdotto()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string path = @"..\..\..\files\prodotti.dat";

            var lista = MyLibrary.LeggiFileOggetti(path);
            //var lista = new List<Prodotto>();
            lista.Add(new Prodotto
            {
                Codice = Convert.ToInt32(txtCodice.Text),
                Denominazione = txtDenominazione.Text,
                Prezzo = Convert.ToDouble(txtPrezzo.Text),
                Giacenza = Convert.ToInt32(txtGiacenza.Text)
            });

            MyLibrary.ScriviFileOggetti(path, lista);

            MessageBox.Show("Operazione avvenuta con successo", "Nuovo prodotto", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CancellaForm()
        {
            txtCodice.Text = string.Empty;
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
