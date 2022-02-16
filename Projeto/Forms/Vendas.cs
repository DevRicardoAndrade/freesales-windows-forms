using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto.Classes;
using Projeto.Forms;
using System.Data.SQLite;

namespace Projeto
{
    public partial class Vendas : Form
    {

        public Principal frmChamador;
        Usuario usuarioLogado;
        Cargo CargoUsuario = new Cargo();
        public Venda venda;
        Conexao con = new Conexao();
        public Vendas(Principal frmChamador, Usuario UsuarioLogado)
        {

            InitializeComponent();
            this.frmChamador = frmChamador;
            this.usuarioLogado = UsuarioLogado;
            
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            frmChamador.vendaAtiva = true;
            if (usuarioLogado.Ds_Usuario != "admin")
            {
                String ConsultaCargo = "SELECT" +
                    " * " +
                    "FROM tbdUsuario Usuario " +
                    "INNER JOIN tbdCargo Cargo on (Cargo.id_Cargo = Usuario.id_Cargo)" +
                    " WHERE Usuario.id_Usuario = " + usuarioLogado.Id;
                SQLiteDataAdapter Select = new SQLiteDataAdapter(ConsultaCargo, con.conexao);
                DataTable Cargo = new DataTable();
                Select.Fill(Cargo);
                CargoUsuario.Tp_cargo = Cargo.Rows[0]["tp_Cargo"].ToString();
                if (CargoUsuario.Tp_cargo == "N")
                {
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;

                }
                
                FormatarGrid();
                CarregarCombos();
            }
        }
        public DadosVenda IncluirVenda;
        public Boolean dVendasAtivo = false;
        private void Incluir_Click(object sender, EventArgs e)
        {
            if (dVendasAtivo == false )
            {
                IncluirVenda = new DadosVenda(this , usuarioLogado.Id);
                IncluirVenda.TopLevel = false;
                foreach (Control controles in frmChamador.Controls)
                {
                    if (controles.Name == "panelPrincipal")
                    {
                        foreach (Form forms in controles.Controls)
                        {
                            forms.WindowState = FormWindowState.Minimized;
                        }
                        controles.Controls.Add(IncluirVenda);
                    }
                        
                }
                IncluirVenda.Show();
            }
            else
            {
                IncluirVenda.Activate();
                MessageBox.Show("A tela de cadastro de vendas já está aberta!", "FreeSales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Boolean alterar = false;
        public int idVenda;
        public DadosVenda AlterarVenda = null;
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(dataGridViewVendas.Rows.Count < 1)
            {
                MessageBox.Show("Não existe venda selecionada para alterar!","FreeSales",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (dVendasAtivo == false)
                {
                       AlterarVenda = new DadosVenda(this, usuarioLogado.Id);
                       AlterarVenda.TopLevel = false;
                       foreach (Control controles in frmChamador.Controls)
                       {
                           if (controles.Name == "panelPrincipal")
                           {
                            foreach (Form forms in controles.Controls)
                            {
                                forms.WindowState = FormWindowState.Minimized;
                            }
                            controles.Controls.Add(AlterarVenda);
                           }
                       }
                       alterar = true;
                       idVenda = int.Parse(dataGridViewVendas.CurrentRow.Cells["id_Venda"].Value.ToString());
                       AlterarVenda.Show();
                }
                else
                {
                        AlterarVenda.Activate();
                        MessageBox.Show("A tela de dados de vendas já está aberta!", "FreeSales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        public DetalheVenda detalheVenda;
        public Boolean detalheAtivo=false;
        private void btnDetalhes_Click(object sender, EventArgs e)
        {

            if (dataGridViewVendas.Rows.Count < 1)
            {
                MessageBox.Show("Não existe venda selecionada!", "FreeSales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (detalheAtivo == false)
            {
                detalheVenda = new DetalheVenda(this);
                detalheVenda.TopLevel = false;
                foreach (Control controles in frmChamador.Controls)
                {
                    if (controles.Name == "panelPrincipal")
                    {
                        foreach (Form forms in controles.Controls)
                        {
                            forms.WindowState = FormWindowState.Minimized;
                        }
                        controles.Controls.Add(detalheVenda);
                    }
                }
                idVenda = int.Parse(dataGridViewVendas.CurrentRow.Cells["id_Venda"].Value.ToString());
                detalheVenda.Show();
            }
            else
            {
                detalheVenda.Activate();
                MessageBox.Show("A tela de detalhe de vendas já está aberta!", "FreeSales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewVendas.Rows.Count < 1)
            {
                MessageBox.Show("Não existe venda selecionada para excluir!", "FreeSales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var mensagem = "Deseja realmente excluir venda?";
            var titulo = "FreeSales";
            var res = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (venda.Excluir(int.Parse(dataGridViewVendas.CurrentRow.Cells["id_Venda"].Value.ToString())))
                {
                    MessageBox.Show("Venda excluída com sucesso!", "FreeSales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewVendas.Rows.RemoveAt(dataGridViewVendas.CurrentRow.Index);
                }
            }
        }
        DateTime data1 ;
        DateTime data2;
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            

            if (txtData1.Text != "  /  /")
            {
                data1 = Convert.ToDateTime(txtData1.Text.Replace("/", "-"));
            }
            if(txtData2.Text != "  /  /")
            {
                data2 = Convert.ToDateTime(txtData2.Text.Replace("/", "-"));
            }
            int idUsuario = 0;
            int idCargo = 0;
            int idVenda = 0;
            venda = new Venda();
            if(txtVenda.Text =="" && txtData1.Text == "  /  /" && txtData2.Text == "  /  /" && cboCargo.Text == "" && cboUsuario.Text == "")
            {
                CarregarGrid(venda.BuscarVenda(0,"","",0,0));
            }
            else
            {
                if (txtVenda.Text != "")
                {
                    idVenda = int.Parse(txtVenda.Text);
                }
                if (cboUsuario.Text != "")
                {
                    idUsuario = int.Parse(cboUsuario.SelectedValue.ToString());
                }
                if (cboCargo.Text != "")
                {
                    idCargo = int.Parse(cboCargo.SelectedValue.ToString());
                }
                CarregarGrid(venda.BuscarVenda(idVenda, data1.ToString("yyyy-MM-dd"), data2.ToString("yyyy-MM-dd"), idUsuario,idCargo));
                data1 = DateTime.UnixEpoch;
                data2 = DateTime.UnixEpoch;
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            var mensagem = "Deseja realmente limpar dados?";
            var titulo = "FreeSales";
            var res = MessageBox.Show(mensagem,titulo,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                cboCargo.Text = "";
                cboUsuario.Text = "";
                txtData1.Clear();
                txtData2.Clear();
                txtVenda.Clear();
                dataGridViewVendas.Rows.Clear();
                MessageBox.Show("Dados zerados!", "FreeSales",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ctnDados_Enter(object sender, EventArgs e)
        {

        }
        public void CarregarCombos()
        {
            try
            {
                con.Conectar();
                String Select = "SELECT * FROM tbdCargo Cargo ORDER BY ds_Cargo ASC";
                SQLiteDataAdapter ConsultarCargos = new SQLiteDataAdapter(Select, con.conexao);
                DataTable Cargos = new DataTable();
                ConsultarCargos.Fill(Cargos);
                cboCargo.DataSource = Cargos;
                cboCargo.ValueMember = "id_Cargo";
                cboCargo.DisplayMember = "ds_Cargo";
                con.Desconectar();


            }
            catch (Exception Erro)
            {
                con.Desconectar();
                MessageBox.Show(Erro.Message.ToString(), "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            try
            {
                con.Conectar();
                string Select = "SELECT id_Usuario, ds_Nome FROM tbdUsuario WHERE tp_Inativo <> 'S' ORDER BY ds_Usuario";
                SQLiteDataAdapter comando = new SQLiteDataAdapter(Select, con.conexao);
                DataTable usuarios = new DataTable();
                comando.Fill(usuarios);
                cboUsuario.DataSource = usuarios;
                cboUsuario.ValueMember = "id_Usuario";
                cboUsuario.DisplayMember = "ds_Nome";

                con.Desconectar();

            }
            catch (Exception e)
            {
                con.Desconectar();
                MessageBox.Show("Erro ao carregar usuários!\n" + e.Message, "FreeSales", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregarGrid(SQLiteDataReader linhas)
        {
            dataGridViewVendas.Rows.Clear();
            while (linhas.Read())
            {
                dataGridViewVendas.Rows.Add();
                dataGridViewVendas.Rows[dataGridViewVendas.Rows.Count - 1].Cells["id_Venda"].Value = linhas.GetInt32("id_Venda");
                dataGridViewVendas.Rows[dataGridViewVendas.Rows.Count - 1].Cells["ds_Cliente"].Value = linhas.GetString("ds_Cliente");
                dataGridViewVendas.Rows[dataGridViewVendas.Rows.Count - 1].Cells["dt_Venda"].Value = String.Format("{0:dd/MM/yyyy}", linhas.GetDateTime("dt_Venda"));
                dataGridViewVendas.Rows[dataGridViewVendas.Rows.Count - 1].Cells["vl_Total"].Value = Convert.ToDecimal(linhas.GetString("vl_Total"));
                dataGridViewVendas.Rows[dataGridViewVendas.Rows.Count - 1].Cells["qt_Total"].Value = linhas.GetInt32("qt_Total");
                if (linhas.IsDBNull("ds_Nome"))
                {
                    dataGridViewVendas.Rows[dataGridViewVendas.Rows.Count - 1].Cells["ds_Nome"].Value = "Admin";
                }
                else
                {
                    dataGridViewVendas.Rows[dataGridViewVendas.Rows.Count - 1].Cells["ds_Nome"].Value = linhas.GetString("ds_Nome");
                }
                
            }
            venda.con.Desconectar();
        }
        private void FormatarGrid()
        {
            dataGridViewVendas.Columns["vl_Total"].DefaultCellStyle.Format = "C2";
        }

        private void Vendas_FormClosing(object sender, FormClosingEventArgs e)
        {
                frmChamador.vendaAtiva = false;
        }
    }
}
