using Npgsql;
using System;
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
            //// printDocument1.Print();
            //string texto = "trabalhando com impressão";

            #region QUERY
            ////Abrindo conexao
            //conexao.Open();
            ////Limpa as linhas...
            //DataViewPedidos.Rows.Clear();

            //try
            //{
            //    string query = "Select P.pedidos_id, C.clietne_nome, C.cliente_endereco, Card.card_nome, CP.quant, " +
            //        "	P.pedidos_valor, F.pag_descricao, P.pedidos_troco " +
            //        " From pedidos AS P, cliente AS C, cardapio AS Card, card_ped AS CP, form_pag AS F " +
            //        " WHERE  P.pedidos_id = CP.id_ped AND " +
            //        "    Card.card_id = CP.id_card  AND " +
            //        "    P.pedidos_cpf_clietne_fk = C.cliente_cpf AND " +
            //        "  P.pedidos_id_form_pgt = F.pag_id AND " +
            //        "  P.pedidos_status LIKE 'ABERTO';";

            //    string Pedidos_id = "P.pedidos_id";
            //    string clietne_nome = "C.clietne_nome";
            //    string cliente_endereco = "C.cliente_endereco";
            //    string card_nome = "Card.card_nome";
            //    string CPquant = "CP.quant";
            //    string pedidos_valor = "P.pedidos_valor";
            //    string pag_descricao = "F.pag_descricao";
            //    string troco = "P.pedidos_troco";
            //    string CPid_card = "CP.id_card";
            //    string Card_id = "Card.card_id";
            //    string CPid_ped = "CP.id_ped";

            //    while (Card_id == CPid_card && Pedidos_id == CPid_ped)
            //    {
            //        texto = texto + ", " + card_nome;
            //    }

            //    label2.Text = texto;

            //    DataTable dados = new DataTable();

            //    NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(query, conexao);
            //    adaptador.Fill(dados);

            //    foreach (DataRow linha in dados.Rows)
            //    {
            //        DataViewPedidos.Rows.Add(linha.ItemArray);

            //    }
            //}
            //catch (Exception ex)
            //{
            //    conexao.Close();
            //    MessageBox.Show(ex.Message, "Erro no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    DataViewPedidos.Rows.Clear();
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {


            #region IMPRIMINDO


            // Font letra = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);
            // Brush pincel = new SolidBrush(Color.Black);
            // Point pontoInicial = new Point(100, 50);


            // //Desenhar o documento para ser impresso
            ////e.Graphics.DrawString(texto, letra, pincel, pontoInicial);


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
    }
}
