using Newtonsoft.Json;

namespace LiAM_Anch_io
{
    public partial class Main : Form
    {
        CNegozio negozio;
        public Main()
        {
            InitializeComponent();
        }

        private void BTNSCARICA_Click(object sender, EventArgs e)
        {
            this.Visible = false;  //nasconde la finestra

            FScarica cliente = new FScarica(negozio);

            if (cliente.ShowDialog() == DialogResult.Cancel) //chiusura finestra per default oppure impostato manualmente 
            {
                this.Visible = true; //riapre la finestra
            }

            //apre la scheda cliente e nasconde questa
            //per ritornarci basta chiudere la scheda precendente oppure
            //utilizzare un bottone apposito
        }

        private void BTNCARICA_Click(object sender, EventArgs e)
        {
            this.Visible = false;  //nasconde la finestra

            FCarica cliente = new FCarica(negozio);

            if (cliente.ShowDialog() == DialogResult.Cancel) //chiusura finestra per default oppure impostato manualmente 
            {
                this.Visible = true; //riapre la finestra
            }

            //apre la scheda cliente e nasconde questa
            //per ritornarci basta chiudere la scheda precendente oppure
            //utilizzare un bottone apposito
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //controllo presenza file json e lettura
            DirectoryInfo dirInfo = new DirectoryInfo(Directory.GetCurrentDirectory());
            string pathname = dirInfo.Parent.Parent.Parent.FullName + @"\Resources\Store\Stocked.json";

            
            if (!File.Exists(pathname)) //se il file non esiste
            {
                using (var fileCheck = File.Create(pathname)){}
                negozio = new CNegozio();
            } else 
            {
                using (var streamReader = new StreamReader(pathname))
                {
                    string read = streamReader.ReadToEnd();
                    if (read.Length > 2)
                    {
                        //json deserialize

                        negozio = JsonConvert.DeserializeObject<CNegozio>(read); //il verdino mente
                    }
                    else
                        negozio = new CNegozio();
                }
            }
        }
    }
}
