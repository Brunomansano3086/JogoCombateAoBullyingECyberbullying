namespace JogoCombateAoBullyingECyberbullying
{
    partial class Cena9_Coordenador
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
            btnCena9A = new Button();
            btnCena9B = new Button();
            btnCena9C = new Button();
            SuspendLayout();
            // 
            // btnCena9A
            // 
            btnCena9A.Location = new Point(363, 69);
            btnCena9A.Name = "btnCena9A";
            btnCena9A.Size = new Size(75, 23);
            btnCena9A.TabIndex = 0;
            btnCena9A.Text = "A";
            btnCena9A.UseVisualStyleBackColor = true;
            btnCena9A.Click += btnCena9A_Click;
            // 
            // btnCena9B
            // 
            btnCena9B.Location = new Point(363, 214);
            btnCena9B.Name = "btnCena9B";
            btnCena9B.Size = new Size(75, 23);
            btnCena9B.TabIndex = 1;
            btnCena9B.Text = "B";
            btnCena9B.UseVisualStyleBackColor = true;
            btnCena9B.Click += btnCena9B_Click;
            // 
            // btnCena9C
            // 
            btnCena9C.Location = new Point(403, 266);
            btnCena9C.Name = "btnCena9C";
            btnCena9C.Size = new Size(75, 23);
            btnCena9C.TabIndex = 2;
            btnCena9C.Text = "C";
            btnCena9C.UseVisualStyleBackColor = true;
            btnCena9C.Click += btnCena9C_Click;
            // 
            // Cena9_Coordenador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCena9C);
            Controls.Add(btnCena9B);
            Controls.Add(btnCena9A);
            Name = "Cena9_Coordenador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cena9_Coordenador";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCena9A;
        private Button btnCena9B;
        private Button btnCena9C;
    }
}