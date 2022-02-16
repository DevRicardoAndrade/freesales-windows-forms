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
using Projeto.Forms;


namespace Projeto
{
    public partial class Principal : Form
    {
        public Principal(Login login)
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.login = login;
        }
        Conexao con = new Conexao();
        public Usuario UsuarioLogado = new Usuario();
        public Cargo CargoUsuario = new Cargo();
        Login login;
        Produtos produto;
        public Boolean produtoAtivo = false;
        Vendas venda;
        public Boolean vendaAtiva = false;
        Usuarios usuario; 
        public Boolean usuarioAtivo=false;
        private void Principal_Load(object sender, EventArgs e)
        {
            panelPrincipal.Width = this.Size.Width;
            panelPrincipal.Height = this.Size.Height;
            try
            {
                con.Conectar();
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message.ToString(), "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            lblUsuario.Text = UsuarioLogado.Ds_Nome;
            if (UsuarioLogado.Ds_Usuario != "admin")
            {
                String ConsultaCargo = "SELECT" +
                    " * " +
                    "FROM tbdUsuario Usuario " +
                    "INNER JOIN tbdCargo Cargo on (Cargo.id_Cargo = Usuario.id_Cargo)" +
                    " WHERE Usuario.id_Usuario = " + UsuarioLogado.Id;
                SQLiteDataAdapter Select = new SQLiteDataAdapter(ConsultaCargo, con.conexao);
                DataTable Cargo = new DataTable();
                Select.Fill(Cargo);
                CargoUsuario.Tp_cargo = Cargo.Rows[0]["tp_Cargo"].ToString();



                if (CargoUsuario.Tp_cargo == "N")
                {
                    btnProdutos.Enabled = false;
                    btnUsuarios.Enabled = false;
                    btnRelatorios.Enabled = false;
                    cadastroToolStripMenuItem.Enabled = false;

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
                this.Close();
                login.Show();
            }

        }
        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Show();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarioAtivo == false)
            {
                usuario = new Usuarios(this);
                usuario.TopLevel = false;
                foreach (Form forms in panelPrincipal.Controls)
                {
                    forms.WindowState = FormWindowState.Minimized;
                }
                panelPrincipal.Controls.Add(usuario);
                usuario.Show();

            }
            else
            {
                usuario.WindowState = FormWindowState.Normal;
                MessageBox.Show("A tela de usuário já está aberta!", "Usuario aberto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (produtoAtivo == false)
            {
                produto = new Produtos(this);
                produto.TopLevel = false;
                foreach (Form forms in panelPrincipal.Controls)
                {
                    forms.WindowState = FormWindowState.Minimized;
                }
                panelPrincipal.Controls.Add(produto);
                produto.Show();
            }
            else
            {
                produto.WindowState = FormWindowState.Normal;
                MessageBox.Show("A tela de produtos já está aberta!", "Produto aberto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string mensagem = "Deseja realmente sair do sistema?";
            const string titulo = "Saindo do sistema";
            var sair = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
            {
                this.Close();
                login.Show();
            }
        }

        private void consultarVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vendaAtiva == false)
            {
                venda = new Vendas(this, UsuarioLogado);
                venda.TopLevel = false;
                foreach (Form forms in panelPrincipal.Controls)
                {
                    forms.WindowState = FormWindowState.Minimized;
                }
                panelPrincipal.Controls.Add(venda);
                venda.Show();
            }
            else
            {
                venda.WindowState = FormWindowState.Normal;
                MessageBox.Show("A tela de vendas já está aberta!", "Vendas aberta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (usuarioAtivo == false)
            {
                foreach(Form forms in panelPrincipal.Controls)
                {
                    forms.WindowState = FormWindowState.Minimized;  
                }
                usuario = new Usuarios(this);
                usuario.TopLevel = false;
                panelPrincipal.Controls.Add(usuario);
                usuario.Show();

            }
            else
            {
                usuario.WindowState = FormWindowState.Normal;
                MessageBox.Show("A tela de usuário já está aberta!", "Usuario aberto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            if (vendaAtiva == false)
            {
                venda = new Vendas(this,UsuarioLogado);
                venda.TopLevel = false;
                foreach (Form forms in panelPrincipal.Controls)
                {
                    forms.WindowState = FormWindowState.Minimized;
                }
                panelPrincipal.Controls.Add(venda);
                venda.Show();
            }
            else
            {
                venda.WindowState = FormWindowState.Normal;
                MessageBox.Show("A tela de vendas já está aberta!", "Vendas aberta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            if (produtoAtivo == false)
            {
                produto = new Produtos(this);
                produto.TopLevel = false;
                foreach (Form forms in panelPrincipal.Controls)
                {
                    forms.WindowState = FormWindowState.Minimized;
                }
                panelPrincipal.Controls.Add(produto);
                produto.Show();
            }
            else
            {
                produto.WindowState = FormWindowState.Normal;
                MessageBox.Show("A tela de produtos já está aberta!", "Produto aberto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        public DadosVenda IncluirVenda;
        public Boolean dVendasAtivo = false;
        private void incluirVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dVendasAtivo == false)
            {
                IncluirVenda = new DadosVenda (this, UsuarioLogado.Id );
                IncluirVenda.TopLevel = false;
                foreach (Form forms in panelPrincipal.Controls)
                {
                    forms.WindowState = FormWindowState.Minimized;
                }
                panelPrincipal.Controls.Add(IncluirVenda);
                IncluirVenda.Show();
            }
            else
            {
                IncluirVenda.WindowState = FormWindowState.Normal;
                MessageBox.Show("A tela de cadastro de vendas já está aberta!", "FreeSales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public Relatorios relatorios;
        public bool relatoriosAtivo = false;
        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            if (relatoriosAtivo == false)
            {
                relatorios = new Relatorios(this);
                relatorios.TopLevel = false;
                foreach (Form forms in panelPrincipal.Controls)
                {
                    forms.WindowState = FormWindowState.Minimized;
                }
                panelPrincipal.Controls.Add(relatorios);
                relatorios.Size = panelPrincipal.Size;
                relatorios.Show();
            }
            else
            {
                relatorios.WindowState = FormWindowState.Normal;
                MessageBox.Show("A tela de relatórios já está aberta!", "FreeSales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
