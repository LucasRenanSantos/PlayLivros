using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PlayLivros.Model.BancoDeDados;

namespace PlayLivros.Model
{
     class EmprestimosLivros
    {
        public int Id { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public int IdLivro { get; set; }
        public int IdUsuario { get; set; }
        public bool Emprestar()
        {
            string comando = "INSERT INTO emprestimos (id_livro, id_usuario) VALUES " +
                "(@id_livro, @id_usuario)";
            BancoDados conexaoBD = new BancoDados();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);


            cmd.Parameters.AddWithValue("@id_livro", IdLivro);
            cmd.Parameters.AddWithValue("@id_usuario", IdUsuario);

            cmd.Prepare();
            // O trecho abaixo irá retornar true caso o cadastro dê certo:
            // Em caso de erro, experimente comentar o try/catch e executar novamente o código;
            // Grande parte dos problemas estão associados à um comando SQL incorreto. Verifique a string comando.
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
    }
}
