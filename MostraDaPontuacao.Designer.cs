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
            lblPosturaAtiva = new Label();
            lblOmissao = new Label();
            lblCumplicidade = new Label();
            SuspendLayout();
            // 
            // btnVoltarAoMenu
            // 
            btnVoltarAoMenu.Location = new Point(745, 577);
            btnVoltarAoMenu.Name = "btnVoltarAoMenu";
            btnVoltarAoMenu.Size = new Size(198, 42);
            btnVoltarAoMenu.TabIndex = 0;
            btnVoltarAoMenu.Text = "Voltar ao Menu";
            btnVoltarAoMenu.UseVisualStyleBackColor = true;
            btnVoltarAoMenu.Click += btnVoltarAoMenu_Click;
            // 
            // lblPosturaAtiva
            // 
            lblPosturaAtiva.BackColor = Color.Transparent;
            lblPosturaAtiva.Font = new Font("Press Start 2P", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPosturaAtiva.ForeColor = Color.White;
            lblPosturaAtiva.Location = new Point(497, 201);
            lblPosturaAtiva.Name = "lblPosturaAtiva";
            lblPosturaAtiva.Size = new Size(316, 46);
            lblPosturaAtiva.TabIndex = 1;
            lblPosturaAtiva.Text = "Post. Ativa";
            lblPosturaAtiva.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOmissao
            // 
            lblOmissao.BackColor = Color.Transparent;
            lblOmissao.Font = new Font("Press Start 2P", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOmissao.ForeColor = Color.White;
            lblOmissao.Location = new Point(497, 266);
            lblOmissao.Name = "lblOmissao";
            lblOmissao.Size = new Size(316, 50);
            lblOmissao.TabIndex = 2;
            lblOmissao.Text = "Omissão";
            lblOmissao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCumplicidade
            // 
            lblCumplicidade.BackColor = Color.Transparent;
            lblCumplicidade.Font = new Font("Press Start 2P", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCumplicidade.ForeColor = Color.White;
            lblCumplicidade.Location = new Point(497, 332);
            lblCumplicidade.Name = "lblCumplicidade";
            lblCumplicidade.Size = new Size(316, 51);
            lblCumplicidade.TabIndex = 3;
            lblCumplicidade.Text = "Cumplicidade";
            lblCumplicidade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MostraDaPontuacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Tela_Pontuação;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(967, 623);
            Controls.Add(lblCumplicidade);
            Controls.Add(lblOmissao);
            Controls.Add(lblPosturaAtiva);
            Controls.Add(btnVoltarAoMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MostraDaPontuacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MostraDaPontuacao";
            FormClosing += MostraDaPontuacao_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnVoltarAoMenu;
        private Label lblPosturaAtiva;
        private Label lblOmissao;
        private Label lblCumplicidade;
    }
}