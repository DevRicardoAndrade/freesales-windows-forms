using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace Projeto
{
    public partial class Produtos : Form
    {
        public Principal frmChamador;
        Conexao con = new Conexao();
        public Produto produto1;
        int id=0;
        
        public Produtos(Principal frmChamador)
        {
            InitializeComponent();
            this.frmChamador = frmChamador;
        }
        public TiposProduto tpProduto;
        public Boolean tpProdutoAtivo=false;
        private void btnTipoProduto_Click(object sender, EventArgs e)
        {
            if(tpProdutoAtivo == false)
            {
                
                tpProduto = new TiposProduto(this);
                tpProduto.TopLevel = false;
                foreach (Control controles in frmChamador.Controls)
                {
                    if (controles.Name == "panelPrincipal")
                    {
                        foreach (Form forms in controles.Controls)
                        {
                            forms.WindowState = FormWindowState.Minimized;
                        }
                        controles.Controls.Add(tpProduto);
                    }
                }
                tpProduto.Show();
            }
            else
            {
                tpProduto.Activate();
                MessageBox.Show("A tela de tipos de produtos já está aberta!", "Tela aberta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (txtQuantidade.Text == "" || txtValor.Text == "" || txtNome.Text == "" || cboTipoProduto.Text == "")
            {
                MessageBox.Show("Alguns dos campos obrigatórios estão em branco!\nÉ necessário preenche-los!", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            produto1 = new Produto();
            var mensagem = "Deseja realmente cadastrar o produto?";
            var titulo = "Cadastrar produto";
            var res = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                int idTipo;

                if(cboTipoProduto.Text == "")
                {
                     idTipo = 0;
                }
                else
                {
                    idTipo = int.Parse(cboTipoProduto.SelectedValue.ToString());
                }
                if (chkInativo.Checked)
                {
                    if (produto1.Inserir(idTipo,"S", txtNome.Text, Convert.ToDecimal(txtValor.Text.Replace("R$ ", "")), int.Parse(txtQuantidade.Text)))
                    {
                        CarregarGrid(produto1.BuscarProduto("N", txtNome.Text, Convert.ToDecimal(txtValor.Text), int.Parse(txtQuantidade.Text), idTipo));
                        txtNome.Clear();
                        txtQuantidade.Clear();
                        txtValor.Clear();
                        chkInativo.Checked = false;
                        cboTipoProduto.Text = "";
                        id = 0;
                    }
                    
                }
                else
                {
                   if (produto1.Inserir(idTipo,"N", txtNome.Text, Convert.ToDecimal(txtValor.Text.Replace("R$ ", "")), int.Parse(txtQuantidade.Text)))
                    {
                        CarregarGrid(produto1.BuscarProduto("N", txtNome.Text, Convert.ToDecimal(txtValor.Text.Replace("R$ ", "")), int.Parse(txtQuantidade.Text), idTipo));

                        txtNome.Clear();
                        txtQuantidade.Clear();
                        txtValor.Clear();
                        chkInativo.Checked = false;
                        cboTipoProduto.Text = "";
                        id = 0;
                    }
                    
                }

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            var mensagem = "Deseja realmente limpar os dados da tela?";
            var titulo = "Limpar dados";
            var res = MessageBox.Show(mensagem,titulo,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                dataGridViewProdutos.Rows.Clear();
                dataGridViewProdutos.Refresh();
                txtNome.Clear();
                txtQuantidade.Clear();
                txtValor.Clear();
                chkInativo.Checked = false;
                txtNome.Focus();
                cboTipoProduto.Text = "";
                id = 0;
                MessageBox.Show("Dados zerados!","Limpou",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(dataGridViewProdutos.CurrentRow is null)
            {
                MessageBox.Show("Não existe nenhum produto selecionado!", "Sem produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var mensagem = "Deseja realmente excluir produto?";
            var titulo = "Excluir produto";
            var res = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                produto1.Excluir(int.Parse(dataGridViewProdutos.CurrentRow.Cells["id_Produto"].Value.ToString()));
                dataGridViewProdutos.Rows.RemoveAt(dataGridViewProdutos.CurrentRow.Index);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtQuantidade.Clear();
            txtValor.Clear();
            chkInativo.Checked = false;
            btnAlterar.Visible = true;
            btnCancelar.Visible = false;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;
            ctnProduto2.Enabled = true;
            btnSalvar.Visible = true;
            btnAtualizar.Visible = false;
            btnTipoProduto.Enabled = true;
            cboTipoProduto.Text = "";
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            FormatarGrid();
            CarregarCombo();
            frmChamador.produtoAtivo = true;
        }

        private void Produtos_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmChamador.produtoAtivo = false;
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            dataGridViewProdutos.Refresh();
            int idTipo;
            if (cboTipoProduto.Text == "")
            {
                idTipo = 0;
            }
            else
            {
                idTipo = int.Parse(cboTipoProduto.SelectedValue.ToString());
            }
            
            produto1 = new Produto();
            int quantidade;
            decimal valor;
            if (txtQuantidade.Text == "")
            {
                quantidade = -1;
            }
            else
            {
                quantidade = int.Parse(txtQuantidade.Text);
            }
            if (txtValor.Text.Replace("R$ ","") == "")
            {
                valor = -1;
            }
            else
            {
                valor = Convert.ToDecimal(txtValor.Text.Replace("R$ ", ""));
            }

            if (chkInativo.Checked == true)
            {

                CarregarGrid(produto1.BuscarProduto("S", txtNome.Text, valor, quantidade, idTipo));
            }
            else
            {
                 CarregarGrid(produto1.BuscarProduto("N", txtNome.Text, valor, quantidade, idTipo));

            }

        }

        private void CarregarGrid(SQLiteDataReader linhas)
        {
            dataGridViewProdutos.Rows.Clear();
            while (linhas.Read())
            {
                dataGridViewProdutos.Rows.Add();
                dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["id_Produto"].Value = linhas.GetInt32("id_Produto");
                dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["qt_Produto"].Value = linhas.GetInt32("qt_Produto");
                dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["vl_Produto"].Value = Convert.ToDecimal(linhas.GetString("vl_Produto"));
                dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["ds_Produto"].Value = linhas.GetString("ds_Produto");
                dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["ds_TipoProduto"].Value = linhas.GetString("ds_TipoProduto");
                dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["tp_Inativo"].Value = linhas.GetString("tp_Inativo");
                

            }
            produto1.con.Desconectar();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            id = 0;
            if(dataGridViewProdutos.CurrentRow is null)
            {
                MessageBox.Show("Não existe nenhum produto selecionado!", "Sem produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            id = int.Parse(dataGridViewProdutos.CurrentRow.Cells["id_Produto"].Value.ToString());
            txtNome.Text = dataGridViewProdutos.CurrentRow.Cells["ds_Produto"].Value.ToString();
            txtQuantidade.Text = dataGridViewProdutos.CurrentRow.Cells["qt_Produto"].Value.ToString();
            txtValor.Text = dataGridViewProdutos.CurrentRow.Cells["vl_Produto"].Value.ToString();
            
            if (dataGridViewProdutos.CurrentRow.Cells["tp_Inativo"].Value.ToString() == "S")
            {
                chkInativo.Checked = true;
            }
            else
            {
                chkInativo.Checked = false;
            }
            btnAlterar.Visible = false;
            btnCancelar.Visible = true;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            ctnProduto2.Enabled = false;
            btnSalvar.Visible = false;
            btnAtualizar.Visible = true;
            btnTipoProduto.Enabled = false;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == "" || txtQuantidade.Text == "" || txtValor.Text == "" || cboTipoProduto.Text == "")
            {
                MessageBox.Show("Alguns campos estão em branco.\nFavor Inserir os dados","Campos em branco",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            var mensagem = "Deseja realmente alterar produto?";
            var titulo = "Alterar produto";
            var res = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                if (chkInativo.Checked)
                {
                    id = int.Parse(dataGridViewProdutos.CurrentRow.Cells["id_Produto"].Value.ToString());
                    produto1.Atualizar(id,"S",txtNome.Text, Convert.ToDecimal(txtValor.Text.Replace("R$ ", "")), int.Parse(txtQuantidade.Text));
                    CarregarGrid(produto1.BuscarProduto("S", txtNome.Text, Convert.ToDecimal(txtValor.Text.Replace("R$ ", "")), int.Parse(txtQuantidade.Text)));
                    txtNome.Clear();
                    txtQuantidade.Clear();
                    txtValor.Clear();
                    chkInativo.Checked = false;
                    btnAlterar.Visible = true;
                    btnCancelar.Visible = false;
                    btnExcluir.Enabled = true;
                    btnLimpar.Enabled = true;
                    ctnProduto2.Enabled = true;
                    btnSalvar.Visible = true;
                    btnAtualizar.Visible = false;
                    btnTipoProduto.Enabled = true;
                    cboTipoProduto.Text = "";

                }
                else
                {
                    id = int.Parse(dataGridViewProdutos.CurrentRow.Cells["id_Produto"].Value.ToString());
                    produto1.Atualizar(id, "N", txtNome.Text, Convert.ToDecimal(txtValor.Text.Replace("R$ ", "")), int.Parse(txtQuantidade.Text));
                    CarregarGrid(produto1.BuscarProduto("N", txtNome.Text, Convert.ToDecimal(txtValor.Text.Replace("R$ ", "")), int.Parse(txtQuantidade.Text)));
                    txtNome.Clear();
                    txtQuantidade.Clear();
                    txtValor.Clear();
                    chkInativo.Checked = false;
                    btnAlterar.Visible = true;
                    btnCancelar.Visible = false;
                    btnExcluir.Enabled = true;
                    btnLimpar.Enabled = true;
                    ctnProduto2.Enabled = true;
                    btnSalvar.Visible = true;
                    btnAtualizar.Visible = false;
                    btnTipoProduto.Enabled = true;
                    cboTipoProduto.Text = "";
                }
                
            }
        }
        public void CarregarCombo()
        {
            try
            {
                con.Conectar();
                string Buscar = "SELECT id_TipoProduto, ds_TipoProduto FROM tbdTipoProduto WHERE tp_Inativo <> 'S' ORDER BY ds_TipoProduto";
                SQLiteDataAdapter ConsultaTipo = new SQLiteDataAdapter(Buscar, con.conexao);
                DataTable Tipo = new DataTable();
                DataRow Linha = Tipo.NewRow();
                ConsultaTipo.Fill(Tipo);
                cboTipoProduto.DataSource = Tipo;
                cboTipoProduto.DisplayMember = "ds_TipoProduto";
                cboTipoProduto.ValueMember = "id_TipoProduto";
                con.Desconectar();
                
            }
            catch(Exception e)
            {
                con.Desconectar();
                MessageBox.Show("Ocorreu um erro ao carregar tipo de produto\n" + e.Message,"Erro ao carregar",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ctnProduto2_Enter(object sender, EventArgs e)
        {

        }
        private void FormatarGrid()
        {
            dataGridViewProdutos.Columns["vl_Produto"].DefaultCellStyle.Format = "C2";
        }
    }
}
