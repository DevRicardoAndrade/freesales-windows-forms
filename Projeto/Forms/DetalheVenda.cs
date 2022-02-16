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
    public partial class DetalheVenda : Form
    {
        public Vendas frmChamador;
        Conexao con = new Conexao();
        public DetalheVenda(Vendas frmChamador)
        {
            InitializeComponent();
            this.frmChamador = frmChamador;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmChamador.detalheAtivo = false;
            this.Close();
        }

        private void DetalheVenda_Load(object sender, EventArgs e)
        {
            frmChamador.detalheAtivo = true;
            FormatarGrid();
            CarregarDados();
            
        }

        private void DetalheVenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmChamador.detalheAtivo = false;
        }
        private void CarregarDados()
        {
            dataGridViewProdutos.Rows.Clear();
            try
            {
                dataGridViewProdutos.Rows.Clear();
                con.Conectar();
                string Select1 = "SELECT * FROM tbdVenda WHERE id_Venda = " + frmChamador.idVenda;
                SQLiteCommand ConsultaVenda = new SQLiteCommand(Select1, con.conexao);
                SQLiteDataReader linhaVenda;
                linhaVenda = ConsultaVenda.ExecuteReader();
                linhaVenda.Read();
                txtValorTotal.Text = linhaVenda.GetString("vl_Total");
                txtCliente.Text = linhaVenda.GetString("ds_Cliente");
                txtDataVenda.Text = String.Format("{0:dd/MM/yyyy}",linhaVenda.GetDateTime("dt_Venda"));
                string Select2 = "SELECT VendaProduto.id_VendaProduto, Venda.ds_Cliente, VendaProduto.id_Produto, Produto.ds_Produto, VendaProduto.qt_Produto, VendaProduto.vl_Produto, '' AS vl_TotalProduto FROM tbdVendaProduto VendaProduto" +
                    " INNER JOIN tbdVenda Venda ON VendaProduto.id_Venda = Venda.id_Venda" +
                    " INNER JOIN tbdProduto Produto ON VendaProduto.id_Produto = Produto.id_Produto WHERE VendaProduto.id_Venda = " + frmChamador.idVenda;
                SQLiteCommand ConsultaVendaProduto = new SQLiteCommand(Select2, con.conexao);
                SQLiteDataReader linhaVendaProduto;
                linhaVendaProduto = ConsultaVendaProduto.ExecuteReader();
                while (linhaVendaProduto.Read())
                {
                    dataGridViewProdutos.Rows.Add();
                    dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["id_VendaProduto"].Value = linhaVendaProduto.GetInt32("id_VendaProduto");
                    dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["ds_Cliente"].Value = linhaVendaProduto.GetString("ds_Cliente");
                    dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["id_Produto"].Value = linhaVendaProduto.GetInt32("id_Produto");
                    dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["ds_Produto"].Value = linhaVendaProduto.GetString("ds_Produto");
                    dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["qt_Produto"].Value = linhaVendaProduto.GetInt32("qt_Produto");
                    dataGridViewProdutos.Rows[dataGridViewProdutos.Rows.Count - 1].Cells["vl_Produto"].Value = Convert.ToDecimal(linhaVendaProduto.GetString("vl_Produto"));
                }
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
                con.Desconectar();
            }
            catch (Exception e)
            {
                con.Desconectar();
                MessageBox.Show("Não foi possivel carregar dados da venda!\n" + e.Message, "FreeSales", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormatarGrid()
        {
            dataGridViewProdutos.Columns["vl_Produto"].DefaultCellStyle.Format = "C2";
            dataGridViewProdutos.Columns["vl_TotalProduto"].DefaultCellStyle.Format = "C2";
        }
    }
}
