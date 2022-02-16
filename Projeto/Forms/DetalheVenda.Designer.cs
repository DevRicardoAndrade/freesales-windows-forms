
namespace Projeto.Forms
{
    partial class DetalheVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalheVenda));
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new Projeto.Controllers.txtValor();
            this.lblValorTotal = new System.Windows.Forms.LinkLabel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtDataVenda = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.id_VendaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qt_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_TotalProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(3, 46);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(232, 23);
            this.txtCliente.TabIndex = 579;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(574, 104);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(88, 23);
            this.txtValorTotal.TabIndex = 578;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(574, 86);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(64, 15);
            this.lblValorTotal.TabIndex = 577;
            this.lblValorTotal.TabStop = true;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.Location = new System.Drawing.Point(3, 29);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 14);
            this.lblCliente.TabIndex = 580;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.Enabled = false;
            this.txtDataVenda.Location = new System.Drawing.Point(468, 46);
            this.txtDataVenda.Mask = "00/00/0000";
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.Size = new System.Drawing.Size(100, 23);
            this.txtDataVenda.TabIndex = 581;
            this.txtDataVenda.ValidatingType = typeof(System.DateTime);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblData.Location = new System.Drawing.Point(468, 29);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(82, 14);
            this.lblData.TabIndex = 582;
            this.lblData.Text = "Data da venda:";
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProdutos.Location = new System.Drawing.Point(3, 69);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(53, 14);
            this.lblProdutos.TabIndex = 583;
            this.lblProdutos.Text = "Produtos:";
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(601, 189);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(61, 60);
            this.btnSair.TabIndex = 584;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToAddRows = false;
            this.dataGridViewProdutos.AllowUserToDeleteRows = false;
            this.dataGridViewProdutos.AllowUserToOrderColumns = true;
            this.dataGridViewProdutos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_VendaProduto,
            this.ds_Cliente,
            this.id_Produto,
            this.ds_Produto,
            this.qt_Produto,
            this.vl_Produto,
            this.vl_TotalProduto});
            this.dataGridViewProdutos.Location = new System.Drawing.Point(3, 86);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.RowHeadersWidth = 51;
            this.dataGridViewProdutos.RowTemplate.Height = 25;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(565, 141);
            this.dataGridViewProdutos.TabIndex = 585;
            // 
            // id_VendaProduto
            // 
            this.id_VendaProduto.DataPropertyName = "id_VendaProduto";
            this.id_VendaProduto.HeaderText = "id_VendaProduto";
            this.id_VendaProduto.MinimumWidth = 6;
            this.id_VendaProduto.Name = "id_VendaProduto";
            this.id_VendaProduto.ReadOnly = true;
            this.id_VendaProduto.Visible = false;
            this.id_VendaProduto.Width = 125;
            // 
            // ds_Cliente
            // 
            this.ds_Cliente.DataPropertyName = "ds_Cliente";
            this.ds_Cliente.HeaderText = "Cliente";
            this.ds_Cliente.MinimumWidth = 6;
            this.ds_Cliente.Name = "ds_Cliente";
            this.ds_Cliente.ReadOnly = true;
            this.ds_Cliente.Width = 122;
            // 
            // id_Produto
            // 
            this.id_Produto.DataPropertyName = "id_Produto";
            this.id_Produto.HeaderText = "id_Produto";
            this.id_Produto.MinimumWidth = 6;
            this.id_Produto.Name = "id_Produto";
            this.id_Produto.ReadOnly = true;
            this.id_Produto.Visible = false;
            this.id_Produto.Width = 125;
            // 
            // ds_Produto
            // 
            this.ds_Produto.DataPropertyName = "ds_Produto";
            this.ds_Produto.HeaderText = "Produto";
            this.ds_Produto.MinimumWidth = 6;
            this.ds_Produto.Name = "ds_Produto";
            this.ds_Produto.ReadOnly = true;
            this.ds_Produto.Width = 125;
            // 
            // qt_Produto
            // 
            this.qt_Produto.DataPropertyName = "qt_Produto";
            this.qt_Produto.HeaderText = "Quantidade";
            this.qt_Produto.MinimumWidth = 6;
            this.qt_Produto.Name = "qt_Produto";
            this.qt_Produto.ReadOnly = true;
            this.qt_Produto.Width = 125;
            // 
            // vl_Produto
            // 
            this.vl_Produto.DataPropertyName = "vl_Produto";
            this.vl_Produto.HeaderText = "Valor unitário";
            this.vl_Produto.MinimumWidth = 6;
            this.vl_Produto.Name = "vl_Produto";
            this.vl_Produto.ReadOnly = true;
            this.vl_Produto.Width = 125;
            // 
            // vl_TotalProduto
            // 
            this.vl_TotalProduto.DataPropertyName = "vl_TotalProduto";
            this.vl_TotalProduto.HeaderText = "Valor Produtos";
            this.vl_TotalProduto.MinimumWidth = 6;
            this.vl_TotalProduto.Name = "vl_TotalProduto";
            this.vl_TotalProduto.ReadOnly = true;
            this.vl_TotalProduto.Width = 125;
            // 
            // DetalheVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(674, 258);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblProdutos);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtDataVenda);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lblValorTotal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(690, 297);
            this.MinimumSize = new System.Drawing.Size(690, 297);
            this.Name = "DetalheVenda";
            this.Text = "DetalheVenda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DetalheVenda_FormClosing);
            this.Load += new System.EventHandler(this.DetalheVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCliente;
        private Projeto.Controllers.txtValor txtValorTotal;
        private System.Windows.Forms.LinkLabel lblValorTotal;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.MaskedTextBox txtDataVenda;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_VendaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn qt_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_TotalProduto;
    }
}