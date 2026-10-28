namespace JogoCombateAoBullyingECyberbullying
{
    partial class Cena1_WhatsApp
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
            btnCena1A = new Button();
            btnCena2B = new Button();
            btnCena1C = new Button();
            SuspendLayout();
            // 
            // btnCena1A
            // 
            btnCena1A.Location = new Point(427, 75);
            btnCena1A.Name = "btnCena1A";
            btnCena1A.Size = new Size(75, 23);
            btnCena1A.TabIndex = 0;
            btnCena1A.Text = "A";
            btnCena1A.UseVisualStyleBackColor = true;
            // 
            // btnCena2B
            // 
            btnCena2B.Location = new Point(427, 119);
            btnCena2B.Name = "btnCena2B";
            btnCena2B.Size = new Size(75, 23);
            btnCena2B.TabIndex = 1;
            btnCena2B.Text = "B";
            btnCena2B.UseVisualStyleBackColor = true;
            // 
            // btnCena1C
            // 
            btnCena1C.Location = new Point(427, 176);
            btnCena1C.Name = "btnCena1C";
            btnCena1C.Size = new Size(75, 23);
            btnCena1C.TabIndex = 2;
            btnCena1C.Text = "C";
            btnCena1C.UseVisualStyleBackColor = true;
            // 
            // Cena1_WhatsApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCena1C);
            Controls.Add(btnCena2B);
            Controls.Add(btnCena1A);
            Name = "Cena1_WhatsApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cena1_WhatsApp";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCena1A;
        private Button btnCena2B;
        private Button btnCena1C;
    }
}