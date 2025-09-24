using PlayLivros.Model;
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
        Model.Livros livros = new Model.Livros();

        public FormsCadastrar()
        {
            InitializeComponent();
            AtualizarDgv();
            ListarCategorisaCmb();
        }
        public void AtualizarDgv()
        {
            // Mostrar as informações do bd no datagridview 
            dgvCadastroLivro.DataSource = livros.Listar();
        }
        public void ListarCategorisaCmb()
        {
            Model.Categoria categoria = new Model.Categoria();
            // tabela p/ receber o resultado do SELECT
            DataTable tabela = categoria.Listar();

            foreach (DataRow dr in tabela.Rows)
            {
               cmbCadastrar.Items.Add($"{dr["id"]} - {dr["categoria"]}");
               cmbEditarClasse.Items.Add($"{dr["id"]} - {dr["categoria"]}");
            }


        }


        public void btnCadastarLivro_Click(object sender, EventArgs e)
        {

            if (txbTituloLivro.Text.Length < 5)
            {
                MessageBox.Show(" O titulo do livro deve ter no minimo 5 caracteres",
                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                //Fazer cadastro 
                Model.Livros livroCadastro = new Model.Livros();

                // salvar os valores dos campos 
                livroCadastro.TituloLivro = txbTituloLivro.Text;
                livroCadastro.CategoriaLivros = (cmbCadastrar.Text.Split('-')[0]);


                if (livroCadastro.Cadastrar())
                {
                    MessageBox.Show("usuario cadastrado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // atualizar o dgv:
                    AtualizarDgv();

                    //apagar os campos de cadastro:
                    txbTituloLivro.Clear();
                    cmbCadastrar.SelectedIndex = -1; 
                 
                }
                else
                {
                    MessageBox.Show("falha ao cadastrar o usuario",
                        "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void btnEditar_Click(object sender, EventArgs e)
        {
            if (TxbEditarTitulo.Text.Length < 5)
            {
                MessageBox.Show(" O nome do livro deve ter no minimo 5 caracteres",
                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Prosseguir com a edição
                Model.Livros livroCadastroedt = new Model.Livros();
                livroCadastroedt.TituloLivro = TxbEditarTitulo.Text;
                livroCadastroedt.CategoriaLivros = (cmbEditarClasse.Text.Split('-')[0]);

                if (livroCadastroedt.Modificar())
                {
                    MessageBox.Show("Informações do LIVRO foram modificadas com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha ao modificar ass informações do LIVRO!",
                                        "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }    
}

