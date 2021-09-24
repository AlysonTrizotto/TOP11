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
            

            try
            {
                //abrindo conexao
                conexao.Open();

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
    }
}
