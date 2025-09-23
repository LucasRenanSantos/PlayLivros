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
    public class Usuarios
    {
        public int IdUsuario { get; set; }
        public string NomeUsuario{ get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string IdTipo { get; set; }

        /* Cadastrar
         * logar
         * modificar 
         * remover 
         */

        public DataTable Logar()
        {

            string comando = "SELECT * FROM usuarios WHERE email = @email AND senha = @senha";
            /*
            Caso vá utilizar o WHERE, empregue o uso de caracteres coringas,
            semelhante ao apresentado no metódo Cadastrar() acima.
            */
            BancoDados conexaoBD = new BancoDados();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            // Obter o hash da senha:
            string senhahash = EasyEncryption.SHA.ComputeSHA256Hash(Senha);

            // Substituir os caracteres coringas (@)
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@senha", senhahash);

            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public DataTable Listar()
        {
            string comando = "SELECT Id nome_usuario, email FROM usuarios";

            BancoDados conexaoBD = new BancoDados();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Prepare();
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public bool Cadastrar()
        {
            string comando = "INSERT INTO usuarios (nome_usuario, email, senha) VALUES " +
                "(@nome_usuario, @email, @senha)";
            BancoDados conexaoBD = new BancoDados();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome_usuario", NomeUsuario);
            cmd.Parameters.AddWithValue("@email", Email);
            // Obter o hash da senha:
            string hashsenha = EasyEncryption.SHA.ComputeSHA256Hash(Senha);
            cmd.Parameters.AddWithValue("@senha", hashsenha);
            // Obs.: Certifique-se de utilizar alguma método para obter o hash da senha antes de cadastrar!
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

        
        
       
        public bool Apagar()
        {
            string comando = "DELETE FROM produtos WHERE id = @id";
            BancoDados conexaoBD = new BancoDados();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id_usuario", IdUsuario);

            cmd.Prepare();
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

        public bool Modificar()
        {
            string comando = "UPDATE usuarios SET nome_usuario = @nome_usuario, " +
                "email = @email, senha = @senha WHERE id_usuario = @id_usuario";
            BancoDados conexaoBD = new BancoDados();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome_usuario", NomeUsuario);
            cmd.Parameters.AddWithValue("@email", Email);

            string hashSenha = EasyEncryption.SHA.ComputeSHA256Hash(Senha);

            cmd.Parameters.AddWithValue("@senha", hashSenha);
            cmd.Parameters.AddWithValue("@id_usuario", IdUsuario);
            cmd.Prepare();
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
