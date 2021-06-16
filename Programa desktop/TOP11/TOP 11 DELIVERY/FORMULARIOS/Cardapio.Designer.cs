
namespace TOP_11_DELIVERY
{
    partial class Produtos
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
            this.gbSelciona = new System.Windows.Forms.GroupBox();
            this.rbCategoria = new System.Windows.Forms.RadioButton();
            this.rbProduto = new System.Windows.Forms.RadioButton();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DataViewProduto = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIÇÃO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEXCLUIR = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DataViewCategoria = new System.Windows.Forms.DataGridView();
            this.ID_CAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAT_CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.btnAtualizaCategoria = new System.Windows.Forms.Button();
            this.gbSelciona.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewProduto)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSelciona
            // 
            this.gbSelciona.Controls.Add(this.rbCategoria);
            this.gbSelciona.Controls.Add(this.rbProduto);
            this.gbSelciona.Location = new System.Drawing.Point(4, 3);
            this.gbSelciona.Name = "gbSelciona";
            this.gbSelciona.Size = new System.Drawing.Size(200, 100);
            this.gbSelciona.TabIndex = 0;
            this.gbSelciona.TabStop = false;
            this.gbSelciona.Text = "TIPO DE BUSCA";
            // 
            // rbCategoria
            // 
            this.rbCategoria.AutoSize = true;
            this.rbCategoria.Location = new System.Drawing.Point(7, 52);
            this.rbCategoria.Name = "rbCategoria";
            this.rbCategoria.Size = new System.Drawing.Size(87, 17);
            this.rbCategoria.TabIndex = 1;
            this.rbCategoria.Text = "CATEGORIA";
            this.rbCategoria.UseVisualStyleBackColor = true;
            // 
            // rbProduto
            // 
            this.rbProduto.AutoSize = true;
            this.rbProduto.Checked = true;
            this.rbProduto.Location = new System.Drawing.Point(7, 29);
            this.rbProduto.Name = "rbProduto";
            this.rbProduto.Size = new System.Drawing.Size(79, 17);
            this.rbProduto.TabIndex = 0;
            this.rbProduto.TabStop = true;
            this.rbProduto.Text = "PRODUTO";
            this.rbProduto.UseVisualStyleBackColor = true;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisa.Location = new System.Drawing.Point(1089, 39);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(112, 33);
            this.btnPesquisa.TabIndex = 1;
            this.btnPesquisa.Text = "PESQUISAR";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Location = new System.Drawing.Point(285, 43);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(798, 20);
            this.txtPesquisa.TabIndex = 2;
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(210, 46);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(69, 13);
            this.lblPesquisa.TabIndex = 3;
            this.lblPesquisa.Text = "PESQUISAR";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 151);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1205, 417);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DataViewProduto);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1197, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PESQUISA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DataViewProduto
            // 
            this.DataViewProduto.AllowUserToAddRows = false;
            this.DataViewProduto.AllowUserToDeleteRows = false;
            this.DataViewProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PRODUTO,
            this.CATEGORIA,
            this.DESCRIÇÃO,
            this.VALOR});
            this.DataViewProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataViewProduto.Location = new System.Drawing.Point(3, 3);
            this.DataViewProduto.Name = "DataViewProduto";
            this.DataViewProduto.ReadOnly = true;
            this.DataViewProduto.Size = new System.Drawing.Size(1191, 385);
            this.DataViewProduto.TabIndex = 0;
            this.DataViewProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataViewProduto_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // PRODUTO
            // 
            this.PRODUTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRODUTO.HeaderText = "PRODUTO";
            this.PRODUTO.Name = "PRODUTO";
            this.PRODUTO.ReadOnly = true;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.ReadOnly = true;
            // 
            // DESCRIÇÃO
            // 
            this.DESCRIÇÃO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESCRIÇÃO.HeaderText = "DESCRIÇÃO";
            this.DESCRIÇÃO.Name = "DESCRIÇÃO";
            this.DESCRIÇÃO.ReadOnly = true;
            // 
            // VALOR
            // 
            this.VALOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Controls.Add(this.lblAviso);
            this.tabPage2.Controls.Add(this.txtPreco);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtProduto);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1197, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CADASTRO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel2.Controls.Add(this.btnCadastrar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSair, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEXCLUIR, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEditar, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 351);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1191, 37);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadastrar.Location = new System.Drawing.Point(3, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(210, 31);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSair.Location = new System.Drawing.Point(975, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(213, 31);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEXCLUIR
            // 
            this.btnEXCLUIR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEXCLUIR.Enabled = false;
            this.btnEXCLUIR.Location = new System.Drawing.Point(651, 3);
            this.btnEXCLUIR.Name = "btnEXCLUIR";
            this.btnEXCLUIR.Size = new System.Drawing.Size(210, 31);
            this.btnEXCLUIR.TabIndex = 3;
            this.btnEXCLUIR.Text = "EXCLUIR";
            this.btnEXCLUIR.UseVisualStyleBackColor = true;
            this.btnEXCLUIR.Click += new System.EventHandler(this.btnEXCLUIR_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(327, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(210, 31);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.rtbDescricao, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.DataViewCategoria, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 101);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1183, 244);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDescricao.Location = new System.Drawing.Point(712, 3);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.Size = new System.Drawing.Size(468, 238);
            this.rtbDescricao.TabIndex = 7;
            this.rtbDescricao.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(594, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 244);
            this.label4.TabIndex = 11;
            this.label4.Text = "DESCRIÇÃO";
            // 
            // DataViewCategoria
            // 
            this.DataViewCategoria.AllowUserToAddRows = false;
            this.DataViewCategoria.AllowUserToDeleteRows = false;
            this.DataViewCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CAT,
            this.CAT_CATEGORIA});
            this.DataViewCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataViewCategoria.Location = new System.Drawing.Point(121, 3);
            this.DataViewCategoria.Name = "DataViewCategoria";
            this.DataViewCategoria.ReadOnly = true;
            this.DataViewCategoria.Size = new System.Drawing.Size(467, 238);
            this.DataViewCategoria.TabIndex = 12;
            this.DataViewCategoria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataViewCategoria_CellDoubleClick);
            // 
            // ID_CAT
            // 
            this.ID_CAT.HeaderText = "ID";
            this.ID_CAT.Name = "ID_CAT";
            this.ID_CAT.ReadOnly = true;
            this.ID_CAT.Visible = false;
            // 
            // CAT_CATEGORIA
            // 
            this.CAT_CATEGORIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CAT_CATEGORIA.HeaderText = "CATEGORIA";
            this.CAT_CATEGORIA.Name = "CAT_CATEGORIA";
            this.CAT_CATEGORIA.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "CATEGORIA";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(72, 75);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(154, 13);
            this.lblAviso.TabIndex = 5;
            this.lblAviso.Text = "USE APENAS VÍRGULAS \" , \"";
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreco.Location = new System.Drawing.Point(75, 52);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(1114, 20);
            this.txtPreco.TabIndex = 13;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "PREÇO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "PRODUTO";
            // 
            // txtProduto
            // 
            this.txtProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Location = new System.Drawing.Point(75, 18);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(1114, 20);
            this.txtProduto.TabIndex = 5;
            // 
            // btnAtualizaCategoria
            // 
            this.btnAtualizaCategoria.Location = new System.Drawing.Point(415, 115);
            this.btnAtualizaCategoria.Name = "btnAtualizaCategoria";
            this.btnAtualizaCategoria.Size = new System.Drawing.Size(209, 30);
            this.btnAtualizaCategoria.TabIndex = 32;
            this.btnAtualizaCategoria.Text = "Atualiza Categoria";
            this.btnAtualizaCategoria.UseVisualStyleBackColor = true;
            this.btnAtualizaCategoria.Visible = false;
            this.btnAtualizaCategoria.Click += new System.EventHandler(this.btnAtualizaCategoria_Click);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 568);
            this.Controls.Add(this.btnAtualizaCategoria);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.gbSelciona);
            this.Name = "Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CARDÁPIO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Produtos_FormClosed);
            this.Load += new System.EventHandler(this.Produtos_Load);
            this.gbSelciona.ResumeLayout(false);
            this.gbSelciona.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewProduto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSelciona;
        private System.Windows.Forms.RadioButton rbCategoria;
        private System.Windows.Forms.RadioButton rbProduto;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DataViewProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEXCLUIR;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIÇÃO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.DataGridView DataViewCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAT_CATEGORIA;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAtualizaCategoria;
    }
}