using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LiAM_Anch_io
{
    public class CNegozio
    {
        public List<CProdotto> stocked { get; set; }
        public int serie { get; set; }
        public CNegozio()
        {
            stocked = new List<CProdotto>();
            serie = 0;
        }

        [JsonConstructor]
        public CNegozio(List<CProdotto> stocked, int serie)
        {
            this.stocked = stocked;
            this.serie = serie;
        }

        public void AddProdotto(CProdotto prodotto) 
        {
            stocked.Add(prodotto);
        }

        public void RemProdotto(CProdotto prodotto) 
        {
            stocked.Remove(prodotto);
        }
    }
}
