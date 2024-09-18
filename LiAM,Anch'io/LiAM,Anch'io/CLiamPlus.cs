using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiAM_Anch_io
{
    public class CLiamPlus
    {
        string nome;
        string credenziali;

        public CLiamPlus() 
        {
            this.nome = "Liam";
            this.credenziali = "c'e'solounacartapoveretto";
        }

        public bool CheckLogin(string nome, string credenziali) 
        {
            if (this.nome == nome && this.credenziali == credenziali) 
                return true;
            return false;
        }
    }
}
