using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiAM_Anch_io
{
    public partial class FCarica : Form
    {
        bool isEditing;
        CProdotto prodottoSelezionato;
        string oldImagePath;
        CNegozio negozio;
        public FCarica(CNegozio negozio)
        {
            InitializeComponent();
            this.negozio = negozio;
            isEditing = false;
        }

        private void BTNBROWSE_Click(object sender, EventArgs e)
        {
            //apre la finestra di scelta file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tutti i file(*.*)|*.*";

            string filePath;

            //se il file è stato scelto
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName; //salva l'indirizzo del file

                PBOXPREVIEW.ImageLocation = filePath;
                //ImageLocation verrà riutilizzato alla creazione del prodotto 
                //come indirizzo da cui partire per copiare il file nella directory Resources/StoreMemory/ProductImages
                //il nome che prenderà sarà NomeProdotto_CodiceSeriale.formatoImmagine
                //es. Pane_rigato_0005.jpeg
            }
        }

        private void FCarica_Load(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        private void RefreshListBox() 
        {
            LSTBOXPRODUCTS.Items.Clear();
            foreach (var prodotto in negozio.stocked)
            {
                LSTBOXPRODUCTS.Items.Add($"Nome: {prodotto.Nome}; ID: {prodotto.ID}"); //ricerca con l'ID
            }
        }

        private void TXTPREZZO_KeyDown(object sender, KeyEventArgs press)
        {
            //consente l'input di soli caratteri numerici e virgola
            bool hasVirgola = false;

            if (TXTPREZZO.Text.Contains('.'))
                hasVirgola = true;

            if (Control.ModifierKeys.HasFlag(Keys.Shift)) //se preme shift
                press.SuppressKeyPress = true;
            else if (hasVirgola && TXTPREZZO.Text.Split(".")[1].Length >= 2 && press.KeyValue != 8) //presenza di una sola virgola divide sempre in 2 substrings, si prende la decimale
                press.SuppressKeyPress = true;
            else if (press.KeyValue == 190 && hasVirgola)
                press.SuppressKeyPress = true;
            else if ((press.KeyValue < 48 || press.KeyValue > 57) && press.KeyValue != 189 && press.KeyValue != 8)
                press.SuppressKeyPress = true;
        }

        private void TXTQUANTITA_KeyDown(object sender, KeyEventArgs press)
        {
            //consente l'input di soli caratteri numerici
            if (Control.ModifierKeys.HasFlag(Keys.Shift))
                press.SuppressKeyPress = true;
            else if ((press.KeyValue < 48 || press.KeyValue > 57) && press.KeyValue != 8)
                press.SuppressKeyPress = true;
        }

        private void BTNCONFERMA_Click(object sender, EventArgs e)
        {
            if (TXTDESCRIZIONE.Text.Length > 0 && TXTNOME.Text.Length > 0 && TXTPREZZO.Text.Length > 0 && TXTQUANTITA.Text.Length > 0 && PBOXPREVIEW.ImageLocation.Length > 0) 
            {
                DirectoryInfo dirInf = new DirectoryInfo(Directory.GetCurrentDirectory());
                string pathname = dirInf.Parent.Parent.Parent.FullName;
                string imagepath = pathname + @"\Resources\Store\ProductImages\"; //imagepath contiene la destinazione del file da copiare
                pathname += @"\Resources\Store\Stocked.json";

                if (!isEditing)
                {
                    CProdotto prodotto = new CProdotto(TXTNOME.Text, decimal.Parse(TXTPREZZO.Text), TXTDESCRIZIONE.Text, int.Parse(TXTQUANTITA.Text));

                    imagepath += $"{TXTNOME.Text.Replace(' ', '_')}_{prodotto.ID}"; //Pane_Rosetta_0024
                    imagepath += "." + PBOXPREVIEW.ImageLocation.Split('.')[^1]/*indice di un'array contando dall'ultimo e da 1 e non 0*/;
                    //e come estensione quella del file scelto //.png

                    //copiare il file nella cartella locale
                    using (FileStream fs = File.Create(imagepath)) { }
                    File.Copy(PBOXPREVIEW.ImageLocation, imagepath, true);
                    //non entra in conflitto non so perché quindi meglio lasciarne 2

                    prodotto.ModificaPathFoto(imagepath);
                    PBOXPREVIEW.ImageLocation = imagepath; //per dopo

                    negozio.AddProdotto(prodotto);
                }
                else
                {
                    File.Delete(oldImagePath);

                    imagepath += $"{TXTNOME.Text.Replace(' ', '_')}_{prodottoSelezionato.ID}"; //Pane_Rosetta_0024
                    imagepath += "." + PBOXPREVIEW.ImageLocation.Split('.')[^1]/*indice di un'array contando dall'ultimo e da 1 e non 0*/;
                    //e come estensione quella del file scelto //.png

                    //copiare il file nella cartella locale
                    using (FileStream fs = File.Create(imagepath)) { }
                    File.Copy(PBOXPREVIEW.ImageLocation, imagepath, true);

                    prodottoSelezionato.ModificaProdotto(TXTNOME.Text, decimal.Parse(TXTPREZZO.Text), imagepath, TXTDESCRIZIONE.Text, int.Parse(TXTQUANTITA.Text));
                }
                //salvare su json
                File.WriteAllText(pathname, JsonConvert.SerializeObject(negozio));

                RefreshListBox();
                Reset();
            }
        }



        private void BTNSELECT_Click(object sender, EventArgs e)
        {
            if (LSTBOXPRODUCTS.SelectedIndex != -1)
            {
                //il riempiono i dati con l'oggetto selezionato
                isEditing = true;

                //si cerca il prodotto corrente
                string serieCerca = LSTBOXPRODUCTS.Items[LSTBOXPRODUCTS.SelectedIndex].ToString().Substring(LSTBOXPRODUCTS.Items[LSTBOXPRODUCTS.SelectedIndex].ToString().Length - 4); //ricava il numero seriale
                foreach (CProdotto prodotto in negozio.stocked)
                {
                    if (prodotto.ID == serieCerca)
                        prodottoSelezionato = prodotto;
                }

                //riempimento txtbox
                TXTDESCRIZIONE.Text = prodottoSelezionato.Descrizione;
                TXTNOME.Text = prodottoSelezionato.Nome;
                TXTPREZZO.Text = prodottoSelezionato.Prezzo.ToString();
                TXTQUANTITA.Text = prodottoSelezionato.Quantita.ToString();
                PBOXPREVIEW.ImageLocation = prodottoSelezionato.PathFoto;
                oldImagePath = prodottoSelezionato.PathFoto;
            }
        }

        private void Reset()
        {
            isEditing = false;
            oldImagePath = string.Empty;
            TXTDESCRIZIONE.Text = string.Empty;
            TXTNOME.Text = string.Empty;
            TXTPREZZO.Text = string.Empty;
            TXTQUANTITA.Text = string.Empty;
            PBOXPREVIEW.ImageLocation = string.Empty;
            oldImagePath = PBOXPREVIEW.ImageLocation;
        }

        private void BTNRESET_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BTNELIMINA_Click(object sender, EventArgs e)
        {
            if (LSTBOXPRODUCTS.SelectedIndex != -1)
            {
                //si cerca il prodotto corrente
                string cercaSerie = LSTBOXPRODUCTS.Items[LSTBOXPRODUCTS.SelectedIndex].ToString().Substring(LSTBOXPRODUCTS.Items[LSTBOXPRODUCTS.SelectedIndex].ToString().Length - 4); //ricava il numero seriale
                foreach (CProdotto prodotto in negozio.stocked)
                {
                    if (prodotto.ID == cercaSerie)
                        prodottoSelezionato = prodotto;
                }

                File.Delete(prodottoSelezionato.PathFoto);
                negozio.RemProdotto(prodottoSelezionato);
                RefreshListBox();

                //salvare su json
                DirectoryInfo dirInf = new DirectoryInfo(Directory.GetCurrentDirectory());
                string pathname = dirInf.Parent.Parent.Parent.FullName;
                pathname += @"\Resources\Store\Stocked.json";

                File.WriteAllText(pathname, JsonConvert.SerializeObject(negozio));
            }
        }
    }
}
