using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Vendas
{

    public partial class Fechamento : Form
    {
        NpgsqlConnection conexao = new NpgsqlConnection("Host=localhost;Database=Top11;Username=postgres;Password=Matematicas2");

        public int comanda;
        

        public Fechamento()
        {
            InitializeComponent();
        }

        public Fechamento(string valor, int cNota)
        {
            InitializeComponent();
            txtFechamento.Text = valor;
            comanda = cNota;
        }


        private void FINALIZAR_Click(object sender, EventArgs e)
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
        }

        private void CANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
               Calcula(null, null);

                
                MessageBox.Show("Troco: " + txtTroco.Text + "","Troco", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Task.Delay(1000);

                FINALIZAR_Click(null, null);
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

                btnFinalizar.Visible = true;

                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
            else if (rbCredito.Checked)
            {
                txtDinheiro.Visible = false;
                txtTroco.Visible = false;

                lblDinheiro.Visible = false;
                lblTroco.Visible = false;

                btnFinalizar.Visible = true;

                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
            else if (rbDinheiro.Checked)
            {
                txtDinheiro.Visible = true;
                txtTroco.Visible = true;

                lblDinheiro.Visible = true;
                lblTroco.Visible = true;

                btnFinalizar.Visible = false;
                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
            else if (rbPIX.Checked)
            {
                txtDinheiro.Visible = false;
                txtTroco.Visible = false;

                lblDinheiro.Visible = false;
                lblTroco.Visible = false;

                btnFinalizar.Visible = true;

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

                btnFinalizar.Visible = true;

                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
            else if (rbCredito.Checked)
            {
                txtDinheiro.Visible = false;
                txtTroco.Visible = false;

                lblDinheiro.Visible = false;
                lblTroco.Visible = false;

                btnFinalizar.Visible = true;

                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
            else if (rbDinheiro.Checked)
            {
                txtDinheiro.Visible = true;
                txtTroco.Visible = true;

                lblDinheiro.Visible = true;
                lblTroco.Visible = true;

                btnFinalizar.Visible = false;
                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
            else if (rbPIX.Checked)
            {
                txtDinheiro.Visible = false;
                txtTroco.Visible = false;

                lblDinheiro.Visible = false;
                lblTroco.Visible = false;

                btnFinalizar.Visible = true;

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

                btnFinalizar.Visible = true;

                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
            else if (rbCredito.Checked)
            {
                txtDinheiro.Visible = false;
                txtTroco.Visible = false;

                lblDinheiro.Visible = false;
                lblTroco.Visible = false;

                btnFinalizar.Visible = true;

                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
            else if (rbDinheiro.Checked)
            {
                txtDinheiro.Visible = true;
                txtTroco.Visible = true;

                lblDinheiro.Visible = true;
                lblTroco.Visible = true;

                btnFinalizar.Visible = false;
                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
            else if (rbPIX.Checked)
            {
                txtDinheiro.Visible = false;
                txtTroco.Visible = false;

                lblDinheiro.Visible = false;
                lblTroco.Visible = false;

                btnFinalizar.Visible = true;

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

                btnFinalizar.Visible = true;

                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
            else if (rbCredito.Checked)
            {
                txtDinheiro.Visible = false;
                txtTroco.Visible = false;

                lblDinheiro.Visible = false;
                lblTroco.Visible = false;

                btnFinalizar.Visible = true;

                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
            else if (rbDinheiro.Checked)
            {
                txtDinheiro.Visible = true;
                txtTroco.Visible = true;

                lblDinheiro.Visible = true;
                lblTroco.Visible = true;

                btnFinalizar.Visible = false;
                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
            else if (rbPIX.Checked)
            {
                txtDinheiro.Visible = false;
                txtTroco.Visible = false;

                lblDinheiro.Visible = false;
                lblTroco.Visible = false;

                btnFinalizar.Visible = true;

                txtDinheiro.Text = "";
                txtTroco.Text = "";
            }
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
                    lbl_SemComanda.Visible = false;
                }
                else
                {
                    lbl_SemComanda.Visible = true;
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

                this.Close();
            }
        }

        private void Fechamento_Load(object sender, EventArgs e)
        {
            
        }

        private void Fechamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexao.Close();
        }
    }
}
