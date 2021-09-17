using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Globalization;


namespace Vendas
{
    public partial class Vendas : Form
    {
        NpgsqlConnection conexao = new NpgsqlConnection("Host=localhost;Database=Top11;Username=postgres;Password=Matematicas2");

        //internal Botao botao = null;

        public int comanda;

        int contaItens;

        int dia = DateTime.Now.Day;
        int mes = DateTime.Now.Month;
        int ano = DateTime.Now.Year;


        public decimal preco;

        public Vendas()
        {
            InitializeComponent();
            btnLimpaTudo_Click(null, null);

        }

        private void Vendas_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexao.Close();

            Application.Exit();
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            contaItens = 0;
            #region Nova Venda

            int ID = new Random(DateTime.Now.Millisecond).Next(0, 999999);
            comanda = ID;

            try
            {
                int hora = Convert.ToInt32(DateTime.Now.Hour);
                int minutos = Convert.ToInt32(DateTime.Now.Minute);
                int segundos = Convert.ToInt32(DateTime.Now.Second);
                conexao.Open();


                NpgsqlCommand comando = new NpgsqlCommand();

                comando.Connection = conexao;


                comando.CommandText = "INSERT INTO pedidos VALUES (" + ID + ", " + 0 + " ,'" + 0.0 + "', '" + ano + "-" + mes + "-" + dia + "', '" + hora + ":" + minutos + ":" + segundos + "', 'ABERTO', '" + 0.0 + "', 0, 0, 0);";

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro no cadastro de nova venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();

                btnBuscaItens_Click(null, null);
                btnBuscaBairro_Click(null, null);

                preco = 0;
            }
            #endregion


            btnNovaVenda.Visible = false;
            btnFinaliza.Visible = true;
            btnCancelamento.Visible = true;

            txtCPF.Enabled = true;
            txtProduto.Enabled = true;
            txtQuantidade.Enabled = true;

            dataGridBairro.Enabled = true;

            cBSemBairro.Enabled = true;
            cBSemCPF.Enabled = true;
        }



        private void btnBuscaBairro_Click(object sender, EventArgs e)
        {
            #region bairro
            try
            {
                //abrindo conexao
                conexao.Open();
                dataGridBairro.Rows.Clear();

                string BuscaVendas = "SELECT * FROM bairro;";

                DataTable dadosVendas = new DataTable();

                NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(BuscaVendas, conexao);
                adaptador.Fill(dadosVendas);

                foreach (DataRow linhaVendas in dadosVendas.Rows)
                {
                    dataGridBairro.Rows.Add(linhaVendas.ItemArray);
                }
            }
            catch (Exception exVendas)
            {
                conexao.Close();
                MessageBox.Show(exVendas.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridBairro.Rows.Clear();
            }
            finally
            {
                //MessageBox.Show("chegou ao fim", "Fim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
            }
            #endregion
        }

        private void btnBuscaItens_Click(object sender, EventArgs e)
        {

            #region itens
            //abrindo conexao
            conexao.Open();
            dataGridItens.Rows.Clear();

            try
            {

                string BuscaVendas = "SELECT  cp.id_card_ped, c.card_nome, cp.quant, c.card_valor " +
                    " FROM card_ped as cp, cardapio as c, pedidos as p" +
                    " WHERE cp.id_ped = " + comanda + " AND " +
                    " c.card_id = id_card AND " +
                    " cp.id_ped = p.pedidos_id;";

                DataTable dadosVendas = new DataTable();

                NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(BuscaVendas, conexao);
                adaptador.Fill(dadosVendas);

                foreach (DataRow linhaVendas in dadosVendas.Rows)
                {
                    dataGridItens.Rows.Add(linhaVendas.ItemArray);
                }
            }
            catch (Exception exVendas)
            {
                conexao.Close();
                MessageBox.Show(exVendas.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridItens.Rows.Clear();
            }
            finally
            {
                conexao.Close();


                #region pegando valor do produto
                if (dataGridItens.Rows.Count > 0)
                {
                    decimal ValorUnit = Convert.ToDecimal(dataGridItens.SelectedCells[0].OwningRow.Cells[3].Value);
                    int passaQuantidade = Convert.ToInt32(txtQuantidade.Text);
                    decimal valorTotal = ValorUnit * passaQuantidade;
                    preco = preco + valorTotal;

                    lblTotal.Text = preco.ToString("N3", new CultureInfo("pt-BR"));
                    contaItens = contaItens + passaQuantidade;
                    lblQuantidade.Text = Convert.ToString(contaItens);
                }
                #endregion
            }
            #endregion


        }

        private void btnAdicionaItem_Click(object sender, EventArgs e)
        {
            #region Nova Item
            try
            {
                int pedido = new Random(DateTime.Now.Millisecond).Next(0, 999999);
                conexao.Open();

                NpgsqlCommand comando = new NpgsqlCommand();

                comando.Connection = conexao;


                comando.CommandText = "INSERT INTO card_ped VALUES (" + pedido + ", " + Convert.ToInt32(txtProduto.Text) + ", " + comanda + ", " + Convert.ToInt32(txtQuantidade.Text) + " );";

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com sucesso", "Mensagem de alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro no cadastro de nova venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //MessageBox.Show("Chegou no fim", "Fim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();

                btnBuscaItens_Click(null, null);
            }
            #endregion
        }

        private void txtProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtProduto.Text != "0" && txtQuantidade.Text != "0")
                {
                    btnAdicionaItem_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "Falta de informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                button1_Click(null, null);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int contalinha = dataGridProduto.Rows.Count;
            //abrindo conexao
            conexao.Open();
            dataGridProduto.Rows.Clear();

            try
            {
                int id = Convert.ToInt32(txtProduto.Text);
                string BuscaVendas = "SELECT * FROM  cardapio WHERE card_id = " + id + ";";

                DataTable dadosVendas = new DataTable();

                NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(BuscaVendas, conexao);
                adaptador.Fill(dadosVendas);

                foreach (DataRow linhaVendas in dadosVendas.Rows)
                {
                    dataGridProduto.Rows.Add(linhaVendas.ItemArray);

                }
            }
            catch (Exception exVendas)
            {
                conexao.Close();
                MessageBox.Show(exVendas.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridProduto.Rows.Clear();
            }
            finally
            {

                conexao.Close();
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                if (txtProduto.Text != "" && txtQuantidade.Text != "")
                {
                    btnAdicionaItem_Click(null, null);

                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "Falta de informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                button1_Click(null, null);
            }
        }


        private void btnFinaliza_Click(object sender, EventArgs e)
        {
            
            int bairro = Convert.ToInt32(dataGridBairro.SelectedCells[0].OwningRow.Cells[0].Value);
            double passaPreco = Convert.ToDouble(preco.ToString("N3", new CultureInfo("pt-BR")));

            float valor = float.Parse(lblTotal.Text);
            string stringValue = valor.ToString().Replace(',', '.');

            if (DialogResult.Yes == MessageBox.Show("Deseja finalizar?", "Não será possível retornar a esta página", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (txtCPF.Text != "")
                {
                    try
                    {
                        conexao.Open();
                        NpgsqlCommand comando = new NpgsqlCommand();
                        comando.Connection = conexao;
                        comando.CommandText = " UPDATE pedidos SET pedidos_qtde = " + Convert.ToInt32(lblQuantidade.Text) + ", " +
                                              " pedidos_valor = '" + 0.0 + "', "+
                                              " pedidos_status = 'ABERTO', " +
                                              " pedidos_id_form_pgt = '" + 0 + "', "+
                                              " pedidos_id_bairro_fk = " + bairro + ", " +
                                              " pedidos_cpf_cliente_fk = " + Convert.ToInt32(txtCPF.Text) + ", " +
                                              " WHERE pedidos_id = " + comanda + ";";

                        comando.ExecuteNonQuery();
                        comando.Dispose();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro ao salvar venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
                else
                {
                    try
                    {
                        int SemCpf = 0;
                        conexao.Open();
                        NpgsqlCommand comando = new NpgsqlCommand();
                        comando.Connection = conexao;
                        comando.CommandText = "UPDATE pedidos SET pedidos_cpf_cliente_fk = " + SemCpf+ "  WHERE pedidos_id = " + comanda + ";";
                        comando.ExecuteNonQuery();
                        comando.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro ao salvar venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }


                if (bairro != 0)
                {
                    try
                    {
                        conexao.Open();
                        NpgsqlCommand comando = new NpgsqlCommand();
                        comando.Connection = conexao;
                        comando.CommandText = "UPDATE pedidos SET pedidos_id_bairro_fk = " + bairro + " WHERE pedidos_id = " + comanda + ";";
                        comando.ExecuteNonQuery();
                        comando.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro ao salvar venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }

               
                btnFinaliza.Visible = true;

                Fechamento fechamento = new Fechamento(lblTotal.Text, comanda);
                
                fechamento.Show();
                Verifica(null, null);
            }
        }

        private void btnCancelamento_Click(object sender, EventArgs e)
        {
            #region cancelamento de produtos
            try
            {
                conexao.Open();
                NpgsqlCommand comandoCancelamento = new NpgsqlCommand();
                comandoCancelamento.Connection = conexao;
                comandoCancelamento.CommandText = "DELETE FROM card_ped WHERE id_ped = " + comanda + ";";
                comandoCancelamento.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro no VENDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
            #endregion

            #region cancelamento de pedido
            try
            {
                conexao.Open();
                NpgsqlCommand comando = new NpgsqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "DELETE FROM pedidos WHERE pedidos_id = " + comanda + " ;";
                comando.ExecuteNonQuery();

                MessageBox.Show("Venda Cancelada com sucesso!", "Mensagem de alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro no cancelamento de venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
            #endregion
            btnCancelamento.Visible = false;
            btnFinaliza.Visible = false;
            btnNovaVenda.Visible = true;

            btnLimpaTudo_Click(null, null);
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Tratando Números
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';
                //verifica se já existe vírgula
                if (txtCPF.Text.Contains(","))
                {
                    e.Handled = true; //caso exista, aborte
                    txtCPF.Text.Replace(",", "");
                }
            }

            if (e.KeyChar == 13)
            {
                if (txtProduto.Text != "" && txtQuantidade.Text != "")
                {
                    btnAdicionaItem_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "Falta de informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
            #endregion
        }

        public void btnLimpaTudo_Click(object sender, EventArgs e)
        {

            txtProduto.Text = "";
            txtQuantidade.Text = "0";
            lblQuantidade.Text = "0";
            lblTotal.Text = "0,00";

            btnBuscaBairro_Click(null, null);
            comanda = 0;


            btnNovaVenda.Visible = true;
            btnFinaliza.Visible = false;
            btnCancelamento.Visible = false;

            txtCPF.Enabled = false;
            txtProduto.Enabled = false;
            txtQuantidade.Enabled = false;

            cBSemBairro.Enabled = false;
            cBSemCPF.Enabled = false;

            dataGridBairro.Enabled = false;

        }

        public void Verifica(object sender, EventArgs e)
        {
            #region tratando os dados de pesquisa
            //abrir conexão
            conexao.Open();
            //gereando a comunicação de pesquisa de usuários
            string queryTotal = "SELECT * FROM pedidos WHERE pedidos_id = " + comanda + ";";

            NpgsqlCommand executasql = new NpgsqlCommand(queryTotal, conexao);
            executasql.Parameters.AddWithValue("pedidos_id", comanda);

            NpgsqlDataReader dados = executasql.ExecuteReader();

            #endregion

            if (dados.Read()) //verificando se foi encontrado um registro com esta conta
            {
                int FormaPag = Convert.ToInt32(dados.GetString(8));
                if (FormaPag == 0)
                {
                    btnFinaliza.Visible = true;
                    btnCancelamento.Visible = true;
                    btnNovaVenda.Visible = false;
                    conexao.Close();                    
                }
                else 
                {
                    btnFinaliza.Visible = false;
                    btnCancelamento.Visible = false;
                    btnNovaVenda.Visible = true;
                    btnLimpaTudo_Click(null, null);
                    conexao.Close();
                }
            }
            else
            {
                MessageBox.Show("Houve um erro ao buscar a venda.", "Erro na coleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }

        private void Vendas_Load(object sender, EventArgs e)
        {
            Verifica(null, null);
        }
    }
}
