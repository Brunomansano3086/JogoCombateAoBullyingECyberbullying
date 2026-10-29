using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public partial class CenaPreJogo : Form
    {
        public CenaPreJogo()
        {
            InitializeComponent();
        }

        private void btnComecarJogo_Click(object sender, EventArgs e)
        {
            new Cena1_WhatsApp().Show();
            this.Close();
        }
    }
}
