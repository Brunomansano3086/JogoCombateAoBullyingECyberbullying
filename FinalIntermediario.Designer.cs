namespace JogoCombateAoBullyingECyberbullying
{
    partial class FinalIntermediario
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
            btnVoltarTelaInicial = new Button();
            SuspendLayout();
            // 
            // btnVoltarTelaInicial
            // 
            btnVoltarTelaInicial.Location = new Point(297, 204);
            btnVoltarTelaInicial.Name = "btnVoltarTelaInicial";
            btnVoltarTelaInicial.Size = new Size(207, 43);
            btnVoltarTelaInicial.TabIndex = 1;
            btnVoltarTelaInicial.Text = "Voltar p tela inicial";
            btnVoltarTelaInicial.UseVisualStyleBackColor = true;
            btnVoltarTelaInicial.Click += btnVoltarTelaInicial_Click;
            // 
            // FinalIntermediario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltarTelaInicial);
            Name = "FinalIntermediario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinalIntermediario";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVoltarTelaInicial;
    }
}