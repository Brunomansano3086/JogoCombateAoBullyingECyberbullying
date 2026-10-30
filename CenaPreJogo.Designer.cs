namespace JogoCombateAoBullyingECyberbullying
{
    partial class CenaPreJogo
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
            btnComecarJogo = new Button();
            SuspendLayout();
            // 
            // btnComecarJogo
            // 
            btnComecarJogo.Location = new Point(252, 416);
            btnComecarJogo.Name = "btnComecarJogo";
            btnComecarJogo.Size = new Size(299, 32);
            btnComecarJogo.TabIndex = 0;
            btnComecarJogo.Text = "Começar jogo";
            btnComecarJogo.UseVisualStyleBackColor = true;
            btnComecarJogo.Click += btnComecarJogo_Click;
            // 
            // CenaPreJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.CenaPreJogo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnComecarJogo);
            Name = "CenaPreJogo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CenaPreJogo";
            ResumeLayout(false);
        }

        #endregion

        private Button btnComecarJogo;
    }
}