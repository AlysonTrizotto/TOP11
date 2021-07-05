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

namespace Vendas
{
    public partial class Login : Form
    {
        NpgsqlConnection conexao = new NpgsqlConnection("Host=localhost;Database=Top11;Username=postgres;Password=Matematicas2");
        Acesso acesso = new Acesso();
        Vendas vendas = new Vendas();
        public Login()
        {
            InitializeComponent();
            txtLogin.Select();
        }

        private void btnLogin_Click(object sender, EventArgs e)
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
                string nivel_acesso = dados.GetString(3);
                if (nivel_acesso.Equals("TOTAL"))
                {
                    vendas.Show();
                    conexao.Close();
                   // MessageBox.Show("Bem vindo ADMINISTRADOR", "BEM VINDO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    //this.Hide();
                }
                else if (nivel_acesso.Equals("LIMITADO"))
                {
                    
                    vendas.Show();
                    conexao.Close();                    
                    
                }
            }
            else
            {
                //caso não seja encontrado nenhum registro com os dados
                MessageBox.Show("Usuário ou Senha invalidos!", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Text = "";
                txtSenha.Text = "";
                txtLogin.Select();
               
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

            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(null, null);
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(null, null);
            }
        }
    }
}
