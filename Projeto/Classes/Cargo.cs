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
    public class Cargo
    {
        public long Id { get; set; }
        public String Tp_cargo { get; set; }
        public String Ds_Cargo { get; set; }
        Conexao con = new Conexao();
        public void AlterarCargo(String Nome, String TipoCargo , int id)
        {
            try 
            {
                
                con.Conectar();
                String Update = "UPDATE tbdCargo SET ds_Cargo = '" + Nome + "', tp_Cargo = '" + TipoCargo + "' WHERE id_Cargo = " + id;
                SQLiteCommand comando = new SQLiteCommand(Update, con.conexao);
                comando.ExecuteNonQuery();
                const string mensagem2 = "Cargo alterado com sucesso!";
                const string titulo2 = "Alterado";
                MessageBox.Show(mensagem2, titulo2, MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Desconectar();
            }
            catch (Exception Erro)
            {
                con.Desconectar();
                MessageBox.Show(Erro.Message,"Erro ao atualizar dados",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public void CadastrarCargo(String Nome, String TipoCargo)
        {
            try
            {
                
                con.Conectar();
                String Insert = "INSERT INTO tbdCargo (ds_Cargo,tp_Cargo) " +
                "VALUES ('" + Nome + "', '" + TipoCargo + "')";
                SQLiteCommand comando = new SQLiteCommand(Insert, con.conexao);
                comando.ExecuteNonQuery();
                const string mensagem2 = "Cargo Cadastrado";
                const string titulo2 = "Cadastrado";
                MessageBox.Show(mensagem2, titulo2, MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Desconectar();

            }
            catch (Exception Erro)
            {
                con.Desconectar();
                MessageBox.Show(Erro.Message.ToString(), "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void Excluir(int id) 
        {
            try
            {
                
                con.Conectar();
                String Delete = "DELETE FROM tbdCargo WHERE id_Cargo = " + id;
                SQLiteCommand comando = new SQLiteCommand(Delete, con.conexao);
                comando.ExecuteNonQueryAsync();
                const string mensagem2 = "Cargo excluído";
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
