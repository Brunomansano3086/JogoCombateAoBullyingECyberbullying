namespace JogoCombateAoBullyingECyberbullying
{
    partial class Cena10_Estacionamento
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
            GerenciadorAudio.TocarMusicaJogo(); // Inicia a música de fundo ao abrir a tela

            btnCena10A = new Button();
            btnCena10B = new Button();
            btnCena10C = new Button();
            SuspendLayout();
            // 
            // btnCena10A
            // 
            btnCena10A.Location = new Point(700, 161);
            btnCena10A.Name = "btnCena10A";
            btnCena10A.Size = new Size(366, 103);
            btnCena10A.TabIndex = 0;
            btnCena10A.Text = "A";
            btnCena10A.UseVisualStyleBackColor = true;
            btnCena10A.Click += btnCena10A_Click;
            // 
            // btnCena10B
            // 
            btnCena10B.Location = new Point(700, 270);
            btnCena10B.Name = "btnCena10B";
            btnCena10B.Size = new Size(366, 107);
            btnCena10B.TabIndex = 1;
            btnCena10B.Text = "B";
            btnCena10B.UseVisualStyleBackColor = true;
            btnCena10B.Click += btnCena10B_Click;
            // 
            // btnCena10C
            // 
            btnCena10C.Location = new Point(700, 385);
            btnCena10C.Name = "btnCena10C";
            btnCena10C.Size = new Size(366, 114);
            btnCena10C.TabIndex = 2;
            btnCena10C.Text = "C";
            btnCena10C.UseVisualStyleBackColor = true;
            btnCena10C.Click += btnCena10C_Click;
            // 
            // Cena10_Estacionamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Estacionamento_3_opções;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 561);
            Controls.Add(btnCena10C);
            Controls.Add(btnCena10B);
            Controls.Add(btnCena10A);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Cena10_Estacionamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cena10_Estacionamento";
            FormClosing += Cena10_Estacionamento_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCena10A;
        private Button btnCena10B;
        private Button btnCena10C;
    }
}