using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace TOP_11_DELIVERY
{
    public partial class Categoria : Form
    {
        NpgsqlConnection conexao = new NpgsqlConnection("Host=localhost;Database=Top11;Username=postgres;Password=Matematicas2");
        public Categoria()
        {
            InitializeComponent();
        }

        private void Categoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Menu menu1 = new Menu();
            //menu1.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //abrindo conexao
            conexao.Open();
            //Limpa as linhas...
            DataViewCategoria.Rows.Clear();

            try
            {
                string query = "SELECT * FROM categoria;";

                if (txtPesquisa.Text != "")
                {
                    query = "SELECT * FROM categoria WHERE categ_descricao LIKE '" + txtPesquisa.Text + "%';";
                }

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
                MessageBox.Show("Não foi encontrado nenhum registro com a palavra '" + txtPesquisa.Text + "'!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Encontramos ' " + Convert.ToString(conta) + " ' com a palavra '" + txtPesquisa.Text + "'!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text != "")
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
                    string desc = txtDescricao.Text;
                    comando.CommandText = "INSERT INTO categoria VALUES (" + ID + ", '" + desc + "');";

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
                    txtDescricao.Text = "";
                    DataViewCategoria.Rows.Clear();
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo Descrição!", "Erro na inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

            conexao.Close();

            txtDescricao.Text = "";
            DataViewCategoria.Rows.Clear();

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //abrindo conexao
            conexao.Open();
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

            txtDescricao.Text = "";
            try
            {
                //criando comando
                NpgsqlCommand comando = new NpgsqlCommand();
                //passando a conexao para o comando
                comando.Connection = conexao;
                //limpando o label

                //pegando o valor da celula celecionada
                var ID = DataViewCategoria.SelectedCells[0].OwningRow.Cells[0].Value;



                //passando o comando sql
                comando.CommandText = "DELETE FROM categoria WHERE categ_id = '" + Convert.ToInt32(ID) + "';";

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
                DataViewCategoria.Rows.Clear();

                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;

                txtDescricao.Text = "";
            }
        }

        private void DataViewCategoria_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (txtDescricao.Text != "")
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
                    var ID = DataViewCategoria.SelectedCells[0].OwningRow.Cells[0].Value;



                    //passando o comando sql
                    comando.CommandText = "UPDATE categoria SET categ_descricao = '" + txtDescricao.Text + "' WHERE categ_id = '" + Convert.ToInt32(ID) + "';";
                    //"UPDATE tempo SET tempo = '" + nome + "' WHERE id = '1';"
                    //executando a query
                    comando.ExecuteNonQuery();

                    //mostrando resultado
                    MessageBox.Show("Editado com sucesso!", "Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comando.Dispose();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescricao.Text = "";
                }
                finally
                {
                    conexao.Close();
                    txtDescricao.Text = "";
                    DataViewCategoria.Rows.Clear();

                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Preencha o Campo descrição!", "Erro de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnPesquisar_Click(null, null);
            }
        }

        private void DataViewCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var ID = DataViewCategoria.SelectedCells[0].OwningRow.Cells[0].Value;


            int conta = DataViewCategoria.Rows.Count;
            if (conta > 0)
            {
                //btnCadastrar.Enabled = false;

                txtDescricao.Text = Convert.ToString(DataViewCategoria.SelectedCells[0].OwningRow.Cells[1].Value);
                //txtNome.Text = Convert.ToString(DataViewCategoria.SelectedCells[0].OwningRow.Cells[1].Value);

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
