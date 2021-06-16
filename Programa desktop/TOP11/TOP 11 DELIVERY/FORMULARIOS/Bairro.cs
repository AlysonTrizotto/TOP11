using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace TOP_11_DELIVERY
{
    public partial class Bairro : Form
    {
        NpgsqlConnection conexao = new NpgsqlConnection("Host=localhost;Database=Top11;Username=postgres;Password=Matematicas2");

        public Bairro()
        {
            InitializeComponent();
        }

        private void Bairro_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Menu menu1 = new Menu();
            //menu1.Show();


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtBairro.Text != "")
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
                    int taxa = (int)Preco.Value;

                    comando.CommandText = "INSERT INTO bairro VALUES (" + ID + ", '" + txtBairro.Text + "', " + taxa + ", '" + Convert.ToString(cbCidade.SelectedItem) + "');";

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
                    txtBairro.Text = "";
                    cbCidade.SelectedIndex = 1;
                    dataGridBairro.Rows.Clear();
                }

            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Erro na inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtBairro.Text != "")
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
                    var ID = dataGridBairro.SelectedCells[0].OwningRow.Cells[0].Value;
                    int taxa = (int)Preco.Value;


                    //passando o comando sql
                    comando.CommandText = "UPDATE bairro SET  bairro_nome = '" + txtBairro.Text + "', bairro_taxa = " + taxa + ", bairro_cidade = '" + Convert.ToString(cbCidade.SelectedItem) + "' WHERE bairro_id = " + Convert.ToInt32(ID) + ";";

                    //executando a query
                    comando.ExecuteNonQuery();

                    //mostrando resultado
                    MessageBox.Show("Editado com sucesso!", "Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comando.Dispose();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtBairro.Text = "";
                    cbCidade.SelectedIndex = 1;
                }
                finally
                {
                    conexao.Close();

                    dataGridBairro.Rows.Clear();
                    txtBairro.Text = "";

                    cbCidade.SelectedIndex = 1;

                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                }

            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Erro de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //abrindo conexao
            conexao.Open();
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

            txtBairro.Text = "";
            cbCidade.SelectedIndex = 1;
            try
            {
                //criando comando
                NpgsqlCommand comando = new NpgsqlCommand();
                //passando a conexao para o comando
                comando.Connection = conexao;
                //limpando o label

                //pegando o valor da celula celecionada
                var ID = dataGridBairro.SelectedCells[0].OwningRow.Cells[0].Value;



                //passando o comando sql
                comando.CommandText = "DELETE FROM bairro WHERE bairro_id = '" + Convert.ToInt32(ID) + "';";

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
                dataGridBairro.Rows.Clear();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

            conexao.Close();

            txtBairro.Text = "";
            cbCidade.SelectedIndex = 1;
            dataGridBairro.Rows.Clear();
            txtPesquisa.Text = "";

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void Bairro_Load(object sender, EventArgs e)
        {
            cbCidade.SelectedIndex = 1;

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //abrindo conexao
            conexao.Open();
            //Limpa as linhas...
            dataGridBairro.Rows.Clear();

            try
            {
                string query = "SELECT * FROM bairro";

                if (txtPesquisa.Text != "")
                {
                    query = "SELECT * FROM bairro WHERE bairro_nome LIKE '" + txtPesquisa.Text + "%';";
                }

                DataTable dados = new DataTable();

                NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(query, conexao);
                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    dataGridBairro.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                conexao.Close();
                MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridBairro.Rows.Clear();
            }
            finally
            {
                conexao.Close();
            }

            int conta = dataGridBairro.Rows.Count;
            if (conta == 0)
            {
                MessageBox.Show("Não foi encontrado nenhum registro com a palavra '" + txtPesquisa.Text + "'!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Encontramos ' " + Convert.ToString(conta) + " ' com a palavra '" + txtPesquisa.Text + "'!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
        }

        private void DataViewBairro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // var ID = dataGridBairro.SelectedCells[0].OwningRow.Cells[0].Value;


            int conta = dataGridBairro.Rows.Count;
            if (conta > 0)
            {
                //btnCadastrar.Enabled = false;
                txtBairro.Text = Convert.ToString(dataGridBairro.SelectedCells[0].OwningRow.Cells[1].Value);
                Preco.Value = Convert.ToInt32(dataGridBairro.SelectedCells[0].OwningRow.Cells[2].Value);
                //cbCidade.SelectedIndex = Convert.ToInt32(dataGridBairro.SelectedCells[0].OwningRow.Cells[2].Value);
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

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnPesquisar_Click(null, null);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
