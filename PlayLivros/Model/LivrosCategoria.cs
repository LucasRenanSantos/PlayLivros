using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PlayLivros.Model.BancoDeDados;

namespace PlayLivros.Model
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Categorias { get; set; }

        public DataTable Listar()
        {
            string comando = "SELECT * FROM categoria_livros" +
                "";

            BancoDados conexaoBD = new BancoDados();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Prepare();
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
    }
}
