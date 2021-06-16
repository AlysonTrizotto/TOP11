
namespace TOP_11_DELIVERY
{
    partial class Categoria
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DataViewCategoria = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewCategoria)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 264);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1130, 304);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DataViewCategoria);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1122, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PESQUISAR";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DataViewCategoria
            // 
            this.DataViewCategoria.AllowUserToAddRows = false;
            this.DataViewCategoria.AllowUserToDeleteRows = false;
            this.DataViewCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DataViewCategoria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DataViewCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DESCRICAO});
            this.DataViewCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataViewCategoria.Location = new System.Drawing.Point(3, 3);
            this.DataViewCategoria.Name = "DataViewCategoria";
            this.DataViewCategoria.ReadOnly = true;
            this.DataViewCategoria.Size = new System.Drawing.Size(1116, 275);
            this.DataViewCategoria.TabIndex = 0;
            this.DataViewCategoria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataViewCategoria_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 90;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESCRICAO.HeaderText = "DESCRIÇÃO";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Controls.Add(this.lblDescricao);
            this.tabPage2.Controls.Add(this.txtDescricao);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1122, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CADASTRO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSair.Location = new System.Drawing.Point(912, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(201, 32);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(609, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(196, 32);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(306, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(196, 32);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadastrar.Location = new System.Drawing.Point(3, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(196, 32);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(6, 25);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(69, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "DESCRIÇÃO";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(86, 22);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(1028, 20);
            this.txtDescricao.TabIndex = 0;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Location = new System.Drawing.Point(90, 15);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(899, 20);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PESQUISAR";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Location = new System.Drawing.Point(992, 8);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(126, 33);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 237);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1116, 38);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 568);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.tabControl1);
            this.Name = "Categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CATEGORIA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Categoria_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewCategoria)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DataViewCategoria;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}