using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;


namespace TOP_11_DELIVERY
{
    public partial class Cliente : Form
    {
        NpgsqlConnection conexao = new NpgsqlConnection("Host=localhost;Database=Top11;Username=postgres;Password=Matematicas2");
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            //abrindo conexao
            conexao.Open();
            GridBairro.Rows.Clear();
            try
            {
                string query = "SELECT * FROM bairro;";


                DataTable dados = new DataTable();

                NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(query, conexao);
                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    GridBairro.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                conexao.Close();
                MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GridBairro.Rows.Clear();
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            #region tratando os dados de pesquisa
            //abrindo conexao
            conexao.Open();
            dataGridCliente.Rows.Clear();

            try
            {
                string query = "SELECT c.cliente_cpf, c.cliente_nome, c.cliente_telefone, c.cliente_endereco," +
                        " c.cliente_complemento, c.cliente_num_end, c.cliente_cep, b.bairro_nome" +
                        " FROM cliente as c, bairro as b" +
                        " WHERE c.cliente_id_bairro = b.bairro_id; ";

                if (txtPesquisa.Text != "")
                {
                    query = "SELECT c.cliente_cpf, c.cliente_nome, c.cliente_telefone, c.cliente_endereco," +
                        " c.cliente_complemento, c.cliente_num_end, c.cliente_cep, b.bairro_nome" +
                        " FROM cliente as c, bairro as b" +
                        " WHERE c.cliente_id_bairro = b.bairro_id AND" +
                        " c.cliente_telefone LIKE '" + txtPesquisa.Text + "%'; ";
                }

                DataTable dados = new DataTable();

                NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(query, conexao);
                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    dataGridCliente.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                conexao.Close();
                MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridCliente.Rows.Clear();
            }
            finally
            {
                conexao.Close();
            }

            int conta = dataGridCliente.Rows.Count;
            if (conta == 0)
            {
                MessageBox.Show("Não foi encontrado nenhum registro com  '" + txtPesquisa.Text + "'!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Encontramos ' " + Convert.ToString(conta) + " ' com  '" + txtPesquisa.Text + "'!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }

            #endregion


        }

        private void Cliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexao.Close();

        }

        private void Cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            conexao.Close();

        }

        private void GridBairro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCadastrar.Enabled = true;

        }

        private void dataGridCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int conta = dataGridCliente.Rows.Count;
            if (conta > 0)
            {

                txtCPF.Text = Convert.ToString(dataGridCliente.SelectedCells[0].OwningRow.Cells[0].Value);
                txtNome.Text = Convert.ToString(dataGridCliente.SelectedCells[0].OwningRow.Cells[1].Value);
                txtTel.Text = Convert.ToString(dataGridCliente.SelectedCells[0].OwningRow.Cells[2].Value);
                txtEnd.Text = Convert.ToString(dataGridCliente.SelectedCells[0].OwningRow.Cells[3].Value);
                txtComp.Text = Convert.ToString(dataGridCliente.SelectedCells[0].OwningRow.Cells[4].Value);
                txtNum.Text = Convert.ToString(dataGridCliente.SelectedCells[0].OwningRow.Cells[5].Value);
                txtCEP.Text = Convert.ToString(dataGridCliente.SelectedCells[0].OwningRow.Cells[6].Value);
                //txtNome.Text = Convert.ToString(dataGridCliente.SelectedCells[0].OwningRow.Cells[7].Value);

                var id = dataGridCliente.SelectedCells[0].OwningRow.Cells[0].Value;

                conexao.Open();

                GridBairro.Rows.Clear();

                try
                {
                    string query = "SELECT b.bairro_id, b.bairro_nome FROM bairro as b, cliente as c  WHERE c.cliente_id_bairro = b.bairro_id AND " +
                        " c.cliente_cpf = '" + id + "';";


                    DataTable dados = new DataTable();

                    NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(query, conexao);
                    adaptador.Fill(dados);

                    foreach (DataRow linha in dados.Rows)
                    {
                        GridBairro.Rows.Add(linha.ItemArray);
                    }
                }
                catch (Exception ex)
                {
                    conexao.Close();
                    MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GridBairro.Rows.Clear();
                }
                finally
                {
                    conexao.Close();
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                }

            }

            else
            {
                //btnCadastrar.Enabled = false;

                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }

            int contaa = dataGridCliente.Rows.Count;
            int contaProduto = GridBairro.Rows.Count;
            if (contaa != 0)
            {
                if (contaProduto == 0)
                {
                    btnCadastrar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                }
                else
                {

                    btnCadastrar.Enabled = true;
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Selecione o Produto que deseja alterar!", "Erro na inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("data = '" + Convert.ToDateTime(dtpDataNasc.Value).ToShortDateString() +"'","Data",MessageBoxButtons.OK,MessageBoxIcon.Question);
            //MessageBox.Show("data = '" + Convert.ToDateTime(dtpDataNasc.Value) + "'", "Data", MessageBoxButtons.OK, MessageBoxIcon.Question);

            if (txtCPF.Text == "")
            {
                int ID = new Random(DateTime.Now.Millisecond).Next(0, 999999);
                txtCPF.Text = Convert.ToString(ID);
            }
            if (txtCPF.Text != "" && txtCEP.Text != "" && txtComp.Text != "" && txtEnd.Text != "" && txtNome.Text != "" && txtNum.Text != "" && txtTel.Text != "")
            {
                //abrindo conexao
                conexao.Open();


                try
                {
                    //criando comando
                    NpgsqlCommand comando = new NpgsqlCommand();
                    //passando a conexao para o comando
                    comando.Connection = conexao;

                    var id = GridBairro.SelectedCells[0].OwningRow.Cells[0].Value;


                    comando.CommandText = "INSERT INTO cliente VALUES (" + txtCPF.Text + ", '" + txtNome.Text + "', '" + txtTel.Text + "', " +
                                            "'" + txtEnd.Text + "', '" + txtComp.Text + "', '" + txtNum.Text + "', '" + txtCEP.Text + "', " +
                                            " '" + Convert.ToInt32(id) + "');";

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
                    txtCPF.Text = "";
                    txtNome.Text = "";
                    txtTel.Text = "";
                    txtEnd.Text = "";
                    txtComp.Text = "";
                    txtNum.Text = "";
                    txtNum.Text = "";
                    txtCEP.Text = "";
                    dataGridCliente.Rows.Clear();
                    btnAtualizaBairro_Click(null, null);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Erro na inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int conta = dataGridCliente.Rows.Count;
            int contaProduto = GridBairro.Rows.Count;
            if (conta != 0)
            {
                if (contaProduto == 0)
                {
                    btnCadastrar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                }
                else
                {

                    btnCadastrar.Enabled = true;
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Selecione o Produto que deseja alterar!", "Erro na inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (txtCPF.Text != "" && txtCEP.Text != "" && txtComp.Text != "" && txtEnd.Text != "" && txtNome.Text != "" && txtNum.Text != "" && txtTel.Text != "")
            {
                //abrindo conexao
                conexao.Open();


                try
                {
                    //criando comando
                    NpgsqlCommand comando = new NpgsqlCommand();
                    //passando a conexao para o comando
                    comando.Connection = conexao;

                    var id = GridBairro.SelectedCells[0].OwningRow.Cells[0].Value;
                    var cpf = dataGridCliente.SelectedCells[0].OwningRow.Cells[0].Value;

                    //passando o comando sql
                    comando.CommandText = "UPDATE cliente SET cliente_cpf = " + txtCPF.Text + ", cliente_nome ='" + txtNome.Text + "', cliente_telefone = '" + txtTel.Text + "', " +
                                            "cliente_endereco = '" + txtEnd.Text + "', cliente_complemento = '" + txtComp.Text + "', cliente_num_end = '" + txtNum.Text + "', " +
                                            "cliente_cep ='" + txtCEP.Text + "', cliente_id_bairro = '" + Convert.ToInt32(id) + "' " +
                                            " WHERE cliente_cpf = '" + cpf + "';";

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Editado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comando.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexao.Close();
                    txtCPF.Text = "";
                    txtNome.Text = "";
                    txtTel.Text = "";
                    txtEnd.Text = "";
                    txtComp.Text = "";
                    txtNum.Text = "";
                    txtNum.Text = "";
                    txtCEP.Text = "";
                    dataGridCliente.Rows.Clear();
                    GridBairro.Rows.Clear();
                    btnAtualizaBairro_Click(null, null);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Erro na inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int conta = dataGridCliente.Rows.Count;
            int contaProduto = GridBairro.Rows.Count;
            if (conta != 0)
            {
                if (contaProduto == 0)
                {
                    btnCadastrar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                }
                else
                {

                    btnCadastrar.Enabled = true;
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Selecione o Produto que deseja alterar!", "Erro na inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //abrindo conexao
            conexao.Open();
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

            txtCPF.Text = "";
            txtNome.Text = "";
            txtTel.Text = "";
            txtEnd.Text = "";
            txtComp.Text = "";
            txtNum.Text = "";
            txtNum.Text = "";
            txtCEP.Text = "";
            //dataGridCliente.Rows.Clear();
            try
            {
                //criando comando
                NpgsqlCommand comando = new NpgsqlCommand();
                //passando a conexao para o comando
                comando.Connection = conexao;

                var cpf = dataGridCliente.SelectedCells[0].OwningRow.Cells[0].Value;

                //passando o comando sql
                comando.CommandText = "DELETE FROM cliente WHERE cliente_cpf = '" + cpf + "';";

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
                dataGridCliente.Rows.Clear();
                GridBairro.Rows.Clear();
                txtCPF.Text = "";
                txtNome.Text = "";
                txtTel.Text = "";
                txtEnd.Text = "";
                txtComp.Text = "";
                txtNum.Text = "";
                txtNum.Text = "";
                txtCEP.Text = "";
                btnAtualizaBairro_Click(null, null);
            }


        }
        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btnAtualizaBairro_Click(object sender, EventArgs e)
        {
            //abrindo conexao
            conexao.Open();
            GridBairro.Rows.Clear();
            try
            {
                string query = "SELECT * FROM bairro;";


                DataTable dados = new DataTable();

                NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(query, conexao);
                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    GridBairro.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                conexao.Close();
                MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GridBairro.Rows.Clear();
            }
            finally
            {
                conexao.Close();
            }

            int conta = dataGridCliente.Rows.Count;
            int contaProduto = GridBairro.Rows.Count;
            if (conta != 0)
            {
                if (contaProduto == 0)
                {
                    btnCadastrar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                }
                else
                {

                    btnCadastrar.Enabled = true;
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Selecione o Produto que deseja alterar!", "Erro na inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnPesquisar_Click(null, null);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            conexao.Close();
            btnCadastrar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            dataGridCliente.Rows.Clear();
            GridBairro.Rows.Clear();
            txtCPF.Text = "";
            txtNome.Text = "";
            txtTel.Text = "";
            txtEnd.Text = "";
            txtComp.Text = "";
            txtNum.Text = "";
            txtNum.Text = "";
            txtCEP.Text = "";
            //btnAtualizaBairro_Click(null, null);
            this.Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
