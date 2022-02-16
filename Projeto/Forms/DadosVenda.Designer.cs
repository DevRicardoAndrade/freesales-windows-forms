
namespace Projeto.Forms
{
    partial class DadosVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DadosVenda));
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.id_VendaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qt_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_TotalProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.txtQuantidade = new Projeto.Controllers.txtNumero();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.LinkLabel();
            this.txtValorTotal = new Projeto.Controllers.txtValor();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblProdutosVenda = new System.Windows.Forms.Label();
            this.txtQuantidadeTotal = new Projeto.Controllers.txtNumero();
            this.lblQuantidadeTotal = new System.Windows.Forms.LinkLabel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(12, 530);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(61, 60);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(354, 530);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(61, 60);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(696, 530);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(61, 60);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToAddRows = false;
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
            this.dataGridViewProdutos.Location = new System.Drawing.Point(12, 338);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.RowHeadersWidth = 51;
            this.dataGridViewProdutos.RowTemplate.Height = 25;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(745, 172);
            this.dataGridViewProdutos.TabIndex = 568;
            this.dataGridViewProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellContentClick);
            this.dataGridViewProdutos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellContentDoubleClick);
            this.dataGridViewProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellDoubleClick);
            this.dataGridViewProdutos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewProdutos_RowsRemoved);
            this.dataGridViewProdutos.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewProdutos_UserDeletedRow);
            this.dataGridViewProdutos.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewProdutos_UserDeletingRow);
            this.dataGridViewProdutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridViewProdutos_KeyPress);
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
            this.ds_Cliente.Width = 230;
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
            this.ds_Produto.Width = 152;
            // 
            // qt_Produto
            // 
            this.qt_Produto.DataPropertyName = "qt_Produto";
            this.qt_Produto.HeaderText = "Quantidade";
            this.qt_Produto.MinimumWidth = 6;
            this.qt_Produto.Name = "qt_Produto";
            this.qt_Produto.ReadOnly = true;
            this.qt_Produto.Width = 85;
            // 
            // vl_Produto
            // 
            this.vl_Produto.DataPropertyName = "vl_Produto";
            this.vl_Produto.HeaderText = "Valor unitário";
            this.vl_Produto.MinimumWidth = 6;
            this.vl_Produto.Name = "vl_Produto";
            this.vl_Produto.ReadOnly = true;
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
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdicionar.Location = new System.Drawing.Point(409, 279);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(79, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cboProduto
            // 
            this.cboProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Location = new System.Drawing.Point(12, 280);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(232, 23);
            this.cboProduto.TabIndex = 2;
            this.cboProduto.SelectedIndexChanged += new System.EventHandler(this.cboProduto_SelectedIndexChanged);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(289, 280);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(63, 23);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantidade.Location = new System.Drawing.Point(289, 263);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(67, 14);
            this.lblQuantidade.TabIndex = 572;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProduto.Location = new System.Drawing.Point(8, 263);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(48, 14);
            this.lblProduto.TabIndex = 573;
            this.lblProduto.Text = "Produto:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(604, 309);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(64, 15);
            this.lblValorTotal.TabIndex = 7;
            this.lblValorTotal.TabStop = true;
            this.lblValorTotal.Text = "Valor Total:";
            this.lblValorTotal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(674, 306);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(83, 23);
            this.txtValorTotal.TabIndex = 8;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.Location = new System.Drawing.Point(12, 169);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 14);
            this.lblCliente.TabIndex = 577;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblProdutosVenda
            // 
            this.lblProdutosVenda.AutoSize = true;
            this.lblProdutosVenda.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProdutosVenda.Location = new System.Drawing.Point(12, 321);
            this.lblProdutosVenda.Name = "lblProdutosVenda";
            this.lblProdutosVenda.Size = new System.Drawing.Size(101, 14);
            this.lblProdutosVenda.TabIndex = 578;
            this.lblProdutosVenda.Text = "Produtos da venda:";
            // 
            // txtQuantidadeTotal
            // 
            this.txtQuantidadeTotal.Enabled = false;
            this.txtQuantidadeTotal.Location = new System.Drawing.Point(515, 306);
            this.txtQuantidadeTotal.Name = "txtQuantidadeTotal";
            this.txtQuantidadeTotal.Size = new System.Drawing.Size(83, 23);
            this.txtQuantidadeTotal.TabIndex = 6;
            this.txtQuantidadeTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuantidadeTotal
            // 
            this.lblQuantidadeTotal.AutoSize = true;
            this.lblQuantidadeTotal.Location = new System.Drawing.Point(409, 309);
            this.lblQuantidadeTotal.Name = "lblQuantidadeTotal";
            this.lblQuantidadeTotal.Size = new System.Drawing.Size(100, 15);
            this.lblQuantidadeTotal.TabIndex = 5;
            this.lblQuantidadeTotal.TabStop = true;
            this.lblQuantidadeTotal.Text = "Quantidade Total:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.AutoSize = true;
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtualizar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAtualizar.Location = new System.Drawing.Point(354, 530);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(61, 60);
            this.btnAtualizar.TabIndex = 10;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Visible = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(12, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(633, 91);
            this.lblTitulo.TabIndex = 579;
            this.lblTitulo.Text = "Seja Bem-Vindo!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(631, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 580;
            this.pictureBox1.TabStop = false;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(12, 187);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(281, 23);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.DoubleClick += new System.EventHandler(this.txtCliente_DoubleClick_1);
            this.txtCliente.Enter += new System.EventHandler(this.txtCliente_Enter);
            this.txtCliente.Leave += new System.EventHandler(this.txtCliente_Leave);
            // 
            // DadosVenda
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(781, 602);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblQuantidadeTotal);
            this.Controls.Add(this.txtQuantidadeTotal);
            this.Controls.Add(this.lblProdutosVenda);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.cboProduto);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(607, 437);
            this.Name = "DadosVenda";
            this.Text = "DadosVenda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DadosVenda_FormClosing);
            this.Load += new System.EventHandler(this.DadosVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox cboProduto;
        private Projeto.Controllers.txtNumero txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.LinkLabel lblValorTotal;
        private Projeto.Controllers.txtValor txtValorTotal;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblProdutosVenda;
        private Controllers.txtNumero txtQuantidadeTotal;
        private System.Windows.Forms.LinkLabel lblQuantidadeTotal;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_VendaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn qt_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_TotalProduto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCliente;
    }
}