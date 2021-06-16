
namespace TOP_11_DELIVERY
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(210, 407);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(210, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 407);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(213, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 407);
            this.panel1.TabIndex = 3;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(69, 349);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(31, 121);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(141, 28);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(32, 46);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(40, 13);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "LOGIN";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(28, 72);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(44, 13);
            this.lblSenha.TabIndex = 7;
            this.lblSenha.Text = "SENHA";
            // 
            // txtLogin
            // 
            this.txtLogin.AcceptsTab = true;
            this.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogin.Location = new System.Drawing.Point(72, 43);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(132, 20);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // txtSenha
            // 
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSenha.Location = new System.Drawing.Point(72, 69);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(132, 20);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 407);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
    }
}

