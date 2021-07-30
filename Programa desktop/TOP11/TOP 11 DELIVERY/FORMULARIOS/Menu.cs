using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace TOP_11_DELIVERY
{
    public partial class Menu : Form
    {
        NpgsqlConnection conexao = new NpgsqlConnection("Host=localhost;Database=Top11;Username=postgres;Password=Matematicas2");
        //criando comando
        NpgsqlCommand comando = new NpgsqlCommand();

        public string controle_local = "";

        int devolve;
        

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login log = new Login();
            log.Show();
            controle_local = "";
            Acesso acesso = new Acesso();
            acesso.controle = false;
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvaHora_Click(object sender, EventArgs e)
        {
            //abrindo conexao
            conexao.Open();

            try
            {

                //passando a conexao para o comando
                comando.Connection = conexao;

                int nome = (int)Numero.Value;
                lblTempo.Text = ("Tempo atual no configurado: " + Convert.ToString(nome));

                comando.CommandText = "UPDATE tempo SET tempo = '" + nome + "' WHERE id = '1';";

                comando.ExecuteNonQuery();

                MessageBox.Show("Atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void pESQUISARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Categoria categoria1 = new Categoria();
            categoria1.Show();
        }

        private void eDITARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Funcionarios func = new Funcionarios();
            func.Show();
        }

        private void eXCLUIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Bairro bairro1 = new Bairro();
            bairro1.Show();
        }

        private void CadastroCardapio_Click(object sender, EventArgs e)
        {
            Produtos produto1 = new Produtos();
            produto1.Show();
            //this.Hide();
        }

        private void rEALIZARVENDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedidos pedido = new Pedidos();
            pedido.Show();
            //this.Hide();
        }

        public void comanda()
        {
            conexao.Open();

            dtPed.Rows.Clear();
            

            #region
            try
            {
                string query = "SELECT pedidos.pedidos_id, card_ped.quant, cardapio.card_nome, pedidos.pedidos_valor, " +
                    " pedidos.pedidos_data, pedidos.pedidos_hora, pedidos.pedidos_status, pedidos.pedidos_troco, " +
                    " bairro.bairro_nome, cliente.cliente_nome,  form_pag.pag_descricao, " +
                    " card_ped.id_card, card_ped.id_ped  FROM pedidos, bairro, cliente, cardapio, form_pag, card_ped " +
                    "  WHERE pedidos.pedidos_id_bairro_fk = bairro.bairro_id AND " +
                    "  pedidos.pedidos_cpf_cliente_fk = cliente.cliente_cpf AND " +
                    "  card_ped.id_ped = pedidos.pedidos_id AND " +
                    "  card_ped.id_card = cardapio.card_id AND " +
                    "  pedidos.pedidos_id_form_pgt = form_pag.pag_id AND " +
                                        " pedidos.pedidos_status LIKE 'ABERTO';";



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
                
            }
            #endregion

            int contagem = dtPed.Rows.Count;

            if (contagem != 0)
            {
                produtos();
            }

        }

        public void produtos()
        {
            //abrindo conexao
            conexao.Open();
            //Limpa as linhas...
            dtProdutos.Rows.Clear();
            var x = dtPed.Rows[0].Cells[0].Value;
            
            #region try catch finally
            
            try
            {
                string query = "select c.card_id, cp.quant, c.card_nome, c.card_valor " +
                    " from cardapio as c, card_ped as cp, pedidos as p " +
                    " where c.card_id = cp.id_card and " +
                    " p.pedidos_id = cp.id_ped and " +
                    " p.pedidos_id = " + Convert.ToInt32(x) + ";";



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

        private void btnImpressao_Click(object sender, EventArgs e)
        {
            comanda();
           
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
            int ID = Convert.ToInt32(dtPed.Rows[0].Cells[0].Value);
            try
            {
                conexao.Open();
                NpgsqlCommand comando = new NpgsqlCommand();
                comando.Connection = conexao;

                comando.CommandText = "UPDATE pedidos SET pedidos_status = 'SAIU PARA ENTREGA' WHERE pedidos_id = " + ID + ";";
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
            }
        }

        private void pESQUISARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            relatorio relatorio1 = new relatorio();
            relatorio1.Show();
            //this.Hide();
        }

        private void Menu_Shown(object sender, EventArgs e)
        {
            Acesso acesso = new Acesso();
            if (controle_local == "TOTAL" || acesso.controle == true)
            {
                controle_local = "TOTAL";
                MenuCadastro.Visible = true;
                menuPedidos.Visible = true;
                menuVendas.Visible = true;
                menuSair.Visible = true;
            }
            else if (controle_local == "LIMITADO" || acesso.controle == false)
            {
                controle_local = "LIMITADO";
                MenuCadastro.Visible = false;
                menuPedidos.Visible = true;
                menuVendas.Visible = false;
                menuSair.Visible = true;
            }
        }

        private void fORMADEPAGAMENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Pgto forma_de_pagamento = new Form_Pgto();
            forma_de_pagamento.Show();
        }

        private void MenuCadastro_Click(object sender, EventArgs e)
        {

        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
