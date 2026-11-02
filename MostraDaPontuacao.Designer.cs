namespace JogoCombateAoBullyingECyberbullying
{
    partial class MostraDaPontuacao
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
            btnVoltarAoMenu = new Button();
            SuspendLayout();
            // 
            // btnVoltarAoMenu
            // 
            btnVoltarAoMenu.Location = new Point(432, 191);
            btnVoltarAoMenu.Name = "btnVoltarAoMenu";
            btnVoltarAoMenu.Size = new Size(155, 23);
            btnVoltarAoMenu.TabIndex = 0;
            btnVoltarAoMenu.Text = "Voltar ao Menu";
            btnVoltarAoMenu.UseVisualStyleBackColor = true;
            btnVoltarAoMenu.Click += btnVoltarAoMenu_Click;
            // 
            // MostraDaPontuacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 561);
            Controls.Add(btnVoltarAoMenu);
            Name = "MostraDaPontuacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MostraDaPontuacao";
            FormClosing += MostraDaPontuacao_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnVoltarAoMenu;
    }
}