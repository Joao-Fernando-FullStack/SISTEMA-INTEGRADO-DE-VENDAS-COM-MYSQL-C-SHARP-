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

namespace Sistema_Integrado_de_Vendas
{
    public partial class Produto : Form
    {
        const string stringConexao = "server=localhost;port=3306;user=root;database=dbvendas";
        MySqlConnection conexao = new MySqlConnection(stringConexao);
        MySqlCommand comando;
        Usuario user = new Usuario();
        public static string Modo_Nocturno { get; set; }
        public Produto()
        {
            InitializeComponent();
            GetUserName();
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
                        dtvProduto.BackColor = Color.FromArgb(41, 39, 40);
                        pictureBox1.BackColor = Color.FromArgb(41, 39, 40);

                        dtvProduto.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
                        dtvProduto.BackgroundColor = Color.FromArgb(41, 39, 40);
                        dtvProduto.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
                        dtvProduto.DefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
                        dtvProduto.RowsDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);   
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

        private void btImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Selecione a Imagem (*.jpg;*.bmp;*.gif;*.png;*)|*.jpg;*.bmp;*.gif;*.png;";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        void carregarTabela()
        {
            //conexao.Open();
            try
            {
                comando = new MySqlCommand("SELECT Id,Produto,Preco,Quantidade FROM produto", conexao);
                MySqlDataAdapter meter = new MySqlDataAdapter(comando);
                DataTable table = new DataTable();
                meter.Fill(table);
                dtvProduto.DataSource = table;
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

                //Verificar se está na BD
                MySqlDataAdapter adpter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                MySqlCommand comando1 = new MySqlCommand("SELECT*from produto WHERE Produto=@nome AND Preço=preco", conexao);
                comando1.Parameters.AddWithValue("@nome", txtProduto.Text);
                comando1.Parameters.AddWithValue("@preco", txtPreco.Text);
                MySqlDataAdapter meter = new MySqlDataAdapter(comando);
                adpter.SelectCommand = comando;
                adpter.Fill(table);

                if (table.Rows[0]["Produto"].Equals(txtProduto.Text))
                {
                    var q = table.Rows[0]["Quantidade"].ToString();
                    double q1 = Convert.ToDouble(q);
                    int id=Convert.ToInt16( table.Rows[0]["Id"].ToString());
                    double quant = q1 + q2;

                    comando = new MySqlCommand("editar_produto", conexao);
                    comando.Parameters.AddWithValue("idd", id);
                    comando.Parameters.AddWithValue("produto", txtProduto.Text);
                    comando.Parameters.AddWithValue("preco", preco);
                    comando.Parameters.AddWithValue("quantidade", quant);
                    comando.Parameters.AddWithValue("imagem", img);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Produto Cadastrado!");
                    btEditar.Enabled = false;
                    btEliminar.Enabled = false;
                    txtProduto.Text = "";
                    txtPreco.Text = "";
                    txtQuantidade.Text = "";
                    carregarTabela();
                }
                else
                {
                    comando = new MySqlCommand("cad_produto", conexao);
                    comando.Parameters.AddWithValue("produto", txtProduto.Text);
                    comando.Parameters.AddWithValue("preco", preco);
                    comando.Parameters.AddWithValue("quantidade", q2);
                    comando.Parameters.AddWithValue("imagem", img);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Produto Cadastrado!");
                    btEditar.Enabled = false;
                    btEliminar.Enabled = false;
                    txtProduto.Text = "";
                    txtPreco.Text = "";
                    txtQuantidade.Text = "";
                    carregarTabela();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Produto não Cadastrado, Verifique os Dados! \n \n" + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        private void txtProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPreco.Focus();
            }
        }

        private void txtPreco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQuantidade.Focus();
            }
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btCadastrar_Click(sender, e);
            }
        }

        private void verImagem()
        {
            conexao.Open();

            try
            {
                comando = new MySqlCommand("SELECT*FROM produto WHERE Id=@ID", conexao);
                comando.Parameters.AddWithValue("@ID", dtvProduto.CurrentRow.Cells[0].Value);

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

        private void dtvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProduto.Text = dtvProduto.CurrentRow.Cells[1].Value.ToString();
            txtPreco.Text = dtvProduto.CurrentRow.Cells[2].Value.ToString();
            txtQuantidade.Text = dtvProduto.CurrentRow.Cells[3].Value.ToString();
            verImagem();
                DataTable table = user.getUserById(GlobalId.UserId);

            if ((table.Rows[0]["Categoria"].ToString().Equals("Administrador")))
            {
                btEditar.Enabled = true;
                btEliminar.Enabled = true;
            }


        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            conexao.Open();
            try
            {
                comando = new MySqlCommand("eliminar_produto", conexao);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("idd", dtvProduto.CurrentRow.Cells[0].Value);
                comando.ExecuteNonQuery();
                carregarTabela();
                MessageBox.Show("Produto Eliminado!");
                btEditar.Enabled = false;
                btEliminar.Enabled = false;
                txtProduto.Text = "";
                txtPreco.Text = "";
                txtQuantidade.Text = "";
                carregarTabela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Produto Não Eliminado! \n \n" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            conexao.Open();
            try
            {
                double preco = Convert.ToDouble(txtPreco.Text);
                double quant = Convert.ToDouble(txtQuantidade.Text);

                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();

                comando = new MySqlCommand("editar_produto", conexao);
                comando.Parameters.AddWithValue("idd", dtvProduto.CurrentRow.Cells[0].Value);
                comando.Parameters.AddWithValue("produto", txtProduto.Text);
                comando.Parameters.AddWithValue("preco", preco);
                comando.Parameters.AddWithValue("quantidade", quant);
                comando.Parameters.AddWithValue("imagem", img);
                comando.CommandType = CommandType.StoredProcedure;
                comando.ExecuteNonQuery();
                MessageBox.Show("Produto Editado!");
                btEditar.Enabled = false;
                btEliminar.Enabled = false;
                txtProduto.Text = "";
                txtPreco.Text = "";
                txtQuantidade.Text = "";
                carregarTabela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Produto não Editado, Verifique os Dados! \n \n" + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        private void Produto_Load(object sender, EventArgs e)
        {
            carregarTabela();
        }

        void GetUserName()
        {
            try
            {
                DataTable table = user.getUserById(GlobalId.UserId);

                if (!(table.Rows[0]["Categoria"].ToString().Equals("Administrador")))
                {
                    btEditar.Visible = false;
                    btEliminar.Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
