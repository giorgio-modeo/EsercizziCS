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

    public partial class ElencoProdotti : Form
    {
        private string path = @"..\..\..\files\prodotti.dat";
        private string pathCSV = @"..\..\..\files\prodotti.csv";
        private List<Prodotto> Lista;
        public ElencoProdotti()
        {
            InitializeComponent();

            LoadDati();
        }

        private void LoadDati()
        {

            string path = @"..\..\..\files\prodotti.dat";

            var lista = MyLibrary.LeggiFileOggetti(path);
            lblNumeroProdotti.Text = lblNumeroProdotti.Text + lista.Count;
            foreach (var item in lista)
                lbxElenco.Items.Add(item.Denominazione);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;
            try { MyLibrary.ScriviFileCSV(pathCSV, Lista); msg = "operazione completata con successo"}
            catch (Exception ex) { msg = "Operazione fallita ( " + ex + " )"; }


            MessageBox.Show(msg, "Esporta csv", MessageBoxButtons.OK);
        }
    }
}
