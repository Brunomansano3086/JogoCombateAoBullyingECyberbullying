namespace JogoCombateAoBullyingECyberbullying
{
    partial class Cena2_Laboratorio
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
            btnCena2A = new Button();
            btnCena2B = new Button();
            btnCena2C = new Button();
            SuspendLayout();
            // 
            // btnCena2A
            // 
            btnCena2A.Location = new Point(542, 88);
            btnCena2A.Name = "btnCena2A";
            btnCena2A.Size = new Size(249, 105);
            btnCena2A.TabIndex = 0;
            btnCena2A.Text = "A";
            btnCena2A.UseVisualStyleBackColor = true;
            btnCena2A.Click += btnCena2A_Click;
            // 
            // btnCena2B
            // 
            btnCena2B.Location = new Point(543, 201);
            btnCena2B.Name = "btnCena2B";
            btnCena2B.Size = new Size(249, 108);
            btnCena2B.TabIndex = 1;
            btnCena2B.Text = "B";
            btnCena2B.UseVisualStyleBackColor = true;
            btnCena2B.Click += btnCena2B_Click;
            // 
            // btnCena2C
            // 
            btnCena2C.Location = new Point(542, 315);
            btnCena2C.Name = "btnCena2C";
            btnCena2C.Size = new Size(250, 108);
            btnCena2C.TabIndex = 2;
            btnCena2C.Text = "C";
            btnCena2C.UseVisualStyleBackColor = true;
            btnCena2C.Click += btnCena2C_Click;
            // 
            // Cena2_Laboratorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Laboratório_3_opções;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 561);
            Controls.Add(btnCena2C);
            Controls.Add(btnCena2B);
            Controls.Add(btnCena2A);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Cena2_Laboratorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cena2_Laboratorio";
            FormClosing += Cena2_Laboratorio_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCena2A;
        private Button btnCena2B;
        private Button btnCena2C;
    }
}