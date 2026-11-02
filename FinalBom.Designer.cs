namespace JogoCombateAoBullyingECyberbullying
{
    partial class FinalBom
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
            btnMostraPontuacao.Location = new Point(869, 514);
            btnMostraPontuacao.Name = "btnMostraPontuacao";
            btnMostraPontuacao.Size = new Size(179, 39);
            btnMostraPontuacao.TabIndex = 0;
            btnMostraPontuacao.UseVisualStyleBackColor = true;
            btnMostraPontuacao.Click += btnMostraPontuacao_Click;
            // 
            // FinalBom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Final_Bom_Pontuação;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 561);
            Controls.Add(btnMostraPontuacao);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FinalBom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinalBom";
            FormClosing += FinalBom_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnMostraPontuacao;
    }
}