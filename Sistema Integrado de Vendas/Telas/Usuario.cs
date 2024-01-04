using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Sistema_Integrado_de_Vendas
{
    public partial class Usuario : Form
    {
        const string stringConexao = "server=localhost;port=3306;user=root;database=dbvendas";
        MySqlConnection conexao = new MySqlConnection(stringConexao);
        MySqlCommand comando;
        public static string Modo_Nocturno { get; set; }
        public Usuario()
        {
            InitializeComponent();
            carregarTabela();
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
                        dtvUsuario.BackColor = Color.FromArgb(41, 39, 40);
                        pictureBox1.BackColor = Color.FromArgb(41, 39, 40);

                        dtvUsuario.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
                        dtvUsuario.BackgroundColor = Color.FromArgb(41, 39, 40);
                        dtvUsuario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
                        dtvUsuario.DefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
                        dtvUsuario.RowsDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
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
            //conexao.Open();
            try
            {
                comando = new MySqlCommand("SELECT Id,Nome,Senha,Categoria from usuário", conexao);
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

        private void btSelecionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Selecione a Imagem (*.jpg;*.bmp;*.gif;*.png;*)|*.jpg;*.bmp;*.gif;*.png;";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
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

                comando = new MySqlCommand("cad_usuario", conexao);
                comando.Parameters.AddWithValue("nome", txtUtilizador.Text);
                comando.Parameters.AddWithValue("senha", txtSenha.Text);
                comando.Parameters.AddWithValue("categoria", txtCategoria.Text);
                comando.Parameters.AddWithValue("imagem", img);
                comando.CommandType = CommandType.StoredProcedure;
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuário Cadastrado!");
                btEditar.Enabled = false;
                btEliminar.Enabled = false;
                txtUtilizador.Text = "";
                txtSenha.Text = "";
                txtCategoria.Text = "";
                carregarTabela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuário não Cadastrado, Verifique os Dados! \n \n" + ex.ToString());
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

        private void btEliminar_Click(object sender, EventArgs e)
        {
            conexao.Open();
            try
            {
                comando = new MySqlCommand("eliminar_usuario", conexao);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("idd", dtvUsuario.CurrentRow.Cells[0].Value);
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuário Eliminado!");
                btEditar.Enabled = false;
                btEliminar.Enabled = false;
                txtUtilizador.Text = "";
                txtSenha.Text = "";
                txtCategoria.Text = "";
                carregarTabela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuário não Eliminado, Verifique os Dados! \n \n" + ex.ToString());
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
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();

                comando = new MySqlCommand("editar_usuario", conexao);
                comando.Parameters.AddWithValue("idd", dtvUsuario.CurrentRow.Cells[0].Value);
                comando.Parameters.AddWithValue("nome", txtUtilizador.Text);
                comando.Parameters.AddWithValue("senha", txtSenha.Text);
                comando.Parameters.AddWithValue("categoria", txtCategoria.Text);
                comando.Parameters.AddWithValue("imagem", img);
                comando.CommandType = CommandType.StoredProcedure;
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuário Editado!");
                btEditar.Enabled = false;
                btEliminar.Enabled = false;
                txtUtilizador.Text = "";
                txtSenha.Text = "";
                txtCategoria.Text = "";
                carregarTabela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuário não Editado, Verifique os Dados! \n \n" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable getUserById(int UserId)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            comando = new MySqlCommand("SELECT*FROM usuário WHERE Id=@uid", conexao);
            //comando.Parameters.AddWithValue("@id", UserId);
            comando.Parameters.Add("@uid", MySqlDbType.Int32).Value = UserId;
            adapter.SelectCommand = comando;
            adapter.Fill(table);
            return table;
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
                txtCategoria.Focus();
            }
        }

        private void txtCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUtilizador.Focus();
            }
        }

        private void dtvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                verImagem();
                int posicao = dtvUsuario.CurrentRow.Index;
                txtUtilizador.Text = dtvUsuario[1, posicao].Value.ToString();
                txtSenha.Text = dtvUsuario[2, posicao].Value.ToString();
                txtCategoria.Text = dtvUsuario[3, posicao].Value.ToString();
                btEditar.Enabled = true;
                btEliminar.Enabled = true;
            }
            catch (Exception)
            {

            }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
