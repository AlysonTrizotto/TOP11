using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace TOP_11_DELIVERY
{
    public partial class Form_Pgto : Form
    {
        NpgsqlConnection conexao = new NpgsqlConnection("Host=localhost;Database=Top11;Username=postgres;Password=Matematicas2");
        public Form_Pgto()
        {
            InitializeComponent();
        }

        private void Form_Pgto_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //abrindo conexao
            conexao.Open();
            //Limpa as linhas...
            DataViewForm_pag.Rows.Clear();

            try
            {
                string query = "SELECT * FROM form_pag;";

                if (txtPesquisa.Text != "")
                {
                    query = "SELECT * FROM form_pag WHERE pag_descricao LIKE '" + txtPesquisa.Text + "%';";
                }

                DataTable dados = new DataTable();

                NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(query, conexao);
                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    DataViewForm_pag.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                conexao.Close();
                MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataViewForm_pag.Rows.Clear();
            }
            finally
            {
                conexao.Close();
            }

            int conta = DataViewForm_pag.Rows.Count;
            if (conta == 0)
            {
                MessageBox.Show("Não foi encontrado nenhum registro com a palavra '" + txtPesquisa.Text + "'!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Encontramos ' " + Convert.ToString(conta) + " ' com a palavra '" + txtPesquisa.Text + "'!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
        }

        private void DataViewForm_pag_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var ID = DataViewForm_pag.SelectedCells[0].OwningRow.Cells[0].Value;


            int conta = DataViewForm_pag.Rows.Count;
            if (conta > 0)
            {
                //btnCadastrar.Enabled = false;
                txtDescricao.Text = Convert.ToString(DataViewForm_pag.SelectedCells[0].OwningRow.Cells[1].Value);
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
                    comando.CommandText = "INSERT INTO form_pag VALUES (" + ID + ", '" + desc + "');";

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
                    DataViewForm_pag.Rows.Clear();
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo Descrição!", "Erro na inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    var ID = DataViewForm_pag.SelectedCells[0].OwningRow.Cells[0].Value;



                    //passando o comando sql
                    comando.CommandText = "UPDATE form_pag SET pag_descricao = '" + txtDescricao.Text + "' WHERE pag_id = '" + Convert.ToInt32(ID) + "';";
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
                    DataViewForm_pag.Rows.Clear();

                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
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

            txtDescricao.Text = "";
            try
            {
                //criando comando
                NpgsqlCommand comando = new NpgsqlCommand();
                //passando a conexao para o comando
                comando.Connection = conexao;
                //limpando o label

                //pegando o valor da celula celecionada
                var ID = DataViewForm_pag.SelectedCells[0].OwningRow.Cells[0].Value;



                //passando o comando sql
                comando.CommandText = "DELETE FROM form_pag WHERE pag_id = '" + Convert.ToInt32(ID) + "';";

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
                DataViewForm_pag.Rows.Clear();

                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;

                txtDescricao.Text = "";
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

            conexao.Close();

            txtDescricao.Text = "";
            DataViewForm_pag.Rows.Clear();

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }
    }
}
