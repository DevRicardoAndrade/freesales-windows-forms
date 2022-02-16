
namespace Projeto
{
    partial class Vendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendas));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Incluir = new System.Windows.Forms.Button();
            this.dataGridViewVendas = new System.Windows.Forms.DataGridView();
            this.dt_Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qt_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtVenda = new Projeto.Controllers.txtNumero();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.txtData2 = new System.Windows.Forms.MaskedTextBox();
            this.txtData1 = new System.Windows.Forms.MaskedTextBox();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnPesquisar, "btnPesquisar");
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            resources.ApplyResources(this.btnExcluir, "btnExcluir");
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            resources.ApplyResources(this.btnLimpar, "btnLimpar");
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Name = "btnSair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAlterar
            // 
            resources.ApplyResources(this.btnAlterar, "btnAlterar");
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Incluir
            // 
            resources.ApplyResources(this.Incluir, "Incluir");
            this.Incluir.BackColor = System.Drawing.SystemColors.Control;
            this.Incluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Incluir.ForeColor = System.Drawing.Color.Green;
            this.Incluir.Name = "Incluir";
            this.Incluir.UseVisualStyleBackColor = false;
            this.Incluir.Click += new System.EventHandler(this.Incluir_Click);
            // 
            // dataGridViewVendas
            // 
            this.dataGridViewVendas.AllowUserToAddRows = false;
            this.dataGridViewVendas.AllowUserToDeleteRows = false;
            this.dataGridViewVendas.AllowUserToOrderColumns = true;
            this.dataGridViewVendas.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dt_Venda,
            this.id_Venda,
            this.ds_Cliente,
            this.vl_Total,
            this.qt_Total,
            this.ds_Nome});
            resources.ApplyResources(this.dataGridViewVendas, "dataGridViewVendas");
            this.dataGridViewVendas.Name = "dataGridViewVendas";
            this.dataGridViewVendas.ReadOnly = true;
            this.dataGridViewVendas.RowTemplate.Height = 25;
            // 
            // dt_Venda
            // 
            this.dt_Venda.DataPropertyName = "dt_Venda";
            resources.ApplyResources(this.dt_Venda, "dt_Venda");
            this.dt_Venda.Name = "dt_Venda";
            this.dt_Venda.ReadOnly = true;
            // 
            // id_Venda
            // 
            this.id_Venda.DataPropertyName = "id_Venda";
            resources.ApplyResources(this.id_Venda, "id_Venda");
            this.id_Venda.Name = "id_Venda";
            this.id_Venda.ReadOnly = true;
            // 
            // ds_Cliente
            // 
            this.ds_Cliente.DataPropertyName = "ds_Cliente";
            resources.ApplyResources(this.ds_Cliente, "ds_Cliente");
            this.ds_Cliente.Name = "ds_Cliente";
            this.ds_Cliente.ReadOnly = true;
            // 
            // vl_Total
            // 
            this.vl_Total.DataPropertyName = "vl_Total";
            resources.ApplyResources(this.vl_Total, "vl_Total");
            this.vl_Total.Name = "vl_Total";
            this.vl_Total.ReadOnly = true;
            // 
            // qt_Total
            // 
            this.qt_Total.DataPropertyName = "qt_Total";
            resources.ApplyResources(this.qt_Total, "qt_Total");
            this.qt_Total.Name = "qt_Total";
            this.qt_Total.ReadOnly = true;
            // 
            // ds_Nome
            // 
            this.ds_Nome.DataPropertyName = "ds_Nome";
            resources.ApplyResources(this.ds_Nome, "ds_Nome");
            this.ds_Nome.Name = "ds_Nome";
            this.ds_Nome.ReadOnly = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // lblData
            // 
            resources.ApplyResources(this.lblData, "lblData");
            this.lblData.Name = "lblData";
            // 
            // lblUsuario
            // 
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.Name = "lblUsuario";
            // 
            // txtVenda
            // 
            resources.ApplyResources(this.txtVenda, "txtVenda");
            this.txtVenda.Name = "txtVenda";
            // 
            // lblNumero
            // 
            resources.ApplyResources(this.lblNumero, "lblNumero");
            this.lblNumero.Name = "lblNumero";
            // 
            // lblCargo
            // 
            resources.ApplyResources(this.lblCargo, "lblCargo");
            this.lblCargo.Name = "lblCargo";
            // 
            // btnDetalhes
            // 
            resources.ApplyResources(this.btnDetalhes, "btnDetalhes");
            this.btnDetalhes.BackColor = System.Drawing.SystemColors.Control;
            this.btnDetalhes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalhes.ForeColor = System.Drawing.Color.Blue;
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.UseVisualStyleBackColor = false;
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // txtData2
            // 
            resources.ApplyResources(this.txtData2, "txtData2");
            this.txtData2.Name = "txtData2";
            this.txtData2.ValidatingType = typeof(System.DateTime);
            // 
            // txtData1
            // 
            resources.ApplyResources(this.txtData1, "txtData1");
            this.txtData1.Name = "txtData1";
            this.txtData1.ValidatingType = typeof(System.DateTime);
            // 
            // cboUsuario
            // 
            this.cboUsuario.FormattingEnabled = true;
            resources.ApplyResources(this.cboUsuario, "cboUsuario");
            this.cboUsuario.Name = "cboUsuario";
            // 
            // cboCargo
            // 
            this.cboCargo.FormattingEnabled = true;
            resources.ApplyResources(this.cboCargo, "cboCargo");
            this.cboCargo.Name = "cboCargo";
            // 
            // Vendas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.txtData2);
            this.Controls.Add(this.txtData1);
            this.Controls.Add(this.btnDetalhes);
            this.Controls.Add(this.cboUsuario);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.Incluir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtVenda);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewVendas);
            this.MaximizeBox = false;
            this.Name = "Vendas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Vendas_FormClosing);
            this.Load += new System.EventHandler(this.Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Incluir;
        private System.Windows.Forms.DataGridView dataGridViewVendas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblUsuario;
        private Controllers.txtNumero txtVenda;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Button btnDetalhes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn qt_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_Nome;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.MaskedTextBox txtData2;
        private System.Windows.Forms.MaskedTextBox txtData1;
    }
}