
namespace Projeto
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.ctnUsuario = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkInativo = new System.Windows.Forms.CheckBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnCargo = new System.Windows.Forms.Button();
            this.Cargo = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.ctnUsuario2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grdUsuario = new System.Windows.Forms.DataGridView();
            this.id_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_Inativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_Cadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.ctnUsuario.SuspendLayout();
            this.ctnUsuario2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).BeginInit();
            this.SuspendLayout();
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
            this.btnCancelar.Location = new System.Drawing.Point(330, 384);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(62, 59);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
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
            this.btnAtualizar.Location = new System.Drawing.Point(398, 383);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(61, 60);
            this.btnAtualizar.TabIndex = 10;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Visible = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click_1);
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
            this.btnAlterar.Location = new System.Drawing.Point(332, 384);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(61, 60);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
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
            this.btnExcluir.Location = new System.Drawing.Point(13, 386);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(61, 58);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
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
            this.btnLimpar.Location = new System.Drawing.Point(265, 384);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(61, 60);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
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
            this.btnSalvar.Location = new System.Drawing.Point(398, 384);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(61, 60);
            this.btnSalvar.TabIndex = 7;
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
            this.btnSair.Location = new System.Drawing.Point(465, 385);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(61, 59);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // ctnUsuario
            // 
            this.ctnUsuario.Controls.Add(this.label1);
            this.ctnUsuario.Controls.Add(this.chkInativo);
            this.ctnUsuario.Controls.Add(this.lblSenha);
            this.ctnUsuario.Controls.Add(this.btnCargo);
            this.ctnUsuario.Controls.Add(this.Cargo);
            this.ctnUsuario.Controls.Add(this.txtSenha);
            this.ctnUsuario.Controls.Add(this.cboCargo);
            this.ctnUsuario.Controls.Add(this.lblNome);
            this.ctnUsuario.Controls.Add(this.txtUsuario);
            this.ctnUsuario.Controls.Add(this.lblUsuario);
            this.ctnUsuario.Controls.Add(this.txtNome);
            this.ctnUsuario.Location = new System.Drawing.Point(13, 7);
            this.ctnUsuario.Name = "ctnUsuario";
            this.ctnUsuario.Size = new System.Drawing.Size(513, 124);
            this.ctnUsuario.TabIndex = 552;
            this.ctnUsuario.TabStop = false;
            this.ctnUsuario.Text = "Dados do usuário";
            this.ctnUsuario.Enter += new System.EventHandler(this.ctnUsuario_Enter_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 18;
            this.label1.Visible = false;
            // 
            // chkInativo
            // 
            this.chkInativo.AutoSize = true;
            this.chkInativo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkInativo.ForeColor = System.Drawing.Color.Red;
            this.chkInativo.Location = new System.Drawing.Point(331, 88);
            this.chkInativo.Name = "chkInativo";
            this.chkInativo.Size = new System.Drawing.Size(60, 18);
            this.chkInativo.TabIndex = 5;
            this.chkInativo.Text = "Inativo";
            this.chkInativo.UseVisualStyleBackColor = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSenha.Location = new System.Drawing.Point(177, 71);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(40, 14);
            this.lblSenha.TabIndex = 17;
            this.lblSenha.Text = "Senha:";
            // 
            // btnCargo
            // 
            this.btnCargo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCargo.Image = ((System.Drawing.Image)(resources.GetObject("btnCargo.Image")));
            this.btnCargo.Location = new System.Drawing.Point(469, 35);
            this.btnCargo.Name = "btnCargo";
            this.btnCargo.Size = new System.Drawing.Size(31, 23);
            this.btnCargo.TabIndex = 15;
            this.btnCargo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCargo.UseVisualStyleBackColor = false;
            this.btnCargo.Click += new System.EventHandler(this.btnCargo_Click_1);
            // 
            // Cargo
            // 
            this.Cargo.AutoSize = true;
            this.Cargo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cargo.Location = new System.Drawing.Point(331, 19);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(38, 14);
            this.Cargo.TabIndex = 8;
            this.Cargo.Text = "Cargo:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenha.Location = new System.Drawing.Point(177, 88);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(134, 23);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // cboCargo
            // 
            this.cboCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Location = new System.Drawing.Point(331, 36);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(134, 23);
            this.cboCargo.TabIndex = 2;
            this.cboCargo.SelectedIndexChanged += new System.EventHandler(this.cboCargo_SelectedIndexChanged_1);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(30, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 14);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(30, 88);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(134, 23);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(30, 71);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(48, 14);
            this.lblUsuario.TabIndex = 15;
            this.lblUsuario.Text = "Usuário:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(30, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(281, 23);
            this.txtNome.TabIndex = 1;
            // 
            // ctnUsuario2
            // 
            this.ctnUsuario2.Controls.Add(this.label2);
            this.ctnUsuario2.Controls.Add(this.grdUsuario);
            this.ctnUsuario2.Controls.Add(this.btnPesquisar);
            this.ctnUsuario2.Location = new System.Drawing.Point(13, 151);
            this.ctnUsuario2.Name = "ctnUsuario2";
            this.ctnUsuario2.Size = new System.Drawing.Size(513, 228);
            this.ctnUsuario2.TabIndex = 553;
            this.ctnUsuario2.TabStop = false;
            this.ctnUsuario2.Text = "Consulta de Usuários";
            this.ctnUsuario2.Enter += new System.EventHandler(this.ctnUsuario2_Enter_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(447, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 546;
            this.label2.Text = "Pesquisar";
            // 
            // grdUsuario
            // 
            this.grdUsuario.AllowUserToAddRows = false;
            this.grdUsuario.AllowUserToDeleteRows = false;
            this.grdUsuario.AllowUserToOrderColumns = true;
            this.grdUsuario.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Usuario,
            this.ds_Nome,
            this.ds_Cargo,
            this.ds_Usuario,
            this.tp_Inativo,
            this.dt_Cadastro});
            this.grdUsuario.Location = new System.Drawing.Point(6, 54);
            this.grdUsuario.MultiSelect = false;
            this.grdUsuario.Name = "grdUsuario";
            this.grdUsuario.ReadOnly = true;
            this.grdUsuario.RowHeadersWidth = 51;
            this.grdUsuario.RowTemplate.Height = 25;
            this.grdUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdUsuario.Size = new System.Drawing.Size(501, 167);
            this.grdUsuario.TabIndex = 20;
            // 
            // id_Usuario
            // 
            this.id_Usuario.DataPropertyName = "id_Usuario";
            this.id_Usuario.HeaderText = "id_Usuario";
            this.id_Usuario.MinimumWidth = 6;
            this.id_Usuario.Name = "id_Usuario";
            this.id_Usuario.ReadOnly = true;
            this.id_Usuario.Visible = false;
            this.id_Usuario.Width = 125;
            // 
            // ds_Nome
            // 
            this.ds_Nome.DataPropertyName = "ds_Nome";
            this.ds_Nome.HeaderText = "Nome";
            this.ds_Nome.MinimumWidth = 6;
            this.ds_Nome.Name = "ds_Nome";
            this.ds_Nome.ReadOnly = true;
            this.ds_Nome.Width = 160;
            // 
            // ds_Cargo
            // 
            this.ds_Cargo.DataPropertyName = "ds_Cargo";
            this.ds_Cargo.HeaderText = "Cargo";
            this.ds_Cargo.MinimumWidth = 6;
            this.ds_Cargo.Name = "ds_Cargo";
            this.ds_Cargo.ReadOnly = true;
            this.ds_Cargo.Width = 125;
            // 
            // ds_Usuario
            // 
            this.ds_Usuario.DataPropertyName = "ds_Usuario";
            this.ds_Usuario.HeaderText = "Usuário";
            this.ds_Usuario.MinimumWidth = 6;
            this.ds_Usuario.Name = "ds_Usuario";
            this.ds_Usuario.ReadOnly = true;
            this.ds_Usuario.Width = 80;
            // 
            // tp_Inativo
            // 
            this.tp_Inativo.DataPropertyName = "tp_Inativo";
            this.tp_Inativo.HeaderText = "Inativo";
            this.tp_Inativo.MinimumWidth = 6;
            this.tp_Inativo.Name = "tp_Inativo";
            this.tp_Inativo.ReadOnly = true;
            this.tp_Inativo.Width = 53;
            // 
            // dt_Cadastro
            // 
            this.dt_Cadastro.DataPropertyName = "dt_Cadastro";
            this.dt_Cadastro.HeaderText = "Data de cadastro";
            this.dt_Cadastro.MinimumWidth = 6;
            this.dt_Cadastro.Name = "dt_Cadastro";
            this.dt_Cadastro.ReadOnly = true;
            this.dt_Cadastro.Width = 125;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisar.Location = new System.Drawing.Point(459, 9);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(33, 30);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click_1);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(555, 487);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.ctnUsuario);
            this.Controls.Add(this.ctnUsuario2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(555, 487);
            this.MinimumSize = new System.Drawing.Size(555, 487);
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Usuarios_FormClosing);
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.ctnUsuario.ResumeLayout(false);
            this.ctnUsuario.PerformLayout();
            this.ctnUsuario2.ResumeLayout(false);
            this.ctnUsuario2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox ctnUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkInativo;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnCargo;
        private System.Windows.Forms.Label Cargo;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox ctnUsuario2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn tp_Inativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_Cadastro;
        private System.Windows.Forms.Button btnPesquisar;
    }
}