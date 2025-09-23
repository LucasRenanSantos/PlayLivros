using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayLivros
{
    public partial class Fomr1 : Form
    {
        public Fomr1()
        {
            InitializeComponent();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {

            // Verificar se a pessoa digitou o email e a senha:
            if (txbEmail.Text.Length < 6)
            {
                MessageBox.Show("Digite um email valido!",
                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenha.Text.Length < 4)
            {
                MessageBox.Show("Digite uma senha valid!",
                      "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Prosseguir....
                Model.Usuarios usuario = new Model.Usuarios();

                // Colocar os bvalores dos campos nos atributos do usuario
                usuario.Email = txbEmail.Text;
                usuario.Senha = txbSenha.Text;
                // Tabela que vai receber o resultado do SELEC (Logar)
                DataTable resultado = usuario.Logar();

                // Verificar se acertou o e-mail e senha:
                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show("E-mail e/ou senha inválidos!", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Armazenar as infos vindas do bd no objeto "usuario"
                    usuario.IdUsuario = int.Parse(resultado.Rows[0]["Id_usuario"].ToString());
                    usuario.NomeUsuario = resultado.Rows[0]["nome_usuario"].ToString();

                    // Mudar para o MenuPrincippal:
                    FormsUsuarios formsUsuarios = new FormsUsuarios (usuario);
                    Hide(); // esconder a janela atual
                    formsUsuarios.ShowDialog(); // Mostrar o menuprincipal

                    Show(); // Mostrar a tela de login ao sair do menu principal
                }

            }

        }
    }
}
