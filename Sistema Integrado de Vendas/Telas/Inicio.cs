using System;
using System.Windows.Forms;

namespace Sistema_Integrado_de_Vendas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (circularProgress1.Value < 100)
            {
                circularProgress1.Value++;
            }
            else
            {
                timer1.Stop();
                Login l = new Login();
                l.Show();
                Visible = false;
            }
        }
    }
}
