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
        int idSelecionado = 0;

        public FormsCadastrar()
        {
            InitializeComponent();
            Atualizardgv();
            ListarCategorisaCmb();
        }
        public void Atualizardgv()
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
            Atualizardgv();
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
                    Atualizardgv();

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
                livroCadastroedt.Id = idSelecionado;

                if (livroCadastroedt.Modificar())
                {
                    MessageBox.Show("Informações do LIVRO foram modificadas com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Atualizardgv();
                }
                else
                {
                    MessageBox.Show("Falha ao modificar ass informações do LIVRO!",
                                        "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Perguntar se o adimin realmente apagar o usuario
            DialogResult r = MessageBox.Show(" Tem certeza que deseja emprestar  este produto",
               "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if ( r == DialogResult.Yes)
            {
                // Prosseguir com a exclusão
                Model.Livros livroApagar = new Model.Livros();
                livroApagar.Id = idSelecionado;
                if (livroApagar.Apagar())
                {
                    MessageBox.Show("livro emprestado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Atualizardgv();
                    //chamar o resetar campo 
                    

                }
                else
                {
                    MessageBox.Show("Falha ao emprestar o livro",
                                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
    }

        private void dgvCadastroLivro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //pegar a linha selecionada:
            int ls = dgvCadastroLivro.SelectedCells[0].RowIndex;

            // colocar os valores da celulas nos txbs de edição
            txbTituloLivro.Text = dgvCadastroLivro.Rows[ls].Cells[1].Value.ToString();
            TxbEditarTitulo.Text = dgvCadastroLivro.Rows[ls].Cells[1].Value.ToString();

            //Aemazenar o id do usuario: 
            idSelecionado = (int)dgvCadastroLivro.Rows[ls].Cells[0].Value;

            // Ativar o grbEditar

            grbCadastrarLivro.Enabled = true;

            // ajustes nom grbApagar
            grbDescricao.Text = $"Apagar: {dgvCadastroLivro.Rows[ls].Cells[1].Value.ToString()}";

            // Ativar o grbApagar:
            grbEditar.Enabled = true;
        }

        private void dgvCadastroLivro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
  }

