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
    public partial class TiposProduto : Form
    {
        Produtos prod1;
        TipoProduto tipo = new TipoProduto();
        Conexao con = new Conexao();
        string[] dadosTipo;
        public TiposProduto(Produtos prod1)
        {
            InitializeComponent();
            this.prod1 = prod1;
            this.prod1.tpProdutoAtivo = true;
        }

        private void TiposProduto_Load(object sender, EventArgs e)
        {
            CarregarLista();
            prod1.tpProdutoAtivo = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            prod1.CarregarCombo();
            prod1.tpProdutoAtivo = false;
            this.Close();
        }

        private void TiposProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            prod1.CarregarCombo();
            prod1.tpProdutoAtivo = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                MessageBox.Show("O campo da descrição do tipo de produto está em branco!","Em branco",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            var mensagem = "Deseja realmente inserir o tipo de produto?";
            var titulo = "Inserir tipo";
            var res = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                if (chkInativo.Checked)
                {
                    tipo.Inserir(txtNome.Text, 'S');
                    
                }
                else
                {
                    tipo.Inserir(txtNome.Text, 'N');
                }
            }
            checkedListBoxTiposProduto.Items.Clear(); ;
            CarregarLista();
        }
        private void CarregarLista()
        {
            try
            {
                con.Conectar();
                string Buscar = "SELECT * FROM tbdTipoProduto ORDER BY id_TipoProduto";
                SQLiteCommand comando = new SQLiteCommand(Buscar, con.conexao);
                SQLiteDataReader linha;
                linha = comando.ExecuteReader();
                while (linha.Read())
                {
                    string dadosLinha;
                    string descricao = linha.GetString("ds_TipoProduto");
                    int id = linha.GetInt32("id_TipoProduto");
                    string inativo =linha.GetString("tp_Inativo");
                    dadosLinha = id + "-" + descricao + "-" + inativo;
                    checkedListBoxTiposProduto.Items.Add(dadosLinha);
                }
                con.Desconectar();
            }
            catch(Exception e)
            {
                con.Desconectar();
                MessageBox.Show("Erro ao carregar dados\n" +e.Message,"Erro ao carregar dados",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (checkedListBoxTiposProduto.CheckedItems.Count < 1)
            {
                MessageBox.Show("Não existe nenhum tipo selecionado!","Seleção em branco",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            var mensagem = "Deseja realmente excluir tipo de produto?";
            var titulo = "Excluir tipo";
            var res = MessageBox.Show(mensagem,titulo,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                dadosTipo = checkedListBoxTiposProduto.SelectedItem.ToString().Split("-");
                tipo.Excluir(int.Parse(dadosTipo[0]));
                checkedListBoxTiposProduto.Items.Clear();
                CarregarLista();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            var mensagem = "Deseja realmente limpar dados?";
            var titulo = "Limpar dados";
            var res = MessageBox.Show(mensagem,titulo,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                txtNome.Clear();
                chkInativo.Checked = false;
                MessageBox.Show("Dados zerados!", "Limpo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnAlterar.Visible = true;
            btnLimpar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Visible = true;
            btnCancelar.Visible = false;
            btnAtualizar.Visible = false;
            checkedListBoxTiposProduto.Enabled = true;
            chkInativo.Checked = false;
            txtNome.Clear();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int id=0;
            if(checkedListBoxTiposProduto.CheckedItems.Count < 1)
            {
                MessageBox.Show("Não foi selecionado o tipo do produto!\nFavor selecionar para alterar!", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dadosTipo = checkedListBoxTiposProduto.SelectedItem.ToString().Split("-");
            txtNome.Text = dadosTipo[1].ToString();
            if(dadosTipo[2].ToString() == "S")
            {
                chkInativo.Checked = true;

            }
            else
            {
                chkInativo.Checked = false;
            }
            btnAlterar.Visible = false;
            btnLimpar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Visible = false;
            btnCancelar.Visible = true;
            btnAtualizar.Visible = true;
            checkedListBoxTiposProduto.Enabled = false;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var mensagem = "Deseja realmente alterar tipo de produto?";
            var titulo = "Alterar";
            var res = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (chkInativo.Checked)
                {
                    tipo.Atualizar(int.Parse(dadosTipo[0].ToString()),txtNome.Text , "S");
                    checkedListBoxTiposProduto.Items.Clear();
                    CarregarLista();
                }
                else
                {
                    tipo.Atualizar(int.Parse(dadosTipo[0].ToString()), txtNome.Text, "N");
                    checkedListBoxTiposProduto.Items.Clear();
                    CarregarLista();
                }
                btnAlterar.Visible = true;
                btnLimpar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Visible = true;
                btnCancelar.Visible = false;
                btnAtualizar.Visible = false;
                checkedListBoxTiposProduto.Enabled = true;
                chkInativo.Checked = false;
                txtNome.Clear();
            }
        }
    }
}
