namespace JogoCombateAoBullyingECyberbullying
{
    partial class FinalRuim
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
            btnMostraPontuacao = new Button();
            SuspendLayout();
            // 
            // btnMostraPontuacao
            // 
            btnMostraPontuacao.Location = new Point(639, 412);
            btnMostraPontuacao.Name = "btnMostraPontuacao";
            btnMostraPontuacao.Size = new Size(133, 32);
            btnMostraPontuacao.TabIndex = 1;
            btnMostraPontuacao.UseVisualStyleBackColor = true;
            btnMostraPontuacao.Click += btnMostraPontuacao_Click;
            // 
            // FinalRuim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Final_Ruim_Pontuação;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 561);
            Controls.Add(btnMostraPontuacao);
            Name = "FinalRuim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinalRuim";
            FormClosing += FinalRuim_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnMostraPontuacao;
    }
}