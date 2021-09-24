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
using System.Drawing.Printing;

namespace Vendas
{
    public partial class Vendas : Form
    {
        NpgsqlConnection conexao = new NpgsqlConnection("Host=localhost;Database=Top11;Username=postgres;Password=Matematicas2");

        //internal Botao botao = null;

        public int comanda;

        int contaItens = 999999999;
        short laranja = 3000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000;

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
            #region Nova Venda
            try
            {
                contaItens = 0;
                PanelVendas.Visible = true;

                int ID = new Random(DateTime.Now.Millisecond).Next(0, 999999);
                comanda = ID;
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
            btnFechamento.Visible = true;
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


        private void btnFechamento_Click(object sender, EventArgs e)
        {
            try
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
                                                  " pedidos_valor = '" + 0.0 + "', " +
                                                  " pedidos_status = 'ABERTO', " +
                                                  " pedidos_id_form_pgt = '" + 0 + "', " +
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
                            comando.CommandText = "UPDATE pedidos SET pedidos_cpf_cliente_fk = " + SemCpf + "  WHERE pedidos_id = " + comanda + ";";
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

                    btnFechamento.Visible = true;

                    PanelFechamento.Visible = true;
                    PanelVendas.Visible = false;
                    txtFechamento.Text = lblTotal.Text;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao salvar venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
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
            btnFechamento.Visible = false;
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
            btnFechamento.Visible = false;
            btnCancelamento.Visible = false;

            txtCPF.Enabled = false;
            txtProduto.Enabled = false;
            txtQuantidade.Enabled = false;

            cBSemBairro.Enabled = false;
            cBSemCPF.Enabled = false;

            dataGridBairro.Enabled = false;

            PanelFechamento.Visible = false;
            PanelVendas.Visible = false;
            txtDinheiro.Text = "0,0";
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
                if (FormaPag != 0)
                 {
                        btnFechamento.Visible = false;
                        btnCancelamento.Visible = false;
                        btnNovaVenda.Visible = true;
                        btnLimpaTudo_Click(null, null);
                        conexao.Close();
                                   
                }
                else 
                {
                    btnFechamento.Visible = true;
                    btnCancelamento.Visible = true;
                    btnNovaVenda.Visible = false;
                    conexao.Close();
                }
            }
            else
            {
                conexao.Close();
            }
            conexao.Close();
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            Verifica(null, null);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ImprimeComanda()
        {
            #region
            try
            {
                conexao.Open();

                dtPed.Rows.Clear();

                string query = "SELECT pedidos.pedidos_id, card_ped.quant, cardapio.card_nome, pedidos.pedidos_valor, " +
                    " pedidos.pedidos_data, pedidos.pedidos_hora, pedidos.pedidos_status, pedidos.pedidos_troco, " +
                    " bairro.bairro_nome, cliente.cliente_nome,  form_pag.pag_descricao, " +
                    " card_ped.id_card, card_ped.id_ped  FROM pedidos, bairro, cliente, cardapio, form_pag, card_ped " +
                    "  WHERE pedidos.pedidos_id_bairro_fk = bairro.bairro_id AND " +
                    "  pedidos.pedidos_cpf_cliente_fk = cliente.cliente_cpf AND " +
                    "  pedidos.pedidos_id = " + comanda + " AND " +
                    "  card_ped.id_ped = pedidos.pedidos_id AND " +
                    "  card_ped.id_card = cardapio.card_id AND " +
                    "  pedidos.pedidos_id_form_pgt = form_pag.pag_id ;";

                DataTable dados = new DataTable();

                NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(query, conexao);
                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    dtPed.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                conexao.Close();
                MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtPed.Rows.Clear();
            }
            finally
            {
                conexao.Close();

                int contagem = dtPed.Rows.Count;

                if (contagem != 0)
                {
                    produtos();
                    
                }
                else
                {
                   
                }
            }
            #endregion
        }

        public void produtos()
        {
            #region try catch finally

            try
            {
                //abrindo conexao
                conexao.Open();
                //Limpa as linhas...
                dtProdutos.Rows.Clear();
                //var x = dtPed.Rows[0].Cells[0].Value;

                string query = "select c.card_id, cp.quant, c.card_nome, c.card_valor " +
                    " from cardapio as c, card_ped as cp, pedidos as p " +
                    " where c.card_id = cp.id_card AND " +
                    " p.pedidos_id = " + comanda + " AND " +
                    " p.pedidos_id = cp.id_ped ;";

                DataTable dados = new DataTable();

                NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(query, conexao);
                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    dtProdutos.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                conexao.Close();
                MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtProdutos.Rows.Clear();
            }
            finally
            {
                conexao.Close();
                printDocument1.Print();
            }
            #endregion
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            #region coleta de dados comanda
            string nome_ped = Convert.ToString(dtPed.Rows[0].Cells[9].Value);
            string status_ped = Convert.ToString(dtPed.Rows[0].Cells[6].Value);
            int id_pedido = Convert.ToInt32(dtPed.Rows[0].Cells[0].Value);
            Double valor_ped = Convert.ToDouble(dtPed.Rows[0].Cells[3].Value);
            DateTime data_ped = Convert.ToDateTime(dtPed.Rows[0].Cells[4].Value).Date;
            string hora_ped = Convert.ToString(dtPed.Rows[0].Cells[5].Value);
            double troco_ped = Convert.ToDouble(dtPed.Rows[0].Cells[7].Value);
            string bairro_ped = Convert.ToString(dtPed.Rows[0].Cells[8].Value);
            string forma_pag_ped = Convert.ToString(dtPed.Rows[0].Cells[10].Value);
            #endregion

            #region coleta de dados produtos
            int num = dtProdutos.Rows.Count;
            string[] cardapio = new string[num];
            int[] quant = new int[num];
            double[] valor = new double[num];
            int i = 0;
            do
            {
                cardapio[i] = Convert.ToString(dtProdutos.Rows[i].Cells[2].Value);
                MessageBox.Show("Quantidade", Convert.ToString(i), MessageBoxButtons.OK, MessageBoxIcon.Information);
                quant[i] = Convert.ToInt32(dtProdutos.Rows[i].Cells[1].Value);
                valor[i] = Convert.ToDouble(dtProdutos.Rows[i].Cells[3].Value);
                i++;
            } while (i != num);
            #endregion

            #region Fonte e Cor
            Font fonte = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);
            Brush pincel = new SolidBrush(Color.Black);
            #endregion

            #region de point
            int x = printDocument1.DefaultPageSettings.Bounds.X;
            int y = printDocument1.DefaultPageSettings.Bounds.Y;
            int largura = printDocument1.DefaultPageSettings.Bounds.Width;
            int altura = printDocument1.DefaultPageSettings.Bounds.Height;
            #endregion

            #region teste impressão com retangulo
            Rectangle areaId = new Rectangle(x + 50, y + 100, altura - 100, largura - 200);
            Rectangle areaStatus = new Rectangle(x + 50, y + 150, altura - 100, largura - 200);
            Rectangle areaCliente = new Rectangle(x + 50, y + 200, altura - 100, largura - 200);
            Rectangle areaBairro = new Rectangle(x + 50, y + 250, altura - 100, largura - 200);

            int w = 300;
            #endregion

            #region Impressão
            //desenhar o documento para imprimir
            e.Graphics.DrawString("Comanda: " + Convert.ToString(id_pedido), fonte, pincel, areaId);
            e.Graphics.DrawString("Status do pedido: " + status_ped, fonte, pincel, areaStatus);
            e.Graphics.DrawString("Cliente: " + nome_ped, fonte, pincel, areaCliente);
            e.Graphics.DrawString("Bairro de entrega: " + bairro_ped, fonte, pincel, areaBairro);

            int z = 0;

            do
            {
                Rectangle areaQuant = new Rectangle(x + 500, y + w, altura - 100, largura - 200);
                Rectangle areaProd = new Rectangle(x + 50, y + w, altura - 100, largura - 200);
                Rectangle areaPreco = new Rectangle(x + 550, y + w, altura - 100, largura - 200);

                //string passaTudo = cardapio[z] + "------" + Convert.ToString(quant[z]) + "------" + Convert.ToString(valor[z]);

                e.Graphics.DrawString(cardapio[z], fonte, pincel, areaProd);
                e.Graphics.DrawString(Convert.ToString(quant[z]), fonte, pincel, areaQuant);
                e.Graphics.DrawString(Convert.ToString(valor[z]), fonte, pincel, areaPreco);
                w = w + 50;
                z++;
            } while (z != num);


            Rectangle areaPag = new Rectangle(x + 50, y + w + 50, altura - 100, largura - 200);
            Rectangle areaData = new Rectangle(x + 50, y + w + 100, altura - 100, largura - 200);
            Rectangle areaValor = new Rectangle(x + 50, y + w + 150, altura - 100, largura - 200);

            Rectangle areaTroco = new Rectangle(x + 50, y + w + 200, altura - 100, largura - 200);

            string dia = Convert.ToString(data_ped.Day);
            string mes = Convert.ToString(data_ped.Month);
            string ano = Convert.ToString(data_ped.Year);
            //e.Graphics.DrawString(hora_ped, fonte, pincel, areaHora);
            e.Graphics.DrawString("Forma de pagamento: " + forma_pag_ped, fonte, pincel, areaPag);
            e.Graphics.DrawString("Valor: " + Convert.ToString(valor_ped), fonte, pincel, areaValor);
            e.Graphics.DrawString("Troco: " + Convert.ToString(troco_ped), fonte, pincel, areaTroco);
            e.Graphics.DrawString(dia + "/" + mes + "/" + ano + "  " + hora_ped, fonte, pincel, areaData);
            #endregion

            edita();
        }

        private void edita()
        {
            //int ID = Convert.ToInt32(dtPed.Rows[0].Cells[0].Value);
            try
            {
                conexao.Open();
                NpgsqlCommand comando = new NpgsqlCommand();
                comando.Connection = conexao;

                comando.CommandText = "UPDATE pedidos SET pedidos_status = 'SAIU PARA ENTREGA' WHERE pedidos_id = " + comanda + ";";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                conexao.Close();
                MessageBox.Show(ex.Message, "Erro no Banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtPed.Rows.Clear();
            }
            finally
            {
                conexao.Close();

                PanelFechamento.Visible = false;
                PanelVendas.Visible = false;
            }
        }


        private void CANCELAR_finalizacao_Click(object sender, EventArgs e)
        {
            PanelFechamento.Visible = false;
            PanelVendas.Visible = true;
            txtDinheiro.Text = "0,0";
        }

        private void txtDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Calcula(null, null);


                MessageBox.Show("Troco: " + txtTroco.Text + "", "Troco", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Task.Delay(1000);

                btnFinalizar_Cobranca_Click(null, null);
            }
        }

        private void Calcula(object sender, EventArgs e)
        {
            decimal dinheiro, fechamento, total;
            dinheiro = Convert.ToDecimal(txtDinheiro.Text);
            fechamento = Convert.ToDecimal(txtFechamento.Text);
            total = dinheiro - fechamento;
            txtTroco.Text = Convert.ToString(total);
        }

        private void rbDebito_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDebito.Checked)
            {
                txtDinheiro.Visible = false;
                txtTroco.Visible = false;

                lblDinheiro.Visible = false;
                lblTroco.Visible = false;

                btnFinalizar_Cobranca.Visible = true;

                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
            else if (rbCredito.Checked)
            {
                txtDinheiro.Visible = false;
                txtTroco.Visible = false;

                lblDinheiro.Visible = false;
                lblTroco.Visible = false;

                btnFinalizar_Cobranca.Visible = true;

                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
            else if (rbDinheiro.Checked)
            {
                txtDinheiro.Visible = true;
                txtTroco.Visible = true;

                lblDinheiro.Visible = true;
                lblTroco.Visible = true;

                btnFinalizar_Cobranca.Visible = false;
                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
            else if (rbPIX.Checked)
            {
                txtDinheiro.Visible = false;
                txtTroco.Visible = false;

                lblDinheiro.Visible = false;
                lblTroco.Visible = false;

                btnFinalizar_Cobranca.Visible = true;

                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
        }

        private void rbCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDebito.Checked)
            {
                txtDinheiro.Visible = false;
                txtTroco.Visible = false;

                lblDinheiro.Visible = false;
                lblTroco.Visible = false;

                btnFinalizar_Cobranca.Visible = true;

                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
            else if (rbCredito.Checked)
            {
                txtDinheiro.Visible = false;
                txtTroco.Visible = false;

                lblDinheiro.Visible = false;
                lblTroco.Visible = false;

                btnFinalizar_Cobranca.Visible = true;

                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
            else if (rbDinheiro.Checked)
            {
                txtDinheiro.Visible = true;
                txtTroco.Visible = true;

                lblDinheiro.Visible = true;
                lblTroco.Visible = true;

                btnFinalizar_Cobranca.Visible = false;
                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
            else if (rbPIX.Checked)
            {
                txtDinheiro.Visible = false;
                txtTroco.Visible = false;

                lblDinheiro.Visible = false;
                lblTroco.Visible = false;

                btnFinalizar_Cobranca.Visible = true;

                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
        }

        private void rbPIX_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDebito.Checked)
            {
                txtDinheiro.Visible = false;
                txtTroco.Visible = false;

                lblDinheiro.Visible = false;
                lblTroco.Visible = false;

                btnFinalizar_Cobranca.Visible = true;

                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
            else if (rbCredito.Checked)
            {
                txtDinheiro.Visible = false;
                txtTroco.Visible = false;

                lblDinheiro.Visible = false;
                lblTroco.Visible = false;

                btnFinalizar_Cobranca.Visible = true;

                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
            else if (rbDinheiro.Checked)
            {
                txtDinheiro.Visible = true;
                txtTroco.Visible = true;

                lblDinheiro.Visible = true;
                lblTroco.Visible = true;

                btnFinalizar_Cobranca.Visible = false;
                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
            else if (rbPIX.Checked)
            {
                txtDinheiro.Visible = false;
                txtTroco.Visible = false;

                lblDinheiro.Visible = false;
                lblTroco.Visible = false;

                btnFinalizar_Cobranca.Visible = true;

                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
        }

        private void rbDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDebito.Checked)
            {
                txtDinheiro.Visible = false;
                txtTroco.Visible = false;

                lblDinheiro.Visible = false;
                lblTroco.Visible = false;

                btnFinalizar_Cobranca.Visible = true;

                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
            else if (rbCredito.Checked)
            {
                txtDinheiro.Visible = false;
                txtTroco.Visible = false;

                lblDinheiro.Visible = false;
                lblTroco.Visible = false;

                btnFinalizar_Cobranca.Visible = true;

                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
            else if (rbDinheiro.Checked)
            {
                txtDinheiro.Visible = true;
                txtTroco.Visible = true;

                lblDinheiro.Visible = true;
                lblTroco.Visible = true;

                btnFinalizar_Cobranca.Visible = false;
                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
            else if (rbPIX.Checked)
            {
                txtDinheiro.Visible = false;
                txtTroco.Visible = false;

                lblDinheiro.Visible = false;
                lblTroco.Visible = false;

                btnFinalizar_Cobranca.Visible = true;

                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
        }

        private void btnFinalizar_Cobranca_Click(object sender, EventArgs e)
        {
            if (rbDebito.Checked)
            {
                try
                {
                    conexao.Open();
                    NpgsqlCommand comando = new NpgsqlCommand();
                    comando.Connection = conexao;
                    comando.CommandText = "UPDATE pedidos SET pedidos_status = 'ABERTO', pedidos_id_form_pgt = '2' WHERE pedidos_id = " + comanda + ";";
                    comando.ExecuteNonQuery();
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
            else if (rbCredito.Checked)
            {
                try
                {
                    conexao.Open();
                    NpgsqlCommand comando = new NpgsqlCommand();
                    comando.Connection = conexao;
                    comando.CommandText = "UPDATE pedidos SET pedidos_status = 'ABERTO', pedidos_id_form_pgt = '1' WHERE pedidos_id = " + comanda + ";";
                    comando.ExecuteNonQuery();
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
            else if (rbDinheiro.Checked)
            {
                float valor = float.Parse(txtTroco.Text);
                string troco = valor.ToString().Replace(',', '.');

                try
                {
                    conexao.Open();
                    NpgsqlCommand comando = new NpgsqlCommand();
                    comando.Connection = conexao;
                    comando.CommandText = "UPDATE pedidos SET pedidos_status = 'ABERTO', pedidos_troco = '" + troco + "', pedidos_id_form_pgt = '3' WHERE pedidos_id = " + comanda + ";";
                    comando.ExecuteNonQuery();
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
            else if (rbPIX.Checked)
            {
                try
                {
                    conexao.Open();
                    NpgsqlCommand comando = new NpgsqlCommand();
                    comando.Connection = conexao;
                    comando.CommandText = "UPDATE pedidos SET pedidos_status = 'ABERTO', pedidos_id_form_pgt = '4' WHERE pedidos_id = " + comanda + ";";
                    comando.ExecuteNonQuery();
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

            ImprimeComanda();

            PanelFechamento.Visible = false; ;
            PanelVendas.Visible = false;
            txtDinheiro.Text = "0,0";
            btnNovaVenda.Visible = true;
        }
    }
}
