namespace JogoCombateAoBullyingECyberbullying
{
    partial class ExplicacaoBullying
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
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(16, 10);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(127, 47);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // ExplicacaoBullying
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Sobre_o_tema;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 561);
            Controls.Add(btnVoltar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ExplicacaoBullying";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExplicacaoBullying";
            FormClosing += ExplicacaoBullying_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnVoltar;
    }
}