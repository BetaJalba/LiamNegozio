namespace LiAM_Anch_io
{
    partial class FLiamPlus
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
            LBLPLUS = new Label();
            TXTNOME = new TextBox();
            MSKDTXT = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            BTNCONFERMA = new Button();
            SuspendLayout();
            // 
            // LBLPLUS
            // 
            LBLPLUS.AutoSize = true;
            LBLPLUS.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LBLPLUS.Location = new Point(38, 41);
            LBLPLUS.Name = "LBLPLUS";
            LBLPLUS.Size = new Size(248, 41);
            LBLPLUS.TabIndex = 0;
            LBLPLUS.Text = "LIAM PLUSSSS!!!";
            // 
            // TXTNOME
            // 
            TXTNOME.Location = new Point(70, 139);
            TXTNOME.Name = "TXTNOME";
            TXTNOME.Size = new Size(165, 27);
            TXTNOME.TabIndex = 1;
            // 
            // MSKDTXT
            // 
            MSKDTXT.Location = new Point(70, 216);
            MSKDTXT.Name = "MSKDTXT";
            MSKDTXT.Size = new Size(165, 27);
            MSKDTXT.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 116);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 3;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 193);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // BTNCONFERMA
            // 
            BTNCONFERMA.Location = new Point(103, 277);
            BTNCONFERMA.Name = "BTNCONFERMA";
            BTNCONFERMA.Size = new Size(94, 29);
            BTNCONFERMA.TabIndex = 6;
            BTNCONFERMA.Text = "Convalida";
            BTNCONFERMA.UseVisualStyleBackColor = true;
            BTNCONFERMA.Click += BTNCONFERMA_Click;
            // 
            // FLiamPlus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 350);
            Controls.Add(BTNCONFERMA);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MSKDTXT);
            Controls.Add(TXTNOME);
            Controls.Add(LBLPLUS);
            Name = "FLiamPlus";
            Text = "FLiamPlus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBLPLUS;
        private TextBox TXTNOME;
        private MaskedTextBox MSKDTXT;
        private Label label1;
        private Label label2;
        private Button BTNCONFERMA;
    }
}