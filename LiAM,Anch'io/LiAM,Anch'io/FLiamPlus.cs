using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiAM_Anch_io
{
    public partial class FLiamPlus : Form
    {
        public FLiamPlus()
        {
            InitializeComponent();
        }

        private void BTNCONFERMA_Click(object sender, EventArgs e)
        {
            if (MSKDTXT.Text != "" && TXTNOME.Text != "") 
            {
                CLiamPlus liamPlus = new CLiamPlus();
                if (liamPlus.CheckLogin(TXTNOME.Text, MSKDTXT.Text))
                    DialogResult = DialogResult.OK;

                Close();
            } 
        }
    }
}
