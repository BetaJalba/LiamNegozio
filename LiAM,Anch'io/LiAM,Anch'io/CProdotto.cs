using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiAM_Anch_io
{
    public class CProdotto
    {
        //come per esercizi passati in cui si utilizzavano attributi statici
        //che incrementavano mano a mano con la creazione di una classe
        //provare a ricrearlo in un programma che deve salvare gli eventuali dati
        //con un semplice static non è possibile
        //per questo invece l'attributo viene salvato su un file
        //a cui la path e la serie corrente è comune a tutti i prodotti
        static string serieFilePath = @"..\..\..\Resources\Store\currentMax.txt"; //il corrente andamento della serie viene salvato su un file apparte
        static int currentSerie = int.Parse(File.ReadAllText(serieFilePath));

        [JsonProperty("id")] //per differenziarlo da ID (che pare non funzioni)
        string id;
        public string ID 
        {
            get 
            {
                return id;
            }
            private set 
            {
                
                //l'id verrà salvato nel formato "XXXX"
                if (int.Parse(value) < 10) 
                {
                    //"000X"
                    id = "000" + value;
                } else if (int.Parse(value) < 100)
                {
                    //"00XX"
                    id = "00" + value;
                } else if (int.Parse(value) < 1000) 
                {
                    //"0XXX"
                    id = "0" + value;
                } else if (int.Parse(value) < 10000) 
                {
                    //"XXXX"
                    id = value;
                } else //id superiore a 9999 
                {
                    throw new Exception("Superato l'id massimo");
                }
            } 
        }
        public string Nome { get; private set; }
        public decimal Prezzo { get; private set; }
        public string PathFoto { get; private set; }
        public string Descrizione { get; private set; }
        public int Quantita { get; private set; }

        public CProdotto()
        {
        }
        public CProdotto(string Nome, decimal Prezzo, string Descrizione, int Quantita)
        {
            ID = currentSerie.ToString();
            currentSerie++;
            File.WriteAllText(serieFilePath, currentSerie.ToString());
            this.Nome = Nome;
            this.Prezzo = Prezzo;
            this.Descrizione = Descrizione;
            this.Quantita = Quantita;
        }

        //se si specifica la quantita iniziale del prodotto nel negozio
        public CProdotto(string Nome, decimal Prezzo, string PathFoto, string Descrizione, int Quantita)
        {

            ID = currentSerie.ToString();
            currentSerie++;
            File.WriteAllText(serieFilePath, currentSerie.ToString());
            this.Nome = Nome;
            this.Prezzo = Prezzo;
            this.PathFoto = PathFoto;
            this.Descrizione = Descrizione;
            this.Quantita = Quantita;
        }

        [JsonConstructor] //costruttore con parametri
        public CProdotto(string ID, string Nome, decimal Prezzo, string PathFoto, string Descrizione, int Quantita) 
        {
            this.id = ID;
            this.Nome = Nome;
            this.Prezzo = Prezzo;
            this.PathFoto = PathFoto;
            this.Descrizione = Descrizione;
            this.Quantita = Quantita;
        }

        public void ModificaProdotto( string Nome, decimal Prezzo, string PathFoto, string Descrizione, int Quantita) 
        {
            this.Nome = Nome;
            this.Prezzo = Prezzo;
            this.PathFoto = PathFoto;
            this.Descrizione = Descrizione;
            this.Quantita = Quantita;
        }

        public void ModificaPathFoto(string pathFoto) 
        {
            this.PathFoto = pathFoto;
        }
    }
}
