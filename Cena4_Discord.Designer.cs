namespace JogoCombateAoBullyingECyberbullying
{
    partial class Cena4_Discord
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
            btnCena4A = new Button();
            btnCena4B = new Button();
            btnCena4C = new Button();
            SuspendLayout();
            // 
            // btnCena4A
            // 
            btnCena4A.Location = new Point(503, 110);
            btnCena4A.Name = "btnCena4A";
            btnCena4A.Size = new Size(285, 71);
            btnCena4A.TabIndex = 0;
            btnCena4A.Text = "A";
            btnCena4A.UseVisualStyleBackColor = true;
            btnCena4A.Click += btnCena4A_Click;
            // 
            // btnCena4B
            // 
            btnCena4B.Location = new Point(503, 187);
            btnCena4B.Name = "btnCena4B";
            btnCena4B.Size = new Size(285, 66);
            btnCena4B.TabIndex = 1;
            btnCena4B.Text = "B";
            btnCena4B.UseVisualStyleBackColor = true;
            btnCena4B.Click += btnCena4B_Click;
            // 
            // btnCena4C
            // 
            btnCena4C.Location = new Point(503, 259);
            btnCena4C.Name = "btnCena4C";
            btnCena4C.Size = new Size(285, 61);
            btnCena4C.TabIndex = 2;
            btnCena4C.Text = "C";
            btnCena4C.UseVisualStyleBackColor = true;
            btnCena4C.Click += btnCena4C_Click;
            // 
            // Cena4_Discord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Discord_3_opções;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 561);
            Controls.Add(btnCena4C);
            Controls.Add(btnCena4B);
            Controls.Add(btnCena4A);
            Name = "Cena4_Discord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cena4_Discord";
            FormClosing += Cena4_Discord_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCena4A;
        private Button btnCena4B;
        private Button btnCena4C;
    }
}