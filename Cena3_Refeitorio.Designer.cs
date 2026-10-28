namespace JogoCombateAoBullyingECyberbullying
{
    partial class Cena3_Refeitorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cena3_Refeitorio));
            btnCena3A = new Button();
            btnCena3B = new Button();
            btnCena3C = new Button();
            SuspendLayout();
            // 
            // btnCena3A
            // 
            btnCena3A.Location = new Point(493, 61);
            btnCena3A.Name = "btnCena3A";
            btnCena3A.Size = new Size(75, 23);
            btnCena3A.TabIndex = 0;
            btnCena3A.Text = "A";
            btnCena3A.UseVisualStyleBackColor = true;
            // 
            // btnCena3B
            // 
            btnCena3B.Location = new Point(313, 158);
            btnCena3B.Name = "btnCena3B";
            btnCena3B.Size = new Size(75, 23);
            btnCena3B.TabIndex = 1;
            btnCena3B.Text = "B";
            btnCena3B.UseVisualStyleBackColor = true;
            // 
            // btnCena3C
            // 
            btnCena3C.Location = new Point(326, 241);
            btnCena3C.Name = "btnCena3C";
            btnCena3C.Size = new Size(75, 23);
            btnCena3C.TabIndex = 2;
            btnCena3C.Text = "C";
            btnCena3C.UseVisualStyleBackColor = true;
            // 
            // Cena3_Refeitorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(btnCena3C);
            Controls.Add(btnCena3B);
            Controls.Add(btnCena3A);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Cena3_Refeitorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cena3_Refeitorio";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCena3A;
        private Button btnCena3B;
        private Button btnCena3C;
    }
}