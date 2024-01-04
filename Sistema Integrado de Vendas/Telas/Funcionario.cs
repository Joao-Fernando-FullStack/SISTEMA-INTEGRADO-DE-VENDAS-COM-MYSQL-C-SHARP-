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
    public partial class Funcionario : Form
    {
        const string stringConexao = "server=localhost;port=3306;user=root;database=dbvendas";
        MySqlConnection conexao = new MySqlConnection(stringConexao);
        MySqlCommand comando;
        Usuario user = new Usuario();

        public static string Modo_Nocturno { get; set; }
        String sexo { get; set; }
        public Funcionario()
        {
            InitializeComponent();
            carregarTabela();
            Modo_Nocturno = Modo_Nocturno1.ModoNocturno;
            Modo();
            GetUserName();
        }

        void carregarTabela()
        {
            //conexao.Open();
            try
            {
                comando = new MySqlCommand("SELECT Id,Nome,Sexo,Data_Nascimento,Telefone,Função,Salário from funcionario", conexao);
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

        private void checkMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMasculino.Checked == true)
            {
                chekFeminino.Checked = false;
            }
        }

        private void chekFeminino_CheckedChanged(object sender, EventArgs e)
        {
            if (chekFeminino.Checked == true)
            {
                checkMasculino.Checked = false;
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

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            conexao.Open();
            try
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();

                if (checkMasculino.Checked == true)
                {
                    sexo = "Masculino";
                }
                else if (chekFeminino.Checked == true)
                {
                    sexo = "Feminino";
                }

                comando = new MySqlCommand("cad_funcionario", conexao);
                comando.Parameters.AddWithValue("nome", txtNome.Text);
                comando.Parameters.AddWithValue("sexo", sexo);
                comando.Parameters.AddWithValue("data_nascimento", txtData.Text.ToString());
                comando.Parameters.AddWithValue("telefone", txtEndereco.Text);
                comando.Parameters.AddWithValue("funcao", cmbFuncao.Text);
                comando.Parameters.AddWithValue("salario", txtSalario.Text);
                comando.Parameters.AddWithValue("imagem", img);
                comando.CommandType = CommandType.StoredProcedure;
                comando.ExecuteNonQuery();
                MessageBox.Show("Funcionário Cadastrado!");
                btEditar.Enabled = false;
                btEliminar.Enabled = false;
                chekFeminino.Checked = false;
                checkMasculino.Checked = false;
                txtNome.Text = "";
                txtData.Text = "";
                txtEndereco.Text = "";
                txtSalario.Text = "";
                carregarTabela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Funcionário não Cadastrado, Verifique os Dados! \n Imagem Inválida!");
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
                comando = new MySqlCommand("eliminar_funcionario", conexao);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("idd", dtvFuncionario.CurrentRow.Cells[0].Value);
                comando.ExecuteNonQuery();
                MessageBox.Show("Funcionário Eliminado!");
                btEditar.Enabled = false;
                btEliminar.Enabled = false;
                txtNome.Text = "";
                txtEndereco.Text = "";
                txtSalario.Text = "";
                cmbFuncao.SelectedText = "";
                checkMasculino.Checked = false;
                chekFeminino.Checked = false;
                txtData.Text = "";
                carregarTabela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Funcionário não Eliminado, Verifique os Dados!");
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
                int posicao = dtvFuncionario.CurrentRow.Index;
                txtNome.Text = dtvFuncionario[1, posicao].Value.ToString();

                if (dtvFuncionario[2, posicao].Value.ToString().Equals("Masculino"))
                {
                    checkMasculino.Checked = true;
                }
                else if (dtvFuncionario[2, posicao].Value.ToString().Equals("Feminino"))
                {
                    chekFeminino.Checked = true;
                }
                txtData.Text = dtvFuncionario[3, posicao].Value.ToString();
                txtEndereco.Text = dtvFuncionario[4, posicao].Value.ToString();
                cmbFuncao.Text = dtvFuncionario[5, posicao].Value.ToString();
                txtSalario.Text = dtvFuncionario[6, posicao].Value.ToString();
                DataTable table = user.getUserById(GlobalId.UserId);

                if (!(table.Rows[0]["Categoria"].ToString().Equals("Monitor") || table.Rows[0]["Categoria"].ToString().Equals("Funcionário")))
                {
                    btEditar.Enabled = true;
                    btEliminar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                if (checkMasculino.Checked == true)
                {
                    sexo = "Masculino";
                }
                else if (chekFeminino.Checked == true)
                {
                    sexo = "Feminino";
                }

                comando = new MySqlCommand("editar_funcionario", conexao);
                comando.Parameters.AddWithValue("idd", dtvFuncionario.CurrentRow.Cells[0].Value);
                comando.Parameters.AddWithValue("nome", txtNome.Text);
                comando.Parameters.AddWithValue("sexo", sexo);
                comando.Parameters.AddWithValue("data_nascimento", txtData.Text.ToString());
                comando.Parameters.AddWithValue("telefone", txtEndereco.Text);
                comando.Parameters.AddWithValue("funcao", cmbFuncao.Text);
                comando.Parameters.AddWithValue("salario", txtSalario.Text);
                comando.Parameters.AddWithValue("imagem", img);
                comando.CommandType = CommandType.StoredProcedure;
                comando.ExecuteNonQuery();
                MessageBox.Show("Funcionário Editado!");
                btEditar.Enabled = false;
                btEliminar.Enabled = false;
                chekFeminino.Checked = false;
                checkMasculino.Checked = false;
                txtNome.Text = "";
                txtData.Text = "";
                txtEndereco.Text = "";
                txtSalario.Text = "";
                carregarTabela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Funcionário não Editado, Verifique os Dados! ");
            }
            finally
            {
                conexao.Close();
            }
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

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkMasculino.Focus();
            }
        }

        private void checkMasculino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chekFeminino.Focus();
            }
        }

        private void chekFeminino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtData.Focus();
            }
        }

        private void txtData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEndereco.Focus();
            }
        }

        private void txtEndereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbFuncao.Focus();
            }
        }
    }
}
