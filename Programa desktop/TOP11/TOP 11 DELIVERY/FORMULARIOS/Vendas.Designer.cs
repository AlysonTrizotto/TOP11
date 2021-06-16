
namespace TOP_11_DELIVERY
{
    partial class relatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGerar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInformaData = new System.Windows.Forms.Label();
            this.lblAte = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.dtpATE = new System.Windows.Forms.DateTimePicker();
            this.dtpDE = new System.Windows.Forms.DateTimePicker();
            this.lblQuant_Vendas = new System.Windows.Forms.Label();
            this.lblQuant = new System.Windows.Forms.Label();
            this.lblTaxa = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.lblDinheiro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDebito = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCredito = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPendente = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DataViewRelatorio = new System.Windows.Forms.DataGridView();
            this.CREDITO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataViewPendente = new System.Windows.Forms.DataGridView();
            this.PENDETE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataViewTotal = new System.Windows.Forms.DataGridView();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataViewTaxa = new System.Windows.Forms.DataGridView();
            this.TAXA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataViewDinheiro = new System.Windows.Forms.DataGridView();
            this.DINHEIRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataViewDebito = new System.Windows.Forms.DataGridView();
            this.DEBITO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataViewQuantidade = new System.Windows.Forms.DataGridView();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtGridTeste = new System.Windows.Forms.DataGridView();
            this.TESTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewPendente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewTaxa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewDinheiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewDebito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTeste)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(586, 50);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(173, 23);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "GERAR RELATÓRIO";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInformaData);
            this.groupBox1.Controls.Add(this.lblAte);
            this.groupBox1.Controls.Add(this.lblDe);
            this.groupBox1.Controls.Add(this.dtpATE);
            this.groupBox1.Controls.Add(this.dtpDE);
            this.groupBox1.Location = new System.Drawing.Point(25, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PEÍODO DE BUSCA";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblInformaData
            // 
            this.lblInformaData.AutoSize = true;
            this.lblInformaData.ForeColor = System.Drawing.Color.Red;
            this.lblInformaData.Location = new System.Drawing.Point(303, 66);
            this.lblInformaData.Name = "lblInformaData";
            this.lblInformaData.Size = new System.Drawing.Size(186, 13);
            this.lblInformaData.TabIndex = 24;
            this.lblInformaData.Text = "PESQUISA POR DATA ATÉ 10 DIAS";
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Location = new System.Drawing.Point(277, 26);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(28, 13);
            this.lblAte.TabIndex = 3;
            this.lblAte.Text = "DE: ";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(15, 26);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(28, 13);
            this.lblDe.TabIndex = 2;
            this.lblDe.Text = "DE: ";
            // 
            // dtpATE
            // 
            this.dtpATE.Location = new System.Drawing.Point(280, 43);
            this.dtpATE.Name = "dtpATE";
            this.dtpATE.Size = new System.Drawing.Size(236, 20);
            this.dtpATE.TabIndex = 1;
            // 
            // dtpDE
            // 
            this.dtpDE.Location = new System.Drawing.Point(15, 43);
            this.dtpDE.Name = "dtpDE";
            this.dtpDE.Size = new System.Drawing.Size(228, 20);
            this.dtpDE.TabIndex = 0;
            // 
            // lblQuant_Vendas
            // 
            this.lblQuant_Vendas.AutoSize = true;
            this.lblQuant_Vendas.Location = new System.Drawing.Point(40, 193);
            this.lblQuant_Vendas.Name = "lblQuant_Vendas";
            this.lblQuant_Vendas.Size = new System.Drawing.Size(143, 13);
            this.lblQuant_Vendas.TabIndex = 3;
            this.lblQuant_Vendas.Text = "QUANTIDADE DE VENDAS";
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(192, 193);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(13, 13);
            this.lblQuant.TabIndex = 4;
            this.lblQuant.Text = "0";
            // 
            // lblTaxa
            // 
            this.lblTaxa.AutoSize = true;
            this.lblTaxa.Location = new System.Drawing.Point(192, 231);
            this.lblTaxa.Name = "lblTaxa";
            this.lblTaxa.Size = new System.Drawing.Size(13, 13);
            this.lblTaxa.TabIndex = 6;
            this.lblTaxa.Text = "0";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(40, 231);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(111, 13);
            this.Label.TabIndex = 5;
            this.Label.Text = "TAXA DO MOTOBOY";
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.AutoSize = true;
            this.lblDinheiro.Location = new System.Drawing.Point(192, 270);
            this.lblDinheiro.Name = "lblDinheiro";
            this.lblDinheiro.Size = new System.Drawing.Size(13, 13);
            this.lblDinheiro.TabIndex = 8;
            this.lblDinheiro.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "VENDAS DINHEIRO";
            // 
            // lblDebito
            // 
            this.lblDebito.AutoSize = true;
            this.lblDebito.Location = new System.Drawing.Point(192, 306);
            this.lblDebito.Name = "lblDebito";
            this.lblDebito.Size = new System.Drawing.Size(13, 13);
            this.lblDebito.TabIndex = 10;
            this.lblDebito.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "VENDAS DÉBITO";
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Location = new System.Drawing.Point(192, 340);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(13, 13);
            this.lblCredito.TabIndex = 12;
            this.lblCredito.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "VENDAS CRÉDITO";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(192, 406);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "SALDO TOTAL";
            // 
            // lblPendente
            // 
            this.lblPendente.AutoSize = true;
            this.lblPendente.Location = new System.Drawing.Point(192, 372);
            this.lblPendente.Name = "lblPendente";
            this.lblPendente.Size = new System.Drawing.Size(13, 13);
            this.lblPendente.TabIndex = 14;
            this.lblPendente.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 372);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "PENDENTE DE PAGAMENTO";
            // 
            // DataViewRelatorio
            // 
            this.DataViewRelatorio.AllowUserToAddRows = false;
            this.DataViewRelatorio.AllowUserToDeleteRows = false;
            this.DataViewRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewRelatorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CREDITO});
            this.DataViewRelatorio.Location = new System.Drawing.Point(780, 306);
            this.DataViewRelatorio.Name = "DataViewRelatorio";
            this.DataViewRelatorio.ReadOnly = true;
            this.DataViewRelatorio.Size = new System.Drawing.Size(132, 243);
            this.DataViewRelatorio.TabIndex = 17;
            this.DataViewRelatorio.Visible = false;
            // 
            // CREDITO
            // 
            this.CREDITO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CREDITO.HeaderText = "CRÉDITO";
            this.CREDITO.Name = "CREDITO";
            this.CREDITO.ReadOnly = true;
            // 
            // DataViewPendente
            // 
            this.DataViewPendente.AllowUserToAddRows = false;
            this.DataViewPendente.AllowUserToDeleteRows = false;
            this.DataViewPendente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewPendente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PENDETE});
            this.DataViewPendente.Location = new System.Drawing.Point(918, 306);
            this.DataViewPendente.Name = "DataViewPendente";
            this.DataViewPendente.ReadOnly = true;
            this.DataViewPendente.Size = new System.Drawing.Size(132, 243);
            this.DataViewPendente.TabIndex = 18;
            this.DataViewPendente.Visible = false;
            // 
            // PENDETE
            // 
            this.PENDETE.HeaderText = "PENDETE DE PAGAMENTO";
            this.PENDETE.Name = "PENDETE";
            this.PENDETE.ReadOnly = true;
            // 
            // DataViewTotal
            // 
            this.DataViewTotal.AllowUserToAddRows = false;
            this.DataViewTotal.AllowUserToDeleteRows = false;
            this.DataViewTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewTotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TOTAL});
            this.DataViewTotal.Location = new System.Drawing.Point(1056, 299);
            this.DataViewTotal.Name = "DataViewTotal";
            this.DataViewTotal.ReadOnly = true;
            this.DataViewTotal.Size = new System.Drawing.Size(132, 243);
            this.DataViewTotal.TabIndex = 19;
            this.DataViewTotal.Visible = false;
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // DataViewTaxa
            // 
            this.DataViewTaxa.AllowUserToAddRows = false;
            this.DataViewTaxa.AllowUserToDeleteRows = false;
            this.DataViewTaxa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewTaxa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TAXA});
            this.DataViewTaxa.Location = new System.Drawing.Point(780, 50);
            this.DataViewTaxa.Name = "DataViewTaxa";
            this.DataViewTaxa.ReadOnly = true;
            this.DataViewTaxa.Size = new System.Drawing.Size(132, 243);
            this.DataViewTaxa.TabIndex = 20;
            this.DataViewTaxa.Visible = false;
            // 
            // TAXA
            // 
            this.TAXA.HeaderText = "TAXA";
            this.TAXA.Name = "TAXA";
            this.TAXA.ReadOnly = true;
            // 
            // DataViewDinheiro
            // 
            this.DataViewDinheiro.AllowUserToAddRows = false;
            this.DataViewDinheiro.AllowUserToDeleteRows = false;
            this.DataViewDinheiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewDinheiro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DINHEIRO});
            this.DataViewDinheiro.Location = new System.Drawing.Point(918, 50);
            this.DataViewDinheiro.Name = "DataViewDinheiro";
            this.DataViewDinheiro.ReadOnly = true;
            this.DataViewDinheiro.Size = new System.Drawing.Size(132, 243);
            this.DataViewDinheiro.TabIndex = 21;
            this.DataViewDinheiro.Visible = false;
            // 
            // DINHEIRO
            // 
            this.DINHEIRO.HeaderText = "DINHEIRO";
            this.DINHEIRO.Name = "DINHEIRO";
            this.DINHEIRO.ReadOnly = true;
            // 
            // DataViewDebito
            // 
            this.DataViewDebito.AllowUserToAddRows = false;
            this.DataViewDebito.AllowUserToDeleteRows = false;
            this.DataViewDebito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewDebito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DEBITO});
            this.DataViewDebito.Location = new System.Drawing.Point(1056, 50);
            this.DataViewDebito.Name = "DataViewDebito";
            this.DataViewDebito.ReadOnly = true;
            this.DataViewDebito.Size = new System.Drawing.Size(132, 243);
            this.DataViewDebito.TabIndex = 22;
            this.DataViewDebito.Visible = false;
            // 
            // DEBITO
            // 
            this.DEBITO.HeaderText = "DÉBITO";
            this.DEBITO.Name = "DEBITO";
            this.DEBITO.ReadOnly = true;
            // 
            // DataViewQuantidade
            // 
            this.DataViewQuantidade.AllowUserToAddRows = false;
            this.DataViewQuantidade.AllowUserToDeleteRows = false;
            this.DataViewQuantidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewQuantidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quantidade});
            this.DataViewQuantidade.Location = new System.Drawing.Point(642, 176);
            this.DataViewQuantidade.Name = "DataViewQuantidade";
            this.DataViewQuantidade.ReadOnly = true;
            this.DataViewQuantidade.Size = new System.Drawing.Size(132, 243);
            this.DataViewQuantidade.TabIndex = 23;
            this.DataViewQuantidade.Visible = false;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantiade de Vendas";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // dtGridTeste
            // 
            this.dtGridTeste.AllowUserToAddRows = false;
            this.dtGridTeste.AllowUserToDeleteRows = false;
            this.dtGridTeste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridTeste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TESTE});
            this.dtGridTeste.Location = new System.Drawing.Point(504, 176);
            this.dtGridTeste.Name = "dtGridTeste";
            this.dtGridTeste.ReadOnly = true;
            this.dtGridTeste.Size = new System.Drawing.Size(132, 243);
            this.dtGridTeste.TabIndex = 24;
            this.dtGridTeste.Visible = false;
            // 
            // TESTE
            // 
            this.TESTE.HeaderText = "TESTE";
            this.TESTE.Name = "TESTE";
            this.TESTE.ReadOnly = true;
            // 
            // relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dtGridTeste);
            this.Controls.Add(this.DataViewQuantidade);
            this.Controls.Add(this.DataViewDebito);
            this.Controls.Add(this.DataViewDinheiro);
            this.Controls.Add(this.DataViewTaxa);
            this.Controls.Add(this.DataViewTotal);
            this.Controls.Add(this.DataViewPendente);
            this.Controls.Add(this.DataViewRelatorio);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblPendente);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblCredito);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDebito);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDinheiro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTaxa);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.lblQuant);
            this.Controls.Add(this.lblQuant_Vendas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGerar);
            this.Name = "relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATÓRIO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.relatorio_FormClosed);
            this.Load += new System.EventHandler(this.Vendas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewPendente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewTaxa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewDinheiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewDebito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTeste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.DateTimePicker dtpATE;
        private System.Windows.Forms.DateTimePicker dtpDE;
        private System.Windows.Forms.Label lblQuant_Vendas;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Label lblTaxa;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label lblDinheiro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDebito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPendente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView DataViewRelatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREDITO;
        private System.Windows.Forms.DataGridView DataViewPendente;
        private System.Windows.Forms.DataGridView DataViewTotal;
        private System.Windows.Forms.DataGridView DataViewTaxa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAXA;
        private System.Windows.Forms.DataGridView DataViewDinheiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DINHEIRO;
        private System.Windows.Forms.DataGridView DataViewDebito;
        private System.Windows.Forms.DataGridView DataViewQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEBITO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PENDETE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.Label lblInformaData;
        private System.Windows.Forms.DataGridView dtGridTeste;
        private System.Windows.Forms.DataGridViewTextBoxColumn TESTE;
    }
}