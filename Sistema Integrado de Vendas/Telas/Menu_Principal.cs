using MySql.Data.MySqlClient;
using Sistema_Integrado_de_Vendas.Telas;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Sistema_Integrado_de_Vendas
{
    public partial class Menu_Principal : Form
    {
        const string stringConexao = "server=localhost;port=3306;user=root;database=dbvendas";
        MySqlConnection conexao = new MySqlConnection(stringConexao);
        Usuario user = new Usuario();
        MySqlCommand comando;
        public static string Modo_Nocturno { get; set; }

        bool mover = false;
        Point posicaoInicial;
        public Menu_Principal()
        {
            InitializeComponent();
            GetImagemUserName();
            Modo_Nocturno = Modo_Nocturno1.ModoNocturno;
            Modo();
        }

        public void Modo()
        {
            conexao.Open();
            try
            {
                MySqlDataAdapter adpter = new MySqlDataAdapter();
                DataTable table = new DataTable();

                comando = new MySqlCommand("SELECT*from modo WHERE Modo_Nocturno = @modo ", conexao);
                comando.Parameters.AddWithValue("@modo", Modo_Nocturno);
                MySqlDataAdapter meter = new MySqlDataAdapter(comando);
                adpter.SelectCommand = comando;
                adpter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    Modo_Nocturno = Convert.ToString(table.Rows[0][1]);
                    Modo_Nocturno1.ModoNocturno = Modo_Nocturno;
                    if (Modo_Nocturno == "True")
                    {
                        BackColor = Color.FromArgb(41, 39, 40);
                        menuStrip1.BackColor = Color.FromArgb(41, 39, 40);
                        statusStrip1.BackColor = Color.FromArgb(41, 39, 40);
                        pictureBox2.BackColor = Color.FromArgb(41, 39, 40);
                        funcionáriosToolStripMenuItem.BackColor = Color.FromArgb(41, 39, 40);
                        funcionáriosToolStripMenuItem1.BackColor = Color.FromArgb(41, 39, 40);
                        produtosToolStripMenuItem.BackColor = Color.FromArgb(41, 39, 40);
                        produtosToolStripMenuItem1.BackColor = Color.FromArgb(41, 39, 40);
                        vendasToolStripMenuItem.BackColor = Color.FromArgb(41, 39, 40);
                        vendasToolStripMenuItem1.BackColor = Color.FromArgb(41, 39, 40);
                        utilizadorToolStripMenuItem.BackColor = Color.FromArgb(41, 39, 40);
                        preferênciaToolStripMenuItem.BackColor = Color.FromArgb(41, 39, 40);
                    }
                    else if (Modo_Nocturno == "False")
                    {
                        BackColor = Color.Purple;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        void GetImagemUserName()
        {
            try
            {
                DataTable table = user.getUserById(GlobalId.UserId);

                byte[] imagem = (byte[])(table.Rows[0]["Imagem"]);
                MemoryStream picture = new MemoryStream(imagem);

                pictureBox3.Image = Image.FromStream(picture);
                lbUser.Text = "Seja Benvindo ( " + table.Rows[0]["Categoria"].ToString() + " )";

                if (!(table.Rows[0]["Categoria"].ToString().Equals("Administrador")))
                {
                    utilizadorToolStripMenuItem.Visible = false;
                    lbEditar.Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime john;
            john = DateTime.Now;
            lbData.Text = "Data: " + john.ToShortDateString() + "   ||   " + " Horas: " + john.ToLongTimeString();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tens Certeza que desejas Sair do Programa?", "Aviso do Programa!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Visible = true;
            }
        }

        private void utilizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.Show();
        }

        private void lbAtualizar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetImagemUserName();
        }

        private void lbEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Usuario u = new Usuario();
            u.Show();
        }

        private void lbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            Visible = false;
        }

        private void _MouseMove(object sender, MouseEventArgs e)
        {
            if (mover == true)
            {
                Point novo = PointToScreen(e.Location);
                Location = new Point(novo.X - posicaoInicial.X, novo.Y - posicaoInicial.Y);
            }
        }

        private void _MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void _MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            posicaoInicial = new Point(e.X, e.Y);
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendas v = new Vendas();
            v.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();
            f.Show();
        }

        private void funcionáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultar_Funcionario cf = new Consultar_Funcionario();
            cf.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultar_Produtos p = new Consultar_Produtos();
            p.Show();
        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas_de_vendas c = new Consultas_de_vendas();
            c.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatórios rel = new Relatórios();
            rel.Show();
        }

        private void preferênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preferências f = new Preferências();
            f.Show();
            Visible = false;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre s = new Sobre();
            s.Show();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajuda a = new Ajuda();
            a.Show();
        }
    }
}
