namespace JogoCombateAoBullyingECyberbullying
{
    partial class Cena9A
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
            btnProximo = new Button();
            SuspendLayout();
            // 
            // btnProximo
            // 
            btnProximo.Location = new Point(631, 415);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(142, 32);
            btnProximo.TabIndex = 1;
            btnProximo.Text = "Próximo";
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // Cena9A
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Coordenador_opção_A_Avançar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProximo);
            Name = "Cena9A";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cena9A";
            FormClosing += Cena9A_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnProximo;
    }
}