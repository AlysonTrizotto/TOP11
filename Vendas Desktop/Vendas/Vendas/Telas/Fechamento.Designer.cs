
namespace Vendas
{
    partial class Fechamento
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
            this.CANCELAR = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FINALIZAR = new System.Windows.Forms.Button();
            this.Mostra = new System.Windows.Forms.Label();
            this.txtFechamento = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CANCELAR
            // 
            this.CANCELAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CANCELAR.Location = new System.Drawing.Point(3, 3);
            this.CANCELAR.Name = "CANCELAR";
            this.CANCELAR.Size = new System.Drawing.Size(260, 94);
            this.CANCELAR.TabIndex = 0;
            this.CANCELAR.Text = "CANCELAR";
            this.CANCELAR.UseVisualStyleBackColor = true;
            this.CANCELAR.Click += new System.EventHandler(this.CANCELAR_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.CANCELAR, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FINALIZAR, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 350);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // FINALIZAR
            // 
            this.FINALIZAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FINALIZAR.Location = new System.Drawing.Point(535, 3);
            this.FINALIZAR.Name = "FINALIZAR";
            this.FINALIZAR.Size = new System.Drawing.Size(262, 94);
            this.FINALIZAR.TabIndex = 1;
            this.FINALIZAR.Text = "FINALIZAR";
            this.FINALIZAR.UseVisualStyleBackColor = true;
            this.FINALIZAR.Click += new System.EventHandler(this.FINALIZAR_Click);
            // 
            // Mostra
            // 
            this.Mostra.AutoSize = true;
            this.Mostra.Location = new System.Drawing.Point(59, 68);
            this.Mostra.Name = "Mostra";
            this.Mostra.Size = new System.Drawing.Size(35, 13);
            this.Mostra.TabIndex = 2;
            this.Mostra.Text = "label1";
            // 
            // txtFechamento
            // 
            this.txtFechamento.Location = new System.Drawing.Point(113, 60);
            this.txtFechamento.Name = "txtFechamento";
            this.txtFechamento.Size = new System.Drawing.Size(100, 20);
            this.txtFechamento.TabIndex = 3;
            // 
            // Fechamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFechamento);
            this.Controls.Add(this.Mostra);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fechamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fechamento_Load);
            this.Shown += new System.EventHandler(this.Fechamento_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CANCELAR;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button FINALIZAR;
        private System.Windows.Forms.Label Mostra;
        public System.Windows.Forms.TextBox txtFechamento;
    }
}