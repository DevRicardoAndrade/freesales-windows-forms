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
    public class Produto
    {
        public long Id { get; set; }
        public string Ds_Produto { get; set; }
        public int Qt_Produto { get; set; }
        public decimal Vl_Produto { get; set;}
        public string Tp_Inativo { get; set; }
        public Conexao con ;
        
        
        public SQLiteDataReader BuscarProduto(string Inativo, string Nome, decimal Valor = 0, int Quantidade = 0, int idTipo = 0) 
        {
            
          
            string Where = "";
            if (Where == "")
            {
                if(Inativo != "")
                {
                    Where = "Produto.tp_Inativo = '" + Inativo + "'";
                }
            }
            else if(Where != "")
            {
                if(Inativo != "")
                {
                    Where = Where +  " AND Produto.tp_Inativo = '" + Inativo + "'";
                }
            }
            if (Where == "")
            {
                if (Nome != "")
                {
                    Where = "Produto.ds_Produto LIKE '%" + Nome + "%'";
                }
            }
            else if (Where != "")
            {
                if (Nome != "")
                {
                    Where = Where + " AND Produto.ds_Produto LIKE '%" + Nome + "%'";
                }
            }
            if (Where == "")
            {
                if (Valor != -1)
                {
                    Where = "Produto.vl_Produto = '" + Valor + "'";
                }
            }
            else if (Where != "")
            {
                if (Valor != -1)
                {
                    Where = Where + " AND Produto.vl_Produto = '" + Valor + "'";
                }
            }
            if (Where == "")
            {
                if (Quantidade != -1)
                {
                    Where = "Produto.qt_Produto = " + Quantidade;
                }
            }
            else if (Where != "")
            {
                if (Quantidade != -1)
                {
                    Where = Where + " AND Produto.qt_Produto = " + Quantidade;
                }
            }
            if (Where == "")
            {
                if (idTipo != 0)
                {
                    Where = Where + " TipoProduto.id_TipoProduto = " + idTipo;
                }
            }
            else if(Where != "")
            {
                if (idTipo != 0)
                {
                    Where = Where + " AND TipoProduto.id_TipoProduto = " + idTipo;
                }
            }
            try
            {
                con  = new Conexao();
                con.Conectar();
                SQLiteCommand comando;
                string Select = "SELECT TipoProduto.ds_TipoProduto, Produto.id_Produto," +
                    " Produto.ds_Produto," +
                    " Produto.qt_Produto," +
                    " Produto.vl_Produto," +
                    " Produto.tp_Inativo" +
                    " FROM tbdProduto Produto INNER JOIN tbdTipoProduto TipoProduto " +
                    "ON TipoProduto.id_TipoProduto = Produto.id_TipoProduto Where " + Where;
                comando = new SQLiteCommand(Select, con.conexao);
                SQLiteDataReader linhas;
                linhas = comando.ExecuteReader();
                return linhas;
            }
            catch (Exception e)
            {
                return null;
                con.Desconectar();
                MessageBox.Show("Não foi possivel realizar a consulta dos produtos. \n" + e.Message,"Erro na consulta",MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }
        public void Excluir(int id)
        {
            try
            {
                con = new Conexao();
                con.Conectar();
                SQLiteCommand comando;
                string Delete = "DELETE FROM tbdProduto WHERE id_Produto = " + id;
                comando = new SQLiteCommand(Delete, con.conexao);
                comando.ExecuteNonQuery();
                MessageBox.Show("Produto Excluido!", "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Desconectar();
            }
            catch(Exception e)
            {
                con.Desconectar();
                MessageBox.Show("Não foi possivel excluir produto.\n" + e.Message, "Erro ao excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Atualizar(int id, string Inativo, string Nome, decimal Valor, int Quantidade)
        {
            try
            {
                con = new Conexao();
                con.Conectar();
                SQLiteCommand comando;
                string Update = "UPDATE tbdProduto SET tp_Inativo = '" + Inativo + "'" +
                    ", ds_Produto = '" + Nome + "'" +
                    ", vl_Produto = '" + Valor + "'" +
                    ", qt_Produto = " + Quantidade + " WHERE id_Produto = " + id;
                comando = new SQLiteCommand(Update, con.conexao);
                comando.ExecuteNonQuery();
                MessageBox.Show("Produto Alterado", "Alterado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                con.Desconectar();

            }
            catch(Exception e)
            {
                con.Desconectar();
                MessageBox.Show("Erro ao alterar Produto. \n" + e.Message, "Erro ao alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AtualizarQuantidade(int id, int Quantidade)
        {
            try
            {
                con = new Conexao();
                con.Conectar();
                SQLiteCommand comando;
                string Update = "UPDATE tbdProduto SET qt_Produto = (qt_Produto - " + Quantidade + ") WHERE id_Produto = " + id;
                comando = new SQLiteCommand(Update, con.conexao);
                comando.ExecuteNonQuery();
                con.Desconectar();

            }
            catch (Exception e)
            {
                con.Desconectar();
                MessageBox.Show("Erro ao atualizar quantidade de produto. \n" + e.Message, "Erro ao alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool Inserir(int idTipo,string Inativo, string Nome, decimal Valor, int Quantidade)
        
        {
            try
            {
                con = new Conexao();
                con.Conectar();
                SQLiteCommand comando;
                string Insert = "INSERT INTO tbdProduto (ds_Produto, tp_Inativo, qt_Produto, vl_Produto, id_TipoProduto) VALUES ('" +
                    Nome + "', '" + Inativo + "', " + Quantidade + ", '" + Valor + "', " + idTipo + ")";
                comando = new SQLiteCommand(Insert, con.conexao);
                comando.ExecuteNonQuery();
                MessageBox.Show("Produto Cadastrado!", "Cadastrado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                con.Desconectar();
                return true;
            }
            catch(Exception e)
            {
                con.Desconectar();
                MessageBox.Show("Ocorreu um erro ao cadastrar o produto.\n" + e.Message, "Erro ao cadastrar",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
