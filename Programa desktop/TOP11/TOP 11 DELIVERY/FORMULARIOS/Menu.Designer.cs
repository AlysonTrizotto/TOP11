
namespace TOP_11_DELIVERY
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BrMenu = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastroCardapio = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastroCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXCLUIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fORMADEPAGAMENTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.rEALIZARVENDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.pESQUISARToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.NumericUpDown();
            this.btnSalvaHora = new System.Windows.Forms.Button();
            this.lblTempo = new System.Windows.Forms.Label();
            this.btnImpressao = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtGridBusca = new System.Windows.Forms.DataGridView();
            this.PED_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ENDERECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CARD_NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORM_PAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TROCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CARD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridBusca)).BeginInit();
            this.SuspendLayout();
            // 
            // BrMenu
            // 
            this.BrMenu.BackColor = System.Drawing.Color.DodgerBlue;
            this.BrMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastro,
            this.menuPedidos,
            this.menuVendas,
            this.menuSair});
            this.BrMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.BrMenu.Location = new System.Drawing.Point(0, 0);
            this.BrMenu.Name = "BrMenu";
            this.BrMenu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.BrMenu.Size = new System.Drawing.Size(1200, 25);
            this.BrMenu.TabIndex = 0;
            this.BrMenu.Text = "MENU";
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTEToolStripMenuItem,
            this.CadastroCardapio,
            this.CadastroCategoria,
            this.eDITARToolStripMenuItem,
            this.eXCLUIRToolStripMenuItem,
            this.fORMADEPAGAMENTOToolStripMenuItem});
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(79, 19);
            this.MenuCadastro.Text = "CADASTRO";
            this.MenuCadastro.Click += new System.EventHandler(this.MenuCadastro_Click);
            // 
            // cLIENTEToolStripMenuItem
            // 
            this.cLIENTEToolStripMenuItem.Name = "cLIENTEToolStripMenuItem";
            this.cLIENTEToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.cLIENTEToolStripMenuItem.Text = "CLIENTE";
            this.cLIENTEToolStripMenuItem.Click += new System.EventHandler(this.cLIENTEToolStripMenuItem_Click);
            // 
            // CadastroCardapio
            // 
            this.CadastroCardapio.Name = "CadastroCardapio";
            this.CadastroCardapio.Size = new System.Drawing.Size(205, 22);
            this.CadastroCardapio.Text = "CARDÁPIO";
            this.CadastroCardapio.Click += new System.EventHandler(this.CadastroCardapio_Click);
            // 
            // CadastroCategoria
            // 
            this.CadastroCategoria.Name = "CadastroCategoria";
            this.CadastroCategoria.Size = new System.Drawing.Size(205, 22);
            this.CadastroCategoria.Text = "CATEGORIA";
            this.CadastroCategoria.Click += new System.EventHandler(this.pESQUISARToolStripMenuItem_Click);
            // 
            // eDITARToolStripMenuItem
            // 
            this.eDITARToolStripMenuItem.Name = "eDITARToolStripMenuItem";
            this.eDITARToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.eDITARToolStripMenuItem.Text = "FUNCIONÁRIO";
            this.eDITARToolStripMenuItem.Click += new System.EventHandler(this.eDITARToolStripMenuItem_Click);
            // 
            // eXCLUIRToolStripMenuItem
            // 
            this.eXCLUIRToolStripMenuItem.Name = "eXCLUIRToolStripMenuItem";
            this.eXCLUIRToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.eXCLUIRToolStripMenuItem.Text = "BAIRRO";
            this.eXCLUIRToolStripMenuItem.Click += new System.EventHandler(this.eXCLUIRToolStripMenuItem_Click);
            // 
            // fORMADEPAGAMENTOToolStripMenuItem
            // 
            this.fORMADEPAGAMENTOToolStripMenuItem.Name = "fORMADEPAGAMENTOToolStripMenuItem";
            this.fORMADEPAGAMENTOToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.fORMADEPAGAMENTOToolStripMenuItem.Text = "FORMA DE PAGAMENTO";
            this.fORMADEPAGAMENTOToolStripMenuItem.Click += new System.EventHandler(this.fORMADEPAGAMENTOToolStripMenuItem_Click);
            // 
            // menuPedidos
            // 
            this.menuPedidos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEALIZARVENDAToolStripMenuItem});
            this.menuPedidos.Name = "menuPedidos";
            this.menuPedidos.Size = new System.Drawing.Size(66, 19);
            this.menuPedidos.Text = "PEDIDOS";
            // 
            // rEALIZARVENDAToolStripMenuItem
            // 
            this.rEALIZARVENDAToolStripMenuItem.Name = "rEALIZARVENDAToolStripMenuItem";
            this.rEALIZARVENDAToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.rEALIZARVENDAToolStripMenuItem.Text = "PESQUISAR";
            this.rEALIZARVENDAToolStripMenuItem.Click += new System.EventHandler(this.rEALIZARVENDAToolStripMenuItem_Click);
            // 
            // menuVendas
            // 
            this.menuVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pESQUISARToolStripMenuItem2});
            this.menuVendas.Name = "menuVendas";
            this.menuVendas.Size = new System.Drawing.Size(78, 19);
            this.menuVendas.Text = "RELATÓRIO";
            // 
            // pESQUISARToolStripMenuItem2
            // 
            this.pESQUISARToolStripMenuItem2.Name = "pESQUISARToolStripMenuItem2";
            this.pESQUISARToolStripMenuItem2.Size = new System.Drawing.Size(118, 22);
            this.pESQUISARToolStripMenuItem2.Text = "VENDAS";
            this.pESQUISARToolStripMenuItem2.Click += new System.EventHandler(this.pESQUISARToolStripMenuItem2_Click);
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(43, 19);
            this.menuSair.Text = "SAIR";
            this.menuSair.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "TEMPO MÉDIO DE PRODUÇÃO";
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Numero.Location = new System.Drawing.Point(274, 60);
            this.Numero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Numero.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(92, 30);
            this.Numero.TabIndex = 2;
            this.Numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Numero.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // btnSalvaHora
            // 
            this.btnSalvaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvaHora.ForeColor = System.Drawing.Color.Black;
            this.btnSalvaHora.Location = new System.Drawing.Point(392, 60);
            this.btnSalvaHora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvaHora.Name = "btnSalvaHora";
            this.btnSalvaHora.Size = new System.Drawing.Size(143, 30);
            this.btnSalvaHora.TabIndex = 3;
            this.btnSalvaHora.Text = "SALVAR HORÁRIO";
            this.btnSalvaHora.UseVisualStyleBackColor = true;
            this.btnSalvaHora.Click += new System.EventHandler(this.btnSalvaHora_Click);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.ForeColor = System.Drawing.Color.Red;
            this.lblTempo.Location = new System.Drawing.Point(46, 96);
            this.lblTempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(193, 20);
            this.lblTempo.TabIndex = 4;
            this.lblTempo.Text = "Tempo atual configurado: ";
            // 
            // btnImpressao
            // 
            this.btnImpressao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpressao.ForeColor = System.Drawing.Color.Black;
            this.btnImpressao.Location = new System.Drawing.Point(26, 323);
            this.btnImpressao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImpressao.Name = "btnImpressao";
            this.btnImpressao.Size = new System.Drawing.Size(143, 30);
            this.btnImpressao.TabIndex = 5;
            this.btnImpressao.Text = "IMPRIMIR";
            this.btnImpressao.UseVisualStyleBackColor = true;
            this.btnImpressao.Click += new System.EventHandler(this.btnImpressao_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dtGridBusca
            // 
            this.dtGridBusca.AllowUserToAddRows = false;
            this.dtGridBusca.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridBusca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridBusca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PED_ID,
            this.C_ENDERECO,
            this.CARD_NOME,
            this.C_NOME,
            this.C_QUANTIDADE,
            this.P_VALOR,
            this.FORM_PAG,
            this.TROCO,
            this.ID_CARD});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridBusca.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridBusca.Location = new System.Drawing.Point(12, 177);
            this.dtGridBusca.Name = "dtGridBusca";
            this.dtGridBusca.ReadOnly = true;
            this.dtGridBusca.Size = new System.Drawing.Size(927, 150);
            this.dtGridBusca.TabIndex = 6;
            // 
            // PED_ID
            // 
            this.PED_ID.HeaderText = "ID";
            this.PED_ID.Name = "PED_ID";
            this.PED_ID.ReadOnly = true;
            // 
            // C_ENDERECO
            // 
            this.C_ENDERECO.HeaderText = "ENDEREÇO";
            this.C_ENDERECO.Name = "C_ENDERECO";
            this.C_ENDERECO.ReadOnly = true;
            // 
            // CARD_NOME
            // 
            this.CARD_NOME.HeaderText = "CARDAPIO";
            this.CARD_NOME.Name = "CARD_NOME";
            this.CARD_NOME.ReadOnly = true;
            // 
            // C_NOME
            // 
            this.C_NOME.HeaderText = "NOME";
            this.C_NOME.Name = "C_NOME";
            this.C_NOME.ReadOnly = true;
            // 
            // C_QUANTIDADE
            // 
            this.C_QUANTIDADE.HeaderText = "QUANTIDADE";
            this.C_QUANTIDADE.Name = "C_QUANTIDADE";
            this.C_QUANTIDADE.ReadOnly = true;
            // 
            // P_VALOR
            // 
            this.P_VALOR.HeaderText = "VALOR";
            this.P_VALOR.Name = "P_VALOR";
            this.P_VALOR.ReadOnly = true;
            // 
            // FORM_PAG
            // 
            this.FORM_PAG.HeaderText = "FORMA DE PAGAMENTO";
            this.FORM_PAG.Name = "FORM_PAG";
            this.FORM_PAG.ReadOnly = true;
            // 
            // TROCO
            // 
            this.TROCO.HeaderText = "TROCO";
            this.TROCO.Name = "TROCO";
            this.TROCO.ReadOnly = true;
            // 
            // ID_CARD
            // 
            this.ID_CARD.HeaderText = "ID_CARDAPIO";
            this.ID_CARD.Name = "ID_CARD";
            this.ID_CARD.ReadOnly = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dtGridBusca);
            this.Controls.Add(this.btnImpressao);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.btnSalvaHora);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.MainMenuStrip = this.BrMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Shown += new System.EventHandler(this.Menu_Shown);
            this.BrMenu.ResumeLayout(false);
            this.BrMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridBusca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem CadastroCardapio;
        private System.Windows.Forms.ToolStripMenuItem CadastroCategoria;
        private System.Windows.Forms.ToolStripMenuItem rEALIZARVENDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pESQUISARToolStripMenuItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Numero;
        private System.Windows.Forms.Button btnSalvaHora;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.ToolStripMenuItem eDITARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXCLUIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fORMADEPAGAMENTOToolStripMenuItem;
        private System.Windows.Forms.Button btnImpressao;
        private System.Drawing.Printing.PrintDocument printDocument1;
        public System.Windows.Forms.ToolStripMenuItem MenuCadastro;
        public System.Windows.Forms.ToolStripMenuItem menuPedidos;
        public System.Windows.Forms.ToolStripMenuItem menuVendas;
        public System.Windows.Forms.ToolStripMenuItem menuSair;
        public System.Windows.Forms.MenuStrip BrMenu;
        public System.Windows.Forms.ToolStripMenuItem cLIENTEToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dtGridBusca;
        private System.Windows.Forms.DataGridViewTextBoxColumn PED_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ENDERECO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARD_NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FORM_PAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TROCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CARD;
    }
}