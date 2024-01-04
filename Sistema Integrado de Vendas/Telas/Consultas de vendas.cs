using MySql.Data.MySqlClient;
using Sistema_Integrado_de_Vendas.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Integrado_de_Vendas
{
    public partial class Consultas_de_vendas : Form
    {
        const string stringConexao = "server=localhost;port=3306;user=root;database=dbvendas";
        MySqlConnection conexao = new MySqlConnection(stringConexao);
        MySqlCommand comando;
        public static string quantidadeVendas { get; set; }
        public static string Modo_Nocturno { get; set; }
        Usuario user = new Usuario();
        public Consultas_de_vendas()
        {
            InitializeComponent();
            carregar();
            quantidadeVendas = dtvVendas.Rows.Count.ToString();
            lbTotal.Text = quantidadeVendas;
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
                        dtvVendas.BackColor = Color.FromArgb(41, 39, 40);
                        pictureBox1.BackColor = Color.FromArgb(41, 39, 40);

                        dtvVendas.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
                        dtvVendas.BackgroundColor = Color.FromArgb(41, 39, 40);
                        dtvVendas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
                        dtvVendas.DefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
                        dtvVendas.RowsDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
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

        void carregar()
        {
            conexao.Open();
            try
            {
                comando = new MySqlCommand("SELECT*FROM vendas", conexao);
                MySqlDataAdapter meter = new MySqlDataAdapter(comando);
                DataTable table = new DataTable();
                meter.Fill(table);
                dtvVendas.DataSource = table;
            }
            catch(Exception ex)
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
                carregar();
            }
            else
            {
                conexao.Open();
                try
                {
                    comando = new MySqlCommand("pesquisar_vendas", conexao);
                    comando.Parameters.AddWithValue("nome1", txtPesquisar.Text);
                    comando.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter meter = new MySqlDataAdapter(comando);
                    comando.ExecuteNonQuery();
                    DataTable table = new DataTable();
                    meter.Fill(table);
                    dtvVendas.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data ou Produto não Encontrado, Verifique os Dados! \n \n" + ex.ToString());
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            Vendas v = new Vendas();
            v.Show();
            Visible = false;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var img = Image.FromFile(@"C:\Users\PC\Documents\Nova pasta\Projects\Sistema Integrado de Vendas\Sistema Integrado de Vendas\Resources\SIV LOG.png");
            e.Graphics.DrawImage(img, -5, -35);
            string s = "Relatório de Todas as Vendas desta empresa, contém \n" +
                       "todas informações de todas as Vendas da Empresa caso\n" +
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
            int height = dtvVendas.Height;
            dtvVendas.Height = dtvVendas.RowCount * dtvVendas.RowTemplate.Height * 2;
            bmp = new Bitmap(dtvVendas.Width, dtvVendas.Height);
            dtvVendas.DrawToBitmap(bmp, new Rectangle(0, 0, dtvVendas.Width, dtvVendas.Height));
            dtvVendas.Height = height;
            printDocument1.PrinterSettings = printDocument1.PrinterSettings;
            printPreviewDialog1.ShowDialog();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
