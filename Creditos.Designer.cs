namespace JogoCombateAoBullyingECyberbullying
{
    partial class Creditos
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
            btnVoltar.Location = new Point(21, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(178, 48);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // Creditos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Tela_de_Créditos_Unisagrado_com_as_duas_logos;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 561);
            Controls.Add(btnVoltar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Creditos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Creditos";
            FormClosing += Creditos_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnVoltar;
    }
}