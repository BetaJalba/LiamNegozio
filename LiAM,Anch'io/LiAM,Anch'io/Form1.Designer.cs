namespace LiAM_Anch_io
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PNLLiam = new Panel();
            PNLTitle = new Panel();
            label1 = new Label();
            PNLChoice = new Panel();
            BTNCARICA = new Button();
            BTNSCARICA = new Button();
            PNLTitle.SuspendLayout();
            PNLChoice.SuspendLayout();
            SuspendLayout();
            // 
            // PNLLiam
            // 
            PNLLiam.BackgroundImage = Properties.Resources.LiAM;
            PNLLiam.BackgroundImageLayout = ImageLayout.Stretch;
            PNLLiam.BorderStyle = BorderStyle.Fixed3D;
            PNLLiam.Location = new Point(24, 21);
            PNLLiam.Name = "PNLLiam";
            PNLLiam.Size = new Size(427, 402);
            PNLLiam.TabIndex = 0;
            // 
            // PNLTitle
            // 
            PNLTitle.BackColor = SystemColors.ControlLightLight;
            PNLTitle.BorderStyle = BorderStyle.Fixed3D;
            PNLTitle.Controls.Add(label1);
            PNLTitle.Location = new Point(480, 21);
            PNLTitle.Name = "PNLTitle";
            PNLTitle.Size = new Size(294, 97);
            PNLTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ebrima", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 29);
            label1.Name = "label1";
            label1.Size = new Size(213, 41);
            label1.TabIndex = 0;
            label1.Text = "Liam, anch'io!";
            // 
            // PNLChoice
            // 
            PNLChoice.BackColor = SystemColors.ButtonHighlight;
            PNLChoice.BorderStyle = BorderStyle.Fixed3D;
            PNLChoice.Controls.Add(BTNCARICA);
            PNLChoice.Controls.Add(BTNSCARICA);
            PNLChoice.Location = new Point(480, 145);
            PNLChoice.Name = "PNLChoice";
            PNLChoice.Size = new Size(294, 278);
            PNLChoice.TabIndex = 2;
            // 
            // BTNCARICA
            // 
            BTNCARICA.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNCARICA.Location = new Point(36, 166);
            BTNCARICA.Name = "BTNCARICA";
            BTNCARICA.Size = new Size(213, 73);
            BTNCARICA.TabIndex = 1;
            BTNCARICA.Text = "CARICA";
            BTNCARICA.UseVisualStyleBackColor = true;
            BTNCARICA.Click += BTNCARICA_Click;
            // 
            // BTNSCARICA
            // 
            BTNSCARICA.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNSCARICA.Location = new Point(36, 45);
            BTNSCARICA.Name = "BTNSCARICA";
            BTNSCARICA.Size = new Size(213, 73);
            BTNSCARICA.TabIndex = 0;
            BTNSCARICA.Text = "SCARICA";
            BTNSCARICA.UseVisualStyleBackColor = true;
            BTNSCARICA.Click += BTNSCARICA_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvdjU0NmJhdGNoMy1teW50LTM0LWJhZGdld2F0ZXJjb2xvcl8xLmpwZw;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(PNLChoice);
            Controls.Add(PNLTitle);
            Controls.Add(PNLLiam);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            PNLTitle.ResumeLayout(false);
            PNLTitle.PerformLayout();
            PNLChoice.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PNLLiam;
        private Panel PNLTitle;
        private Panel PNLChoice;
        private Label label1;
        private Button BTNSCARICA;
        private Button BTNCARICA;
    }
}
