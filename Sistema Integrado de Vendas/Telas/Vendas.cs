using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Integrado_de_Vendas.Telas
{
    public partial class Vendas : Form
    {
        const string stringConexao = "server=localhost;port=3306;user=root;database=dbvendas";
        MySqlConnection conexao = new MySqlConnection(stringConexao);
        MySqlCommand comando;
        Usuario user = new Usuario();
        GlobalId globaId = new GlobalId();
        public static string Modo_Nocturno { get; set; }
        static string Produto;
        int produtoId { get; set; }
        public Vendas()
        {
            InitializeComponent();
            GetUserName();
            carregarProduto();
            Modo_Nocturno = Modo_Nocturno1.ModoNocturno;
            Modo();
            gdvProduto.Visible = false;
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

        void GetUserName()
        {
            conexao.Open();
            try
            {

                DataTable table = user.getUserById(GlobalId.UserId);

                byte[] imagem = (byte[])(table.Rows[0]["Imagem"]);
                MemoryStream picture = new MemoryStream(imagem);

                //pictureBox3.Image = Image.FromStream(picture);
                txtUsuario.Text = table.Rows[0]["Nome"].ToString();

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
        void carregarProduto()
        {
            //conexao.Open();
            try
            {
                comando = new MySqlCommand("SELECT Id,Produto,Preco,Quantidade FROM produto", conexao);
                MySqlDataAdapter meter = new MySqlDataAdapter(comando);
                DataTable table = new DataTable();
                meter.Fill(table);
                gdvProduto.DataSource = table;
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

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gdvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicao = gdvProduto.CurrentRow.Index;
            Produto = gdvProduto[1, posicao].Value.ToString();
            txtProduto.Text = gdvProduto[1, posicao].Value.ToString();
            txtPreco.Text = gdvProduto[2, posicao].Value.ToString();
            verImagem();
            gdvProduto.Visible = false;
        }

        private void txtProduto_Click(object sender, EventArgs e)
        {
            int posicao = gdvProduto.CurrentRow.Index;
            gdvProduto.Visible = true;
            //txtProduto.Text = gdvProduto[1, posicao].Value.ToString();
            //MessageBox.Show(txtProduto.Text);
        }

        private void labelX6_Click(object sender, EventArgs e)
        {
            gdvProduto.Visible = true;
            if (gdvProduto.Visible == true)
            {
                labelX6.Visible = false;
                labelX4.Visible = true;
            }
            
        }

        private void verImagem()
        {
            conexao.Open();

            try
            {
                comando = new MySqlCommand("SELECT*FROM produto WHERE Id=@ID", conexao);
                comando.Parameters.AddWithValue("@ID", gdvProduto.CurrentRow.Cells[0].Value);

                var dir = comando.ExecuteReader(CommandBehavior.SingleRow);

                if (dir.HasRows)
                {
                    dir.Read();

                    byte[] imagem = (byte[])(dir[4]);

                    if (imagem == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MemoryStream memory = new MemoryStream(imagem);
                        pictureBox1.Image = Image.FromStream(memory);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime john;
            john = DateTime.Now;
            txtData.Text = john.ToShortDateString() +"    "+ john.ToLongTimeString();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            conexao.Open();
            try
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();

                double preco = Convert.ToDouble(txtPreco.Text);
                double q2 = Convert.ToDouble(txtQuantidade.Text);

                DataTable table = new DataTable();
                MySqlCommand comando1 = new MySqlCommand("SELECT*from produto WHERE Produto=@nome AND Preco = @preco ", conexao);
                comando1.Parameters.AddWithValue("@nome", txtProduto.Text);
                comando1.Parameters.AddWithValue("@preco", txtPreco.Text);
                MySqlDataAdapter meter = new MySqlDataAdapter(comando); 
                meter.SelectCommand = comando;
                meter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    int qq = Convert.ToInt16(table.Rows[0]["Quantidade"].ToString());
                    if (q2 < qq)
                    {
                        var q = table.Rows[0]["Quantidade"].ToString();
                        double q1 = Convert.ToDouble(q);
                        int id = Convert.ToInt16(table.Rows[0]["Id"].ToString());
                        double quant = q1-q2;

                        comando = new MySqlCommand("editar_produto", conexao);
                        comando.Parameters.AddWithValue("idd", id);
                        comando.Parameters.AddWithValue("produto", Produto);
                        comando.Parameters.AddWithValue("preco", preco);
                        comando.Parameters.AddWithValue("quantidade", quant);
                        comando.Parameters.AddWithValue("imagem", img);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Produto Vendido!");
                        txtProduto.Text = "";
                        txtPreco.Text = "";
                        txtQuantidade.Text = "";

                        comando = new MySqlCommand("cad_vendas", conexao);
                        comando.Parameters.AddWithValue("cliente", txtNomeCliente.Text);
                        comando.Parameters.AddWithValue("produto", Produto);
                        comando.Parameters.AddWithValue("data_compra", txtData.Text);
                        comando.Parameters.AddWithValue("preco", preco);
                        comando.Parameters.AddWithValue("quantidade", q2);
                        comando.Parameters.AddWithValue("usuario", txtUsuario.Text);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.ExecuteNonQuery();
                        //MessageBox.Show(txtProduto.Text);
                        MessageBox.Show("Venda Salva");
                        carregarProduto();
                    }
                    else if (qq == q2)
                    {
                        produtoId = Convert.ToInt32(table.Rows[0][0]);
                        globaId.SetGlobalProdutoId(produtoId);

                        comando = new MySqlCommand("eliminar_produto", conexao);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("idd", produtoId);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Produto Vendido!");

                        comando = new MySqlCommand("cad_vendas", conexao);
                        comando.Parameters.AddWithValue("cliente", txtNomeCliente.Text);
                        comando.Parameters.AddWithValue("produto", Produto);
                        comando.Parameters.AddWithValue("data_compra", txtData.Text);
                        comando.Parameters.AddWithValue("preco", preco);
                        comando.Parameters.AddWithValue("quantidade", q2);
                        comando.Parameters.AddWithValue("usuario", txtUsuario.Text);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Venda Salva");
                        carregarProduto();

                        carregarProduto();
                    }
                    else
                    {
                        MessageBox.Show("A Quantidade digitada excede o Limite! Digite uma Quantidada menor!");
                    }
                }

                produtoId = Convert.ToInt32(table.Rows[0][0]);
                globaId.SetGlobalProdutoId(produtoId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Produto não Vendido, Verifique os Dados! \n \n" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void labelX4_Click(object sender, EventArgs e)
        {
            gdvProduto.Visible = false;
            if (gdvProduto.Visible == false)
            {
                labelX6.Visible = true;
                labelX4.Visible = false;
                MessageBox.Show(Produto);
            }
        }
    }

}
