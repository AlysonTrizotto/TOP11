using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;


namespace TOP_11_DELIVERY
{
    public partial class relatorio : Form
    {
        NpgsqlConnection conexao = new NpgsqlConnection("Host=localhost;Database=Top11;Username=postgres;Password=Matematicas2");

        public relatorio()
        {
            InitializeComponent();
        }

        private void Vendas_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void relatorio_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Menu menu1 = new Menu();
            //menu1.Show();
            conexao.Close();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            //abrindo conexao
            conexao.Open();
            //Limpa as linhas...
            DataViewRelatorio.Rows.Clear();
            DataViewDebito.Rows.Clear();
            DataViewDinheiro.Rows.Clear();
            DataViewPendente.Rows.Clear();
            DataViewQuantidade.Rows.Clear();
            DataViewTaxa.Rows.Clear();
            DataViewTotal.Rows.Clear();



            try
            {
                string CREDITO = " select SUM(pedidos_valor) " +
                    " from pedidos, vendas, form_pag " +
                    " WHERE pedidos.pedidos_id = vendas.vendas_id_pedidos_fk AND " +
                    " pedidos.pedidos_id_form_pgt = form_pag.pag_id AND " +
                    " form_pag.pag_descricao = 'CRÉDITO' AND " +
                     " pedidos.pedidos_status = 'FECHADO' AND " +
                    " vendas.vendas_data BETWEEN  '" + Convert.ToDateTime(dtpDE.Value.Date).ToShortDateString() + "' AND '" + Convert.ToDateTime(dtpATE.Value.Date).ToShortDateString() + "';";



                DataTable dados = new DataTable();

                NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(CREDITO, conexao);
                adaptador.Fill(dados);
                foreach (DataRow linha in dados.Rows)
                {
                    dtGridTeste.Rows.Add(linha.ItemArray);
                    var consulta = Convert.ToString(dtGridTeste.Rows[0].Cells[0].Value);
                }
            }
            catch (Exception ex)
            {
                conexao.Close();
                MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtGridTeste.Rows.Clear();
            }
            finally
            {
                conexao.Close();
            }

            int conta = dtGridTeste.Rows.Count;
            if (conta == 0)
            {
                MessageBox.Show("Nenhum registro encontrado com esse parâmetro, por favor redefina as datas!", "Erro de parâmetro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                #region CREDITO
                try
                {
                    string CREDITO = " select SUM(pedidos_valor) " +
                        " from pedidos, vendas, form_pag " +
                        " WHERE pedidos.pedidos_id = vendas.vendas_id_pedidos_fk AND " +
                        " pedidos.pedidos_id_form_pgt = form_pag.pag_id AND " +
                        " form_pag.pag_descricao = 'CRÉDITO' AND " +
                         " pedidos.pedidos_status = 'FECHADO' AND " +
                        " vendas.vendas_data BETWEEN  '" + Convert.ToDateTime(dtpDE.Value.Date).ToShortDateString() + "' AND '" + Convert.ToDateTime(dtpATE.Value.Date).ToShortDateString() + "';";



                    DataTable dados = new DataTable();

                    NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(CREDITO, conexao);
                    adaptador.Fill(dados);
                    foreach (DataRow linha in dados.Rows)
                    {
                        DataViewRelatorio.Rows.Add(linha.ItemArray);
                        var consulta = Convert.ToString(DataViewRelatorio.Rows[0].Cells[0].Value);
                        lblCredito.Text = Convert.ToString(consulta);
                    }
                }
                catch (Exception ex)
                {
                    conexao.Close();
                    MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataViewRelatorio.Rows.Clear();
                }
                finally
                {
                    conexao.Close();
                }
                #endregion

                #region bairro
                try
                {

                    string BAIRRO = "select SUM(bairro_taxa) " +
                        " from pedidos, vendas, bairro " +
                        " WHERE pedidos.pedidos_id = vendas.vendas_id_pedidos_fk AND " +
                        " pedidos.pedidos_id_bairro_fk = bairro.bairro_id AND " +
                        " pedidos.pedidos_status = 'FECHADO' AND " +
                        " vendas.vendas_data BETWEEN  '" + Convert.ToDateTime(dtpDE.Value.Date).ToShortDateString() + "' AND '" + Convert.ToDateTime(dtpATE.Value.Date).ToShortDateString() + "';";

                    DataTable dadosBairro = new DataTable();

                    NpgsqlDataAdapter adaptadorBairro = new NpgsqlDataAdapter(BAIRRO, conexao);
                    adaptadorBairro.Fill(dadosBairro);
                    foreach (DataRow linha in dadosBairro.Rows)
                    {
                        DataViewTaxa.Rows.Add(linha.ItemArray);
                        var consultaBairro = Convert.ToString(DataViewTaxa.Rows[0].Cells[0].Value);
                        lblTaxa.Text = Convert.ToString(consultaBairro);
                    }

                }
                catch (Exception ex)
                {
                    conexao.Close();
                    MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataViewTaxa.Rows.Clear();
                }
                finally
                {
                    conexao.Close();
                }
                #endregion

                #region dinheiro
                try
                {
                    string DINHEIRO = " select SUM(pedidos_valor) " +
                        " from pedidos, vendas, form_pag " +
                        " WHERE pedidos.pedidos_id = vendas.vendas_id_pedidos_fk AND " +
                        " pedidos.pedidos_id_form_pgt = form_pag.pag_id AND " +
                        " form_pag.pag_descricao = 'DINHEIRO' AND " +
                        " pedidos.pedidos_status = 'FECHADO' AND " +
                        " vendas.vendas_data BETWEEN  '" + Convert.ToDateTime(dtpDE.Value.Date).ToShortDateString() + "' AND '" + Convert.ToDateTime(dtpATE.Value.Date).ToShortDateString() + "';";


                    DataTable dadosDinheiro = new DataTable();

                    NpgsqlDataAdapter adaptadorDinheiro = new NpgsqlDataAdapter(DINHEIRO, conexao);
                    adaptadorDinheiro.Fill(dadosDinheiro);
                    foreach (DataRow linha in dadosDinheiro.Rows)
                    {
                        DataViewDinheiro.Rows.Add(linha.ItemArray);
                        var consultaDinheiro = Convert.ToString(DataViewDinheiro.Rows[0].Cells[0].Value);
                        lblDinheiro.Text = Convert.ToString(consultaDinheiro);
                    }
                }
                catch (Exception ex)
                {
                    conexao.Close();
                    MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataViewDinheiro.Rows.Clear();
                }
                finally
                {
                    conexao.Close();
                }
                #endregion

                #region débito
                try
                {
                    DataViewDebito.Rows.Clear();
                    string DEBITO = " select SUM(pedidos_valor) " +
                         " from pedidos, vendas, form_pag " +
                         " WHERE pedidos.pedidos_id = vendas.vendas_id_pedidos_fk AND " +
                         " pedidos.pedidos_id_form_pgt = form_pag.pag_id AND " +
                         " form_pag.pag_descricao = 'DÉBITO' AND " +
                         " pedidos.pedidos_status = 'FECHADO' AND " +
                         " vendas.vendas_data BETWEEN  '" + Convert.ToDateTime(dtpDE.Value.Date).ToShortDateString() + "' AND '" + Convert.ToDateTime(dtpATE.Value.Date).ToShortDateString() + "';";

                    DataTable dadosDebito = new DataTable();

                    NpgsqlDataAdapter adaptadorDebito = new NpgsqlDataAdapter(DEBITO, conexao);
                    adaptadorDebito.Fill(dadosDebito);
                    foreach (DataRow linha in dadosDebito.Rows)
                    {
                        DataViewDebito.Rows.Add(linha.ItemArray);
                        var consultaDebito = Convert.ToString(DataViewDebito.Rows[0].Cells[0].Value);
                        lblDebito.Text = Convert.ToString(consultaDebito);
                    }
                }
                catch (Exception ex)
                {
                    conexao.Close();
                    MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataViewDebito.Rows.Clear();
                }
                finally
                {
                    conexao.Close();
                }
                #endregion

                #region Pendente
                try
                {
                    string PENDENTE = " select SUM(pedidos_valor) " +
                        " from pedidos, vendas, form_pag " +
                        " WHERE pedidos.pedidos_id = vendas.vendas_id_pedidos_fk AND " +
                        " pedidos.pedidos_id_form_pgt = form_pag.pag_id AND " +
                        " pedidos.pedidos_status <> 'FECHADO' AND " +
                        " vendas.vendas_data BETWEEN  '" + Convert.ToDateTime(dtpDE.Value.Date).ToShortDateString() + "' AND '" + Convert.ToDateTime(dtpATE.Value.Date).ToShortDateString() + "';";

                    DataTable dadosPENDENTE = new DataTable();

                    NpgsqlDataAdapter adaptadorPENDENTE = new NpgsqlDataAdapter(PENDENTE, conexao);
                    adaptadorPENDENTE.Fill(dadosPENDENTE);
                    foreach (DataRow linha in dadosPENDENTE.Rows)
                    {
                        DataViewPendente.Rows.Add(linha.ItemArray);
                        var consultaPENDENTE = Convert.ToString(DataViewPendente.Rows[0].Cells[0].Value);
                        lblPendente.Text = Convert.ToString(consultaPENDENTE);
                    }

                }
                catch (Exception ex)
                {
                    conexao.Close();
                    MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataViewPendente.Rows.Clear();
                }
                finally
                {
                    conexao.Close();
                }
                #endregion

                #region total
                try
                {

                    string TOTAL = " select SUM(pedidos_valor) " +
                        " from pedidos, vendas, form_pag " +
                        " WHERE pedidos.pedidos_id = vendas.vendas_id_pedidos_fk AND " +
                        " pedidos.pedidos_id_form_pgt = form_pag.pag_id AND " +
                        " pedidos.pedidos_status = 'FECHADO' AND " +
                       " vendas.vendas_data BETWEEN  '" + Convert.ToDateTime(dtpDE.Value.Date).ToShortDateString() + "' AND '" + Convert.ToDateTime(dtpATE.Value.Date).ToShortDateString() + "';";

                    DataTable dadosTOTAL = new DataTable();

                    NpgsqlDataAdapter adaptadorTOTAL = new NpgsqlDataAdapter(TOTAL, conexao);
                    adaptadorTOTAL.Fill(dadosTOTAL);
                    foreach (DataRow linha in dadosTOTAL.Rows)
                    {
                        DataViewTotal.Rows.Add(linha.ItemArray);
                        var consultaTOTAL = Convert.ToString(DataViewTotal.Rows[0].Cells[0].Value);
                        lblTotal.Text = Convert.ToString(consultaTOTAL);
                    }
                }
                catch (Exception ex)
                {
                    conexao.Close();
                    MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataViewTotal.Rows.Clear();
                }
                finally
                {
                    conexao.Close();
                }
                #endregion

                #region vendas

                try
                {

                    string VENDAS = " select count(*) " +
                        " from pedidos, vendas " +
                        " WHERE pedidos.pedidos_id = vendas.vendas_id_pedidos_fk AND " +
                        " vendas.vendas_data BETWEEN  '" + Convert.ToDateTime(dtpDE.Value.Date).ToShortDateString() + "' AND '" + Convert.ToDateTime(dtpATE.Value.Date).ToShortDateString() + "';";

                    DataTable dadosVENDAS = new DataTable();

                    NpgsqlDataAdapter adaptadorVENDAS = new NpgsqlDataAdapter(VENDAS, conexao);
                    adaptadorVENDAS.Fill(dadosVENDAS);
                    foreach (DataRow linha in dadosVENDAS.Rows)
                    {
                        DataViewQuantidade.Rows.Add(linha.ItemArray);
                        var consultaVENDAS = Convert.ToString(DataViewQuantidade.Rows[0].Cells[0].Value);
                        lblQuant.Text = Convert.ToString(consultaVENDAS);
                    }
                }
                catch (Exception ex)
                {
                    conexao.Close();
                    MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataViewQuantidade.Rows.Clear();
                }
                finally
                {
                    conexao.Close();
                }
                #endregion
                conexao.Close();
            }

        }
    }
}
