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
    public class TipoProduto
    {
        int Id { get; set; }
        string Descricao { get; set; }
        char Inativo { get; set; }

        Conexao con = new Conexao();

        public void Inserir(string Descricao, char Inativo)
        {
            try
            {
                con.Conectar();
                SQLiteCommand comando;
                string Insert = "INSERT INTO tbdTipoProduto (ds_TipoProduto, tp_Inativo) VALUES ('" + Descricao + "', '" + Inativo + "')";
                comando = new SQLiteCommand(Insert, con.conexao);
                comando.ExecuteNonQuery();
                MessageBox.Show("Tipo de produto Inserido com sucesso.","Tipo de produto",MessageBoxButtons.OK,MessageBoxIcon.Information);
                con.Desconectar();
            }
            catch(Exception e)
            {
                con.Desconectar();
                MessageBox.Show("Ocorreu um erro ao inserir tipo de produto \n" + e.Message,"Erro ao incluir",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public void Excluir(int id)
        {
            try
            {
                con.Conectar();
                string Delete = "DELETE FROM tbdTipoProduto WHERE id_TipoProduto = " + id;
                SQLiteCommand comando = new SQLiteCommand(Delete, con.conexao);
                comando.ExecuteNonQueryAsync();
                MessageBox.Show("Tipo de produto excluído com sucesso","Excluído",MessageBoxButtons.OK,MessageBoxIcon.Information);
                con.Desconectar();
            }
            catch(Exception e)
            {
                MessageBox.Show("Ocorreu um erro na exclusão\n" + e.Message, "Erro na exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Desconectar();
            }
        }
        public void Atualizar(int id, string descricao,string Inativo)
        {
            try
            {
                con.Conectar();
                SQLiteCommand comando;
                string Update = "UPDATE tbdTipoProduto SET ds_TipoProduto = '" + descricao + "', tp_Inativo = '" + Inativo + "' WHERE id_TipoProduto = " + id;
                comando = new SQLiteCommand(Update, con.conexao);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados alterados com sucesso!","Alterado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                con.Desconectar();
            }
            catch(Exception e)
            {
                MessageBox.Show("Ocorreu um erro na atualização\n" + e.Message, "Erro na atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Desconectar();
            }
        }
    }
}
