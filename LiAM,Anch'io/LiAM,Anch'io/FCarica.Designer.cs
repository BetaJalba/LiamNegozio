namespace LiAM_Anch_io
{
    partial class FCarica
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
            Button BTNCONFERMA;
            PNLINFO = new Panel();
            LBLINFO = new Label();
            PNLPRODUCT = new Panel();
            LSTBOXPRODUCTS = new ListBox();
            PNLINFOMERCI = new Panel();
            LBLINFOMERCI = new Label();
            panel1 = new Panel();
            BTNRESET = new Button();
            LBLIMMAGINE = new Label();
            BTNBROWSE = new Button();
            PBOXPREVIEW = new PictureBox();
            LBLQUANTITA = new Label();
            TXTQUANTITA = new TextBox();
            LBLDESCRIZIONE = new Label();
            LBLPREZZO = new Label();
            LBLNOME = new Label();
            TXTPREZZO = new TextBox();
            TXTDESCRIZIONE = new TextBox();
            TXTNOME = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            panel2 = new Panel();
            BTNELIMINA = new Button();
            BTNSELECT = new Button();
            BTNCONFERMA = new Button();
            PNLINFO.SuspendLayout();
            PNLPRODUCT.SuspendLayout();
            PNLINFOMERCI.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBOXPREVIEW).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // BTNCONFERMA
            // 
            BTNCONFERMA.Location = new Point(249, 330);
            BTNCONFERMA.Name = "BTNCONFERMA";
            BTNCONFERMA.Size = new Size(146, 62);
            BTNCONFERMA.TabIndex = 12;
            BTNCONFERMA.Text = "CONFERMA";
            BTNCONFERMA.UseVisualStyleBackColor = true;
            BTNCONFERMA.Click += BTNCONFERMA_Click;
            // 
            // PNLINFO
            // 
            PNLINFO.BorderStyle = BorderStyle.Fixed3D;
            PNLINFO.Controls.Add(LBLINFO);
            PNLINFO.Location = new Point(31, 21);
            PNLINFO.Name = "PNLINFO";
            PNLINFO.Size = new Size(232, 92);
            PNLINFO.TabIndex = 3;
            // 
            // LBLINFO
            // 
            LBLINFO.AutoSize = true;
            LBLINFO.Font = new Font("Ebrima", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLINFO.Location = new Point(37, 26);
            LBLINFO.Name = "LBLINFO";
            LBLINFO.Size = new Size(136, 41);
            LBLINFO.TabIndex = 1;
            LBLINFO.Text = "Prodotti";
            // 
            // PNLPRODUCT
            // 
            PNLPRODUCT.BorderStyle = BorderStyle.Fixed3D;
            PNLPRODUCT.Controls.Add(LSTBOXPRODUCTS);
            PNLPRODUCT.Location = new Point(31, 119);
            PNLPRODUCT.Name = "PNLPRODUCT";
            PNLPRODUCT.Size = new Size(232, 325);
            PNLPRODUCT.TabIndex = 2;
            // 
            // LSTBOXPRODUCTS
            // 
            LSTBOXPRODUCTS.FormattingEnabled = true;
            LSTBOXPRODUCTS.Location = new Point(6, 7);
            LSTBOXPRODUCTS.Name = "LSTBOXPRODUCTS";
            LSTBOXPRODUCTS.Size = new Size(217, 304);
            LSTBOXPRODUCTS.TabIndex = 0;
            // 
            // PNLINFOMERCI
            // 
            PNLINFOMERCI.BorderStyle = BorderStyle.Fixed3D;
            PNLINFOMERCI.Controls.Add(LBLINFOMERCI);
            PNLINFOMERCI.Location = new Point(324, 21);
            PNLINFOMERCI.Name = "PNLINFOMERCI";
            PNLINFOMERCI.Size = new Size(463, 92);
            PNLINFOMERCI.TabIndex = 4;
            // 
            // LBLINFOMERCI
            // 
            LBLINFOMERCI.AutoSize = true;
            LBLINFOMERCI.Font = new Font("Ebrima", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLINFOMERCI.Location = new Point(103, 26);
            LBLINFOMERCI.Name = "LBLINFOMERCI";
            LBLINFOMERCI.Size = new Size(236, 41);
            LBLINFOMERCI.TabIndex = 2;
            LBLINFOMERCI.Text = "Aggiunta merci";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(BTNCONFERMA);
            panel1.Controls.Add(BTNRESET);
            panel1.Controls.Add(LBLIMMAGINE);
            panel1.Controls.Add(BTNBROWSE);
            panel1.Controls.Add(PBOXPREVIEW);
            panel1.Controls.Add(LBLQUANTITA);
            panel1.Controls.Add(TXTQUANTITA);
            panel1.Controls.Add(LBLDESCRIZIONE);
            panel1.Controls.Add(LBLPREZZO);
            panel1.Controls.Add(LBLNOME);
            panel1.Controls.Add(TXTPREZZO);
            panel1.Controls.Add(TXTDESCRIZIONE);
            panel1.Controls.Add(TXTNOME);
            panel1.Location = new Point(324, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 424);
            panel1.TabIndex = 5;
            // 
            // BTNRESET
            // 
            BTNRESET.Location = new Point(69, 330);
            BTNRESET.Name = "BTNRESET";
            BTNRESET.Size = new Size(146, 62);
            BTNRESET.TabIndex = 11;
            BTNRESET.Text = "RESET";
            BTNRESET.UseVisualStyleBackColor = true;
            BTNRESET.Click += BTNRESET_Click;
            // 
            // LBLIMMAGINE
            // 
            LBLIMMAGINE.AutoSize = true;
            LBLIMMAGINE.Location = new Point(284, 92);
            LBLIMMAGINE.Name = "LBLIMMAGINE";
            LBLIMMAGINE.Size = new Size(143, 20);
            LBLIMMAGINE.TabIndex = 10;
            LBLIMMAGINE.Text = "Immagine prodotto:";
            // 
            // BTNBROWSE
            // 
            BTNBROWSE.Location = new Point(284, 245);
            BTNBROWSE.Name = "BTNBROWSE";
            BTNBROWSE.Size = new Size(125, 29);
            BTNBROWSE.TabIndex = 9;
            BTNBROWSE.Text = "Sfoglia...";
            BTNBROWSE.UseVisualStyleBackColor = true;
            BTNBROWSE.Click += BTNBROWSE_Click;
            // 
            // PBOXPREVIEW
            // 
            PBOXPREVIEW.BackgroundImageLayout = ImageLayout.Stretch;
            PBOXPREVIEW.Location = new Point(284, 115);
            PBOXPREVIEW.Name = "PBOXPREVIEW";
            PBOXPREVIEW.Size = new Size(143, 114);
            PBOXPREVIEW.SizeMode = PictureBoxSizeMode.StretchImage;
            PBOXPREVIEW.TabIndex = 8;
            PBOXPREVIEW.TabStop = false;
            // 
            // LBLQUANTITA
            // 
            LBLQUANTITA.AutoSize = true;
            LBLQUANTITA.Location = new Point(284, 17);
            LBLQUANTITA.Name = "LBLQUANTITA";
            LBLQUANTITA.Size = new Size(69, 20);
            LBLQUANTITA.TabIndex = 7;
            LBLQUANTITA.Text = "Quantità:";
            // 
            // TXTQUANTITA
            // 
            TXTQUANTITA.Location = new Point(284, 40);
            TXTQUANTITA.Name = "TXTQUANTITA";
            TXTQUANTITA.Size = new Size(125, 27);
            TXTQUANTITA.TabIndex = 6;
            TXTQUANTITA.KeyDown += TXTQUANTITA_KeyDown;
            // 
            // LBLDESCRIZIONE
            // 
            LBLDESCRIZIONE.AutoSize = true;
            LBLDESCRIZIONE.Location = new Point(42, 156);
            LBLDESCRIZIONE.Name = "LBLDESCRIZIONE";
            LBLDESCRIZIONE.Size = new Size(89, 20);
            LBLDESCRIZIONE.TabIndex = 5;
            LBLDESCRIZIONE.Text = "Descrizione:";
            // 
            // LBLPREZZO
            // 
            LBLPREZZO.AutoSize = true;
            LBLPREZZO.Location = new Point(42, 81);
            LBLPREZZO.Name = "LBLPREZZO";
            LBLPREZZO.Size = new Size(56, 20);
            LBLPREZZO.TabIndex = 4;
            LBLPREZZO.Text = "Prezzo:";
            // 
            // LBLNOME
            // 
            LBLNOME.AutoSize = true;
            LBLNOME.Location = new Point(42, 17);
            LBLNOME.Name = "LBLNOME";
            LBLNOME.Size = new Size(53, 20);
            LBLNOME.TabIndex = 3;
            LBLNOME.Text = "Nome:";
            // 
            // TXTPREZZO
            // 
            TXTPREZZO.Location = new Point(42, 104);
            TXTPREZZO.Name = "TXTPREZZO";
            TXTPREZZO.Size = new Size(125, 27);
            TXTPREZZO.TabIndex = 2;
            TXTPREZZO.KeyDown += TXTPREZZO_KeyDown;
            // 
            // TXTDESCRIZIONE
            // 
            TXTDESCRIZIONE.Location = new Point(42, 179);
            TXTDESCRIZIONE.Multiline = true;
            TXTDESCRIZIONE.Name = "TXTDESCRIZIONE";
            TXTDESCRIZIONE.Size = new Size(125, 95);
            TXTDESCRIZIONE.TabIndex = 1;
            // 
            // TXTNOME
            // 
            TXTNOME.Location = new Point(42, 40);
            TXTNOME.Name = "TXTNOME";
            TXTNOME.Size = new Size(125, 27);
            TXTNOME.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(BTNELIMINA);
            panel2.Controls.Add(BTNSELECT);
            panel2.Location = new Point(31, 451);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 92);
            panel2.TabIndex = 6;
            // 
            // BTNELIMINA
            // 
            BTNELIMINA.Location = new Point(125, 15);
            BTNELIMINA.Name = "BTNELIMINA";
            BTNELIMINA.Size = new Size(87, 60);
            BTNELIMINA.TabIndex = 1;
            BTNELIMINA.Text = "Elimina";
            BTNELIMINA.UseVisualStyleBackColor = true;
            BTNELIMINA.Click += BTNELIMINA_Click;
            // 
            // BTNSELECT
            // 
            BTNSELECT.Location = new Point(16, 15);
            BTNSELECT.Name = "BTNSELECT";
            BTNSELECT.Size = new Size(87, 60);
            BTNSELECT.TabIndex = 0;
            BTNSELECT.Text = "Seleziona";
            BTNSELECT.UseVisualStyleBackColor = true;
            BTNSELECT.Click += BTNSELECT_Click;
            // 
            // FCarica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1343542567_612x612;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(831, 555);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(PNLINFOMERCI);
            Controls.Add(PNLINFO);
            Controls.Add(PNLPRODUCT);
            Name = "FCarica";
            Text = "FCarica";
            Load += FCarica_Load;
            PNLINFO.ResumeLayout(false);
            PNLINFO.PerformLayout();
            PNLPRODUCT.ResumeLayout(false);
            PNLINFOMERCI.ResumeLayout(false);
            PNLINFOMERCI.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBOXPREVIEW).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PNLINFO;
        private Label LBLINFO;
        private Panel PNLPRODUCT;
        private ListBox LSTBOXPRODUCTS;
        private Panel PNLINFOMERCI;
        private Label LBLINFOMERCI;
        private Panel panel1;
        private TextBox TXTQUANTITA;
        private Label LBLDESCRIZIONE;
        private Label LBLPREZZO;
        private Label LBLNOME;
        private TextBox TXTPREZZO;
        private TextBox TXTDESCRIZIONE;
        private TextBox TXTNOME;
        private Button BTNBROWSE;
        private PictureBox PBOXPREVIEW;
        private Label LBLQUANTITA;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label LBLIMMAGINE;
        private Button BTNRESET;
        private Panel panel2;
        private Button BTNSELECT;
        private Button BTNELIMINA;
    }
}