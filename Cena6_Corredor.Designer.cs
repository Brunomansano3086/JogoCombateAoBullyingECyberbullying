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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cena6_Corredor));
            btnCena6A = new Button();
            btnCena6B = new Button();
            btnCena6C = new Button();
            SuspendLayout();
            // 
            // btnCena6A
            // 
            btnCena6A.Location = new Point(476, 98);
            btnCena6A.Name = "btnCena6A";
            btnCena6A.Size = new Size(75, 23);
            btnCena6A.TabIndex = 0;
            btnCena6A.Text = "A";
            btnCena6A.UseVisualStyleBackColor = true;
            btnCena6A.Click += btnCena6A_Click;
            // 
            // btnCena6B
            // 
            btnCena6B.Location = new Point(381, 184);
            btnCena6B.Name = "btnCena6B";
            btnCena6B.Size = new Size(75, 23);
            btnCena6B.TabIndex = 1;
            btnCena6B.Text = "B";
            btnCena6B.UseVisualStyleBackColor = true;
            btnCena6B.Click += btnCena6B_Click;
            // 
            // btnCena6C
            // 
            btnCena6C.Location = new Point(381, 258);
            btnCena6C.Name = "btnCena6C";
            btnCena6C.Size = new Size(75, 23);
            btnCena6C.TabIndex = 2;
            btnCena6C.Text = "C";
            btnCena6C.UseVisualStyleBackColor = true;
            btnCena6C.Click += btnCena6C_Click;
            // 
            // Cena6_Corredor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(btnCena6C);
            Controls.Add(btnCena6B);
            Controls.Add(btnCena6A);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Cena6_Corredor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cena6_Corredor";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCena6A;
        private Button btnCena6B;
        private Button btnCena6C;
    }
}