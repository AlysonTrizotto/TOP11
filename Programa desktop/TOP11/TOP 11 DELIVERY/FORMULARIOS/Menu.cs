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

        private void btnImpressao_Click(object sender, EventArgs e)
        {
             printDocument1.Print();
            //string texto = "trabalhando com impressão";
            /*
            #region QUERY
            //Abrindo conexao
            conexao.Open();
            //Limpa as linhas...
            dtGridBusca.Rows.Clear();

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

                DataTable dados = new DataTable();

                NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(query, conexao);
                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    dtGridBusca.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                conexao.Close();
                MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtGridBusca.Rows.Clear();
            }
            finally
            {
                conexao.Close();
            } 
            #endregion*/
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {


            #region Parte 1

            //Preparar os dados
            string texto = "Trabalhando com impressão";
            Font fonte = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);
            Brush pincel = new SolidBrush(Color.Black);
            Point pontoInicial = new Point(100, 50);

            //desenhar o documento para imprimir
            e.Graphics.DrawString(texto, fonte, pincel, pontoInicial); 
            
            #endregion
        }

        private void DataViewPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pESQUISARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            relatorio relatorio1 = new relatorio();
            relatorio1.Show();
            //this.Hide();
        }

        private void DataViewPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        private void Menu_Load(object sender, EventArgs e)
        {
            // Acesso acesso = new Acesso();
            // lblAcesso.Text = acesso.controle;
            //// MessageBox.Show(acesso.controle, "controle", MessageBoxButtons.OK);
            // if (lblAcesso.Text == "TOTAL" || controle_local == "TOTAL")
            // {
            //     MenuCadastro.Visible = true;
            //     menuPedidos.Visible = true;
            //     menuVendas.Visible = true;
            //     menuSair.Visible = true;

            // }
            // else
            // {
            //     controle_local = lblAcesso.Text;
            //     MenuCadastro.Visible = false;
            //     menuPedidos.Visible = true;
            //     menuVendas.Visible = false;
            //     menuSair.Visible = true;
            //}
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
