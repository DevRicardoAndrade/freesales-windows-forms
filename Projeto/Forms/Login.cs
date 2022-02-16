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

namespace Projeto{


    public partial class Login : Form
{
        Conexao con = new Conexao();

        Usuario usuario = new Usuario();


        public Login()
    {
        InitializeComponent();
    }

    private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                con.Conectar();
                con.Desconectar();
            }
            catch (Exception Erro){
                con.Desconectar();
                MessageBox.Show(Erro.Message.ToString(),"Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            
    }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "";
            String ConsultaUsuario = "SELECT * FROM tbdUsuario WHERE ds_Usuario = '" + txtUsuario.Text + "'" + " AND ds_Senha = '" + txtSenha.Text + "'";

            if (txtUsuario.Text == "admin" && txtSenha.Text == "admin")
            {
                Principal principal = new Principal(this);
                var mensagem = "Bem vindo Admin!";
                var titulo = "Bem vindo";
                MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                principal.UsuarioLogado.Ds_Nome = "Admin";
                principal.UsuarioLogado.Ds_Usuario = "admin";
                principal.Show();
                this.Hide();
            }
            else if (txtUsuario.Text == "" || txtSenha.Text == "") {
                lblMensagem.ForeColor=Color.Yellow;
                lblMensagem.Text = "Usuário ou senha não digitados.\nPor favor inserir os dados e fazer login";
                var mensagem = "Usuário ou senha não digitados, por favor inserir os dados e fazer login";
                var titulo = "Aviso";
                MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else{
                try
                {
                    SQLiteDataAdapter Select = new SQLiteDataAdapter(ConsultaUsuario, con.conexao);
                    DataTable Usuario = new DataTable();
                    Select.Fill(Usuario);
                    if (Usuario.Rows.Count > 0)
                    {
                        {
                            Principal principal = new Principal(this);
                            usuario.Ds_Usuario = txtUsuario.Text;
                            usuario.Tp_Inativo = Usuario.Rows[0]["tp_Inativo"].ToString();
                            usuario.Ds_Nome = Usuario.Rows[0]["ds_Nome"].ToString();
                            usuario.Id = int.Parse(Usuario.Rows[0]["id_Usuario"].ToString());

                            if (usuario.Tp_Inativo == "N")
                            {
                                var mensagem = "Bem vindo " + usuario.Ds_Nome;
                                var titulo = "Bem vindo";
                                MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                principal.UsuarioLogado.Id = usuario.Id;
                                principal.UsuarioLogado.Ds_Nome = usuario.Ds_Nome;
                                principal.Show();
                                this.Hide();
                            }
                            else if (usuario.Tp_Inativo == "S")
                            {
                                lblMensagem.ForeColor = Color.Red;
                                lblMensagem.Text = "Usuário esta inativado.\nFavor contatar seu administrador.";
                                var mensagem = "Usuário esta inativado.\nFavor contatar seu administrador.";
                                var titulo = "Aviso";
                                MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtUsuario.Focus();
                            }
                        }
                    }
                    else if (Usuario.Rows.Count == 0)
                    {
                        lblMensagem.ForeColor = Color.Red;
                        lblMensagem.Text = "Usuário ou senha digitados está incorreto.\nCaso não esteja cadastrado, favor contatar seu administrador.";
                        MessageBox.Show("Usuário ou senha digitados está incorreto.\nCaso não esteja cadastrado, favor contatar seu administrador.", "Erro ao acessar sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                catch (Exception Erro)
                {
                    MessageBox.Show( Erro.Message.ToString(), "Erro ao acessar sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            const string mensagem = "Deseja realmente sair do sistema?";
            const string titulo = "Saindo do sistema";
            var sair = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
            {
                con.Desconectar();
                Application.Exit();
            }
            
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblFavor_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
                con.Desconectar();
                Application.Exit();
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
