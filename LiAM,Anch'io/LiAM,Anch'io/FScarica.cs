using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiAM_Anch_io
{
    public partial class FScarica : Form
    {
        CNegozio negozio;
        CProdotto prodottoSelezionato;
        bool liamPlus;
        public FScarica(CNegozio negozio)
        {
            InitializeComponent();
            this.negozio = negozio;
        }

        private void FScarica_Load(object sender, EventArgs e)
        {
            this.Width = 300;
            LSTBOXPRODUCTS.Items.Clear();
            foreach (var prodotto in negozio.stocked)
            {
                LSTBOXPRODUCTS.Items.Add($"Nome: {prodotto.Nome}; ID: {prodotto.ID}"); //ricerca con l'ID
            }
        }

        private void LSTBOXPRODUCTS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LSTBOXPRODUCTS.SelectedIndex != -1)
            {
                //si allarga la schermata
                if (this.Width != 1010)
                {
                    this.Width = 665;
                }
                PNLDESCRIZIONE.Visible = true;

                //si cerca il prodotto corrente
                string cercaSerie = LSTBOXPRODUCTS.Items[LSTBOXPRODUCTS.SelectedIndex].ToString().Substring(LSTBOXPRODUCTS.Items[LSTBOXPRODUCTS.SelectedIndex].ToString().Length - 4); //ricava il numero seriale
                foreach (CProdotto prodotto in negozio.stocked)
                {
                    if (prodotto.ID == cercaSerie)
                        prodottoSelezionato = prodotto;
                }

                PBOXITEM.ImageLocation = prodottoSelezionato.PathFoto;
                LBLNOME.Text = prodottoSelezionato.Nome;
                LBLPREZZO.Text = $"Prezzo: {prodottoSelezionato.Prezzo}€ al pz";
                LBLDESC.Text = prodottoSelezionato.Descrizione;
                LBLQUANTITA.Text = prodottoSelezionato.Quantita.ToString();
            }
        }

        private void TXTQUANTITA_KeyDownn(object sender, KeyEventArgs press)
        {
            //consente l'input di soli caratteri numerici
            if (Control.ModifierKeys.HasFlag(Keys.Shift))
                press.SuppressKeyPress = true;
            else if ((press.KeyValue < 48 || press.KeyValue > 57) && press.KeyValue != 8)
                press.SuppressKeyPress = true;
        }

        private void BTNADDCART_Click(object sender, EventArgs e)
        {
            if (TXTQUANTITA.Text != "" && int.Parse(TXTQUANTITA.Text) <= prodottoSelezionato.Quantita)
            {
                this.Width = 1010;

                bool alreadyIn = false; //verifica se il prodotto è gia presente nello scontrino
                int index = -1;

                if (LSTBOXSCONTRINO.Items.Count > 0)
                {

                    foreach (string entry in LSTBOXSCONTRINO.Items)
                    {
                        index++;
                        if (entry.Substring(entry.Length - 4) == prodottoSelezionato.ID)
                        {
                            alreadyIn = true;
                            break;
                        }
                    }
                }

                if (alreadyIn)
                {
                    //si conosce l'indice del prodotto nello scontrino
                    char[] separatori = { ';', ' ' };
                    int vecchiaQuantita = int.Parse(LSTBOXSCONTRINO.Items[index].ToString().Split(separatori, StringSplitOptions.RemoveEmptyEntries)[2]); //prene la quantità già esistente
                    LSTBOXSCONTRINO.Items.RemoveAt(index);
                    LSTBOXSCONTRINO.Items.Insert(index, $"- {prodottoSelezionato.Nome}; {vecchiaQuantita + int.Parse(TXTQUANTITA.Text)}; {prodottoSelezionato.Prezzo * (vecchiaQuantita + int.Parse(TXTQUANTITA.Text))}; {prodottoSelezionato.ID}");

                }
                else
                {
                    LSTBOXSCONTRINO.Items.Add($"- {prodottoSelezionato.Nome}; {TXTQUANTITA.Text}; {prodottoSelezionato.Prezzo * int.Parse(TXTQUANTITA.Text)}; {prodottoSelezionato.ID}"); // - nome; quantità; prezzo tot; numero serie
                }
                prodottoSelezionato.Quantita -= int.Parse(TXTQUANTITA.Text);
                LBLQUANTITA.Text = prodottoSelezionato.Quantita.ToString();

                SalvaSuJSON();
            }
        }

        private void BTNREMOVE_Click(object sender, EventArgs e)
        {
            if (LSTBOXSCONTRINO.SelectedIndex != -1)
            {
                char[] separatori = { ';', ' ' };
                int quantitàRestituita = int.Parse(LSTBOXSCONTRINO.Items[LSTBOXSCONTRINO.SelectedIndex].ToString().Split(separatori, StringSplitOptions.RemoveEmptyEntries)[2]);
                string serie = LSTBOXSCONTRINO.Items[LSTBOXSCONTRINO.SelectedIndex].ToString().Substring(LSTBOXSCONTRINO.Items[LSTBOXSCONTRINO.SelectedIndex].ToString().Length - 4);

                LSTBOXSCONTRINO.Items.RemoveAt(LSTBOXSCONTRINO.SelectedIndex);

                foreach (CProdotto prodotto in negozio.stocked)
                {
                    if (prodotto.ID == serie)
                        prodotto.Quantita += quantitàRestituita;
                }

                LBLQUANTITA.Text = prodottoSelezionato.Quantita.ToString(); //nel caso il prodotto rimosso dallo scontrino fosse già in videata
            }

            SalvaSuJSON();
        }

        private void BTNCHECKOUT_Click(object sender, EventArgs e)
        {
            if (LSTBOXSCONTRINO.Items.Count > 0) 
            {
                SalvaSuJSON();
                liamPlus = false;

                if (CKBOX.Checked) 
                {
                    FLiamPlus fLiamPlus = new FLiamPlus();
                    if (fLiamPlus.ShowDialog() == DialogResult.OK)
                        liamPlus = true;
                }

                PrintDialog printDialog = new PrintDialog();
                PrintDocument printDocument = new PrintDocument();

                printDialog.Document = printDocument;   //aggiungi il documento alla dialog box
                printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //aggiungi l'event handler per stampare la pagina

                //avvia la finestra di stampa
                DialogResult result = printDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    printDocument.Print();
                    this.Close(); //chiude le compere (esci dal negozio dopo aver comprato)
                }
            }
        }

        public void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);

            float fontHeight = font.GetHeight();

            //offset rigorosamente testati a mano
            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("     Liam, Anch'io!", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            string top = "Nome".PadRight(30) + "Prezzo";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;

            decimal totale = 0;

            foreach (string item in LSTBOXSCONTRINO.Items)
            {
                string[] parti = item.Split(';');

                //si prendono le parti dallo scontrino sul form
                string nome = parti[0].Substring(2);
                int quantita = int.Parse(parti[1]);
                decimal prezzo = decimal.Parse(parti[2]);

                totale += prezzo;

                graphic.DrawString(nome, font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(quantita.ToString(), font, new SolidBrush(Color.Black), startX + 240, startY + offset);
                graphic.DrawString(prezzo.ToString(), font, new SolidBrush(Color.Black), startX + 310, startY + offset);
                offset += (int)fontHeight + 5;
            }

            offset = offset + (int)fontHeight;
            graphic.DrawString("------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;

            if (liamPlus)
                graphic.DrawString("Totale (Sconto LiamPlus 30%)".PadRight(30) + (totale - (totale*30)/100), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            else
                graphic.DrawString("Totale".PadRight(30) + totale, new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 30; //spaziato
            graphic.DrawString("    Grazie per le sue compere,", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString("   Liam si augura di ritrovarti!", font, new SolidBrush(Color.Black), startX, startY + offset);
        }

        private void SalvaSuJSON()
        {
            //salvare su json
            DirectoryInfo dirInf = new DirectoryInfo(Directory.GetCurrentDirectory());
            string pathname = dirInf.Parent.Parent.Parent.FullName;
            pathname += @"\Resources\Store\Stocked.json";

            File.WriteAllText(pathname, JsonConvert.SerializeObject(negozio));
        }
    }
}
