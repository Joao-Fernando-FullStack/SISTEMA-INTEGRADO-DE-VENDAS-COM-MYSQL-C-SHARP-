using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Sistema_Integrado_de_Vendas.Telas
{
    public partial class Consultar_Produtos : Form
    {
        const string stringConexao = "server=localhost;port=3306;user=root;database=dbvendas";
        MySqlConnection conexao = new MySqlConnection(stringConexao);
        MySqlCommand comando;
        Usuario user = new Usuario();
        public static string quantidadeProduto { get; set; }
        public static string Modo_Nocturno { get; set; }
        public Consultar_Produtos()
        {
            InitializeComponent();
            Modo_Nocturno = Modo_Nocturno1.ModoNocturno;
            Modo();
            GetUserName();
        }

        void GetUserName()
        {
            try
            {
                DataTable table = user.getUserById(GlobalId.UserId);

                if (table.Rows[0]["Categoria"].ToString().Equals("Monitor") || table.Rows[0]["Categoria"].ToString().Equals("Funcionário"))
                {
                    btEditar.Visible = false;
                    //btEliminar.Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
        void carregarTabela()
        {
            conexao.Open();
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

        void pesquisar()
        {
            if (txtPesquisar.Text.Equals(" "))
            {
                carregarTabela();
            }
            else
            {
                conexao.Open();
                try
                {
                    comando = new MySqlCommand("pesquisar_produto", conexao);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("nome1", txtPesquisar.Text);
                    MySqlDataAdapter meter = new MySqlDataAdapter(comando);
                    comando.ExecuteNonQuery();
                    DataTable table = new DataTable();
                    meter.Fill(table);
                    dtvProduto.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Produto não Encontrado, Verifique os Dados! \n \n" + ex.ToString());
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var img = Image.FromFile(@"C:\Users\PC\Documents\Nova pasta\Projects\Sistema Integrado de Vendas\Sistema Integrado de Vendas\Resources\SIV LOG.png");
            e.Graphics.DrawImage(img, -5, -35);
            string s = "Relatório de Todos os Produtos desta empresa, contém \n" +
                       "todas informações de todos os Produto da Empresa caso\n" +
                       "tenha dúvidas contacte o administrador!\n" +
                       "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n " +
                        "                       A Assinatura do Secretário \n" +
                        "                 _______________________________________" + "\n" +
                        "                     João Fernando Matias Vilassanda         \n\n\n " +
                        "                                       Luanda Aos " + DateTime.Now.ToLongDateString().ToString();
            printDocument1.PrinterSettings = printDocument1.PrinterSettings;
            e.Graphics.DrawString(s, new Font("Maiandra GD", 18), new SolidBrush(Color.Purple), 100, 360, StringFormat.GenericTypographic);
            e.Graphics.DrawImage(bmp, 50, 465);
        }

        Bitmap bmp;

        private void btImprimir_Click(object sender, EventArgs e)
        {
            int height = dtvProduto.Height;
            dtvProduto.Height = dtvProduto.RowCount * dtvProduto.RowTemplate.Height * 2;
            bmp = new Bitmap(dtvProduto.Width, dtvProduto.Height);
            dtvProduto.DrawToBitmap(bmp, new Rectangle(0, 0, dtvProduto.Width, dtvProduto.Height));
            dtvProduto.Height = height;
            printDocument1.PrinterSettings = printDocument1.PrinterSettings;
            printPreviewDialog1.ShowDialog();
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

        private void buttonX1_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            pesquisar();
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            pesquisar();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.Show();
            Visible = false;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void Consultar_Produtos_Load(object sender, EventArgs e)
        {
            carregarTabela();
            quantidadeProduto = dtvProduto.Rows.Count.ToString();
            lbTotal.Text = quantidadeProduto;
        }

        private void dtvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            verImagem();
        }
    }
}
