using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace TOP_11_DELIVERY
{
    public partial class Funcionarios : Form
    {
        NpgsqlConnection conexao = new NpgsqlConnection("Host=localhost;Database=Top11;Username=postgres;Password=Matematicas2");
        public Funcionarios()
        {
            InitializeComponent();
        }

        private void Funcionarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Menu menu1 = new Menu();
            //menu1.Show();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            //abrindo conexao
            conexao.Open();
            //Limpa as linhas...
            DataViewFuncionarios.Rows.Clear();

            try
            {
                string query = "SELECT * FROM funcionarios;";

                if (txtPesquisa.Text != "")
                {
                    query = "SELECT * FROM funcionarios WHERE func_nome LIKE '" + txtPesquisa.Text + "%';";
                }

                DataTable dados = new DataTable();

                NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(query, conexao);
                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    DataViewFuncionarios.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                conexao.Close();
                MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataViewFuncionarios.Rows.Clear();
            }
            finally
            {
                conexao.Close();
            }

            int conta = DataViewFuncionarios.Rows.Count;
            if (conta == 0)
            {
                MessageBox.Show("Não foi encontrado nenhum registro com a palavra '" + txtPesquisa.Text + "'!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Encontramos ' " + Convert.ToString(conta) + " ' com a palavra '" + txtPesquisa.Text + "'!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }

        }



        private void Funcionarios_Load(object sender, EventArgs e)
        {
            cbAcesso.SelectedIndex = 1;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                if (txtSenha.Text == txtConfirma.Text)
                {
                    //abrindo conexao
                    conexao.Open();


                    try
                    {
                        //criando comando
                        NpgsqlCommand comando = new NpgsqlCommand();
                        //passando a conexao para o comando
                        comando.Connection = conexao;

                        int ID = new Random(DateTime.Now.Millisecond).Next(0, 999999);

                        comando.CommandText = "INSERT INTO funcionarios VALUES (" + ID + ", '" + txtNome.Text + "', '" + txtSenha.Text + "', '" + Convert.ToString(cbAcesso.SelectedItem) + "');";

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comando.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Close();
                        txtNome.Text = "";
                        txtConfirma.Text = "";
                        txtSenha.Text = "";
                        cbAcesso.SelectedIndex = 1;
                        DataViewFuncionarios.Rows.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("As senhas não conferem.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirma.Text = "";
                    txtSenha.Text = "";
                    txtSenha.Focus();
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo Nome!", "Erro na inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnPesquisa_Click(null, null);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text != "")
            {
                if (txtSenha.Text == txtConfirma.Text)
                {
                    //abrindo conexao
                    conexao.Open();
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;


                    try
                    {
                        //criando comando
                        NpgsqlCommand comando = new NpgsqlCommand();
                        //passando a conexao para o comando
                        comando.Connection = conexao;


                        //pegando o valor da celula celecionada
                        var ID = DataViewFuncionarios.SelectedCells[0].OwningRow.Cells[0].Value;



                        //passando o comando sql
                        comando.CommandText = "UPDATE funcionarios SET  func_nome = '" + txtNome.Text + "', func_senha = '" + txtSenha.Text + "', func_acesso = '" + Convert.ToString(cbAcesso.SelectedItem) + "' WHERE func_id = " + Convert.ToInt32(ID) + ";";

                        //executando a query
                        comando.ExecuteNonQuery();

                        //mostrando resultado
                        MessageBox.Show("Editado com sucesso!", "Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comando.Dispose();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txtNome.Text = "";
                        txtSenha.Text = "";
                        txtConfirma.Text = "";
                        cbAcesso.SelectedIndex = 1;
                    }
                    finally
                    {
                        conexao.Close();

                        DataViewFuncionarios.Rows.Clear();
                        txtNome.Text = "";
                        txtSenha.Text = "";
                        txtConfirma.Text = "";

                        cbAcesso.SelectedIndex = 1;

                        btnEditar.Enabled = true;
                        btnExcluir.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("As senhas não conferem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirma.Text = "";
                    txtSenha.Text = "";
                    txtSenha.Focus();

                }
            }
            else
            {
                MessageBox.Show("Preencha o Campo descrição!", "Erro de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //abrindo conexao
            conexao.Open();
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

            txtNome.Text = "";
            txtConfirma.Text = "";
            txtSenha.Text = "";
            cbAcesso.SelectedIndex = 1;
            try
            {
                //criando comando
                NpgsqlCommand comando = new NpgsqlCommand();
                //passando a conexao para o comando
                comando.Connection = conexao;
                //limpando o label

                //pegando o valor da celula celecionada
                var ID = DataViewFuncionarios.SelectedCells[0].OwningRow.Cells[0].Value;



                //passando o comando sql
                comando.CommandText = "DELETE FROM funcionarios WHERE func_id = '" + Convert.ToInt32(ID) + "';";

                //executando a query
                comando.ExecuteNonQuery();

                //mostrando resultado
                MessageBox.Show("Excluido com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
                DataViewFuncionarios.Rows.Clear();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

            conexao.Close();

            txtNome.Text = "";
            txtConfirma.Text = "";
            txtSenha.Text = "";
            cbAcesso.SelectedIndex = 1;
            DataViewFuncionarios.Rows.Clear();
            txtPesquisa.Text = "";

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void DataViewFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var ID = DataViewFuncionarios.SelectedCells[0].OwningRow.Cells[0].Value;
            //label2.Text = Convert.ToString(ID);

            int conta = DataViewFuncionarios.Rows.Count;
            if (conta > 0)
            {
                //btnCadastrar.Enabled = false;

                txtNome.Text = Convert.ToString(DataViewFuncionarios.SelectedCells[0].OwningRow.Cells[1].Value);

                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }

            else
            {
                //btnCadastrar.Enabled = false;

                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }
    }
}
