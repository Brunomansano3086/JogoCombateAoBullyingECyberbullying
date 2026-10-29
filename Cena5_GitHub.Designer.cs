namespace JogoCombateAoBullyingECyberbullying
{
    partial class Cena5_GitHub
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
            btnCena5A = new Button();
            btnCena5B = new Button();
            btnCena5C = new Button();
            SuspendLayout();
            // 
            // btnCena5A
            // 
            btnCena5A.Location = new Point(562, 161);
            btnCena5A.Name = "btnCena5A";
            btnCena5A.Size = new Size(247, 61);
            btnCena5A.TabIndex = 0;
            btnCena5A.Text = "A";
            btnCena5A.UseVisualStyleBackColor = true;
            btnCena5A.Click += btnCena5A_Click;
            // 
            // btnCena5B
            // 
            btnCena5B.Location = new Point(562, 228);
            btnCena5B.Name = "btnCena5B";
            btnCena5B.Size = new Size(247, 65);
            btnCena5B.TabIndex = 1;
            btnCena5B.Text = "B";
            btnCena5B.UseVisualStyleBackColor = true;
            btnCena5B.Click += btnCena5B_Click;
            // 
            // btnCena5C
            // 
            btnCena5C.Location = new Point(562, 296);
            btnCena5C.Name = "btnCena5C";
            btnCena5C.Size = new Size(247, 73);
            btnCena5C.TabIndex = 2;
            btnCena5C.Text = "C";
            btnCena5C.UseVisualStyleBackColor = true;
            btnCena5C.Click += btnCena5C_Click;
            // 
            // Cena5_GitHub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.GitHub_3_opções;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(816, 450);
            Controls.Add(btnCena5C);
            Controls.Add(btnCena5B);
            Controls.Add(btnCena5A);
            DoubleBuffered = true;
            Name = "Cena5_GitHub";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cena5_GitHub";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCena5A;
        private Button btnCena5B;
        private Button btnCena5C;
    }
}