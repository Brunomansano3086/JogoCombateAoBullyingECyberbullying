namespace JogoCombateAoBullyingECyberbullying
{
    partial class Cena6C
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
            btnProximo.Location = new Point(630, 415);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(143, 33);
            btnProximo.TabIndex = 1;
            btnProximo.Text = "Próximo";
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // Cena6C
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Corredor_opção_C_Avançar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 561);
            Controls.Add(btnProximo);
            Name = "Cena6C";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cena6C";
            FormClosing += Cena6C_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnProximo;
    }
}