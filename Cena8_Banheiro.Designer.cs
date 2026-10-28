namespace JogoCombateAoBullyingECyberbullying
{
    partial class Cena8_Banheiro
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
            btnCena8A = new Button();
            btnCena8B = new Button();
            btnCena8C = new Button();
            SuspendLayout();
            // 
            // btnCena8A
            // 
            btnCena8A.Location = new Point(425, 75);
            btnCena8A.Name = "btnCena8A";
            btnCena8A.Size = new Size(75, 23);
            btnCena8A.TabIndex = 0;
            btnCena8A.Text = "A";
            btnCena8A.UseVisualStyleBackColor = true;
            btnCena8A.Click += btnCena8A_Click;
            // 
            // btnCena8B
            // 
            btnCena8B.Location = new Point(425, 126);
            btnCena8B.Name = "btnCena8B";
            btnCena8B.Size = new Size(75, 23);
            btnCena8B.TabIndex = 1;
            btnCena8B.Text = "B";
            btnCena8B.UseVisualStyleBackColor = true;
            btnCena8B.Click += btnCena8B_Click;
            // 
            // btnCena8C
            // 
            btnCena8C.Location = new Point(439, 276);
            btnCena8C.Name = "btnCena8C";
            btnCena8C.Size = new Size(75, 23);
            btnCena8C.TabIndex = 2;
            btnCena8C.Text = "C";
            btnCena8C.UseVisualStyleBackColor = true;
            btnCena8C.Click += btnCena8C_Click;
            // 
            // Cena8_Banheiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCena8C);
            Controls.Add(btnCena8B);
            Controls.Add(btnCena8A);
            Name = "Cena8_Banheiro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cena8_Banheiro";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCena8A;
        private Button btnCena8B;
        private Button btnCena8C;
    }
}