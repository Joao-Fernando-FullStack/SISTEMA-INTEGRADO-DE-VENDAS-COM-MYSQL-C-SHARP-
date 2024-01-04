using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Sistema_Integrado_de_Vendas.Telas
{
    public partial class Preferências : Form
    {
        const string stringConexao = "server=localhost;port=3306;user=root;database=dbvendas";
        MySqlConnection conexao = new MySqlConnection(stringConexao);
        MySqlCommand comando;
        Menu_Principal m;
        public static string Modo_Nocturno { get; set; }
        public Preferências()
        {
            InitializeComponent();
            Modo();
            carregarTabela();
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
                        dtvUsuario.BackColor = Color.FromArgb(41, 39, 40);
                        pictureBox1.BackColor = Color.FromArgb(41, 39, 40);
                        richTextBox1.BackColor = Color.FromArgb(41, 39, 40);
                        richTextBox2.BackColor = Color.FromArgb(41, 39, 40);
                        panel1.BackColor = Color.FromArgb(41, 39, 40);
                        panel2.BackColor = Color.FromArgb(41, 39, 40);
                        dtvUsuario.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
                        dtvUsuario.BackgroundColor = Color.FromArgb(41, 39, 40);
                        dtvUsuario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
                        dtvUsuario.DefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
                        dtvUsuario.RowsDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);

                        btTrue.Visible = false;
                        btFalse.Visible = true; ;
                    }
                else if (Modo_Nocturno == "False")
                {
                        BackColor = Color.Purple;
                        groupBox1.BackColor = Color.Purple;
                        dtvUsuario.BackColor = Color.Purple;
                        pictureBox1.BackColor = Color.Purple;
                        richTextBox1.BackColor = Color.Purple;
                        richTextBox2.BackColor = Color.Purple;
                        panel1.BackColor = Color.Purple;
                        panel2.BackColor = Color.Purple;
                        dtvUsuario.RowHeadersDefaultCellStyle.BackColor = Color.Purple;
                        dtvUsuario.BackgroundColor = Color.Purple;
                        dtvUsuario.AlternatingRowsDefaultCellStyle.BackColor = Color.Purple;
                        dtvUsuario.DefaultCellStyle.BackColor = Color.Purple;
                        dtvUsuario.RowsDefaultCellStyle.BackColor = Color.Purple;
                        btTrue.Visible = true;
                        btFalse.Visible = false;
                    }
            }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }    
           }



        private void buttonX3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btFalse_Click(object sender, EventArgs e)
        {
            Modo_Nocturno = "False";
            Modo();
        }

        private void btTrue_Click(object sender, EventArgs e)
        {
            Modo_Nocturno = "True";
            Modo();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            
            if (m.Visible==true)
            {
                Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Menu_Principal n = new Menu_Principal();
            n.Show();
        }

        private void verImagem()
        {
            conexao.Open();

            try
            {
                comando = new MySqlCommand("SELECT*FROM usuário WHERE Id=@ID", conexao);
                comando.Parameters.AddWithValue("@ID", dtvUsuario.CurrentRow.Cells[0].Value);

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
        private void dtvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                verImagem();
                int posicao = dtvUsuario.CurrentRow.Index;
                if (!(dtvUsuario[2, posicao].Value.ToString().Equals("Administrador")))
                {
                    cad.Checked = true;
                    editar.Checked = false;
                    eliminar.Checked = false;
                    usuario.Checked = false;
                    privilegio.Checked = true;
                }
                else 
                {
                    cad.Checked = true;
                    editar.Checked = true;
                    eliminar.Checked = true;
                    usuario.Checked = true;
                    privilegio.Checked = true;
                }
            }
            catch (Exception)
            {

            }
        }

        void carregarTabela()
        {
            //conexao.Open();
            try
            {
                comando = new MySqlCommand("SELECT Id,Nome,Categoria from usuário", conexao);
                MySqlDataAdapter meter = new MySqlDataAdapter(comando);
                DataTable table = new DataTable();
                meter.Fill(table);
                dtvUsuario.DataSource = table;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonX2_Click_1(object sender, EventArgs e)
        {
            Visible = false;
            Menu_Principal m = new Menu_Principal();
            m.Show();
        }
    }
}
