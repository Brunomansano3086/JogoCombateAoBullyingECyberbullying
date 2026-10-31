namespace JogoCombateAoBullyingECyberbullying
{
    partial class Cena1_WhatsApp
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
            GerenciadorAudio.TocarMusicaJogo(); // Inicia a música de fundo ao abrir a cena

            btnCena1A = new Button();
            btnCena1B = new Button();
            btnCena1C = new Button();
            SuspendLayout();
            // 
            // btnCena1A
            // 
            btnCena1A.Location = new Point(616, 133);
            btnCena1A.Margin = new Padding(3, 4, 3, 4);
            btnCena1A.Name = "btnCena1A";
            btnCena1A.Size = new Size(285, 136);
            btnCena1A.TabIndex = 0;
            btnCena1A.Text = "A";
            btnCena1A.UseVisualStyleBackColor = true;
            btnCena1A.Click += btnCena1A_Click;
            // 
            // btnCena1B
            // 
            btnCena1B.Location = new Point(616, 277);
            btnCena1B.Margin = new Padding(3, 4, 3, 4);
            btnCena1B.Name = "btnCena1B";
            btnCena1B.Size = new Size(285, 137);
            btnCena1B.TabIndex = 1;
            btnCena1B.Text = "B";
            btnCena1B.UseVisualStyleBackColor = true;
            btnCena1B.Click += btnCena1B_Click;
            // 
            // btnCena1C
            // 
            btnCena1C.Location = new Point(617, 422);
            btnCena1C.Margin = new Padding(3, 4, 3, 4);
            btnCena1C.Name = "btnCena1C";
            btnCena1C.Size = new Size(285, 140);
            btnCena1C.TabIndex = 2;
            btnCena1C.Text = "C";
            btnCena1C.UseVisualStyleBackColor = true;
            btnCena1C.Click += btnCena1C_Click;
            // 
            // Cena1_WhatsApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_3_opções;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(btnCena1C);
            Controls.Add(btnCena1B);
            Controls.Add(btnCena1A);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Cena1_WhatsApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cena1_WhatsApp";
            FormClosing += Cena1_WhatsApp_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCena1A;
        private Button btnCena1B;
        private Button btnCena1C;
    }
}