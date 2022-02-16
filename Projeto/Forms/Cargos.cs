using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Projeto
{
    public partial class Cargos : Form
    {
        Conexao con = new Conexao();
        Cargo cargo = new Cargo();
        string[] dadosCargo;
        int id;
        Usuarios frmChamador;


        public Cargos(Usuarios usuarios)
        {
            this.frmChamador = usuarios;
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
        public void atualizaLista()
        {
            try
                {
                    con.Conectar();
                    String Select = "SELECT * FROM tbdCargo Cargo ORDER BY ds_Cargo";
                    SQLiteCommand comando = new SQLiteCommand(Select, con.conexao);
                    SQLiteDataReader linha;
                    linha = comando.ExecuteReader();
                while (linha.Read())
                {
                    string dadosLinha;
                    string descricao = linha.GetString("ds_Cargo");
                    int id = linha.GetInt32("id_Cargo");
                    string tipo = linha.GetString("tp_Cargo");
                    dadosLinha = id + "-" + descricao + "-" + tipo; 
                    lstboxCargo.Items.Add(dadosLinha);
                }

                    
                    con.Desconectar();
            }
            catch (Exception Erro)
                {
                    MessageBox.Show(Erro.Message.ToString(), "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    
            }
        }
        private void Cargos_Load(object sender, EventArgs e)
        {
            atualizaLista();
            frmChamador.cargoAtivo = true;
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            frmChamador.CarregarCombo();
            frmChamador.cargoAtivo = false;
            this.Close();
            
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            var mensagem = "Deseja realmente cadastrar cargo?";
            var titulo = "Cadastrar cargo";
            var cadastrar = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cadastrar == DialogResult.Yes)
            {
                if (optAdmin.Checked)
                {
                    cargo.CadastrarCargo(txtCargo.Text, "A");
                }
                else if (optNormal.Checked)
                {
                    cargo.CadastrarCargo(txtCargo.Text, "N");
                }
                else
                {
                    MessageBox.Show("Favor selecionar o tipo do cargo", "Opção de cargo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                lstboxCargo.Items.Clear();
                atualizaLista();
            }
            
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (lstboxCargo.SelectedItem is null)
            {
                MessageBox.Show("É necessário selecionar um cargo para excluir!", "Selecionar Cargo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var mensagem = "Deseja realmente excluir cargo?";
            var titulo = "Excluir cargo";
            var cadastrar = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cadastrar == DialogResult.Yes)
            {
                dadosCargo = lstboxCargo.SelectedItem.ToString().Split("-");
                id = int.Parse(dadosCargo[0]);
                cargo.Excluir(id);
                lstboxCargo.Items.Clear();
                atualizaLista();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                if (lstboxCargo.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Não tem nenhum cargo selecionado.\nFavor selecionar o cargo que deseja alterar.", "Sem cargo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lstboxCargo.Enabled = false;
                    btnAtualizar.Visible = true;
                    btnCancelar.Visible = true;
                    btnSalvar.Visible = false;
                    btnExcluir.Visible = false;
                    btnAlterar.Enabled = false;
                    dadosCargo = lstboxCargo.SelectedItem.ToString().Split("-");
                    id = int.Parse(dadosCargo[0]);
                    txtCargo.Text = dadosCargo[1];
                    if (dadosCargo[2] == "A")
                    {
                        optAdmin.Checked = true;
                    }
                    else
                    {
                        optNormal.Checked = true;
                    }
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message.ToString(), "Erro ao selecionar cargo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lstboxCargo.Enabled = true;
            btnAtualizar.Visible = false;
            btnCancelar.Visible = false;
            btnSalvar.Visible = true;
            btnExcluir.Visible = true;
            btnAlterar.Enabled = true;
            id = 0;
            optAdmin.Checked = false;
            optNormal.Checked = false;
            txtCargo.Clear();
            lstboxCargo.Items.Clear();
            atualizaLista();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var mensagem = "Deseja realmente atualizar cargo?";
            var titulo = "Atualizar cargo";
            var cadastrar = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cadastrar == DialogResult.Yes)
            {
                if (optAdmin.Checked)
                {
                    
                    cargo.AlterarCargo(txtCargo.Text, "A", id);
                    lstboxCargo.Enabled = true;
                    btnAtualizar.Visible = false;
                    btnCancelar.Visible = false;
                    btnSalvar.Visible = true;
                    btnExcluir.Visible = true;
                    btnAlterar.Enabled = true;
                    optAdmin.Checked = false;
                    optNormal.Checked = false;
                    txtCargo.Clear();
                }
                else
                {
                    cargo.AlterarCargo(txtCargo.Text, "N", id);
                    lstboxCargo.Enabled = true;
                    btnAtualizar.Visible = false;
                    btnCancelar.Visible = false;
                    btnSalvar.Visible = true;
                    btnExcluir.Visible = true;
                    btnAlterar.Enabled = true;
                    optAdmin.Checked = false;
                    optNormal.Checked = false;
                    txtCargo.Clear();
                }
                
            }
            id = 0;
            lstboxCargo.Items.Clear();
            atualizaLista();
            
        }

        private void Cargos_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmChamador.cargoAtivo = false;
        }
    }
}