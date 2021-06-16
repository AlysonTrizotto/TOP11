using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace TOP_11_DELIVERY
{
    public partial class Produtos : Form
    {
        NpgsqlConnection conexao = new NpgsqlConnection("Host=localhost;Database=Top11;Username=postgres;Password=Matematicas2");

        public Produtos()
        {
            InitializeComponent();

        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            //abrindo conexao
            conexao.Open();
            //Limpa as linhas...
            DataViewCategoria.Rows.Clear();

            //Limpa as linhas...
            DataViewProduto.Rows.Clear();

            try
            {
                string query = "SELECT * FROM categoria;";


                DataTable dados = new DataTable();

                NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(query, conexao);
                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    DataViewCategoria.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                conexao.Close();
                MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataViewCategoria.Rows.Clear();
            }
            finally
            {
                conexao.Close();
            }

            int conta = DataViewCategoria.Rows.Count;
            if (conta == 0)
            {
                MessageBox.Show("Não foi encontrado nenhuma CATEGORIA. \n Por favor, cadastre a categoria para poder ser liberado o CARDÁPIO!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCadastrar.Enabled = false;
                btnEditar.Enabled = false;
                btnEXCLUIR.Enabled = false;
            }
            else
            {
                btnCadastrar.Enabled = false;
                btnEditar.Enabled = false;
                btnEXCLUIR.Enabled = false;
            }
            conexao.Close();
        }

        private void Produtos_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Menu menu1 = new Menu();
            //menu1.Show();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (rbProduto.Checked)
            {


                //abrindo conexao
                conexao.Open();
                //Limpa as linhas...
                DataViewProduto.Rows.Clear();

                #region try catch finally
                try
                {
                    string query = "SELECT cardapio.card_id, cardapio.card_nome, categoria.categ_descricao," +
                                   " cardapio.card_descricao, cardapio.card_valor FROM cardapio, categoria " +
                                            "WHERE cardapio.categ_id_fk = categoria.categ_id;";

                    if (txtPesquisa.Text != "")
                    {
                        query = "SELECT cardapio.card_id, cardapio.card_nome, categoria.categ_descricao, " +
                                "cardapio.card_descricao, cardapio.card_valor FROM cardapio, categoria " +
                                          "WHERE cardapio.categ_id_fk = categoria.categ_id AND " +
                                            "cardapio.card_nome LIKE '" + txtPesquisa.Text + "%';";
                    }

                    DataTable dados = new DataTable();

                    NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(query, conexao);
                    adaptador.Fill(dados);

                    foreach (DataRow linha in dados.Rows)
                    {
                        DataViewProduto.Rows.Add(linha.ItemArray);
                    }
                }
                catch (Exception ex)
                {
                    conexao.Close();
                    MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataViewProduto.Rows.Clear();
                }
                finally
                {
                    conexao.Close();
                }
                #endregion


                #region conta linhas do grid
                int conta = DataViewProduto.Rows.Count;
                if (conta == 0)
                {
                    MessageBox.Show("Não foi encontrado nenhum registro com a palavra '" + txtPesquisa.Text + "'!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPesquisa.Text = "";
                }
                else
                {
                    MessageBox.Show("Encontramos ' " + Convert.ToString(conta) + " ' com a palavra '" + txtPesquisa.Text + "'!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
                #endregion
            }
            else if (rbCategoria.Checked)
            {

                //abrindo conexao
                conexao.Open();
                //Limpa as linhas...
                DataViewProduto.Rows.Clear();
                #region try catch finally
                try
                {
                    string query = "SELECT cardapio.card_id, cardapio.card_nome, categoria.categ_descricao," +
                                   " cardapio.card_descricao, cardapio.card_valor FROM cardapio, categoria " +
                                            "WHERE cardapio.categ_id_fk = categoria.categ_id;";

                    if (txtPesquisa.Text != "")
                    {
                        query = "SELECT cardapio.card_id, cardapio.card_nome, categoria.categ_descricao, " +
                                "cardapio.card_descricao, cardapio.card_valor FROM cardapio, categoria " +
                                          "WHERE cardapio.categ_id_fk = categoria.categ_id AND " +
                                            "categoria.categ_descricao LIKE '" + txtPesquisa.Text + "%';";
                    }

                    DataTable dados = new DataTable();

                    NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(query, conexao);
                    adaptador.Fill(dados);

                    foreach (DataRow linha in dados.Rows)
                    {
                        DataViewProduto.Rows.Add(linha.ItemArray);
                    }
                }
                catch (Exception ex)
                {
                    conexao.Close();
                    MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataViewProduto.Rows.Clear();
                }
                finally
                {
                    conexao.Close();
                }
                #endregion


                #region conta linhas do grid

                int conta = DataViewProduto.Rows.Count;
                if (conta == 0)
                {
                    MessageBox.Show("Não foi encontrado nenhum registro com a palavra '" + txtPesquisa.Text + "'!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPesquisa.Text = "";
                }
                else
                {
                    MessageBox.Show("Encontramos ' " + Convert.ToString(conta) + " ' com a palavra '" + txtPesquisa.Text + "'!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
                #endregion
            }
            else
            {
                MessageBox.Show("Por favor, selecione a forma de pesquisa!", "Seleção de pesquisa.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text != "")
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

                    var ID_Categ = DataViewCategoria.SelectedCells[0].OwningRow.Cells[0].Value;



                    float preco = float.Parse(txtPreco.Text);
                    string stringValue = preco.ToString().Replace(',', '.');

                    comando.CommandText = @"INSERT INTO cardapio VALUES (" + ID + ", '" + txtProduto.Text + "', '" + rtbDescricao.Text + "', " + stringValue + "," + ID_Categ + ");";


                    NpgsqlParameter param = new NpgsqlParameter();


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
                    txtProduto.Text = "";
                    txtPreco.Text = "";
                    rtbDescricao.Text = "";
                    DataViewProduto.Rows.Clear();
                    btnAtualizaCategoria_Click(null, null);
                }

                int conta = DataViewCategoria.Rows.Count;
                int contaProduto = DataViewProduto.Rows.Count;
                if (conta != 0)
                {
                    if (contaProduto == 0)
                    {
                        btnCadastrar.Enabled = true;
                        btnEditar.Enabled = false;
                        btnEXCLUIR.Enabled = false;
                    }
                    else
                    {

                        btnCadastrar.Enabled = true;
                        btnEditar.Enabled = true;
                        btnEXCLUIR.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Selecione o Produto que deseja alterar!", "Erro na inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Erro na inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataViewCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int conta = DataViewCategoria.Rows.Count;
            int contaProduto = DataViewProduto.Rows.Count;
            if (conta != 0)
            {
                if (contaProduto == 0)
                {
                    btnCadastrar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEXCLUIR.Enabled = false;
                }
                else
                {

                    btnCadastrar.Enabled = true;
                    btnEditar.Enabled = true;
                    btnEXCLUIR.Enabled = true;
                }
            }
            else
            {
                btnCadastrar.Enabled = false;
                btnEditar.Enabled = true;
                btnEXCLUIR.Enabled = true;
                MessageBox.Show("Não encontramos registro de categoria cadastradas no sistema!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {

            #region pego da net
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca por vírgula
                e.KeyChar = ',';

                //verifica se já existe vírgula
                if (txtPreco.Text.Contains(","))
                {
                    e.Handled = true; //caso exista, aborte
                }
            }

            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
            #endregion


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text != "")
            {

                //abrindo conexao
                conexao.Open();


                try
                {
                    //criando comando
                    NpgsqlCommand comando = new NpgsqlCommand();
                    //passando a conexao para o comando
                    comando.Connection = conexao;

                    NpgsqlCommand comando1 = new NpgsqlCommand();

                    //recuperando dados dos grids
                    var ID_Categ = DataViewCategoria.SelectedCells[0].OwningRow.Cells[0].Value;
                    var ID = DataViewProduto.SelectedCells[0].OwningRow.Cells[0].Value;


                    float preco = float.Parse(txtPreco.Text);
                    string stringValue = preco.ToString().Replace(',', '.');

                    comando.CommandText = "UPDATE cardapio SET card_nome = '" + txtProduto.Text + "', " +
                        "card_descricao = '" + rtbDescricao.Text + "', card_valor = " + stringValue + ",  categ_id_fk = " + ID_Categ + " WHERE card_id = " + ID + ";";

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Editado com sucesso!", "Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comando.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexao.Close();
                    txtProduto.Text = "";
                    txtPreco.Text = "";
                    rtbDescricao.Text = "";
                    DataViewProduto.Rows.Clear();
                    btnAtualizaCategoria_Click(null, null);
                }

                int conta = DataViewCategoria.Rows.Count;
                int contaProduto = DataViewProduto.Rows.Count;
                if (conta != 0)
                {
                    if (contaProduto == 0)
                    {
                        btnCadastrar.Enabled = true;
                        btnEditar.Enabled = false;
                        btnEXCLUIR.Enabled = false;
                    }
                    else
                    {

                        btnCadastrar.Enabled = true;
                        btnEditar.Enabled = true;
                        btnEXCLUIR.Enabled = true;
                    }
                }
                else
                {
                    btnCadastrar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEXCLUIR.Enabled = true;
                    MessageBox.Show("Selecione o Produto que deseja alterar!", "Erro na inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos", "Erro na inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataViewProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int conta = DataViewCategoria.Rows.Count;
            int contaProduto = DataViewProduto.Rows.Count;
            if (contaProduto != 0)
            {
                if (conta == 0)
                {
                    btnCadastrar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEXCLUIR.Enabled = false;
                }
                else
                {
                    txtProduto.Text = Convert.ToString(DataViewProduto.SelectedCells[0].OwningRow.Cells[1].Value);
                    txtPreco.Text = Convert.ToString(DataViewProduto.SelectedCells[0].OwningRow.Cells[4].Value);
                    rtbDescricao.Text = Convert.ToString(DataViewProduto.SelectedCells[0].OwningRow.Cells[3].Value);


                    var id = DataViewProduto.SelectedCells[0].OwningRow.Cells[2].Value;
                    var teste = DataViewProduto.SelectedCells[0].OwningRow.Cells[0].Value;
                    conexao.Open();

                    DataViewCategoria.Rows.Clear();

                    try
                    {
                        string query = "SELECT * FROM categoria, cardapio WHERE cardapio.card_id = '" + teste + "'  AND cardapio.categ_id_fk = categoria.categ_id;";


                        DataTable dados = new DataTable();

                        NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(query, conexao);
                        adaptador.Fill(dados);

                        foreach (DataRow linha in dados.Rows)
                        {
                            DataViewCategoria.Rows.Add(linha.ItemArray);
                        }
                    }
                    catch (Exception ex)
                    {
                        conexao.Close();
                        MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DataViewCategoria.Rows.Clear();
                    }
                    finally
                    {
                        conexao.Close();

                    }

                    btnCadastrar.Enabled = true;
                    btnEditar.Enabled = true;
                    btnEXCLUIR.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Não encontramos registros de produtos do seu cardápio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEXCLUIR_Click(object sender, EventArgs e)
        {
            //abrindo conexao
            conexao.Open();


            try
            {
                //criando comando
                NpgsqlCommand comando = new NpgsqlCommand();
                //passando a conexao para o comando
                comando.Connection = conexao;

                NpgsqlCommand comando1 = new NpgsqlCommand();

                //recuperando dados dos grids

                var ID = DataViewProduto.SelectedCells[0].OwningRow.Cells[0].Value;


                comando.CommandText = "DELETE FROM cardapio WHERE card_id = " + Convert.ToInt32(ID) + ";";

                comando.ExecuteNonQuery();

                MessageBox.Show("Excluido com sucesso!", "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
                txtProduto.Text = "";
                txtPreco.Text = "";
                rtbDescricao.Text = "";
                DataViewProduto.Rows.Clear();
                btnAtualizaCategoria_Click(null, null);
            }

            int conta = DataViewCategoria.Rows.Count;
            int contaProduto = DataViewProduto.Rows.Count;
            if (conta != 0)
            {
                if (contaProduto == 0)
                {
                    btnCadastrar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEXCLUIR.Enabled = false;
                }
                else
                {

                    btnCadastrar.Enabled = true;
                    btnEditar.Enabled = true;
                    btnEXCLUIR.Enabled = true;
                }
            }
            else
            {
                btnCadastrar.Enabled = false;
                btnEditar.Enabled = true;
                btnEXCLUIR.Enabled = true;
                MessageBox.Show("Selecione o Produto que deseja alterar!", "Erro na inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            conexao.Close();

            btnCadastrar.Enabled = false;
            btnEditar.Enabled = false;
            btnEXCLUIR.Enabled = false;

            txtPesquisa.Text = "";
            txtProduto.Text = "";
            txtPreco.Text = "";
            rtbDescricao.Text = "";
            DataViewProduto.Rows.Clear();
            DataViewCategoria.Rows.Clear();
            this.Close();
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnPesquisa_Click(null, null);
            }
        }

        private void btnAtualizaCategoria_Click(object sender, EventArgs e)
        {
            //abrindo conexao
            conexao.Open();
            //Limpa as linhas...
            DataViewCategoria.Rows.Clear();

            //Limpa as linhas...
            // DataViewProduto.Rows.Clear();

            try
            {
                string query = "SELECT * FROM categoria;";


                DataTable dados = new DataTable();

                NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(query, conexao);
                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    DataViewCategoria.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                conexao.Close();
                MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataViewCategoria.Rows.Clear();
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}


