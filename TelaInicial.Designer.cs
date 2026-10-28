namespace JogoCombateAoBullyingECyberbullying
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            btnJogar = new Button();
            btnTema = new Button();
            btnSair = new Button();
            btnCreditos = new Button();
            SuspendLayout();
            // 
            // btnJogar
            // 
            btnJogar.FlatStyle = FlatStyle.Flat;
            btnJogar.Location = new Point(633, 266);
            btnJogar.Margin = new Padding(3, 4, 3, 4);
            btnJogar.Name = "btnJogar";
            btnJogar.Size = new Size(250, 58);
            btnJogar.TabIndex = 0;
            btnJogar.Text = "Jogar";
            btnJogar.UseVisualStyleBackColor = true;
            btnJogar.Click += btnJogar_Click;
            // 
            // btnTema
            // 
            btnTema.FlatStyle = FlatStyle.Flat;
            btnTema.Location = new Point(633, 341);
            btnTema.Margin = new Padding(3, 4, 3, 4);
            btnTema.Name = "btnTema";
            btnTema.Size = new Size(250, 53);
            btnTema.TabIndex = 1;
            btnTema.Text = "Tema";
            btnTema.UseVisualStyleBackColor = true;
            btnTema.Click += btnTema_Click;
            // 
            // btnSair
            // 
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Location = new Point(633, 483);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(250, 54);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnCreditos
            // 
            btnCreditos.FlatStyle = FlatStyle.Flat;
            btnCreditos.Location = new Point(633, 410);
            btnCreditos.Margin = new Padding(3, 4, 3, 4);
            btnCreditos.Name = "btnCreditos";
            btnCreditos.Size = new Size(250, 59);
            btnCreditos.TabIndex = 3;
            btnCreditos.Text = "Créditos";
            btnCreditos.UseVisualStyleBackColor = true;
            btnCreditos.Click += btnCreditos_Click;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(btnCreditos);
            Controls.Add(btnSair);
            Controls.Add(btnTema);
            Controls.Add(btnJogar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaInicial";
            Text = "TelaInicial";
            Load += TelaInicial_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnJogar;
        private Button btnTema;
        private Button btnSair;
        private Button btnCreditos;
    }
}