
namespace Projeto
{
    partial class Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            this.ctnProduto = new System.Windows.Forms.GroupBox();
            this.txtQuantidade = new Projeto.Controllers.txtNumero();
            this.txtValor = new Projeto.Controllers.txtValor();
            this.chkInativo = new System.Windows.Forms.CheckBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnTipoProduto = new System.Windows.Forms.Button();
            this.lblTipoProduto = new System.Windows.Forms.Label();
            this.cboTipoProduto = new System.Windows.Forms.ComboBox();
            this.lblDescricaoProduto = new System.Windows.Forms.Label();
            this.lblQuatidade = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.ctnProduto2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.id_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qt_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_TipoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_Inativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.ctnProduto.SuspendLayout();
            this.ctnProduto2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // ctnProduto
            // 
            this.ctnProduto.Controls.Add(this.txtQuantidade);
            this.ctnProduto.Controls.Add(this.txtValor);
            this.ctnProduto.Controls.Add(this.chkInativo);
            this.ctnProduto.Controls.Add(this.lblValor);
            this.ctnProduto.Controls.Add(this.btnTipoProduto);
            this.ctnProduto.Controls.Add(this.lblTipoProduto);
            this.ctnProduto.Controls.Add(this.cboTipoProduto);
            this.ctnProduto.Controls.Add(this.lblDescricaoProduto);
            this.ctnProduto.Controls.Add(this.lblQuatidade);
            this.ctnProduto.Controls.Add(this.txtNome);
            this.ctnProduto.Location = new System.Drawing.Point(12, 12);
            this.ctnProduto.Name = "ctnProduto";
            this.ctnProduto.Size = new System.Drawing.Size(357, 124);
            this.ctnProduto.TabIndex = 19;
            this.ctnProduto.TabStop = false;
            this.ctnProduto.Text = "Dados do produto";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(30, 88);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(67, 23);
            this.txtQuantidade.TabIndex = 1;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(103, 88);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(91, 23);
            this.txtValor.TabIndex = 2;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkInativo
            // 
            this.chkInativo.AutoSize = true;
            this.chkInativo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkInativo.ForeColor = System.Drawing.Color.Red;
            this.chkInativo.Location = new System.Drawing.Point(274, 15);
            this.chkInativo.Name = "chkInativo";
            this.chkInativo.Size = new System.Drawing.Size(60, 18);
            this.chkInativo.TabIndex = 4;
            this.chkInativo.Text = "Inativo";
            this.chkInativo.UseVisualStyleBackColor = true;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValor.Location = new System.Drawing.Point(103, 71);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(91, 14);
            this.lblValor.TabIndex = 17;
            this.lblValor.Text = "Valor do Produto:";
            // 
            // btnTipoProduto
            // 
            this.btnTipoProduto.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTipoProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnTipoProduto.Image")));
            this.btnTipoProduto.Location = new System.Drawing.Point(303, 64);
            this.btnTipoProduto.Name = "btnTipoProduto";
            this.btnTipoProduto.Size = new System.Drawing.Size(31, 23);
            this.btnTipoProduto.TabIndex = 13;
            this.btnTipoProduto.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTipoProduto.UseVisualStyleBackColor = false;
            this.btnTipoProduto.Click += new System.EventHandler(this.btnTipoProduto_Click);
            // 
            // lblTipoProduto
            // 
            this.lblTipoProduto.AutoSize = true;
            this.lblTipoProduto.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoProduto.Location = new System.Drawing.Point(200, 71);
            this.lblTipoProduto.Name = "lblTipoProduto";
            this.lblTipoProduto.Size = new System.Drawing.Size(84, 14);
            this.lblTipoProduto.TabIndex = 8;
            this.lblTipoProduto.Text = "Tipo do produto";
            // 
            // cboTipoProduto
            // 
            this.cboTipoProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboTipoProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipoProduto.FormattingEnabled = true;
            this.cboTipoProduto.Location = new System.Drawing.Point(200, 88);
            this.cboTipoProduto.Name = "cboTipoProduto";
            this.cboTipoProduto.Size = new System.Drawing.Size(134, 23);
            this.cboTipoProduto.TabIndex = 3;
            // 
            // lblDescricaoProduto
            // 
            this.lblDescricaoProduto.AutoSize = true;
            this.lblDescricaoProduto.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescricaoProduto.Location = new System.Drawing.Point(30, 19);
            this.lblDescricaoProduto.Name = "lblDescricaoProduto";
            this.lblDescricaoProduto.Size = new System.Drawing.Size(99, 14);
            this.lblDescricaoProduto.TabIndex = 1;
            this.lblDescricaoProduto.Text = "Descrição Produto:";
            // 
            // lblQuatidade
            // 
            this.lblQuatidade.AutoSize = true;
            this.lblQuatidade.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuatidade.Location = new System.Drawing.Point(30, 71);
            this.lblQuatidade.Name = "lblQuatidade";
            this.lblQuatidade.Size = new System.Drawing.Size(67, 14);
            this.lblQuatidade.TabIndex = 15;
            this.lblQuatidade.Text = "Quantidade:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(30, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(304, 23);
            this.txtNome.TabIndex = 0;
            // 
            // ctnProduto2
            // 
            this.ctnProduto2.Controls.Add(this.label2);
            this.ctnProduto2.Controls.Add(this.btnPesquisar);
            this.ctnProduto2.Controls.Add(this.dataGridViewProdutos);
            this.ctnProduto2.Location = new System.Drawing.Point(12, 159);
            this.ctnProduto2.Name = "ctnProduto2";
            this.ctnProduto2.Size = new System.Drawing.Size(356, 222);
            this.ctnProduto2.TabIndex = 25;
            this.ctnProduto2.TabStop = false;
            this.ctnProduto2.Text = "Consulta de produto";
            this.ctnProduto2.Enter += new System.EventHandler(this.ctnProduto2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(293, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 551;
            this.label2.Text = "Pesquisar";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisar.Location = new System.Drawing.Point(305, 10);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(33, 31);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click_1);
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToAddRows = false;
            this.dataGridViewProdutos.AllowUserToDeleteRows = false;
            this.dataGridViewProdutos.AllowUserToOrderColumns = true;
            this.dataGridViewProdutos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Produto,
            this.ds_Produto,
            this.qt_Produto,
            this.vl_Produto,
            this.ds_TipoProduto,
            this.tp_Inativo});
            this.dataGridViewProdutos.Location = new System.Drawing.Point(6, 61);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.RowHeadersWidth = 51;
            this.dataGridViewProdutos.RowTemplate.Height = 25;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(344, 155);
            this.dataGridViewProdutos.TabIndex = 0;
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
            this.ds_Produto.HeaderText = "Descrição";
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
            this.vl_Produto.HeaderText = "Valor";
            this.vl_Produto.MinimumWidth = 6;
            this.vl_Produto.Name = "vl_Produto";
            this.vl_Produto.ReadOnly = true;
            this.vl_Produto.Width = 125;
            // 
            // ds_TipoProduto
            // 
            this.ds_TipoProduto.DataPropertyName = "ds_TipoProduto";
            this.ds_TipoProduto.HeaderText = "Tipo Produto";
            this.ds_TipoProduto.MinimumWidth = 6;
            this.ds_TipoProduto.Name = "ds_TipoProduto";
            this.ds_TipoProduto.ReadOnly = true;
            this.ds_TipoProduto.Width = 125;
            // 
            // tp_Inativo
            // 
            this.tp_Inativo.DataPropertyName = "tp_Inativo";
            this.tp_Inativo.HeaderText = "Inativo";
            this.tp_Inativo.MinimumWidth = 6;
            this.tp_Inativo.Name = "tp_Inativo";
            this.tp_Inativo.ReadOnly = true;
            this.tp_Inativo.Width = 125;
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(12, 385);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(61, 60);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            this.btnLimpar.Location = new System.Drawing.Point(108, 384);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(61, 60);
            this.btnLimpar.TabIndex = 10;
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
            this.btnSalvar.Location = new System.Drawing.Point(241, 384);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(61, 60);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(307, 385);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(61, 60);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(174, 385);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(61, 60);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnAtualizar.Location = new System.Drawing.Point(242, 385);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(61, 60);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Visible = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(174, 385);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(61, 60);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(381, 448);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.ctnProduto2);
            this.Controls.Add(this.ctnProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(397, 487);
            this.MinimumSize = new System.Drawing.Size(397, 487);
            this.Name = "Produtos";
            this.Text = "Produtos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Produtos_FormClosing);
            this.Load += new System.EventHandler(this.Produtos_Load);
            this.ctnProduto.ResumeLayout(false);
            this.ctnProduto.PerformLayout();
            this.ctnProduto2.ResumeLayout(false);
            this.ctnProduto2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ctnProduto;
        private System.Windows.Forms.CheckBox chkInativo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnTipoProduto;
        private System.Windows.Forms.Label lblTipoProduto;
        private System.Windows.Forms.ComboBox cboTipoProduto;
        private System.Windows.Forms.Label lblDescricaoProduto;
        private System.Windows.Forms.Label lblQuatidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox ctnProduto2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn qt_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_TipoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tp_Inativo;
        private Controllers.txtValor txtValor;
        private Controllers.txtNumero txtQuantidade;
    }
}