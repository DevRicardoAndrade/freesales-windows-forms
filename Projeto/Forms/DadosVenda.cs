using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto.Controllers;
using System.Data.SQLite;
using Projeto.Classes;


namespace Projeto.Forms
{
    public partial class DadosVenda : Form
    {
        public Vendas frmChamador;
        Principal principal;
        Conexao con;
        string[] dadosProduto;
        Produto prod = new Produto();
        private Venda venda = new Venda();
        int idUsuario;
        Boolean alterarLinha = false;
        public DadosVenda (Principal principal, int idUsuario)
        {
            InitializeComponent();
            this.principal = principal;
            this.idUsuario = idUsuario;
        }
        public DadosVenda(Vendas frmChamador, int idUsuario)
        {
            this.frmChamador = frmChamador;
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            this.Close();
            if (frmChamador is not null)
            {
                frmChamador.dVendasAtivo = false;
                frmChamador.alterar = false;
            }
            if (principal is not null)
            {
                principal.dVendasAtivo = false;
            }
            
            btnAtualizar.Visible = false;
            btnSalvar.Visible = true;


        }

        private void DadosVenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmChamador is not null)
            {
                frmChamador.dVendasAtivo = false;
                frmChamador.alterar = false;
                btnAtualizar.Visible = false;
                btnSalvar.Visible = true;
            }
            else if(principal is not null)
            {
                principal.dVendasAtivo = false;
            }
            
           
        }
        decimal valortotal;
        int quantidadetotal;
        int[] idProd = new int [999];
        int[] qtProd = new int[999];
        
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text == "" )
            {
                txtCliente.Text = "Geral";
                txtCliente.Enabled = false;

            }
            //Valida se os campos estão em branco
            if (txtQuantidade.Text == "" ||  cboProduto.Text == "")
            {
                MessageBox.Show("Alguns dos campos necessários para venda está em branco.", "FreeSales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Pega os dados do item selecionado no combo
            dadosProduto = cboProduto.SelectedItem.ToString().Split("-");

            //Valida se a quantidade a ser solicitada é maior que a disponivel
            if (int.Parse(txtQuantidade.Text) > int.Parse(dadosProduto[2]))
            {
                MessageBox.Show("Quantidade de produto solicitado maior que a disponível!", "FreeSales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Valida se o usuário está alterando a linha

            if (alterarLinha)
            {
                dataGridViewProdutos.CurrentRow.Cells["id_Produto"].Value = dadosProduto[0];
                dataGridViewProdutos.CurrentRow.Cells["ds_Produto"].Value = dadosProduto[1];
                dataGridViewProdutos.CurrentRow.Cells["vl_Produto"].Value = String.Format("{0:c}", dadosProduto[3]);
                dataGridViewProdutos.CurrentRow.Cells["qt_Produto"].Value = txtQuantidade.Text;
                dataGridViewProdutos.CurrentRow.Cells["vl_TotalProduto"].Value = int.Parse(dataGridViewProdutos.CurrentRow.Cells["qt_Produto"].Value.ToString()) * Convert.ToDecimal(dataGridViewProdutos.CurrentRow.Cells["vl_Produto"].Value.ToString());
                int qt = int.Parse(txtQuantidade.Text) + int.Parse(txtQuantidadeTotal.Text);
                txtQuantidadeTotal.Text = qt.ToString();
                decimal vl = Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", "")) + Convert.ToDecimal(dataGridViewProdutos.CurrentRow.Cells["vl_TotalProduto"].Value.ToString()); 
                txtValorTotal.Text = vl.ToString();
                cboProduto.Text = "";
                txtQuantidade.Clear();
                dataGridViewProdutos.Enabled = true;
                alterarLinha = false;
                return;
                
            }

            //Valida se o produto selecionado no combo ja existe e faz a validação pra saber se é maior que a quantidade disponivel
            if (dataGridViewProdutos.Rows.Count >= 1)
            {
                for (int i = 0; i < dataGridViewProdutos.Rows.Count; i++)
                {
                    idProd[i] = int.Parse(dataGridViewProdutos.Rows[i].Cells["id_Produto"].Value.ToString());
                    qtProd[i] = int.Parse(dataGridViewProdutos.Rows[i].Cells["qt_Produto"].Value.ToString());
                    if (int.Parse(dadosProduto[0]) == idProd[i])
                    {
                        if (int.Parse(txtQuantidade.Text) > int.Parse(dadosProduto[2]) - qtProd[i])
                        {
                            MessageBox.Show("Quantidade de produto solicitado maior que a disponível!", "FreeSales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }
            if (int.Parse(txtQuantidade.Text) < 1)
            {
                MessageBox.Show("Quantidade de produto é inválida!\nItem não adicionado", "FreeSales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Verificar se o usuário está alterando a linha selecionada
            if (!alterarLinha)
            {
                int quantidade_total = int.Parse(txtQuantidadeTotal.Text);
                decimal valor_total = Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", ""));
                for (int i = 0; i < dataGridViewProdutos.Rows.Count; i++)
                {
                    //Verificar se o produto a ser adicionado é o mesmo que já existe na lista caso for ele atribui os novos valores.
                    if (int.Parse(dataGridViewProdutos.Rows[i].Cells["id_Produto"].Value.ToString()) == int.Parse(dadosProduto[0]))
                    {
                        dataGridViewProdutos.Rows[i].Cells["qt_Produto"].Value = int.Parse(dataGridViewProdutos.Rows[i].Cells["qt_Produto"].Value.ToString()) + int.Parse(txtQuantidade.Text);
                        dataGridViewProdutos.Rows[i].Cells["vl_TotalProduto"].Value = int.Parse(dataGridViewProdutos.Rows[i].Cells["qt_Produto"].Value.ToString()) * Convert.ToDecimal(dataGridViewProdutos.Rows[i].Cells["vl_Produto"].Value.ToString());
                        quantidade_total += int.Parse(txtQuantidade.Text);
                        valor_total += int.Parse(txtQuantidade.Text) * Convert.ToDecimal(dadosProduto[3]);
                        txtQuantidadeTotal.Text = quantidade_total.ToString();
                        txtValorTotal.Text = valor_total.ToString();
                        txtQuantidade.Clear();
                        cboProduto.Text = "";
                        cboProduto.Items.Clear();
                        CarregarCombo();
                        return;
                    }
                }
                //Caso não existir o mesmo produto no grid ele adiciona a nova linha
                dataGridViewProdutos.Rows.Add();
                dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["id_VendaProduto"].Value = "";
                dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["ds_Cliente"].Value = txtCliente.Text;
                dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["id_Produto"].Value = dadosProduto[0];
                dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["ds_Produto"].Value = dadosProduto[1];
                dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["qt_Produto"].Value = txtQuantidade.Text;
                decimal valorTotal = 0;
                valortotal = Convert.ToDecimal(dadosProduto[3]);
                dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["vl_Produto"].Value = valortotal;
                dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["vl_TotalProduto"].Value = (int.Parse(dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["qt_Produto"].Value.ToString()) * Convert.ToDecimal(dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["vl_Produto"].Value.ToString()));
                quantidadetotal = int.Parse(txtQuantidadeTotal.Text);
                valortotal = Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", ""));
                quantidadetotal += int.Parse(txtQuantidade.Text);
                valortotal += int.Parse(txtQuantidade.Text) * Convert.ToDecimal(dadosProduto[3]);
                txtQuantidadeTotal.Text = quantidadetotal.ToString();
                txtValorTotal.Text = valortotal.ToString();
                txtQuantidade.Clear();
                cboProduto.Text = "";
                cboProduto.Items.Clear();
                CarregarCombo();
            }
            
        }

        private void dataGridViewProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            

        }

        private void dataGridViewProdutos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
 
        private void CarregarCombo()
        {
            try
            {
                con = new Conexao();
                con.Conectar();
                string Select = "SELECT id_Produto, ds_Produto, qt_Produto, vl_Produto FROM tbdProduto WHERE tp_Inativo <> 'S' ORDER BY ds_Produto";
                SQLiteCommand comando = new SQLiteCommand(Select,con.conexao);
                SQLiteDataReader linha;
                linha = comando.ExecuteReader();
                while (linha.Read())
                {
                    string dadosLinha;
                    int id = linha.GetInt32("id_Produto");
                    string descricao = linha.GetString("ds_Produto");
                    int quantidade;
                    quantidade = linha.GetInt32("qt_Produto");
                    decimal valor = Convert.ToDecimal(linha.GetString("vl_Produto"));
                    dadosLinha = id + "-" + descricao + "-" + quantidade + "-" + valor;
                    cboProduto.Items.Add(dadosLinha);
                }
                con.Desconectar();

            }
            catch (Exception e) 
            {
                con.Desconectar();
                MessageBox.Show("Erro ao carregar produtos!\n" + e.Message,"FreeSales",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void DadosVenda_Load(object sender, EventArgs e)
        {
            
            txtQuantidadeTotal.Text = "0";
            txtValorTotal.Text = "0";
            CarregarCombo();
            FormatarGrid();
            if (frmChamador is not null)
            {
                frmChamador.dVendasAtivo = true;
                if (frmChamador.alterar)
                {
                    btnLimpar.Enabled = false;
                    btnAtualizar.Visible = true;
                    btnSalvar.Visible = false;
                    CarregarDados();
                }
            }
            else if (principal is not null)
            {
                principal.dVendasAtivo = true;
            }
            
        }
        int idvenda = 0;
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(dataGridViewProdutos.Rows.Count <= 0)
            {
                MessageBox.Show("Não existe produtos para criar a venda!","FreeSales",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            var mensagem = "Deseja realmente cadastrar venda?";
            var titulo = "FreeSales";
            var res = MessageBox.Show(mensagem,titulo,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {

                idvenda = venda.InserirVenda(idUsuario, txtCliente.Text, Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", "")), int.Parse(txtQuantidadeTotal.Text));
                if (idvenda > 0)
                {
                    for (int i = 0; i < dataGridViewProdutos.Rows.Count; i++)
                    {
                        int id_Produto = int.Parse(dataGridViewProdutos.Rows[i].Cells["id_Produto"].Value.ToString());
                        int quantidade = int.Parse(dataGridViewProdutos.Rows[i].Cells["qt_Produto"].Value.ToString());
                        decimal valor = Convert.ToDecimal(dataGridViewProdutos.Rows[i].Cells["vl_Produto"].Value.ToString());

                        if (venda.InserirVendaProduto(id_Produto, idvenda, valor, quantidade) > 0)
                        {
                            prod.AtualizarQuantidade(id_Produto, quantidade);
                        }
                    }
                    MessageBox.Show("Venda cadastrada com sucesso!\nNúmero da Venda: " + idvenda, "FreeSales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboProduto.Items.Clear();
                    cboProduto.Text = "";
                    txtCliente.Clear();
                    txtCliente.Enabled = true;
                    txtQuantidade.Clear();
                    txtQuantidadeTotal.Text = "0";
                    txtValorTotal.Text = "0";
                    CarregarCombo();
                    dataGridViewProdutos.Rows.Clear();
                }   
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            var mensagem = "Deseja realmente limpar dados?";
            var titulo = "FreeSales";
            var res = MessageBox.Show(mensagem,titulo,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                txtCliente.ReadOnly = false;
                txtCliente.Clear();
                txtQuantidade.Clear();
                txtQuantidadeTotal.Text = "0";
                txtValorTotal.Text = "0";
                cboProduto.Text = "";
                quantidadetotal = 0;
                valortotal = 0;
                dataGridViewProdutos.Rows.Clear();
                btnSalvar.Enabled = true;
                MessageBox.Show("Dados zerados!","FreeSales",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }
        private void CarregarDados()
        {
            dataGridViewProdutos.Rows.Clear();  
            try
            {
                con = new Conexao();
                con.Conectar();
                string Select1 = "SELECT * FROM tbdVenda WHERE id_Venda = " + frmChamador.idVenda;
                SQLiteCommand ConsultaVenda = new SQLiteCommand(Select1,con.conexao);
                SQLiteDataReader LinhaVenda;
                LinhaVenda = ConsultaVenda.ExecuteReader();
                LinhaVenda.Read();
                txtValorTotal.Text = LinhaVenda.GetString("vl_Total");
                txtQuantidadeTotal.Text = LinhaVenda.GetInt32("qt_Total").ToString();
                txtCliente.Text = LinhaVenda.GetString("ds_Cliente");
                LinhaVenda.Close();
                con.Desconectar();
                con.Conectar();
                string Select2 = "SELECT VendaProduto.id_VendaProduto, Venda.ds_Cliente, VendaProduto.id_Produto, Produto.ds_Produto, VendaProduto.qt_Produto, VendaProduto.vl_Produto, '' AS vl_TotalProduto FROM tbdVendaProduto VendaProduto" +
                    " INNER JOIN tbdVenda Venda ON VendaProduto.id_Venda = Venda.id_Venda" +
                    " INNER JOIN tbdProduto Produto ON VendaProduto.id_Produto = Produto.id_Produto WHERE VendaProduto.id_Venda = " + frmChamador.idVenda;
                SQLiteCommand ConsultaVendaProduto = new SQLiteCommand(Select2,con.conexao);
                SQLiteDataReader LinhaVendaProduto;
                LinhaVendaProduto = ConsultaVendaProduto.ExecuteReader();
                while (LinhaVendaProduto.Read())
                {
                    dataGridViewProdutos.Rows.Add();
                    dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["id_VendaProduto"].Value = LinhaVendaProduto.GetInt32("id_VendaProduto");
                    dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["ds_Cliente"].Value = LinhaVendaProduto.GetString("ds_Cliente");
                    dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["id_Produto"].Value = LinhaVendaProduto.GetInt32("id_Produto");
                    dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["ds_Produto"].Value = LinhaVendaProduto.GetString("ds_Produto");
                    dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["qt_Produto"].Value = LinhaVendaProduto.GetInt32("qt_Produto");
                    dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["vl_Produto"].Value = Convert.ToDecimal(LinhaVendaProduto.GetString("vl_Produto"));
                }
                con.Desconectar();
                for (int i = 0; i < dataGridViewProdutos.Rows.Count; i++)
                {
                    int[] qt = new int[999];
                    decimal[] vl = new decimal[999];
                    decimal[] vlTotal = new decimal[999];
                    vl[i] = Convert.ToDecimal(dataGridViewProdutos.Rows[i].Cells["vl_Produto"].Value.ToString());
                    qt[i] = int.Parse(dataGridViewProdutos.Rows[i].Cells["qt_Produto"].Value.ToString());
                    vlTotal[i] = vl[i] * qt[i];
                    dataGridViewProdutos.Rows[i].Cells["vl_TotalProduto"].Value = vlTotal[i];
                } 
            }
            catch(Exception e)
            {
                con.Desconectar();
                MessageBox.Show("Não foi possivel carregar dados da venda!\n" + e.Message,"FreeSales",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dataGridViewProdutos_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

            
            
        }

        private void dataGridViewProdutos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int res1 = int.Parse(txtQuantidadeTotal.Text) - int.Parse(dataGridViewProdutos.CurrentRow.Cells["qt_Produto"].Value.ToString());
            txtQuantidadeTotal.Text = res1.ToString();
            decimal valortotal = Convert.ToDecimal(dataGridViewProdutos.CurrentRow.Cells["vl_TotalProduto"].Value.ToString());
            decimal valortotal2 = Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", ""));
            decimal res2 = valortotal2 - valortotal;
            txtValorTotal.Text = res2.ToString();
        }

        private void dataGridViewProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCliente.ReadOnly = false;
            txtQuantidade.Text = dataGridViewProdutos.CurrentRow.Cells["qt_Produto"].Value.ToString();
            string[] combo = new string[99999];
            string[] comboDados = new string[3];
            for (int i = 0; i < cboProduto.Items.Count; i++)
            {
                combo[i] = cboProduto.Items[i].ToString();
                comboDados = combo[i].Split("-");
                if(comboDados[0].ToString() == dataGridViewProdutos.CurrentRow.Cells["id_Produto"].Value.ToString())
                {
                    
                    cboProduto.Text = combo[i];
                }

            }
            int qt = int.Parse(txtQuantidadeTotal.Text) - int.Parse(dataGridViewProdutos.CurrentRow.Cells["qt_Produto"].Value.ToString());
            txtQuantidadeTotal.Text = qt.ToString();
            decimal vl = Convert.ToDecimal(txtValorTotal.Text.Replace("R$ ", "")) - Convert.ToDecimal(dataGridViewProdutos.CurrentRow.Cells["vl_TotalProduto"].Value.ToString());
            txtValorTotal.Text = vl.ToString();
            dataGridViewProdutos.Enabled = false;
            alterarLinha = true;
        }

        private void dataGridViewProdutos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
        }

        private void dataGridViewProdutos_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void FormatarGrid()
        {
            dataGridViewProdutos.Columns["vl_Produto"].DefaultCellStyle.Format = "C2";
            dataGridViewProdutos.Columns["vl_TotalProduto"].DefaultCellStyle.Format = "C2";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var mensagem = "Deseja realmente atualizar a venda?";
            var titulo = "FreeSales";
            var res = MessageBox.Show(mensagem,titulo,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
            }
        }

        private void txtCliente_DoubleClick(object sender, EventArgs e)
        {
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            if(txtCliente.Text == "")
            {
                txtCliente.Text = "Geral";
            }
            txtCliente.ReadOnly = true;    
        }

        private void txtCliente_Enter(object sender, EventArgs e)
        {
            txtCliente.SelectAll();
        }

        private void txtCliente_DoubleClick_1(object sender, EventArgs e)
        {
            txtCliente.ReadOnly = false;
        }
    }
}
