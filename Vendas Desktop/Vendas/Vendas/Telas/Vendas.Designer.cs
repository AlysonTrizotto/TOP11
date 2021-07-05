
namespace Vendas
{
    partial class Vendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridItens = new System.Windows.Forms.DataGridView();
            this.CUPOM1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUTO1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnFinaliza = new System.Windows.Forms.Button();
            this.btnCancelamento = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridBairro = new System.Windows.Forms.DataGridView();
            this.ID_BAIRRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAIRRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAXA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.btnBuscaVendas = new System.Windows.Forms.Button();
            this.btnBuscaBairros = new System.Windows.Forms.Button();
            this.btnBuscaItens = new System.Windows.Forms.Button();
            this.btnAdicionaItem = new System.Windows.Forms.Button();
            this.dataGridProduto = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cBSemCPF = new System.Windows.Forms.CheckBox();
            this.cBSemBairro = new System.Windows.Forms.CheckBox();
            this.btnLimpaTudo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItens)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBairro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridItens
            // 
            this.dataGridItens.AllowUserToAddRows = false;
            this.dataGridItens.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0,0";
            this.dataGridItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridItens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUPOM1,
            this.PRODUTO1,
            this.QUANTIDADE,
            this.PRECO});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridItens.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridItens.Location = new System.Drawing.Point(894, 305);
            this.dataGridItens.Name = "dataGridItens";
            this.dataGridItens.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridItens.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.dataGridItens.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridItens.Size = new System.Drawing.Size(443, 394);
            this.dataGridItens.TabIndex = 1;
            // 
            // CUPOM1
            // 
            this.CUPOM1.HeaderText = "CUPOM";
            this.CUPOM1.Name = "CUPOM1";
            this.CUPOM1.ReadOnly = true;
            // 
            // PRODUTO1
            // 
            this.PRODUTO1.HeaderText = "PRODUTO";
            this.PRODUTO1.Name = "PRODUTO1";
            this.PRODUTO1.ReadOnly = true;
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.HeaderText = "QUANTIDADE";
            this.QUANTIDADE.Name = "QUANTIDADE";
            this.QUANTIDADE.ReadOnly = true;
            // 
            // PRECO
            // 
            this.PRECO.HeaderText = "PREÇO";
            this.PRECO.Name = "PRECO";
            this.PRECO.ReadOnly = true;
            // 
            // txtProduto
            // 
            this.txtProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProduto.Enabled = false;
            this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(104, 26);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(1240, 30);
            this.txtProduto.TabIndex = 1;
            this.txtProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduto_KeyPress);
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCPF.Enabled = false;
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(104, 101);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(1240, 30);
            this.txtCPF.TabIndex = 3;
            this.txtCPF.Text = "000000000";
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PRODUTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF / CNPJ";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(104, 65);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(136, 30);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // btnFinaliza
            // 
            this.btnFinaliza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFinaliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinaliza.Location = new System.Drawing.Point(396, 3);
            this.btnFinaliza.Name = "btnFinaliza";
            this.btnFinaliza.Size = new System.Drawing.Size(257, 49);
            this.btnFinaliza.TabIndex = 8;
            this.btnFinaliza.Text = "FECHAR  VENDA";
            this.btnFinaliza.UseVisualStyleBackColor = true;
            this.btnFinaliza.Visible = false;
            this.btnFinaliza.Click += new System.EventHandler(this.btnFinaliza_Click);
            // 
            // btnCancelamento
            // 
            this.btnCancelamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelamento.ForeColor = System.Drawing.Color.Red;
            this.btnCancelamento.Location = new System.Drawing.Point(3, 3);
            this.btnCancelamento.Name = "btnCancelamento";
            this.btnCancelamento.Size = new System.Drawing.Size(256, 49);
            this.btnCancelamento.TabIndex = 7;
            this.btnCancelamento.Text = "CANCELAR VENDA";
            this.btnCancelamento.UseVisualStyleBackColor = true;
            this.btnCancelamento.Visible = false;
            this.btnCancelamento.Click += new System.EventHandler(this.btnCancelamento_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "SUBTOTAL :";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(255, 188);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(50, 25);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "0,00";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancelamento, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFinaliza, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 644);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(656, 55);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // dataGridBairro
            // 
            this.dataGridBairro.AllowUserToAddRows = false;
            this.dataGridBairro.AllowUserToDeleteRows = false;
            this.dataGridBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridBairro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBairro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_BAIRRO,
            this.BAIRRO,
            this.TAXA});
            this.dataGridBairro.Enabled = false;
            this.dataGridBairro.Location = new System.Drawing.Point(894, 137);
            this.dataGridBairro.Name = "dataGridBairro";
            this.dataGridBairro.ReadOnly = true;
            this.dataGridBairro.Size = new System.Drawing.Size(443, 150);
            this.dataGridBairro.TabIndex = 13;
            // 
            // ID_BAIRRO
            // 
            this.ID_BAIRRO.HeaderText = "ID";
            this.ID_BAIRRO.Name = "ID_BAIRRO";
            this.ID_BAIRRO.ReadOnly = true;
            this.ID_BAIRRO.Visible = false;
            // 
            // BAIRRO
            // 
            this.BAIRRO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BAIRRO.HeaderText = "BAIRRO";
            this.BAIRRO.Name = "BAIRRO";
            this.BAIRRO.ReadOnly = true;
            // 
            // TAXA
            // 
            this.TAXA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TAXA.HeaderText = "TAXA";
            this.TAXA.Name = "TAXA";
            this.TAXA.ReadOnly = true;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(255, 244);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(23, 25);
            this.lblQuantidade.TabIndex = 15;
            this.lblQuantidade.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "QUANTIDADE DE ITENS :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "QUANTIDADE";
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaVenda.Location = new System.Drawing.Point(12, 597);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(656, 41);
            this.btnNovaVenda.TabIndex = 6;
            this.btnNovaVenda.Text = "NOVA VENDA";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // btnBuscaVendas
            // 
            this.btnBuscaVendas.Location = new System.Drawing.Point(674, 673);
            this.btnBuscaVendas.Name = "btnBuscaVendas";
            this.btnBuscaVendas.Size = new System.Drawing.Size(101, 23);
            this.btnBuscaVendas.TabIndex = 18;
            this.btnBuscaVendas.Text = "Busca vendas";
            this.btnBuscaVendas.UseVisualStyleBackColor = true;
            this.btnBuscaVendas.Visible = false;
            this.btnBuscaVendas.Click += new System.EventHandler(this.btnBuscaVendas_Click);
            // 
            // btnBuscaBairros
            // 
            this.btnBuscaBairros.Location = new System.Drawing.Point(885, 244);
            this.btnBuscaBairros.Name = "btnBuscaBairros";
            this.btnBuscaBairros.Size = new System.Drawing.Size(99, 23);
            this.btnBuscaBairros.TabIndex = 19;
            this.btnBuscaBairros.Text = "Busca bairros";
            this.btnBuscaBairros.UseVisualStyleBackColor = true;
            this.btnBuscaBairros.Visible = false;
            this.btnBuscaBairros.Click += new System.EventHandler(this.btnBuscaBairro_Click);
            // 
            // btnBuscaItens
            // 
            this.btnBuscaItens.Location = new System.Drawing.Point(849, 676);
            this.btnBuscaItens.Name = "btnBuscaItens";
            this.btnBuscaItens.Size = new System.Drawing.Size(75, 23);
            this.btnBuscaItens.TabIndex = 20;
            this.btnBuscaItens.Text = "Busca itens";
            this.btnBuscaItens.UseVisualStyleBackColor = true;
            this.btnBuscaItens.Visible = false;
            this.btnBuscaItens.Click += new System.EventHandler(this.btnBuscaItens_Click);
            // 
            // btnAdicionaItem
            // 
            this.btnAdicionaItem.Location = new System.Drawing.Point(246, 65);
            this.btnAdicionaItem.Name = "btnAdicionaItem";
            this.btnAdicionaItem.Size = new System.Drawing.Size(101, 23);
            this.btnAdicionaItem.TabIndex = 100;
            this.btnAdicionaItem.Text = "Adiciona Item";
            this.btnAdicionaItem.UseVisualStyleBackColor = true;
            this.btnAdicionaItem.Visible = false;
            this.btnAdicionaItem.Click += new System.EventHandler(this.btnAdicionaItem_Click);
            // 
            // dataGridProduto
            // 
            this.dataGridProduto.AllowUserToAddRows = false;
            this.dataGridProduto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = "0,0";
            this.dataGridProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOME,
            this.DESCRICAO,
            this.VALOR1,
            this.IDCATEGORIA});
            this.dataGridProduto.Location = new System.Drawing.Point(536, 305);
            this.dataGridProduto.Name = "dataGridProduto";
            this.dataGridProduto.ReadOnly = true;
            this.dataGridProduto.Size = new System.Drawing.Size(328, 273);
            this.dataGridProduto.TabIndex = 22;
            this.dataGridProduto.Visible = false;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NOME
            // 
            this.NOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESCRICAO.HeaderText = "DESCRIÇÃO";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.ReadOnly = true;
            // 
            // VALOR1
            // 
            this.VALOR1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VALOR1.HeaderText = "VALOR";
            this.VALOR1.Name = "VALOR1";
            this.VALOR1.ReadOnly = true;
            // 
            // IDCATEGORIA
            // 
            this.IDCATEGORIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDCATEGORIA.HeaderText = "IDFK";
            this.IDCATEGORIA.Name = "IDCATEGORIA";
            this.IDCATEGORIA.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Busca itens";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cBSemCPF
            // 
            this.cBSemCPF.AutoSize = true;
            this.cBSemCPF.Enabled = false;
            this.cBSemCPF.Location = new System.Drawing.Point(104, 137);
            this.cBSemCPF.Name = "cBSemCPF";
            this.cBSemCPF.Size = new System.Drawing.Size(142, 17);
            this.cBSemCPF.TabIndex = 4;
            this.cBSemCPF.Text = "Realizar venda sem CPF";
            this.cBSemCPF.UseVisualStyleBackColor = true;
            // 
            // cBSemBairro
            // 
            this.cBSemBairro.AutoSize = true;
            this.cBSemBairro.Enabled = false;
            this.cBSemBairro.Location = new System.Drawing.Point(104, 160);
            this.cBSemBairro.Name = "cBSemBairro";
            this.cBSemBairro.Size = new System.Drawing.Size(148, 17);
            this.cBSemBairro.TabIndex = 5;
            this.cBSemBairro.Text = "Realizar venda sem bairro";
            this.cBSemBairro.UseVisualStyleBackColor = true;
            // 
            // btnLimpaTudo
            // 
            this.btnLimpaTudo.Location = new System.Drawing.Point(379, 175);
            this.btnLimpaTudo.Name = "btnLimpaTudo";
            this.btnLimpaTudo.Size = new System.Drawing.Size(75, 23);
            this.btnLimpaTudo.TabIndex = 101;
            this.btnLimpaTudo.Text = "Limpa Tudo";
            this.btnLimpaTudo.UseVisualStyleBackColor = true;
            this.btnLimpaTudo.Visible = false;
            this.btnLimpaTudo.Click += new System.EventHandler(this.btnLimpaTudo_Click);
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 711);
            this.Controls.Add(this.btnLimpaTudo);
            this.Controls.Add(this.cBSemBairro);
            this.Controls.Add(this.cBSemCPF);
            this.Controls.Add(this.dataGridItens);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridProduto);
            this.Controls.Add(this.btnAdicionaItem);
            this.Controls.Add(this.btnBuscaItens);
            this.Controls.Add(this.btnBuscaBairros);
            this.Controls.Add(this.btnBuscaVendas);
            this.Controls.Add(this.btnNovaVenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridBairro);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtProduto);
            this.Name = "Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENDAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Vendas_FormClosed);
            this.Load += new System.EventHandler(this.Vendas_Load);
            this.Shown += new System.EventHandler(this.Vendas_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItens)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBairro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_BAIRRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAIRRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAXA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridItens;
        private System.Windows.Forms.Button btnBuscaVendas;
        private System.Windows.Forms.Button btnBuscaItens;
        private System.Windows.Forms.Button btnAdicionaItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUPOM1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUTO1;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECO;
        private System.Windows.Forms.DataGridView dataGridProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCATEGORIA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cBSemCPF;
        private System.Windows.Forms.CheckBox cBSemBairro;
        public System.Windows.Forms.TextBox txtProduto;
        public System.Windows.Forms.TextBox txtCPF;
        public System.Windows.Forms.TextBox txtQuantidade;
        public System.Windows.Forms.Button btnFinaliza;
        public System.Windows.Forms.Button btnCancelamento;
        public System.Windows.Forms.Button btnNovaVenda;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label lblQuantidade;
        public System.Windows.Forms.Button btnBuscaBairros;
        public System.Windows.Forms.Button btnLimpaTudo;
    }
}