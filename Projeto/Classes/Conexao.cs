using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace Projeto
{
    public class Conexao
    {
        string Banco;
        static string caminho = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FreeSales.s3db;";
       
        public Conexao()
        {       
        }
        public SQLiteConnection conexao = new SQLiteConnection("Data Source = " + caminho);

        public void Conectar() {
            conexao.Open();
        }
        public void Desconectar()
        {
            conexao.Close();
        }
    }
}
