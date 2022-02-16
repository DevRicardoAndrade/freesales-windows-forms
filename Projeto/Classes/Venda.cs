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

namespace Projeto.Classes
{
    public class Venda
    {

        public int Id { get; set; }
        public int id_VendaProduto { get; set; }
        public int id_Usuario { get; set; }
        public string ds_Cliente { get; set; }

        public Conexao con;

        public  SQLiteDataReader BuscarVenda(int Numero, string data1, string data2, int Usuario, int Cargo)
        {
            if (data1 == "0001-01-01" || data1 == "1970-01-01")
            {
                data1 = "";
            }
            if(data2 == "0001-01-01" || data2 == "1970-01-01")
            {
                data2 = "";
            }
            try
            {
                string Where = "";
                string Select = "";
                if (Usuario == 0 && Cargo == 0 && Numero == 0 && data1 == "" && data2 == "")
                {
                    Select = "SELECT Venda.dt_Venda, Venda.id_Venda, Venda.ds_Cliente, Venda.vl_Total, Venda.qt_Total, Usuario.ds_Nome" +
                   " FROM tbdVenda Venda " +
                   " LEFT JOIN tbdUsuario Usuario ON Venda.id_Usuario = Usuario.id_Usuario";
                }
                else
                {
                    if(Where == "")
                    {
                        if (Numero != 0)
                        {
                            Where = "WHERE Venda.id_Venda = " + Numero;
                        }
                    }
                    else if(Where != "")
                    {
                        if(Numero != 0)
                        {
                            Where = Where + " AND Venda.id_Venda = " + Numero;
                        }
                    }
                    if (Where == "")
                    {
                        if (Cargo != 0)
                        {
                            Where = "WHERE Usuario.id_Cargo = " + Cargo;
                        }
                    }
                    else if (Where != "")
                    {
                        if (Cargo != 0)
                        {
                            Where = Where + " AND Usuario.id_Cargo = " + Cargo;
                        }
                    }
                    if (Where == "")
                    {
                        if (data1 != "" && data2 != "")
                        {
                            Where = "WHERE Venda.dt_Venda BETWEEN '" + data1 + "' AND '" + data2 + "'";
                        }
                        else if (data1 != "" && data2 == "")
                        {
                            Where = "WHERE Venda.dt_Venda >= '" + data1 + "'";
                        }
                        else if (data1 == "" && data2 != "")
                        {
                            Where = "WHERE Venda.dt_Venda <= '" + data2 + "'";
                        }
                    }
                    else if (Where != "")
                    {
                        if (data1 != "" && data2 != "")
                        {
                            Where = Where + " AND Venda.dt_Venda BETWEEN '" + data1 + "' AND '" + data2 + "'";
                        }
                        else if(data1 != "" && data2 == "")
                        {
                            Where = Where + " AND Venda.dt_Venda >= '" + data1 + "'";
                        }
                        else if (data1 == "" && data2 != "")
                        {
                            Where = Where + " AND Venda.dt_Venda <= '" + data2 + "'";
                        }
                    }
                    Select = "SELECT Venda.dt_Venda, Venda.id_Venda, Venda.ds_Cliente, Venda.vl_Total, Venda.qt_Total, Usuario.ds_Nome" +
                    " FROM tbdVenda Venda " +
                    " LEFT JOIN tbdUsuario Usuario ON Venda.id_Usuario = Usuario.id_Usuario " + Where ;
                }
                con = new Conexao();
                con.Conectar();
                SQLiteCommand comando = new SQLiteCommand(Select, con.conexao);
                SQLiteDataReader linhas;
                linhas = comando.ExecuteReader();
                return linhas;
                con.Desconectar();  
                
            }
            catch(Exception e)
            {
                MessageBox.Show("Não foi possivel buscar dados da venda!\n" + e.Message, "FreeSales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Desconectar();
                return null;
            }
        }
        public int InserirVenda(int Usuario, string Cliente, decimal Valor, int Quantidade)
        {
            int id = 0;
            
            try
            {
                con = new Conexao();
                con.Conectar();
                string Insert = "INSERT INTO tbdVenda (id_Usuario, ds_Cliente, vl_Total, qt_Total) VALUES (" + Usuario + ", '" + Cliente + "', '" + Valor + "', " + Quantidade + ")";
                SQLiteCommand comando = new SQLiteCommand(Insert, con.conexao);
                comando.ExecuteNonQuery();
                string Select = "SELECT id_Venda FROM tbdVenda WHERE id_Usuario = " + Usuario + " AND ds_Cliente = '" + Cliente + "' AND vl_Total = '" + Valor + "' AND qt_Total = " + Quantidade +
                    " ORDER BY id_Venda DESC";
                SQLiteDataAdapter ConsultaId = new SQLiteDataAdapter(Select, con.conexao);
                DataTable idVenda = new DataTable();
                ConsultaId.Fill(idVenda);
                id = int.Parse(idVenda.Rows[0]["id_Venda"].ToString());
                con.Desconectar();
                return id;


            }
            catch (Exception e)
            {
                con.Desconectar();
                MessageBox.Show("Não foi possivel incluir dados da venda!\n" + e.Message , "FreeSales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }
        public int InserirVendaProduto(int idProd, int idVenda, decimal Valor, int Quantidade)
        {

            try
            {
                con = new Conexao();
                con.Conectar();
                string Insert = "INSERT INTO tbdVendaProduto (id_Produto, id_Venda, vl_Produto, qt_Produto) VALUES (" + idProd + ", " + idVenda + ", '" + Valor + "', " + Quantidade + ")";
                SQLiteCommand comando = new SQLiteCommand(Insert, con.conexao);
                comando.ExecuteNonQuery();
                con.Desconectar();
                return 1;
            }
            catch (Exception e)
            {
                con.Desconectar();
                MessageBox.Show("Não foi possivel incluir dados da venda!\n" + e.Message, "FreeSales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }
        public bool Excluir(int id) 
        {
            try
            {
                con=new Conexao();
                string DeleVendaProduto = "DELETE FROM tbdVendaProduto WHERE id_Venda = " + id;
                string DeleteVenda = "DELETE FROM tbdVenda WHERE id_Venda = " +  id;
                con.Conectar();
                SQLiteCommand comando = new SQLiteCommand(DeleVendaProduto, con.conexao);
                comando.ExecuteNonQuery();
                comando = new SQLiteCommand(DeleteVenda, con.conexao);
                comando.ExecuteNonQuery();
                con.Desconectar();
                return true;
                
            }
            catch(Exception e)
            {
                return false;
                MessageBox.Show("Não possivel excluir venda!\n" + e.Message,"FreeSales",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }
        public bool AtualizarVenda()
        {
            string Update = "UPDATE tbdVenda SET ds_Cliente = '";
            return true;
        }

    }
}
