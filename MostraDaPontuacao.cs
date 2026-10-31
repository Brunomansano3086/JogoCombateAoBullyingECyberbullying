using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoCombateAoBullyingECyberbullying
{
    public partial class MostraDaPontuacao : Form
    {
        public MostraDaPontuacao()
        {
            InitializeComponent();
        }

        private void btnVoltarAoMenu_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is TelaInicial)
                {
                    f.Show();
                    break;
                }
            }
            this.Close();
        }
    }
}
