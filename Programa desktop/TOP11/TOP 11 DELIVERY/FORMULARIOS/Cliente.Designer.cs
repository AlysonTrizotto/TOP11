
namespace TOP_11_DELIVERY
{
    partial class Cliente
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridCliente = new System.Windows.Forms.DataGridView();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDERECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPLEMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAIRRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CadCliente = new System.Windows.Forms.TabPage();
            this.btnAtualizaBairro = new System.Windows.Forms.Button();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.GridBairro = new System.Windows.Forms.DataGridView();
            this.id_bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).BeginInit();
            this.CadCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBairro)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PESQUISAR";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Location = new System.Drawing.Point(87, 12);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(935, 20);
            this.txtPesquisa.TabIndex = 5;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Location = new System.Drawing.Point(1028, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 34);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.CadCliente);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 275);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 417);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridCliente);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1192, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PESQUISA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridCliente
            // 
            this.dataGridCliente.AllowUserToAddRows = false;
            this.dataGridCliente.AllowUserToDeleteRows = false;
            this.dataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPF,
            this.NOME,
            this.TELEFONE,
            this.ENDERECO,
            this.COMPLEMENTO,
            this.NUMERO,
            this.CEP,
            this.BAIRRO});
            this.dataGridCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridCliente.Location = new System.Drawing.Point(3, 3);
            this.dataGridCliente.Name = "dataGridCliente";
            this.dataGridCliente.ReadOnly = true;
            this.dataGridCliente.Size = new System.Drawing.Size(1186, 385);
            this.dataGridCliente.TabIndex = 0;
            this.dataGridCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCliente_CellDoubleClick);
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Visible = false;
            // 
            // NOME
            // 
            this.NOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            // 
            // TELEFONE
            // 
            this.TELEFONE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TELEFONE.HeaderText = "TELEFONE";
            this.TELEFONE.Name = "TELEFONE";
            this.TELEFONE.ReadOnly = true;
            // 
            // ENDERECO
            // 
            this.ENDERECO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ENDERECO.HeaderText = "ENDEREÇO";
            this.ENDERECO.Name = "ENDERECO";
            this.ENDERECO.ReadOnly = true;
            // 
            // COMPLEMENTO
            // 
            this.COMPLEMENTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COMPLEMENTO.HeaderText = "COMPLEMENTO";
            this.COMPLEMENTO.Name = "COMPLEMENTO";
            this.COMPLEMENTO.ReadOnly = true;
            // 
            // NUMERO
            // 
            this.NUMERO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NUMERO.HeaderText = "NÚMERO";
            this.NUMERO.Name = "NUMERO";
            this.NUMERO.ReadOnly = true;
            // 
            // CEP
            // 
            this.CEP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            this.CEP.ReadOnly = true;
            // 
            // BAIRRO
            // 
            this.BAIRRO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BAIRRO.HeaderText = "BAIRRO";
            this.BAIRRO.Name = "BAIRRO";
            this.BAIRRO.ReadOnly = true;
            // 
            // CadCliente
            // 
            this.CadCliente.AutoScroll = true;
            this.CadCliente.Controls.Add(this.btnAtualizaBairro);
            this.CadCliente.Controls.Add(this.txtCEP);
            this.CadCliente.Controls.Add(this.label2);
            this.CadCliente.Controls.Add(this.dtpDataNasc);
            this.CadCliente.Controls.Add(this.GridBairro);
            this.CadCliente.Controls.Add(this.txtNum);
            this.CadCliente.Controls.Add(this.txtComp);
            this.CadCliente.Controls.Add(this.txtEnd);
            this.CadCliente.Controls.Add(this.txtTel);
            this.CadCliente.Controls.Add(this.txtNome);
            this.CadCliente.Controls.Add(this.txtCPF);
            this.CadCliente.Controls.Add(this.lblBairro);
            this.CadCliente.Controls.Add(this.label8);
            this.CadCliente.Controls.Add(this.lblNum);
            this.CadCliente.Controls.Add(this.lblComplemento);
            this.CadCliente.Controls.Add(this.lblEndereco);
            this.CadCliente.Controls.Add(this.label4);
            this.CadCliente.Controls.Add(this.lblNome);
            this.CadCliente.Controls.Add(this.lblCPF);
            this.CadCliente.Controls.Add(this.tableLayoutPanel1);
            this.CadCliente.Location = new System.Drawing.Point(4, 22);
            this.CadCliente.Name = "CadCliente";
            this.CadCliente.Padding = new System.Windows.Forms.Padding(3);
            this.CadCliente.Size = new System.Drawing.Size(1192, 391);
            this.CadCliente.TabIndex = 1;
            this.CadCliente.Text = "CADASTRO";
            this.CadCliente.UseVisualStyleBackColor = true;
            // 
            // btnAtualizaBairro
            // 
            this.btnAtualizaBairro.Enabled = false;
            this.btnAtualizaBairro.Location = new System.Drawing.Point(790, 259);
            this.btnAtualizaBairro.Name = "btnAtualizaBairro";
            this.btnAtualizaBairro.Size = new System.Drawing.Size(209, 30);
            this.btnAtualizaBairro.TabIndex = 31;
            this.btnAtualizaBairro.Text = "Atualiza Bairro";
            this.btnAtualizaBairro.UseVisualStyleBackColor = true;
            this.btnAtualizaBairro.Visible = false;
            this.btnAtualizaBairro.Click += new System.EventHandler(this.btnAtualizaBairro_Click);
            // 
            // txtCEP
            // 
            this.txtCEP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCEP.Location = new System.Drawing.Point(107, 233);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(588, 20);
            this.txtCEP.TabIndex = 26;
            this.txtCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCEP_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "CEP";
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(107, 269);
            this.dtpDataNasc.MaxDate = new System.DateTime(2909, 12, 31, 0, 0, 0, 0);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(588, 20);
            this.dtpDataNasc.TabIndex = 28;
            this.dtpDataNasc.Visible = false;
            // 
            // GridBairro
            // 
            this.GridBairro.AllowUserToAddRows = false;
            this.GridBairro.AllowUserToDeleteRows = false;
            this.GridBairro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridBairro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBairro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_bairro,
            this.colunaBairro});
            this.GridBairro.Location = new System.Drawing.Point(790, 20);
            this.GridBairro.Name = "GridBairro";
            this.GridBairro.ReadOnly = true;
            this.GridBairro.Size = new System.Drawing.Size(394, 233);
            this.GridBairro.TabIndex = 27;
            this.GridBairro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridBairro_CellClick);
            // 
            // id_bairro
            // 
            this.id_bairro.HeaderText = "ID";
            this.id_bairro.Name = "id_bairro";
            this.id_bairro.ReadOnly = true;
            this.id_bairro.Visible = false;
            // 
            // colunaBairro
            // 
            this.colunaBairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colunaBairro.HeaderText = "BAIRRO";
            this.colunaBairro.Name = "colunaBairro";
            this.colunaBairro.ReadOnly = true;
            // 
            // txtNum
            // 
            this.txtNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNum.Location = new System.Drawing.Point(107, 197);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(588, 20);
            this.txtNum.TabIndex = 25;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // txtComp
            // 
            this.txtComp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComp.Location = new System.Drawing.Point(107, 162);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(588, 20);
            this.txtComp.TabIndex = 24;
            // 
            // txtEnd
            // 
            this.txtEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnd.Location = new System.Drawing.Point(107, 127);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(588, 20);
            this.txtEnd.TabIndex = 23;
            // 
            // txtTel
            // 
            this.txtTel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTel.Location = new System.Drawing.Point(107, 89);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(588, 20);
            this.txtTel.TabIndex = 22;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(107, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(588, 20);
            this.txtNome.TabIndex = 21;
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCPF.Location = new System.Drawing.Point(107, 20);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(588, 20);
            this.txtCPF.TabIndex = 20;
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_KeyPress);
            // 
            // lblBairro
            // 
            this.lblBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(719, 24);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(48, 13);
            this.lblBairro.TabIndex = 19;
            this.lblBairro.Text = "BAIRRO";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "DATA DE NASC";
            this.label8.Visible = false;
            // 
            // lblNum
            // 
            this.lblNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(46, 200);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(55, 13);
            this.lblNum.TabIndex = 17;
            this.lblNum.Text = "NÚMERO";
            // 
            // lblComplemento
            // 
            this.lblComplemento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(11, 165);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(90, 13);
            this.lblComplemento.TabIndex = 16;
            this.lblComplemento.Text = "COMPLEMENTO";
            // 
            // lblEndereco
            // 
            this.lblEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(34, 130);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(67, 13);
            this.lblEndereco.TabIndex = 15;
            this.lblEndereco.Text = "ENDEREÇO";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "TELEFONE";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(62, 54);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "NOME";
            // 
            // lblCPF
            // 
            this.lblCPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(74, 20);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 12;
            this.lblCPF.Text = "CPF";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1186, 34);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.Location = new System.Drawing.Point(3, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(209, 30);
            this.btnCadastrar.TabIndex = 28;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSair.Location = new System.Drawing.Point(969, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(214, 30);
            this.btnSair.TabIndex = 31;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(647, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(209, 30);
            this.btnExcluir.TabIndex = 30;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(325, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(209, 30);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cliente_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cliente_FormClosed);
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).EndInit();
            this.CadCliente.ResumeLayout(false);
            this.CadCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBairro)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridCliente;
        private System.Windows.Forms.TabPage CadCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.DataGridView GridBairro;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAtualizaBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDERECO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPLEMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAIRRO;
    }
}