using Npgsql;
using System;
using System.Windows.Forms;




namespace TOP_11_DELIVERY
{
    public partial class Login : Form
    {
        NpgsqlConnection conexao = new NpgsqlConnection("Host=localhost;Database=Top11;Username=postgres;Password=Matematicas2");
        Acesso acesso = new Acesso();
        Menu menu1 = new Menu();
        public Login()
        {
            InitializeComponent();
            txtLogin.Select();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            #region tratando os dados de pesquisa
            //abrir conexão
            conexao.Open();
            //gereando a comunicação de pesquisa de usuários
            string queryTotal = "SELECT * FROM funcionarios WHERE func_nome = '" + txtLogin.Text + "' AND func_senha = '" + txtSenha.Text + "';";


            NpgsqlCommand executasql = new NpgsqlCommand(queryTotal, conexao);
            executasql.Parameters.AddWithValue("func_nome", txtLogin.Text);
            executasql.Parameters.AddWithValue("func_senha", txtSenha.Text);

            NpgsqlDataReader dados = executasql.ExecuteReader();

            #endregion


            if (dados.Read()) //verificando se foi encontrado um registro com esta conta
            {
                menu1.controle_local = "";
                string nivel_acesso = dados.GetString(3);
                if (nivel_acesso.Equals("TOTAL"))
                {
                    menu1.Show();
                    conexao.Close();
                    MessageBox.Show("Bem vindo ADMINISTRADOR", "BEM VINDO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    menu1.MenuCadastro.Visible = true;
                    menu1.menuVendas.Visible = true;
                    menu1.menuPedidos.Visible = true;
                    menu1.menuSair.Visible = true;
                    menu1.controle_local = "TOTAL";
                    acesso.controle = true;
                    this.Hide();
                }
                else if (nivel_acesso.Equals("LIMITADO"))
                {
                    acesso.controle = false;
                    menu1.Show();
                    conexao.Close();
                    menu1.MenuCadastro.Visible = false;
                    menu1.menuVendas.Visible = false;
                    menu1.menuPedidos.Visible = true;
                    menu1.menuSair.Visible = true;
                    menu1.controle_local = "LIMITADO";
                    this.Hide();
                }
            }
            else
            {
                //caso não seja encontrado nenhum registro com os dados
                MessageBox.Show("Usuário ou Senha invalidos!", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Text = "";
                txtSenha.Text = "";
                txtLogin.Select();
                menu1.controle_local = "";
                #region fechando conexão
                //fechando conexão
                conexao.Close();
                #endregion

            }
            txtLogin.Text = "";
            txtSenha.Text = "";
            txtLogin.Select();
            //fechando conexão
            conexao.Close();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnEntrar_Click(null, null);
            }
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnEntrar_Click(null, null);
            }
        }
    }
}