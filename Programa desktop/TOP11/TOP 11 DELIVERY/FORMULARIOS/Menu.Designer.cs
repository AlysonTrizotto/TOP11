
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
            this.dtProdutos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CARDÁPIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPed = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPed)).BeginInit();
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
            // dtProdutos
            // 
            this.dtProdutos.AllowUserToAddRows = false;
            this.dtProdutos.AllowUserToDeleteRows = false;
            this.dtProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.QUANTIDADE,
            this.CARDÁPIO,
            this.VALOR});
            this.dtProdutos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtProdutos.Location = new System.Drawing.Point(0, 553);
            this.dtProdutos.Name = "dtProdutos";
            this.dtProdutos.ReadOnly = true;
            this.dtProdutos.Size = new System.Drawing.Size(1200, 139);
            this.dtProdutos.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.HeaderText = "QUANTIDADE";
            this.QUANTIDADE.Name = "QUANTIDADE";
            this.QUANTIDADE.ReadOnly = true;
            this.QUANTIDADE.Width = 80;
            // 
            // CARDÁPIO
            // 
            this.CARDÁPIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CARDÁPIO.HeaderText = "CARDÁPIO";
            this.CARDÁPIO.Name = "CARDÁPIO";
            this.CARDÁPIO.ReadOnly = true;
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            this.VALOR.Width = 80;
            // 
            // dtPed
            // 
            this.dtPed.AllowUserToAddRows = false;
            this.dtPed.AllowUserToDeleteRows = false;
            this.dtPed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dtPed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtPed.Location = new System.Drawing.Point(0, 414);
            this.dtPed.Name = "dtPed";
            this.dtPed.ReadOnly = true;
            this.dtPed.Size = new System.Drawing.Size(1200, 139);
            this.dtPed.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "QUANTIDADE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "CARDÁPIO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "VALOR";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "DATA";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "HORA";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "STATUS";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "TROCO";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.HeaderText = "BAIRRO";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.HeaderText = "CLIENTE";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "FORMA DE PAGAMENTO";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 80;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dtPed);
            this.Controls.Add(this.dtProdutos);
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
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Shown += new System.EventHandler(this.Menu_Shown);
            this.BrMenu.ResumeLayout(false);
            this.BrMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPed)).EndInit();
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
        private System.Windows.Forms.DataGridView dtProdutos;
        private System.Windows.Forms.DataGridView dtPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARDÁPIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
    }
}