namespace JogoCombateAoBullyingECyberbullying
{
    partial class Cena8B
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
            btnProximo.Location = new Point(629, 415);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(145, 32);
            btnProximo.TabIndex = 1;
            btnProximo.Text = "Próximo";
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // Cena8B
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Banheiro_opção_B_Avançar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 561);
            Controls.Add(btnProximo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Cena8B";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cena8B";
            FormClosing += Cena8B_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnProximo;
    }
}