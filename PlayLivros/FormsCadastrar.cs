using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayLivros
{
    public partial class FormsCadastrar : Form
    {
        public FormsCadastrar()
        {
            InitializeComponent();
        }

        private void btnCadastarLivro_Click(object sender, EventArgs e)
        {
            if (txbTituloLivro.Text.Length < 5)
            {
                MessageBox.Show(" O titulo do livro deve ter no minimo 5 caracteres",
                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                //Fazer cadastro 
                Model.Usuarios livroCadastro = new Model.Usuarios();

                // salvar os valores dos campos 
                livroCadastro.Nome = txbNomecadastro.Text;
           

                if (usuariocadastro.Cadastrar())
                {
                    MessageBox.Show("usuario cadastrado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // atualizar o dgv:
                    AtualizarDgv();

                    //apagar os campos de cadastro:
                    txbEmailCadastro.Clear();
                    txbNomecadastro.Clear();
                    TxbSenhaCadastro.Clear();
                }
                else
                {
                    MessageBox.Show("falha ao cadastrar o usuario",
                        "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
    }
}
