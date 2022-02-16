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
    public partial class Usuarios : Form

    {
        public Principal frmChamador;
        Usuario usuario = new Usuario();
        Conexao con = new Conexao();
        int id;
        public Usuarios(Principal frmChamador)
        {
            InitializeComponent();
            this.frmChamador = frmChamador;
        }
        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
        public void CarregarCombo()
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
        }
        private void Usuarios_Load(object sender, EventArgs e)
        {
            CarregarCombo();
            frmChamador.usuarioAtivo = true;
        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
        private void cboCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ctnUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void grdUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ctnUsuario2_Enter(object sender, EventArgs e)
        {

        }
        private void addLinha(int id, string nome, string cargo, string usuario, string inativo, DateTime dtCadastro)
        {
            DataTable dt = new DataTable();
            DataColumn dc;
            dc = dt.Columns.Add("id_Usuario");
            dc = dt.Columns.Add("ds_Nome");
            dc = dt.Columns.Add("ds_Cargo");
            dc = dt.Columns.Add("ds_Usuario");
            dc = dt.Columns.Add("tp_Inativo");
            dc = dt.Columns.Add("dt_Cadastro");
            DataRow dr = dt.NewRow();
            dr["id_Usuario"] = string.Empty;
            dr["ds_Nome"] = nome;
            dr["ds_Cargo"] = cargo;
            dr["ds_Usuario"] = usuario;
            dr["tp_Inativo"] = inativo;
            dr["dt_Cadastro"] = dtCadastro;
            dt.Rows.Add(dr);
            grdUsuario.DataSource = dt;
        }
        private void Usuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmChamador.usuarioAtivo = false;
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmChamador.usuarioAtivo = false;
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            try
            {
                const string mensagem = "Deseja realmente limpar os dados da tela?";
                const string titulo = "Limpando dados";
                var limpar = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (limpar == DialogResult.Yes)
                {
                    foreach(DataGridViewRow row in grdUsuario.Rows)
                    {
                        grdUsuario.Rows.RemoveAt(row.Index);
                    }
                    grdUsuario.Refresh();
                    cboCargo.Text = "";
                    txtNome.Text = "";
                    txtSenha.Text = "";
                    txtUsuario.Text = "";
                    chkInativo.Checked = false;
                    cboCargo.SelectedValue = 0;
                    txtNome.Focus();
                    const string mensagem2 = "Dados zerados";
                    const string titulo2 = "Limpou dados";
                    var limpo = MessageBox.Show(mensagem2, titulo2, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Não foi possivel limpar os dados " + Erro.Message.ToString(), "Erro ao limpar dados", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            btnAtualizar.Visible = false;
            btnCancelar.Visible = false;
            btnExcluir.Enabled = true;
            btnSalvar.Visible = true;
            btnAtualizar.Visible = false;
            ctnUsuario2.Enabled = true;
            chkInativo.Checked = false;
            btnCargo.Enabled = true;
            txtSenha.Enabled = true;
            btnLimpar.Enabled = true;
            txtUsuario.Clear();
            txtSenha.Clear();
            txtNome.Clear();
            txtNome.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {

                if (grdUsuario.RowCount == 0)
                {
                    MessageBox.Show("Não tem nenhum usuário selecionado.\nFavor buscar o usuario que deseja alterar.", "Sem usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    btnAtualizar.Visible = true;
                    btnCancelar.Visible = true;
                    btnExcluir.Enabled = false;
                    btnSalvar.Visible = false;
                    btnLimpar.Enabled = false;
                    txtSenha.Enabled = false;
                    btnCargo.Enabled = false;
                    id = Int32.Parse(grdUsuario.CurrentRow.Cells[0].Value.ToString());
                    txtNome.Text = grdUsuario.CurrentRow.Cells[1].Value.ToString();
                    cboCargo.Text = grdUsuario.CurrentRow.Cells[2].Value.ToString();
                    txtUsuario.Text = grdUsuario.CurrentRow.Cells[3].Value.ToString();
                    if (grdUsuario.CurrentRow.Cells[4].Value.ToString() == "S")
                    {
                        chkInativo.Checked = true;
                    }
                    else
                    {
                        chkInativo.Checked = false;
                    }
                    ctnUsuario2.Enabled = false;

                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message.ToString(), "Erro ao selecionar usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtUsuario.Text == "")
            {
                MessageBox.Show("É necessário preencher os campos para alterar usuário!", "Faltando os campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var mensagem = "Deseja realmente alterar os dados do usuário?";
                var titulo = "Alterar usuário";
                var atualizar = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (atualizar == DialogResult.Yes)
                {
                    if (chkInativo.Checked)
                    {
                        if(usuario.Atualizar(id, txtNome.Text, Int32.Parse(cboCargo.SelectedValue.ToString()), txtUsuario.Text, "S"))
                        {
                            usuario.BuscarUsuarios(txtNome.Text, int.Parse(cboCargo.SelectedValue.ToString()), txtUsuario.Text, "S");
                            grdUsuario.DataSource = usuario.RetornoUsuario;
                            btnAtualizar.Visible = false;
                            btnCancelar.Visible = false;
                            btnExcluir.Enabled = true;
                            btnSalvar.Visible = true;
                            btnAtualizar.Visible = false;
                            btnLimpar.Enabled = true;
                            btnCargo.Enabled = true;
                            ctnUsuario2.Enabled = true;
                            txtSenha.Enabled = true;
                            txtUsuario.Clear();
                            txtSenha.Clear();
                            txtNome.Clear();
                            txtNome.Focus();
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        if(usuario.Atualizar(id, txtNome.Text, Int32.Parse(cboCargo.SelectedValue.ToString()), txtUsuario.Text, "N"))
                        {
                            usuario.BuscarUsuarios(txtNome.Text, int.Parse(cboCargo.SelectedValue.ToString()), txtUsuario.Text, "N");
                            grdUsuario.DataSource = usuario.RetornoUsuario;
                            btnAtualizar.Visible = false;
                            btnCancelar.Visible = false;
                            btnExcluir.Enabled = true;
                            btnSalvar.Visible = true;
                            btnAtualizar.Visible = false;
                            txtSenha.Enabled = true;
                            btnCargo.Enabled = true;
                            btnLimpar.Enabled = true;
                            ctnUsuario2.Enabled = true;
                            txtUsuario.Clear();
                            txtSenha.Clear();
                            txtNome.Clear();
                            txtNome.Focus();
                        }
                        else
                        {
                            return;
                        }

                    }
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro: " + Erro.ToString(), "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("É necessário preencher os campos para cadastrar usuário!", "Faltando os campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            const string mensagem = "Deseja realmente cadastrar esse usuário?";
            const string titulo = "FreeSales";
            var salvar = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salvar == DialogResult.Yes)
            {
                try
                {

                    if (chkInativo.Checked)
                    {
                        if(usuario.Cadastrar(txtNome.Text, Int32.Parse(cboCargo.SelectedValue.ToString()), txtUsuario.Text, txtSenha.Text, "S"))
                        {
                            usuario.BuscarUsuarios(txtNome.Text, int.Parse(cboCargo.SelectedValue.ToString()), txtUsuario.Text, "S");
                            grdUsuario.DataSource = usuario.RetornoUsuario;
                            txtUsuario.Clear();
                            txtSenha.Clear();
                            txtNome.Clear();
                            txtNome.Focus();
                        }
                        

                    }
                    else
                    {
                        if(usuario.Cadastrar(txtNome.Text, Int32.Parse(cboCargo.SelectedValue.ToString()), txtUsuario.Text, txtSenha.Text, "N"))
                        {
                            usuario.BuscarUsuarios(txtNome.Text, int.Parse(cboCargo.SelectedValue.ToString()), txtUsuario.Text, "N");
                            grdUsuario.DataSource = usuario.RetornoUsuario;
                            txtUsuario.Clear();
                            txtSenha.Clear();
                            txtNome.Clear();
                            txtNome.Focus();
                        }
                    }

                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro ao salvar usuário" + Erro.Message.ToString(), "FreeSales", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
                if (chkInativo.Checked)
                {
                    if (cboCargo.Text == "")
                    {
                        usuario.BuscarUsuarios(txtNome.Text, 0, txtUsuario.Text, "S");
                        grdUsuario.DataSource = usuario.RetornoUsuario;
                    }
                    else
                    {
                        usuario.BuscarUsuarios(txtNome.Text, int.Parse(cboCargo.SelectedValue.ToString()), txtUsuario.Text, "S");
                        grdUsuario.DataSource = usuario.RetornoUsuario;
                    }
                }
                else
                {
                    if (cboCargo.Text == "")
                    {
                        usuario.BuscarUsuarios(txtNome.Text, 0, txtUsuario.Text, "N");
                        grdUsuario.DataSource = usuario.RetornoUsuario;
                    }
                    else
                    {
                        int idCargo = int.Parse(cboCargo.SelectedValue.ToString());
                        usuario.BuscarUsuarios(txtNome.Text, idCargo, txtUsuario.Text, "N");
                        grdUsuario.DataSource = usuario.RetornoUsuario;
                    }
                }
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (grdUsuario.RowCount == 0)
            {
                MessageBox.Show("Não tem nenhum usuário selecionado.\nFavor buscar o usuario que deseja excluir.", "FreeSales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            const string mensagem = "Deseja realmente excluir este usuário?";
            const string titulo = "FreeSales";
            var excluir = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (excluir == DialogResult.Yes)
            {
                id = Int32.Parse(grdUsuario.CurrentRow.Cells[0].Value.ToString());
                usuario.Excluir(id);
                grdUsuario.Rows.RemoveAt(grdUsuario.CurrentRow.Index);
            }
        }
        Cargos cargo;
        public Boolean cargoAtivo = false;
        private void btnCargo_Click_1(object sender, EventArgs e)
        {
            if (cargoAtivo == false)
            {
                
                cargo = new Cargos(this);
                cargo.TopLevel = false;
                foreach (Control controles in frmChamador.Controls)
                {
                    if(controles.Name == "panelPrincipal")
                    {
                        foreach (Form forms in controles.Controls)
                        {
                            forms.WindowState = FormWindowState.Minimized;
                        }
                        controles.Controls.Add(cargo);
                    }
                }
                cargo.Show();
            }
            else
            {
                cargo.Activate();
                MessageBox.Show("A tela de cargos já está aberta!", "FreeSales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
        }

        private void ctnUsuario2_Enter_1(object sender, EventArgs e)
        {

        }

        private void cboCargo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ctnUsuario_Enter_1(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }
    }
}