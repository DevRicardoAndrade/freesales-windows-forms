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
    public class Usuario
    {
        public int Id { get; set; }
        public String Ds_Usuario { get; set; }
        public String Ds_Cargo { get; set; }
        public String Ds_Nome { get; set; }
        public String Ds_Senha { get; set; }
        public String Tp_Inativo { get; set; }
        public DataTable RetornoUsuario = new DataTable();
        Conexao con = new Conexao();

        public void BuscarUsuarios(String Nome, int Cargo, String Usuario, String Inativo)
        {
            if (Cargo == 0)
            {
                
                String sWhere = "";
                if (sWhere == "")
                {
                    if (Nome != "")
                    {
                        sWhere = "Usuario.ds_Nome LIKE '%" + Nome + "%'";
                    }
                }
                else if (sWhere != "")
                {
                    if (Nome != "")
                    {
                        sWhere = sWhere + " AND Usuario.ds_Nome LIKE '%" + Nome + "%'";
                    }
                }
                if (sWhere == "")
                {
                    if (Usuario != "")
                    {
                        sWhere = "Usuario.ds_Usuario LIKE '%" + Usuario + "%'";
                    }
                }
                else if (sWhere != "")
                {
                    if (Usuario != "")
                    {
                        sWhere = sWhere + " AND Usuario.ds_Usuario LIKE '%" + Usuario + "%'";
                    }
                }

                if (sWhere == "")
                {
                    if (Inativo != "")
                    {
                        sWhere = "Usuario.tp_Inativo = '" + Inativo + "'";
                    }
                }
                else if (sWhere != "")
                {
                    if (Inativo != "")
                    {
                        sWhere = sWhere + " AND Usuario.tp_Inativo ='" + Inativo + "'";
                    }
                }
                string Select;
                if(sWhere == "")
                {
                     Select = "SELECT" +
                    " Usuario.id_Usuario, " +
                    " Usuario.ds_Nome," +
                    "Cargo.ds_Cargo," +
                    "Usuario.ds_Usuario," +
                    "Usuario.tp_Inativo, " +
                    "Usuario.dt_Cadastro " +
                    "FROM tbdUsuario Usuario " +
                    "INNER JOIN tbdCargo Cargo on (Usuario.id_Cargo = Cargo.id_Cargo)" 
                    +
                    " ORDER BY ds_Nome";
                }
                else
                {
                     Select = "SELECT" +
                    " Usuario.id_Usuario, " +
                    " Usuario.ds_Nome," +
                    "Cargo.ds_Cargo," +
                    "Usuario.ds_Usuario," +
                    "Usuario.tp_Inativo, " +
                    "Usuario.dt_Cadastro " +
                    "FROM tbdUsuario Usuario " +
                    "INNER JOIN tbdCargo Cargo on (Usuario.id_Cargo = Cargo.id_Cargo)" +
                    " WHERE " + sWhere + " " +
                    "ORDER BY ds_Nome";
                }
                
                
                try
                {
                    SQLiteCommand comando;
                    SQLiteDataReader ler;
                    comando = new SQLiteCommand(Select, con.conexao);
                    SQLiteDataAdapter ConsultarUsuarios = new SQLiteDataAdapter(comando);
                    DataTable Usuarios = new DataTable();
                    ConsultarUsuarios.Fill(Usuarios);
                    RetornoUsuario = Usuarios;
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Ocorreu erro ao buscar o(s) usuario(s). " + Erro.Message.ToString(), "Erro na consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
               
                String sWhere = "";
                if (sWhere == "")
                {
                    if (Nome != "")
                    {
                        sWhere = "Usuario.ds_Nome LIKE '%" + Nome + "%'";
                    }
                }
                else if (sWhere != "")
                {
                    if (Nome != "")
                    {
                        sWhere = sWhere + " AND Usuario.ds_Nome LIKE '%" + Nome + "%'";
                    }
                }

                if (sWhere == "")
                {
                    if (Cargo != 0)
                    {
                        sWhere = "Cargo.id_Cargo = " + Cargo;
                    }
                }
                else if (sWhere != "")
                {
                    if (Cargo != 0)
                    {
                        sWhere = sWhere + " AND Cargo.id_Cargo = " + Cargo;
                    }
                }
                if (sWhere == "")
                {
                    if (Usuario != "")
                    {
                        sWhere = "Usuario.ds_Usuario LIKE '%" + Usuario + "%'";
                    }
                }
                else if (sWhere != "")
                {
                    if (Usuario != "")
                    {
                        sWhere = sWhere + " AND Usuario.ds_Usuario LIKE '%" + Usuario + "%'";
                    }
                }

                if (sWhere == "")
                {
                    if (Inativo != "")
                    {
                        sWhere = "Usuario.tp_Inativo = '" + Inativo + "'";
                    }
                }
                else if (sWhere != "")
                {
                    if (Inativo != "")
                    {
                        sWhere = sWhere + " AND Usuario.tp_Inativo ='" + Inativo + "'";
                    }
                }

                String Select;
                if (sWhere == "")
                {
                    Select = "SELECT" +
                    " Usuario.id_Usuario, " +
                    " Usuario.ds_Nome," +
                    "Cargo.ds_Cargo," +
                    "Usuario.ds_Usuario," +
                    "Usuario.tp_Inativo, " +
                    "Usuario.dt_Cadastro " +
                    "FROM tbdUsuario Usuario " +
                    "INNER JOIN tbdCargo Cargo on (Usuario.id_Cargo = Cargo.id_Cargo)" +
                    " ORDER BY ds_Nome";
                }
                else
                {
                    Select = "SELECT" +
                        " Usuario.id_Usuario, " +
                        " Usuario.ds_Nome," +
                        "Cargo.ds_Cargo," +
                        "Usuario.ds_Usuario," +
                        "Usuario.tp_Inativo, " +
                        "Usuario.dt_Cadastro " +
                        "FROM tbdUsuario Usuario " +
                        "INNER JOIN tbdCargo Cargo on (Usuario.id_Cargo = Cargo.id_Cargo)" +
                        " WHERE " + sWhere + " " +
                        "ORDER BY ds_Nome";
                }

                try
                {
                    SQLiteCommand comando;
                    SQLiteDataReader ler;
                    comando = new SQLiteCommand(Select, con.conexao);
                    SQLiteDataAdapter ConsultarUsuarios = new SQLiteDataAdapter(comando);
                    DataTable Usuarios = new DataTable();
                    ConsultarUsuarios.Fill(Usuarios);
                    RetornoUsuario = Usuarios;
                }
                catch (Exception Erro)
                {
                    con.Desconectar();
                    MessageBox.Show("Ocorreu erro ao buscar o(s) usuario(s). " + Erro.Message.ToString(), "Erro na consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public Boolean Cadastrar(String Nome, int Cargo, String Usuario, String Senha, String Inativo)
        {
            try
            {
                
                
                con.Conectar();
                String validarUsuario = "SELECT * FROM tbdUsuario WHERE ds_Usuario = '" + Usuario +"'";
                SQLiteCommand comandoValidar = new SQLiteCommand(validarUsuario, con.conexao);
                SQLiteDataAdapter Consultar = new SQLiteDataAdapter(comandoValidar);
                DataTable linhasUsuarios = new DataTable();
                Consultar.Fill(linhasUsuarios);
                if(linhasUsuarios.Rows.Count > 0)
                {
                    con.Desconectar();
                    MessageBox.Show("Este nome de usuário já esta cadastrado!\nFavor escolher outro.","Usuario já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                String Insert = "INSERT INTO tbdUsuario (ds_Nome,ds_Usuario,ds_Senha,id_Cargo,tp_Inativo) " +
                "VALUES ('" + Nome + "', '" + Usuario + "', '" + Senha + "', '" + Cargo + "', '" + Inativo + "')";
                SQLiteCommand comando = new SQLiteCommand(Insert, con.conexao);
                comando.ExecuteNonQuery();
                const string mensagem2 = "Usuário cadastrado!";
                const string titulo2 = "Cadastrado";
                MessageBox.Show(mensagem2, titulo2, MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Desconectar();
                return true;

            }
            catch (Exception Erro)
            {
                con.Desconectar();
                MessageBox.Show(Erro.Message.ToString(), "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

        }
        public Boolean Atualizar(int id,String Nome, int Cargo, String Usuario, String Inativo) 
        {
            try
            {
                
                con.Conectar();
                String validarUsuario = "SELECT * FROM tbdUsuario WHERE ds_Usuario = '" + Usuario + "'";
                SQLiteCommand comandoValidar = new SQLiteCommand(validarUsuario, con.conexao);
                SQLiteDataAdapter Consultar = new SQLiteDataAdapter(comandoValidar);
                DataTable linhasUsuarios = new DataTable();
                Consultar.Fill(linhasUsuarios);
                string validaUsuario2 = "SELECT * FROM tbdUsuario WHERE id_Usuario = " + id;
                SQLiteCommand comandoValidar2 = new SQLiteCommand(validaUsuario2, con.conexao);
                SQLiteDataAdapter Consultar2 = new SQLiteDataAdapter(comandoValidar2);
                DataTable linhasUsuarios2 = new DataTable();
                Consultar2.Fill(linhasUsuarios2);
                if (linhasUsuarios.Rows.Count > 0 && Usuario != linhasUsuarios2.Rows[0]["ds_Usuario"].ToString())
                {
                    con.Desconectar();
                    MessageBox.Show("Este nome de usuário já esta cadastrado!\nFavor escolher outro.", "Usuario já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                String Update = "UPDATE tbdUsuario SET ds_Nome = '" + Nome + "',ds_Usuario = '" + Usuario + "', tp_Inativo = '" + Inativo + "' ,id_Cargo = " + Cargo 
                    + " WHERE id_Usuario = " + id;
                SQLiteCommand comando = new SQLiteCommand(Update, con.conexao);
                comando.ExecuteNonQuery();
                const string mensagem2 = "Usuário alterado!";
                const string titulo2 = "Alterado";
                MessageBox.Show(mensagem2, titulo2, MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Desconectar();
                return true;

            }
            catch (Exception Erro)
            {
                con.Desconectar();
                return false;
                MessageBox.Show(Erro.Message.ToString(), "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void Excluir(int id) 
        {
            try
            {
                
                con.Conectar();
                String Delete = "DELETE FROM tbdUsuario WHERE id_Usuario = " + id;
                SQLiteCommand comando = new SQLiteCommand(Delete, con.conexao);
                comando.ExecuteNonQuery();
                const string mensagem2 = "Usuário excluído!";
                const string titulo2 = "Excluído";
                MessageBox.Show(mensagem2, titulo2, MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Desconectar();

            }
            catch (Exception Erro)
            {
                con.Desconectar();
                MessageBox.Show(Erro.Message.ToString(), "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

    }
}
