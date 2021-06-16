
namespace TOP_11_DELIVERY
{
    partial class Funcionarios
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
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DataViewFuncionarios = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SENHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACESSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblConfirma = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblAcesso = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtConfirma = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbAcesso = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewFuncionarios)).BeginInit();
            this.TabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisa.Location = new System.Drawing.Point(1090, 12);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(92, 30);
            this.btnPesquisa.TabIndex = 0;
            this.btnPesquisa.Text = "PESQUISAR";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FUNCIONARIO";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Location = new System.Drawing.Point(99, 16);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(985, 20);
            this.txtPesquisa.TabIndex = 2;
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.TabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 188);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1194, 380);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DataViewFuncionarios);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1186, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PESQUISAR";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DataViewFuncionarios
            // 
            this.DataViewFuncionarios.AllowUserToAddRows = false;
            this.DataViewFuncionarios.AllowUserToDeleteRows = false;
            this.DataViewFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DataViewFuncionarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DataViewFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOME,
            this.SENHA,
            this.ACESSO});
            this.DataViewFuncionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataViewFuncionarios.Location = new System.Drawing.Point(3, 3);
            this.DataViewFuncionarios.Name = "DataViewFuncionarios";
            this.DataViewFuncionarios.ReadOnly = true;
            this.DataViewFuncionarios.Size = new System.Drawing.Size(1180, 348);
            this.DataViewFuncionarios.TabIndex = 0;
            this.DataViewFuncionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataViewFuncionarios_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 90;
            // 
            // NOME
            // 
            this.NOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            // 
            // SENHA
            // 
            this.SENHA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SENHA.HeaderText = "SENHA";
            this.SENHA.Name = "SENHA";
            this.SENHA.ReadOnly = true;
            this.SENHA.Visible = false;
            // 
            // ACESSO
            // 
            this.ACESSO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ACESSO.HeaderText = "ACESSO";
            this.ACESSO.Name = "ACESSO";
            this.ACESSO.ReadOnly = true;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.tableLayoutPanel1);
            this.TabPage2.Controls.Add(this.lblConfirma);
            this.TabPage2.Controls.Add(this.lblSenha);
            this.TabPage2.Controls.Add(this.lblAcesso);
            this.TabPage2.Controls.Add(this.lblNome);
            this.TabPage2.Controls.Add(this.txtConfirma);
            this.TabPage2.Controls.Add(this.txtSenha);
            this.TabPage2.Controls.Add(this.txtNome);
            this.TabPage2.Controls.Add(this.cbAcesso);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(1186, 354);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "CADASTRO";
            this.TabPage2.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 311);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1180, 40);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadastrar.Location = new System.Drawing.Point(3, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(208, 34);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(324, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(208, 34);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(645, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(208, 34);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSair.Location = new System.Drawing.Point(966, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(211, 34);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblConfirma
            // 
            this.lblConfirma.AutoSize = true;
            this.lblConfirma.Location = new System.Drawing.Point(10, 103);
            this.lblConfirma.Name = "lblConfirma";
            this.lblConfirma.Size = new System.Drawing.Size(111, 13);
            this.lblConfirma.TabIndex = 11;
            this.lblConfirma.Text = "CONFIRMAR SENHA";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(77, 77);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(44, 13);
            this.lblSenha.TabIndex = 10;
            this.lblSenha.Text = "SENHA";
            // 
            // lblAcesso
            // 
            this.lblAcesso.AutoSize = true;
            this.lblAcesso.Location = new System.Drawing.Point(75, 46);
            this.lblAcesso.Name = "lblAcesso";
            this.lblAcesso.Size = new System.Drawing.Size(50, 13);
            this.lblAcesso.TabIndex = 9;
            this.lblAcesso.Text = "ACESSO";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(82, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "NOME";
            // 
            // txtConfirma
            // 
            this.txtConfirma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirma.Location = new System.Drawing.Point(127, 96);
            this.txtConfirma.Name = "txtConfirma";
            this.txtConfirma.Size = new System.Drawing.Size(1053, 20);
            this.txtConfirma.TabIndex = 7;
            this.txtConfirma.UseSystemPasswordChar = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.Location = new System.Drawing.Point(127, 70);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(1053, 20);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(127, 17);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(1053, 20);
            this.txtNome.TabIndex = 5;
            // 
            // cbAcesso
            // 
            this.cbAcesso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAcesso.FormattingEnabled = true;
            this.cbAcesso.Items.AddRange(new object[] {
            "TOTAL",
            "LIMITADO"});
            this.cbAcesso.Location = new System.Drawing.Point(127, 43);
            this.cbAcesso.Name = "cbAcesso";
            this.cbAcesso.Size = new System.Drawing.Size(1053, 21);
            this.cbAcesso.TabIndex = 4;
            this.cbAcesso.Tag = "1";
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 568);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisa);
            this.Name = "Funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Funcionarios_FormClosed);
            this.Load += new System.EventHandler(this.Funcionarios_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewFuncionarios)).EndInit();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage TabPage2;
        private System.Windows.Forms.DataGridView DataViewFuncionarios;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cbAcesso;
        private System.Windows.Forms.Label lblConfirma;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblAcesso;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtConfirma;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SENHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACESSO;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}