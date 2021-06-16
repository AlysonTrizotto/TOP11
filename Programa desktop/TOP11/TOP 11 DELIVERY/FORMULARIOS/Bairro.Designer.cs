
namespace TOP_11_DELIVERY
{
    partial class Bairro
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridBairro = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAIRRO_NOVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAXA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblBairo = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.Preco = new System.Windows.Forms.NumericUpDown();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBairro)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Preco)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PESQUISAR";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Location = new System.Drawing.Point(85, 14);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(935, 20);
            this.txtPesquisa.TabIndex = 2;
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 151);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1130, 417);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridBairro);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1122, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PESQUISA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridBairro
            // 
            this.dataGridBairro.AllowUserToAddRows = false;
            this.dataGridBairro.AllowUserToDeleteRows = false;
            this.dataGridBairro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBairro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.BAIRRO_NOVO,
            this.TAXA,
            this.CIDADE});
            this.dataGridBairro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridBairro.Location = new System.Drawing.Point(3, 3);
            this.dataGridBairro.Name = "dataGridBairro";
            this.dataGridBairro.ReadOnly = true;
            this.dataGridBairro.Size = new System.Drawing.Size(1116, 385);
            this.dataGridBairro.TabIndex = 0;
            this.dataGridBairro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataViewBairro_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // BAIRRO_NOVO
            // 
            this.BAIRRO_NOVO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BAIRRO_NOVO.HeaderText = "BAIRRO";
            this.BAIRRO_NOVO.Name = "BAIRRO_NOVO";
            this.BAIRRO_NOVO.ReadOnly = true;
            // 
            // TAXA
            // 
            this.TAXA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TAXA.HeaderText = "TAXA";
            this.TAXA.Name = "TAXA";
            this.TAXA.ReadOnly = true;
            // 
            // CIDADE
            // 
            this.CIDADE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CIDADE.HeaderText = "CIDADE";
            this.CIDADE.Name = "CIDADE";
            this.CIDADE.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Controls.Add(this.lblBairo);
            this.tabPage2.Controls.Add(this.lblCidade);
            this.tabPage2.Controls.Add(this.lblPreco);
            this.tabPage2.Controls.Add(this.txtBairro);
            this.tabPage2.Controls.Add(this.Preco);
            this.tabPage2.Controls.Add(this.cbCidade);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1122, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CADASTRO";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.Controls.Add(this.btnCadastrar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSair, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExcluir, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEditar, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 354);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1116, 34);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadastrar.Location = new System.Drawing.Point(3, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(196, 30);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSair.Location = new System.Drawing.Point(912, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(201, 30);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(306, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(196, 30);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(609, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(196, 30);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblBairo
            // 
            this.lblBairo.AutoSize = true;
            this.lblBairo.Location = new System.Drawing.Point(8, 6);
            this.lblBairo.Name = "lblBairo";
            this.lblBairo.Size = new System.Drawing.Size(48, 13);
            this.lblBairo.TabIndex = 5;
            this.lblBairo.Text = "BAIRRO";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(9, 32);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(47, 13);
            this.lblCidade.TabIndex = 7;
            this.lblCidade.Text = "CIDADE";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(12, 58);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(44, 13);
            this.lblPreco.TabIndex = 6;
            this.lblPreco.Text = "PREÇO";
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(62, 3);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(1057, 20);
            this.txtBairro.TabIndex = 10;
            // 
            // Preco
            // 
            this.Preco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Preco.Location = new System.Drawing.Point(62, 56);
            this.Preco.Name = "Preco";
            this.Preco.Size = new System.Drawing.Size(1057, 20);
            this.Preco.TabIndex = 9;
            // 
            // cbCidade
            // 
            this.cbCidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Items.AddRange(new object[] {
            "CURITIBA",
            "SÃO JOSÉ DOS PINHAIS",
            "PIRAQUARA",
            "COLOMBO"});
            this.cbCidade.Location = new System.Drawing.Point(62, 29);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(1057, 21);
            this.cbCidade.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Location = new System.Drawing.Point(1026, 6);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 34);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // Bairro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "Bairro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bairro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bairro_FormClosed);
            this.Load += new System.EventHandler(this.Bairro_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBairro)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Preco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridBairro;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblBairo;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.NumericUpDown Preco;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAIRRO_NOVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAXA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDADE;
    }
}