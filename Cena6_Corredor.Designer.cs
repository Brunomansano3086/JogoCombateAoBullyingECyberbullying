namespace JogoCombateAoBullyingECyberbullying
{
    partial class Cena6_Corredor
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
            btnCena6A = new Button();
            btnCena6B = new Button();
            btnCena6C = new Button();
            SuspendLayout();
            // 
            // btnCena6A
            // 
            btnCena6A.Location = new Point(445, 122);
            btnCena6A.Name = "btnCena6A";
            btnCena6A.Size = new Size(245, 49);
            btnCena6A.TabIndex = 0;
            btnCena6A.Text = "A";
            btnCena6A.UseVisualStyleBackColor = true;
            btnCena6A.Click += btnCena6A_Click;
            // 
            // btnCena6B
            // 
            btnCena6B.Location = new Point(445, 174);
            btnCena6B.Name = "btnCena6B";
            btnCena6B.Size = new Size(245, 49);
            btnCena6B.TabIndex = 1;
            btnCena6B.Text = "B";
            btnCena6B.UseVisualStyleBackColor = true;
            btnCena6B.Click += btnCena6B_Click;
            // 
            // btnCena6C
            // 
            btnCena6C.Location = new Point(445, 226);
            btnCena6C.Name = "btnCena6C";
            btnCena6C.Size = new Size(245, 48);
            btnCena6C.TabIndex = 2;
            btnCena6C.Text = "C";
            btnCena6C.UseVisualStyleBackColor = true;
            btnCena6C.Click += btnCena6C_Click;
            // 
            // Cena6_Corredor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Corredor_3_opções;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 561);
            Controls.Add(btnCena6C);
            Controls.Add(btnCena6B);
            Controls.Add(btnCena6A);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Cena6_Corredor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cena6_Corredor";
            FormClosing += Cena6_Corredor_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCena6A;
        private Button btnCena6B;
        private Button btnCena6C;
    }
}