using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Integrado_de_Vendas
{
    public partial class Consultar_Funcionario : Form
    {
        const string stringConexao = "server=localhost;port=3306;user=root;database=dbvendas";
        MySqlConnection conexao = new MySqlConnection(stringConexao);
        MySqlCommand comando;
        public static string Modo_Nocturno { get; set; }
        Usuario user = new Usuario();
        public static string quantidadeFuncionario { get; set; }
        public Consultar_Funcionario()
        {
            InitializeComponent();
            carregarTabela();
            quantidadeFuncionario= dtvFuncionario.Rows.Count.ToString();
            lbTotal.Text = quantidadeFuncionario;
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

        void carregarTabela()
        {
            //conexao.Open();
            try
            {
                comando = new MySqlCommand("SELECT Id,Nome,Sexo,Data_Nascimento,Telefone,Função,Salário From funcionario ORDER BY Nome ASC", conexao);
                MySqlDataAdapter meter = new MySqlDataAdapter(comando);
                DataTable table = new DataTable();
                meter.Fill(table);
                dtvFuncionario.DataSource = table;
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
                        dtvFuncionario.BackColor = Color.FromArgb(41, 39, 40);
                        pictureBox1.BackColor = Color.FromArgb(41, 39, 40);

                        dtvFuncionario.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
                        dtvFuncionario.BackgroundColor = Color.FromArgb(41, 39, 40);
                        dtvFuncionario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
                        dtvFuncionario.DefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
                        dtvFuncionario.RowsDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
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

        private void verImagem()
        {
            conexao.Open();

            try
            {
                comando = new MySqlCommand("SELECT*FROM funcionario WHERE Id=@ID", conexao);
                comando.Parameters.AddWithValue("@ID", dtvFuncionario.CurrentRow.Cells[0].Value);

                var dir = comando.ExecuteReader(CommandBehavior.SingleRow);

                if (dir.HasRows)
                {
                    dir.Read();

                    byte[] imagem = (byte[])(dir[7]);

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

        private void dtvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                verImagem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Consultar_Funcionario_Load(object sender, EventArgs e)
        {

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();
            f.Show();
            Visible = false;
        }

        Bitmap bmp;
        private void buttonX2_Click(object sender, EventArgs e)
        {
            int height = dtvFuncionario.Height;
            dtvFuncionario.Height = dtvFuncionario.RowCount * dtvFuncionario.RowTemplate.Height*2;
            bmp = new Bitmap(dtvFuncionario.Width, dtvFuncionario.Height);
            dtvFuncionario.DrawToBitmap(bmp, new Rectangle(0, 0, dtvFuncionario.Width, dtvFuncionario.Height));
            dtvFuncionario.Height = height;
            printDocument1.PrinterSettings = printDocument1.PrinterSettings;
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            var img = Image.FromFile(@"C:\Users\PC\Documents\Nova pasta\Projects\Sistema Integrado de Vendas\Sistema Integrado de Vendas\Resources\SIV LOG.png");
            //img.PixelFormat = 10;
            e.Graphics.DrawImage(img, -95, -135);
            string s = "Relatório de Todos os Funcionários desta empresa, contém \n" +
                       "todas informações de todos os funcionários da Empresa caso\n" +
                       "não tenha o seu nome contacte o administrador!\n" +
                       "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n " +
                        "                       A Assinatura do Secretário \n"+ 
                        "                 _______________________________________"+"\n"+
                        "                     João Fernando Matias Vilassanda         \n\n\n " +
                        "                                       Luanda Aos " + DateTime.Now.ToLongDateString().ToString();
            printDocument1.PrinterSettings = printDocument1.PrinterSettings;
            e.Graphics.DrawString(s, new Font("Maiandra GD", 18), new SolidBrush(Color.Purple),0,250,StringFormat.GenericTypographic);
            e.Graphics.DrawImage(bmp, -90, 350);
                

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
                    comando = new MySqlCommand("pesquisar_funcionario", conexao);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("nome1", txtPesquisar.Text);
                    MySqlDataAdapter meter = new MySqlDataAdapter(comando);
                    comando.ExecuteNonQuery();
                    DataTable table = new DataTable();
                    meter.Fill(table);
                    dtvFuncionario.DataSource = table;
                    //MessageBox.Show("Funcionário Eliminado!");
                    //carregarTabela();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Funcionário não Encontrado, Verifique os Dados! \n \n" + ex.ToString());
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //pesquisar();
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            pesquisar();
        }

        private void buttonX2_Click_1(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
