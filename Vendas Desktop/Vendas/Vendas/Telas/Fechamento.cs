using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas
{

    public partial class Fechamento : Form
    {
        public  int comanda;

       
        public Fechamento()
        {
            InitializeComponent();
        }

        
        private void FINALIZAR_Click(object sender, EventArgs e)
        {
            Passagem passagem = new Passagem();


            // comanda = passagem.Os;

            Mostra.Text = Convert.ToString(passagem.GetOs);
        }

        private void CANCELAR_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();
           
            this.Close();
        }

        private void Fechamento_Shown(object sender, EventArgs e)
        {
           
        }

        private void Fechamento_Load(object sender, EventArgs e)
        {
            
            Passagem passagem = new Passagem();



            Mostra.Text = passagem.GetOs.ToString();
            MessageBox.Show(passagem.GetOs.ToString());
        }
    }
}
