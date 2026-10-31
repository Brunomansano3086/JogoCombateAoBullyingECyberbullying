namespace JogoCombateAoBullyingECyberbullying
{
    partial class Cena7_Apresentacao
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
            btnCena7A = new Button();
            btnCena7B = new Button();
            btnCena7C = new Button();
            SuspendLayout();
            // 
            // btnCena7A
            // 
            btnCena7A.Location = new Point(513, 91);
            btnCena7A.Name = "btnCena7A";
            btnCena7A.Size = new Size(275, 63);
            btnCena7A.TabIndex = 0;
            btnCena7A.Text = "A";
            btnCena7A.UseVisualStyleBackColor = true;
            btnCena7A.Click += btnCena7A_Click;
            // 
            // btnCena7B
            // 
            btnCena7B.Location = new Point(513, 158);
            btnCena7B.Name = "btnCena7B";
            btnCena7B.Size = new Size(275, 67);
            btnCena7B.TabIndex = 1;
            btnCena7B.Text = "B";
            btnCena7B.UseVisualStyleBackColor = true;
            btnCena7B.Click += btnCena7B_Click;
            // 
            // btnCena7C
            // 
            btnCena7C.Location = new Point(513, 230);
            btnCena7C.Name = "btnCena7C";
            btnCena7C.Size = new Size(275, 65);
            btnCena7C.TabIndex = 2;
            btnCena7C.Text = "C";
            btnCena7C.UseVisualStyleBackColor = true;
            btnCena7C.Click += btnCena7C_Click;
            // 
            // Cena7_Apresentacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Apresentação_3_opções;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCena7C);
            Controls.Add(btnCena7B);
            Controls.Add(btnCena7A);
            DoubleBuffered = true;
            Name = "Cena7_Apresentacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cena7_Apresentacao";
            FormClosing += Cena7_Apresentacao_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCena7A;
        private Button btnCena7B;
        private Button btnCena7C;
    }
}