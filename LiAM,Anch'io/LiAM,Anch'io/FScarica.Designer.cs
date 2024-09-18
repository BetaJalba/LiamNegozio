namespace LiAM_Anch_io
{
    partial class FScarica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FScarica));
            PNLPRODUCT = new Panel();
            LSTBOXPRODUCTS = new ListBox();
            PNLINFO = new Panel();
            label1 = new Label();
            PNLDESCRIZIONE = new Panel();
            LBLQUANTITA = new Label();
            LBLPREZZO = new Label();
            BTNADDCART = new Button();
            TXTQUANTITA = new TextBox();
            LBLDESC = new Label();
            LBLNOME = new Label();
            PBOXITEM = new PictureBox();
            panel1 = new Panel();
            BTNREMOVE = new Button();
            BTNCHECKOUT = new Button();
            LSTBOXSCONTRINO = new ListBox();
            panel2 = new Panel();
            LBLSCONTRINO = new Label();
            PPWDLGSCONTRINO = new PrintPreviewDialog();
            CKBOX = new CheckBox();
            PNLPRODUCT.SuspendLayout();
            PNLINFO.SuspendLayout();
            PNLDESCRIZIONE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBOXITEM).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // PNLPRODUCT
            // 
            PNLPRODUCT.BorderStyle = BorderStyle.Fixed3D;
            PNLPRODUCT.Controls.Add(LSTBOXPRODUCTS);
            PNLPRODUCT.Location = new Point(29, 113);
            PNLPRODUCT.Name = "PNLPRODUCT";
            PNLPRODUCT.Size = new Size(232, 344);
            PNLPRODUCT.TabIndex = 0;
            // 
            // LSTBOXPRODUCTS
            // 
            LSTBOXPRODUCTS.FormattingEnabled = true;
            LSTBOXPRODUCTS.Location = new Point(6, 7);
            LSTBOXPRODUCTS.Name = "LSTBOXPRODUCTS";
            LSTBOXPRODUCTS.Size = new Size(217, 324);
            LSTBOXPRODUCTS.TabIndex = 0;
            LSTBOXPRODUCTS.SelectedIndexChanged += LSTBOXPRODUCTS_SelectedIndexChanged;
            // 
            // PNLINFO
            // 
            PNLINFO.BorderStyle = BorderStyle.Fixed3D;
            PNLINFO.Controls.Add(label1);
            PNLINFO.Location = new Point(29, 15);
            PNLINFO.Name = "PNLINFO";
            PNLINFO.Size = new Size(232, 75);
            PNLINFO.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ebrima", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 17);
            label1.Name = "label1";
            label1.Size = new Size(136, 41);
            label1.TabIndex = 1;
            label1.Text = "Prodotti";
            // 
            // PNLDESCRIZIONE
            // 
            PNLDESCRIZIONE.BorderStyle = BorderStyle.Fixed3D;
            PNLDESCRIZIONE.Controls.Add(LBLQUANTITA);
            PNLDESCRIZIONE.Controls.Add(LBLPREZZO);
            PNLDESCRIZIONE.Controls.Add(BTNADDCART);
            PNLDESCRIZIONE.Controls.Add(TXTQUANTITA);
            PNLDESCRIZIONE.Controls.Add(LBLDESC);
            PNLDESCRIZIONE.Controls.Add(LBLNOME);
            PNLDESCRIZIONE.Controls.Add(PBOXITEM);
            PNLDESCRIZIONE.Location = new Point(314, 19);
            PNLDESCRIZIONE.Name = "PNLDESCRIZIONE";
            PNLDESCRIZIONE.Size = new Size(298, 437);
            PNLDESCRIZIONE.TabIndex = 2;
            PNLDESCRIZIONE.Visible = false;
            // 
            // LBLQUANTITA
            // 
            LBLQUANTITA.AutoSize = true;
            LBLQUANTITA.Location = new Point(24, 394);
            LBLQUANTITA.Name = "LBLQUANTITA";
            LBLQUANTITA.Size = new Size(89, 20);
            LBLQUANTITA.TabIndex = 6;
            LBLQUANTITA.Text = "Quantità: 12";
            // 
            // LBLPREZZO
            // 
            LBLPREZZO.AutoSize = true;
            LBLPREZZO.Location = new Point(128, 241);
            LBLPREZZO.Name = "LBLPREZZO";
            LBLPREZZO.Size = new Size(134, 20);
            LBLPREZZO.TabIndex = 5;
            LBLPREZZO.Text = "Prezzo: 2,50€ al pz.";
            // 
            // BTNADDCART
            // 
            BTNADDCART.Location = new Point(177, 364);
            BTNADDCART.Name = "BTNADDCART";
            BTNADDCART.Size = new Size(94, 29);
            BTNADDCART.TabIndex = 4;
            BTNADDCART.Text = "AGGIUNGI";
            BTNADDCART.UseVisualStyleBackColor = true;
            BTNADDCART.Click += BTNADDCART_Click;
            // 
            // TXTQUANTITA
            // 
            TXTQUANTITA.Location = new Point(24, 364);
            TXTQUANTITA.Name = "TXTQUANTITA";
            TXTQUANTITA.Size = new Size(125, 27);
            TXTQUANTITA.TabIndex = 3;
            TXTQUANTITA.KeyDown += TXTQUANTITA_KeyDownn;
            // 
            // LBLDESC
            // 
            LBLDESC.Location = new Point(24, 276);
            LBLDESC.Name = "LBLDESC";
            LBLDESC.Size = new Size(247, 67);
            LBLDESC.TabIndex = 2;
            LBLDESC.Text = "Pane di finissima qualità realizzato con grano da farina tipo '0'";
            // 
            // LBLNOME
            // 
            LBLNOME.AutoSize = true;
            LBLNOME.Location = new Point(24, 241);
            LBLNOME.Name = "LBLNOME";
            LBLNOME.Size = new Size(53, 20);
            LBLNOME.TabIndex = 1;
            LBLNOME.Text = "P a n e";
            // 
            // PBOXITEM
            // 
            PBOXITEM.Location = new Point(24, 13);
            PBOXITEM.Name = "PBOXITEM";
            PBOXITEM.Size = new Size(247, 212);
            PBOXITEM.SizeMode = PictureBoxSizeMode.StretchImage;
            PBOXITEM.TabIndex = 0;
            PBOXITEM.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(CKBOX);
            panel1.Controls.Add(BTNREMOVE);
            panel1.Controls.Add(BTNCHECKOUT);
            panel1.Controls.Add(LSTBOXSCONTRINO);
            panel1.Location = new Point(664, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 342);
            panel1.TabIndex = 3;
            // 
            // BTNREMOVE
            // 
            BTNREMOVE.Location = new Point(160, 270);
            BTNREMOVE.Name = "BTNREMOVE";
            BTNREMOVE.Size = new Size(108, 29);
            BTNREMOVE.TabIndex = 2;
            BTNREMOVE.Text = "Rimuovi";
            BTNREMOVE.UseVisualStyleBackColor = true;
            BTNREMOVE.Click += BTNREMOVE_Click;
            // 
            // BTNCHECKOUT
            // 
            BTNCHECKOUT.Location = new Point(32, 270);
            BTNCHECKOUT.Name = "BTNCHECKOUT";
            BTNCHECKOUT.Size = new Size(108, 61);
            BTNCHECKOUT.TabIndex = 1;
            BTNCHECKOUT.Text = "Cash OUT";
            BTNCHECKOUT.UseVisualStyleBackColor = true;
            BTNCHECKOUT.Click += BTNCHECKOUT_Click;
            // 
            // LSTBOXSCONTRINO
            // 
            LSTBOXSCONTRINO.FormattingEnabled = true;
            LSTBOXSCONTRINO.Location = new Point(13, 17);
            LSTBOXSCONTRINO.Name = "LSTBOXSCONTRINO";
            LSTBOXSCONTRINO.Size = new Size(269, 244);
            LSTBOXSCONTRINO.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(LBLSCONTRINO);
            panel2.Location = new Point(664, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(302, 75);
            panel2.TabIndex = 2;
            // 
            // LBLSCONTRINO
            // 
            LBLSCONTRINO.AutoSize = true;
            LBLSCONTRINO.Font = new Font("Ebrima", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLSCONTRINO.Location = new Point(75, 13);
            LBLSCONTRINO.Name = "LBLSCONTRINO";
            LBLSCONTRINO.Size = new Size(154, 41);
            LBLSCONTRINO.TabIndex = 1;
            LBLSCONTRINO.Text = "Scontrino";
            // 
            // PPWDLGSCONTRINO
            // 
            PPWDLGSCONTRINO.AutoScrollMargin = new Size(0, 0);
            PPWDLGSCONTRINO.AutoScrollMinSize = new Size(0, 0);
            PPWDLGSCONTRINO.ClientSize = new Size(400, 300);
            PPWDLGSCONTRINO.Enabled = true;
            PPWDLGSCONTRINO.Icon = (Icon)resources.GetObject("PPWDLGSCONTRINO.Icon");
            PPWDLGSCONTRINO.Name = "PPWDLGSCONTRINO";
            PPWDLGSCONTRINO.Visible = false;
            // 
            // CKBOX
            // 
            CKBOX.AutoSize = true;
            CKBOX.Location = new Point(171, 307);
            CKBOX.Name = "CKBOX";
            CKBOX.Size = new Size(97, 24);
            CKBOX.TabIndex = 3;
            CKBOX.Text = "Liam Plus!";
            CKBOX.UseVisualStyleBackColor = true;
            // 
            // FScarica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.lidlPane;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(992, 479);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(PNLDESCRIZIONE);
            Controls.Add(PNLINFO);
            Controls.Add(PNLPRODUCT);
            Name = "FScarica";
            Text = "FScarica";
            Load += FScarica_Load;
            PNLPRODUCT.ResumeLayout(false);
            PNLINFO.ResumeLayout(false);
            PNLINFO.PerformLayout();
            PNLDESCRIZIONE.ResumeLayout(false);
            PNLDESCRIZIONE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBOXITEM).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private void TXTQUANTITA_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel PNLPRODUCT;
        private Panel PNLINFO;
        private Label label1;
        private ListBox LSTBOXPRODUCTS;
        private Panel PNLDESCRIZIONE;
        private Label LBLDESC;
        private Label LBLNOME;
        private PictureBox PBOXITEM;
        private Label LBLPREZZO;
        private Button BTNADDCART;
        private TextBox TXTQUANTITA;
        private Panel panel1;
        private Panel panel2;
        private Label LBLSCONTRINO;
        private Label LBLQUANTITA;
        private Button BTNREMOVE;
        private Button BTNCHECKOUT;
        private ListBox LSTBOXSCONTRINO;
        private PrintPreviewDialog PPWDLGSCONTRINO;
        private CheckBox CKBOX;
    }
}