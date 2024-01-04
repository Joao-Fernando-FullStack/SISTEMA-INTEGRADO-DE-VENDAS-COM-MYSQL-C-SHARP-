using MySql.Data.MySqlClient;
using Sistema_Integrado_de_Vendas.Telas;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Sistema_Integrado_de_Vendas
{
    public partial class Relatórios : Form
    {
        const string stringConexao = "server=localhost;port=3306;user=root;database=dbvendas";
        MySqlConnection conexao = new MySqlConnection(stringConexao);
        MySqlCommand comando;
        double capitalS { get; set; }
        public static string Modo_Nocturno { get; set; }
        public Relatórios()
        {
            InitializeComponent();
            Capital();
            lbQuantidadeVendas.Text = Consultas_de_vendas.quantidadeVendas;
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
                        groupBox1.BackColor = Color.FromArgb(41, 39, 40);
                        chart3.BackColor = Color.FromArgb(41, 39, 40);
                        chart2.BackColor = Color.FromArgb(41, 39, 40);
                        pictureBox1.BackColor = Color.FromArgb(41, 39, 40);
                    }
                    else if (Modo_Nocturno == "False")
                    {
                        BackColor = Color.Purple;
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        void Capital()
        {
            conexao.Open();
            try
            {
                MySqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = "SELECT*FROM produto";
                MySqlDataReader reader;
                double valor = 0;
                double capital = 0;

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    valor = Convert.ToDouble(reader.GetString("Preco"));
                    capital += valor;
                }
                capitalS = capital;
                lbCapital.Text = capitalS.ToString();
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void Relatórios_Load(object sender, EventArgs e)
        {
            lbQuantidadeFuncionario.Text = Consultar_Funcionario.quantidadeFuncionario;
            lbQuantidadeProduto.Text = Consultar_Produtos.quantidadeProduto;

            SerieVendas();
            SerieProduto();

            chart2.Series["Capital"].Points.AddXY("Vendas", Consultas_de_vendas.quantidadeVendas);
            chart2.Series["Capital"].Points.AddXY("Funcionários", Consultar_Funcionario.quantidadeFuncionario);
            chart2.Series["Capital"].Points.AddXY("Produtos", Consultar_Produtos.quantidadeProduto);
            
        }

        void SerieVendas()
        {
            conexao.Open();
            try
            {
                MySqlCommand cmd = conexao.CreateCommand();
                cmd.CommandText = "SELECT Produto,Preco FROM vendas";
                MySqlDataReader reader;

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chart3.Series["Vendas"].Points.AddXY(reader.GetChar("Produto"), reader.GetChar("Preco"));
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        void SerieProduto()
        {
            conexao.Open();
            try
            {
                MySqlCommand cmd1 = conexao.CreateCommand();
                cmd1.CommandText = "SELECT Produto,Preco FROM produto";
                MySqlDataReader reader1;
                reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {

                    chart3.Series["Produto"].Points.AddXY(reader1.GetChar("Produto"), reader1.GetChar("Preco"));
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            SerieVendas();   
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
