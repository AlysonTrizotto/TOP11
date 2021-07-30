using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;



namespace TOP_11_DELIVERY
{
    public partial class Pedidos : Form
    {
        NpgsqlConnection conexao = new NpgsqlConnection("Host=localhost;Database=Top11;Username=postgres;Password=Matematicas2");
        string consulta = "";
        public Pedidos()
        {
            InitializeComponent();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            lblInformaData.Visible = false;
        }



        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            conexao.Open();
            conexao.ReloadTypes();
            conexao.Close();

            if (rbAberto.Checked)
            {

                txtPesquisa.Enabled = false;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;

                lblDataFinal.Visible = false;
                lblDataIni.Visible = false;
                lblPesquisa.Visible = true;
                //abrindo conexao
                conexao.Open();
                //Limpa as linhas...
                DataViewPedidos.Rows.Clear();

                #region try catch finally
                try
                {
                    string query = " SELECT pedidos.pedidos_id, card_ped.quant, cardapio.card_nome, pedidos.pedidos_valor, " +
                        " pedidos.pedidos_data, pedidos.pedidos_hora, pedidos.pedidos_status, pedidos.pedidos_troco, " +
                        " bairro.bairro_nome, cliente.cliente_nome,  form_pag.pag_descricao, " +
                        " card_ped.id_card, card_ped.id_ped  FROM pedidos, bairro, cliente, cardapio, form_pag, card_ped " +
                        "  WHERE pedidos.pedidos_id_bairro_fk = bairro.bairro_id AND " +
                        "  pedidos.pedidos_cpf_cliente_fk = cliente.cliente_cpf AND " +
                        "  card_ped.id_ped = pedidos.pedidos_id AND " +
                        "  card_ped.id_card = cardapio.card_id AND " +
                        "  pedidos.pedidos_id_form_pgt = form_pag.pag_id AND " +
                                            " pedidos.pedidos_status LIKE 'ABERTO';";

                    txtPesquisa.Enabled = false;

                    DataTable dados = new DataTable();

                    NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(query, conexao);
                    adaptador.Fill(dados);

                    foreach (DataRow linha in dados.Rows)
                    {
                        DataViewPedidos.Rows.Add(linha.ItemArray);
                    }
                }
                catch (Exception ex)
                {
                    conexao.Close();
                    MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataViewPedidos.Rows.Clear();
                }
                finally
                {
                    conexao.Close();
                }
                #endregion


                #region conta linhas do grid
                int conta = DataViewPedidos.Rows.Count;
                if (conta == 0)
                {
                    MessageBox.Show("Não foi encontrado nenhum registro em aberto!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPesquisa.Text = "";
                }
                else
                {
                    MessageBox.Show("Encontramos ' " + Convert.ToString(conta) + " ' registros em aberto!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
                #endregion
            }
            else if (rbEmEntrega.Checked)
            {
                txtPesquisa.Enabled = false;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;

                lblDataFinal.Visible = false;
                lblDataIni.Visible = false;
                lblPesquisa.Visible = true;
                //abrindo conexao
                conexao.Open();
                //Limpa as linhas...
                DataViewPedidos.Rows.Clear();
                #region try catch finally
                try
                {
                    string query = " SELECT pedidos.pedidos_id, card_ped.quant, cardapio.card_nome, pedidos.pedidos_valor, " +
                        " pedidos.pedidos_data, pedidos.pedidos_hora, pedidos.pedidos_status, pedidos.pedidos_troco, " +
                        " bairro.bairro_nome, cliente.cliente_nome,  form_pag.pag_descricao, " +
                        " card_ped.id_card, card_ped.id_ped  FROM pedidos, bairro, cliente, cardapio, form_pag, card_ped " +
                        "  WHERE pedidos.pedidos_id_bairro_fk = bairro.bairro_id AND " +
                        "  pedidos.pedidos_cpf_cliente_fk = cliente.cliente_cpf AND " +
                        "  card_ped.id_ped = pedidos.pedidos_id AND " +
                        "  card_ped.id_card = cardapio.card_id AND " +
                        "  pedidos.pedidos_id_form_pgt = form_pag.pag_id AND " +
                                             " pedidos.pedidos_status LIKE 'SAIU PARA ENTREGA';";



                    DataTable dados = new DataTable();

                    NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(query, conexao);
                    adaptador.Fill(dados);

                    foreach (DataRow linha in dados.Rows)
                    {
                        DataViewPedidos.Rows.Add(linha.ItemArray);
                    }
                }
                catch (Exception ex)
                {
                    conexao.Close();
                    MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataViewPedidos.Rows.Clear();
                }
                finally
                {
                    conexao.Close();
                }
                #endregion


                #region conta linhas do grid

                int conta = DataViewPedidos.Rows.Count;
                if (conta == 0)
                {
                    MessageBox.Show("Não foi encontrado nenhum registro em entrega!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPesquisa.Text = "";
                }
                else
                {
                    MessageBox.Show("Encontramos ' " + Convert.ToString(conta) + " ' registros em entrega !", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
                #endregion
            }
            else if (rbFechado.Checked)
            {
                txtPesquisa.Enabled = false;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;

                lblDataFinal.Visible = false;
                lblDataIni.Visible = false;
                lblPesquisa.Visible = true;
                //abrindo conexao
                conexao.Open();
                //Limpa as linhas...
                DataViewPedidos.Rows.Clear();
                #region try catch finally
                try
                {
                    string query = " SELECT pedidos.pedidos_id, card_ped.quant, cardapio.card_nome, pedidos.pedidos_valor, " +
                        " pedidos.pedidos_data, pedidos.pedidos_hora, pedidos.pedidos_status, pedidos.pedidos_troco, " +
                        " bairro.bairro_nome, cliente.cliente_nome,  form_pag.pag_descricao, " +
                        " card_ped.id_card, card_ped.id_ped  FROM pedidos, bairro, cliente, cardapio, form_pag, card_ped " +
                        "  WHERE pedidos.pedidos_id_bairro_fk = bairro.bairro_id AND " +
                        "  pedidos.pedidos_cpf_cliente_fk = cliente.cliente_cpf AND " +
                        "  card_ped.id_ped = pedidos.pedidos_id AND " +
                        "  card_ped.id_card = cardapio.card_id AND " +
                        "  pedidos.pedidos_id_form_pgt = form_pag.pag_id AND " +
                                      " pedidos.pedidos_status LIKE 'FECHADO';";



                    DataTable dados = new DataTable();

                    NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(query, conexao);
                    adaptador.Fill(dados);

                    foreach (DataRow linha in dados.Rows)
                    {
                        DataViewPedidos.Rows.Add(linha.ItemArray);
                    }
                }
                catch (Exception ex)
                {
                    conexao.Close();
                    MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataViewPedidos.Rows.Clear();
                }
                finally
                {
                    conexao.Close();
                }
                #endregion


                #region conta linhas do grid

                int conta = DataViewPedidos.Rows.Count;
                if (conta == 0)
                {
                    MessageBox.Show("Não foi encontrado nenhum registro fechado!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPesquisa.Text = "";
                }
                else
                {
                    MessageBox.Show("Encontramos ' " + Convert.ToString(conta) + " ' registros fehcados!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
            }
            #endregion
            else if (rbCliente.Checked)
            {
                txtPesquisa.Enabled = true;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;

                lblDataFinal.Visible = false;
                lblDataIni.Visible = false;
                lblPesquisa.Visible = true;
                //abrindo conexao
                conexao.Open();
                //Limpa as linhas...
                DataViewPedidos.Rows.Clear();
                #region try catch finally
                try
                {
                    string query = " SELECT pedidos.pedidos_id, card_ped.quant, cardapio.card_nome,pedidos.pedidos_valor, " +
                        " pedidos.pedidos_data, pedidos.pedidos_hora, pedidos.pedidos_status, pedidos.pedidos_troco, " +
                        " bairro.bairro_nome, cliente.cliente_nome,  form_pag.pag_descricao, " +
                        " card_ped.id_card, card_ped.id_ped  FROM pedidos, bairro, cliente, cardapio, form_pag, card_ped " +
                        "  WHERE pedidos.pedidos_id_bairro_fk = bairro.bairro_id AND " +
                        "  pedidos.pedidos_cpf_cliente_fk = cliente.cliente_cpf AND " +
                        "  card_ped.id_ped = pedidos.pedidos_id AND " +
                        "  card_ped.id_card = cardapio.card_id AND " +
                        "  pedidos.pedidos_id_form_pgt = form_pag.pag_id AND " +
                        "  cliente.cliente_nome LIKE '" + txtPesquisa.Text + "';";



                    DataTable dados = new DataTable();

                    NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(query, conexao);
                    adaptador.Fill(dados);

                    foreach (DataRow linha in dados.Rows)
                    {
                        DataViewPedidos.Rows.Add(linha.ItemArray);
                    }
                }
                catch (Exception ex)
                {
                    conexao.Close();
                    MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataViewPedidos.Rows.Clear();
                }
                finally
                {
                    conexao.Close();
                }
                #endregion


                #region conta linhas do grid

                int conta = DataViewPedidos.Rows.Count;
                if (conta == 0)
                {
                    MessageBox.Show("Não foi encontrado nenhum registro '" + txtPesquisa.Text + "'!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPesquisa.Text = "";
                }
                else
                {
                    MessageBox.Show("Encontramos ' " + Convert.ToString(conta) + " ' registros '" + txtPesquisa.Text + "'!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
                #endregion
            }
            else if (rbData.Checked)
            {
                if (dtpInicial.Value.Date < dtpFinal.Value.Date)
                {
                    // lblInformaData.Text = Convert.ToDateTime(dtpInicial.Value.Date).ToShortDateString();


                    txtPesquisa.Enabled = false;
                    dtpInicial.Visible = true;
                    dtpFinal.Visible = true;

                    lblDataFinal.Visible = true;
                    lblDataIni.Visible = true;
                    lblPesquisa.Visible = false;
                    //abrindo conexao
                    //conexao.Open();
                    //Limpa as linhas...
                    DataViewPedidos.Rows.Clear();
                    #region try catch finally

                    try
                    {
                        conexao.Open();
                        //DateTime datainicial = dtpInicial.Value.Date;
                        // DateTime dataFinal = dtpInicial.Value.Date;
                        string query = " SELECT pedidos.pedidos_id, card_ped.quant, cardapio.card_nome, pedidos.pedidos_valor, " +
                            " pedidos.pedidos_data, pedidos.pedidos_hora, pedidos.pedidos_status, pedidos.pedidos_troco, " +
                            " bairro.bairro_nome, cliente.cliente_nome, form_pag.pag_descricao, " +
                            " card_ped.id_card, card_ped.id_ped  FROM pedidos, bairro, cliente, cardapio, form_pag, card_ped " +
                            "  WHERE pedidos.pedidos_id_bairro_fk = bairro.bairro_id AND " +
                            "  pedidos.pedidos_cpf_cliente_fk = cliente.cliente_cpf AND " +
                            "  card_ped.id_ped = pedidos.pedidos_id AND " +
                            "  card_ped.id_card = cardapio.card_id AND " +
                            "  pedidos.pedidos_id_form_pgt = form_pag.pag_id AND " +
                        " pedidos.pedidos_data BETWEEN  '" + Convert.ToDateTime(dtpInicial.Value.Date).ToShortDateString() +
                        "' AND '" + Convert.ToDateTime(dtpFinal.Value.Date).ToShortDateString() + "'" +
                        " ORDER BY pedidos.pedidos_hora;";



                        DataTable dados = new DataTable();

                        NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(query, conexao);
                        adaptador.Fill(dados);

                        foreach (DataRow linha in dados.Rows)
                        {
                            DataViewPedidos.Rows.Add(linha.ItemArray);
                        }
                    }
                    catch (Exception ex)
                    {
                        conexao.Close();
                        MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DataViewPedidos.Rows.Clear();
                    }
                    finally
                    {
                        conexao.Close();
                    }
                    #endregion


                    #region conta linhas do grid

                    int conta = DataViewPedidos.Rows.Count;
                    if (conta == 0)
                    {
                        MessageBox.Show("Não foi encontrado nenhum registro entre '" + Convert.ToDateTime(dtpInicial.Value.Date).ToShortDateString() + "' e '" + Convert.ToDateTime(dtpFinal.Value.Date).ToShortDateString() + "'!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPesquisa.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Encontramos ' " + Convert.ToString(conta) + " ' registros entre '" + Convert.ToDateTime(dtpInicial.Value.Date).ToShortDateString() + "' e '" + Convert.ToDateTime(dtpFinal.Value.Date).ToShortDateString() + "'!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    #endregion

                }
                else
                {
                    MessageBox.Show("A data final não pode ser menor que a dana inicial!", "Erro de pesquisa!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtpInicial.Focus();
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione um modelo de pesquisa!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbPesquisar_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Menu menu1 = new Menu();
            //menu1.Show();
            conexao.Close();

            txtPesquisa.Enabled = false;
            dtpInicial.Visible = false;
            dtpFinal.Visible = false;
            txtPesquisa.Visible = true;

            lblDataFinal.Visible = false;
            lblDataIni.Visible = false;
            lblPesquisa.Visible = false;
        }

        private void rbAberto_Click(object sender, EventArgs e)
        {
            if (rbAberto.Checked)
            {

                txtPesquisa.Enabled = false;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;

                lblDataFinal.Visible = false;
                lblDataIni.Visible = false;
                lblPesquisa.Visible = true;
                txtPesquisa.Visible = true;

                rbSaida.Enabled = true;
                rbFechamento.Enabled = true;
                btnSalvar.Enabled = true;

                DataViewPedidos.Rows.Clear();
                lblInformaData.Visible = false;
            }
            else if (rbEmEntrega.Checked)
            {
                txtPesquisa.Enabled = false;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;
                txtPesquisa.Visible = true;

                lblDataFinal.Visible = false;
                lblDataIni.Visible = false;
                lblPesquisa.Visible = true;

                rbSaida.Enabled = true;
                rbFechamento.Enabled = true;
                btnSalvar.Enabled = true;

                DataViewPedidos.Rows.Clear();
                lblInformaData.Visible = false;
            }
            else if (rbFechado.Checked)
            {
                txtPesquisa.Enabled = false;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;
                txtPesquisa.Visible = true;

                lblDataFinal.Visible = false;
                lblDataIni.Visible = false;
                lblPesquisa.Visible = true;

                rbSaida.Enabled = false;
                rbFechamento.Enabled = false;
                btnSalvar.Enabled = false;

                DataViewPedidos.Rows.Clear();
                lblInformaData.Visible = false;
            }

            else if (rbCliente.Checked)
            {
                txtPesquisa.Visible = true;
                txtPesquisa.Enabled = true;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;

                lblDataFinal.Visible = false;
                lblDataIni.Visible = false;
                lblPesquisa.Visible = true;

                rbSaida.Enabled = true;
                rbFechamento.Enabled = true;
                btnSalvar.Enabled = true;

                DataViewPedidos.Rows.Clear();
                lblInformaData.Visible = false;
            }
            else if (rbData.Checked)
            {
                txtPesquisa.Visible = false;
                dtpInicial.Visible = true;
                dtpFinal.Visible = true;

                lblDataFinal.Visible = true;
                lblDataIni.Visible = true;
                lblPesquisa.Visible = false;

                rbSaida.Enabled = true;
                rbFechamento.Enabled = true;
                btnSalvar.Enabled = true;

                DataViewPedidos.Rows.Clear();
                lblInformaData.Visible = true;
            }
        }

        private void rbEmEntrega_Click(object sender, EventArgs e)
        {
            if (rbAberto.Checked)
            {

                txtPesquisa.Enabled = false;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;

                lblDataFinal.Visible = false;
                lblDataIni.Visible = false;
                lblPesquisa.Visible = true;
                txtPesquisa.Visible = true;

                rbSaida.Enabled = true;
                rbFechamento.Enabled = true;
                btnSalvar.Enabled = true;

                DataViewPedidos.Rows.Clear();
                lblInformaData.Visible = false;
            }
            else if (rbEmEntrega.Checked)
            {
                txtPesquisa.Enabled = false;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;
                txtPesquisa.Visible = true;

                lblDataFinal.Visible = false;
                lblDataIni.Visible = false;
                lblPesquisa.Visible = true;

                rbSaida.Enabled = true;
                rbFechamento.Enabled = true;
                btnSalvar.Enabled = true;

                DataViewPedidos.Rows.Clear();
                lblInformaData.Visible = false;
            }
            else if (rbFechado.Checked)
            {
                txtPesquisa.Enabled = false;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;
                txtPesquisa.Visible = true;

                lblDataFinal.Visible = false;
                lblDataIni.Visible = false;
                lblPesquisa.Visible = true;

                rbSaida.Enabled = false;
                rbFechamento.Enabled = false;
                btnSalvar.Enabled = false;

                DataViewPedidos.Rows.Clear();
                lblInformaData.Visible = false;
            }

            else if (rbCliente.Checked)
            {
                txtPesquisa.Visible = true;
                txtPesquisa.Enabled = true;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;

                lblDataFinal.Visible = false;
                lblDataIni.Visible = false;
                lblPesquisa.Visible = true;

                rbSaida.Enabled = true;
                rbFechamento.Enabled = true;
                btnSalvar.Enabled = true;

                DataViewPedidos.Rows.Clear();
                lblInformaData.Visible = false;
            }
            else if (rbData.Checked)
            {
                txtPesquisa.Visible = false;
                dtpInicial.Visible = true;
                dtpFinal.Visible = true;

                lblDataFinal.Visible = true;
                lblDataIni.Visible = true;
                lblPesquisa.Visible = false;

                rbSaida.Enabled = true;
                rbFechamento.Enabled = true;
                btnSalvar.Enabled = true;

                DataViewPedidos.Rows.Clear();
                lblInformaData.Visible = true;
            }
        }

        private void rbFechado_Click(object sender, EventArgs e)
        {
            if (rbAberto.Checked)
            {

                txtPesquisa.Enabled = false;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;

                lblDataFinal.Visible = false;
                lblDataIni.Visible = false;
                lblPesquisa.Visible = true;
                txtPesquisa.Visible = true;

                rbSaida.Enabled = true;
                rbFechamento.Enabled = true;
                btnSalvar.Enabled = true;

                DataViewPedidos.Rows.Clear();
                lblInformaData.Visible = false;
            }
            else if (rbEmEntrega.Checked)
            {
                txtPesquisa.Enabled = false;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;
                txtPesquisa.Visible = true;

                lblDataFinal.Visible = false;
                lblDataIni.Visible = false;
                lblPesquisa.Visible = true;

                rbSaida.Enabled = true;
                rbFechamento.Enabled = true;
                btnSalvar.Enabled = true;

                DataViewPedidos.Rows.Clear();
                lblInformaData.Visible = false;
            }
            else if (rbFechado.Checked)
            {
                txtPesquisa.Enabled = false;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;
                txtPesquisa.Visible = true;

                lblDataFinal.Visible = false;
                lblDataIni.Visible = false;
                lblPesquisa.Visible = true;

                rbSaida.Enabled = false;
                rbFechamento.Enabled = false;
                btnSalvar.Enabled = false;

                lblInformaData.Visible = false;

                DataViewPedidos.Rows.Clear();
            }

            else if (rbCliente.Checked)
            {
                txtPesquisa.Visible = true;
                txtPesquisa.Enabled = true;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;

                lblDataFinal.Visible = false;
                lblDataIni.Visible = false;
                lblPesquisa.Visible = true;

                rbSaida.Enabled = true;
                rbFechamento.Enabled = true;
                btnSalvar.Enabled = true;

                DataViewPedidos.Rows.Clear();
                lblInformaData.Visible = false;
            }
            else if (rbData.Checked)
            {
                txtPesquisa.Visible = false;
                dtpInicial.Visible = true;
                dtpFinal.Visible = true;

                lblDataFinal.Visible = true;
                lblDataIni.Visible = true;
                lblPesquisa.Visible = false;

                rbSaida.Enabled = true;
                rbFechamento.Enabled = true;
                btnSalvar.Enabled = true;

                DataViewPedidos.Rows.Clear();
                lblInformaData.Visible = true;
            }
        }

        private void rbCliente_Click(object sender, EventArgs e)
        {
            if (rbAberto.Checked)
            {

                txtPesquisa.Enabled = false;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;

                lblDataFinal.Visible = false;
                lblDataIni.Visible = false;
                lblPesquisa.Visible = true;
                txtPesquisa.Visible = true;

                rbSaida.Enabled = true;
                rbFechamento.Enabled = true;
                btnSalvar.Enabled = true;

                DataViewPedidos.Rows.Clear();
                lblInformaData.Visible = false;
            }
            else if (rbEmEntrega.Checked)
            {
                txtPesquisa.Enabled = false;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;
                txtPesquisa.Visible = true;

                lblDataFinal.Visible = false;
                lblDataIni.Visible = false;
                lblPesquisa.Visible = true;

                rbSaida.Enabled = true;
                rbFechamento.Enabled = true;
                btnSalvar.Enabled = true;

                DataViewPedidos.Rows.Clear();
                lblInformaData.Visible = false;
            }
            else if (rbFechado.Checked)
            {
                txtPesquisa.Enabled = false;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;
                txtPesquisa.Visible = true;

                lblDataFinal.Visible = false;
                lblDataIni.Visible = false;
                lblPesquisa.Visible = true;

                rbSaida.Enabled = false;
                rbFechamento.Enabled = false;
                btnSalvar.Enabled = false;

                DataViewPedidos.Rows.Clear();
                lblInformaData.Visible = false;
            }

            else if (rbCliente.Checked)
            {
                txtPesquisa.Visible = true;
                txtPesquisa.Enabled = true;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;

                lblDataFinal.Visible = false;
                lblDataIni.Visible = false;
                lblPesquisa.Visible = true;

                rbSaida.Enabled = true;
                rbFechamento.Enabled = true;
                btnSalvar.Enabled = true;

                DataViewPedidos.Rows.Clear();
                lblInformaData.Visible = false;
            }
            else if (rbData.Checked)
            {
                txtPesquisa.Visible = false;
                dtpInicial.Visible = true;
                dtpFinal.Visible = true;

                lblDataFinal.Visible = true;
                lblDataIni.Visible = true;
                lblPesquisa.Visible = false;

                rbSaida.Enabled = true;
                rbFechamento.Enabled = true;
                btnSalvar.Enabled = true;

                DataViewPedidos.Rows.Clear();
                lblInformaData.Visible = true;
            }
        }

        private void rbData_Click(object sender, EventArgs e)
        {
            if (rbAberto.Checked)
            {

                txtPesquisa.Enabled = false;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;

                lblDataFinal.Visible = false;
                lblDataIni.Visible = false;
                lblPesquisa.Visible = true;
                txtPesquisa.Visible = true;

                rbSaida.Enabled = true;
                rbFechamento.Enabled = true;
                btnSalvar.Enabled = true;

                DataViewPedidos.Rows.Clear();
                lblInformaData.Visible = false;
            }
            else if (rbEmEntrega.Checked)
            {
                txtPesquisa.Enabled = false;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;
                txtPesquisa.Visible = true;

                lblDataFinal.Visible = false;
                lblDataIni.Visible = false;
                lblPesquisa.Visible = true;

                rbSaida.Enabled = true;
                rbFechamento.Enabled = true;
                btnSalvar.Enabled = true;

                DataViewPedidos.Rows.Clear();
                lblInformaData.Visible = false;
            }
            else if (rbFechado.Checked)
            {
                txtPesquisa.Enabled = false;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;
                txtPesquisa.Visible = true;

                lblDataFinal.Visible = false;
                lblDataIni.Visible = false;
                lblPesquisa.Visible = true;

                rbSaida.Enabled = false;
                rbFechamento.Enabled = false;
                btnSalvar.Enabled = false;

                DataViewPedidos.Rows.Clear();
                lblInformaData.Visible = false;
            }

            else if (rbCliente.Checked)
            {
                txtPesquisa.Visible = true;
                txtPesquisa.Enabled = true;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;

                lblDataFinal.Visible = false;
                lblDataIni.Visible = false;
                lblPesquisa.Visible = true;

                rbSaida.Enabled = true;
                rbFechamento.Enabled = true;
                btnSalvar.Enabled = true;

                DataViewPedidos.Rows.Clear();
                lblInformaData.Visible = false;
            }
            else if (rbData.Checked)
            {
                txtPesquisa.Visible = false;
                dtpInicial.Visible = true;
                dtpFinal.Visible = true;

                lblDataFinal.Visible = true;
                lblDataIni.Visible = true;
                lblPesquisa.Visible = false;

                rbSaida.Enabled = true;
                rbFechamento.Enabled = true;
                btnSalvar.Enabled = true;

                DataViewPedidos.Rows.Clear();
                lblInformaData.Visible = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //recuperando dados dos grids
            var ID = DataViewPedidos.SelectedCells[0].OwningRow.Cells[0].Value;
            if (consulta != "FECHADO")
            {
                if (rbSaida.Checked)
                {
                    #region try catch finally
                    try
                    {
                        //abrindo conexao
                        conexao.Open();

                        //criando comando
                        NpgsqlCommand comando = new NpgsqlCommand();
                        //passando a conexao para o comando
                        comando.Connection = conexao;


                        //recuperando dados dos grids
                        //var ID = DataViewPedidos.SelectedCells[0].OwningRow.Cells[0].Value;

                        comando.CommandText = "UPDATE pedidos SET pedidos_status = 'SAIU PARA ENTREGA' WHERE pedidos_id = " + ID + ";";

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Editado com sucesso!", "Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comando.Dispose();

                    }
                    catch (Exception ex)
                    {
                        conexao.Close();
                        MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DataViewPedidos.Rows.Clear();
                    }
                    finally
                    {
                        conexao.Close();

                        rbSaida.Enabled = false;
                        rbFechamento.Enabled = false;
                        btnSalvar.Enabled = false;

                        DataViewPedidos.Rows.Clear();
                    }
                    #endregion
                }
                else if (rbFechamento.Checked)
                {
                    #region try catch finally
                    try
                    {
                        //abrindo conexao
                        conexao.Open();

                        //criando comando
                        NpgsqlCommand comando = new NpgsqlCommand();

                        //passando a conexao para o comando
                        comando.Connection = conexao;


                        
                        comando.CommandText = "UPDATE pedidos SET pedidos_status = 'FECHADO' WHERE pedidos_id = " + ID + ";";
                        comando.ExecuteNonQuery();
                        comando.Dispose();

                    }
                    catch (Exception ex)
                    {
                        conexao.Close();
                        MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DataViewPedidos.Rows.Clear();
                    }
                    finally
                    {
                        conexao.Close();

                        MessageBox.Show("Editado com sucesso!", "Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        rbSaida.Enabled = false;
                        rbFechamento.Enabled = false;
                        btnSalvar.Enabled = false;
                        DataViewPedidos.Rows.Clear();
                    }
                    #endregion

                    #region insere dados vendas
                    try
                    {
                        //abrindo conexao
                        conexao.Open();

                        //criando comando
                        NpgsqlCommand comandoEnvia = new NpgsqlCommand();

                        comandoEnvia.Connection = conexao;

                        DateTime data = DateTime.Now.Date;

                        var hora = new DateTime(2008, 1, 1, 6, 9, 1);

                        int ID_Venda = new Random(DateTime.Now.Millisecond).Next(0, 999999);

                        comandoEnvia.CommandText = "INSERT INTO vendas VALUES (" + ID_Venda + ", '" + data.ToString("d") + "', '" + hora.ToString("HH:mm:ss") + "', " + ID + ");";
                        comandoEnvia.ExecuteNonQuery();
                        comandoEnvia.Dispose();

                        MessageBox.Show("Editado com sucesso!", "Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        conexao.Close();
                        MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DataViewPedidos.Rows.Clear();
                    }
                    finally
                    {
                        conexao.Close();

                        rbSaida.Enabled = false;
                        rbFechamento.Enabled = false;
                        btnSalvar.Enabled = false;
                        DataViewPedidos.Rows.Clear();
                    }
                    #endregion
                }
            }
            else
            {
                MessageBox.Show("O pedido já foi encerrado!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DataViewPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int contaPedidos = DataViewPedidos.Rows.Count;

            //pegando os dados do pedido
            consulta = Convert.ToString(DataViewPedidos.Rows[e.RowIndex].Cells[6].Value);
            MessageBox.Show(consulta, "SATUS DO PEDIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DateTime data = DateTime.Now.Date;

            var hora = DateTime.Now.TimeOfDay;



            if (contaPedidos != 0)
            {
                if (rbFechado.Checked)
                {
                    btnSalvar.Enabled = false;
                    rbFechamento.Enabled = false;
                    rbSaida.Enabled = false;
                }
                else
                {
                    rbSaida.Enabled = true;
                    rbFechamento.Enabled = true;
                    btnSalvar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Não encontramos registros de produtos do seu cardápio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void rbData_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbSaida_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
