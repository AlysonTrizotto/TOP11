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

                    Vendas vendas = new Vendas();

                    vendas.Show();

                    this.Close();
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

                    Vendas vendas = new Vendas();

                    vendas.Show();

                    this.Close();
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

                    Vendas vendas = new Vendas();

                    vendas.Show();
                    this.Close();
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

                    Vendas vendas = new Vendas();

                    vendas.Show();

                    this.Close();
                }
            }

            
        }

        private void CANCELAR_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();

            vendas.Show();

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
    }
}
