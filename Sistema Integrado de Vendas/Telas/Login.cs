using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_Integrado_de_Vendas
{
    public partial class Login : Form
    {
        const string stringConexao = "server=localhost;port=3306;user=root;database=dbvendas;";

        MySqlConnection conexao = new MySqlConnection(stringConexao);
        MySqlCommand comando;
        public static string Modo_Nocturno { get; set; }

        GlobalId globaId = new GlobalId();
        public int UsuarioId { get; set; }
        public Login()
        {
            InitializeComponent();
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
                        //BackColor = Color.White;
                        pictureBox1.BackColor = Color.FromArgb(41, 39, 40);
                        txtSenha.BackColor = Color.FromArgb(41, 39, 40);
                        txtUtilizador.BackColor = Color.FromArgb(41, 39, 40);
                        panel1.BackColor = Color.FromArgb(41, 39, 40);
                    }
                    else if (Modo_Nocturno == "False")
                    {
                        BackColor = Color.White;
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


        void bdSenha()
        {
            conexao.Open();
            try
            {
                MySqlDataAdapter adpter = new MySqlDataAdapter();
                DataTable table = new DataTable();

                comando = new MySqlCommand("SELECT*from usuário WHERE Nome=@nome AND Senha = @senha ", conexao);
                comando.Parameters.AddWithValue("@nome", txtUtilizador.Text);
                comando.Parameters.AddWithValue("@senha", txtSenha.Text);
                MySqlDataAdapter meter = new MySqlDataAdapter(comando);
                adpter.SelectCommand = comando;
                adpter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    UsuarioId = Convert.ToInt32(table.Rows[0][0]);
                    globaId.SetGlobalUserId(UsuarioId);

                    Menu_Principal mf = new Menu_Principal();
                    mf.Show();
                    Visible = false;
                }
                else
                {
                    lbErro.Text = "Padrão de Acesso Incorrecto, contacte o Administrador!";
                    lbErro.ForeColor = Color.PaleVioletRed;
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

        private void btLogin_Click(object sender, EventArgs e)
        {
            bdSenha();
        }

        private void txtUtilizador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bdSenha();
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
