using PlayLivros.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayLivros
{
    public partial class FormEmprestar : Form
    {
        Model.Usuarios usuarios;
        Model.Livros livros = new Model.Livros();
        int idLivro = 0;
        public void AtualizarDgv()
        {
            // Mostrar as informações do bd no datagridview 
            dgvEmprestarLivro.DataSource = livros.Listar();
        }
        public FormEmprestar(Model.Usuarios usuarios)
        {
            InitializeComponent();
            this.usuarios = usuarios;
        }

        private void btnCadastarLivroEMP_Click(object sender, EventArgs e)
        {
            Model.EmprestimosLivros emprestimos = new EmprestimosLivros();
            emprestimos.IdLivro = idLivro;
            emprestimos.IdUsuario = usuarios.IdUsuario;
            if (emprestimos.Emprestar())
            {

                MessageBox.Show("livro emprestado com sucesso!", "Show!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarDgv();
            }
            else
            {

                MessageBox.Show("O livro não pode ser emprestado!", "ERRO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                AtualizarDgv();
            }
        }

        private void dgvEmprestarDevolverLivro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //pegar a linha selecionada:
            int ls = dgvEmprestarLivro.SelectedCells[0].RowIndex;

            //Aemazenar o id do usuario: 
            idLivro = (int)dgvEmprestarLivro.Rows[ls].Cells[0].Value;
            AtualizarDgv();

            AtualizarDgv();
            DialogResult r = MessageBox.Show(" Tem certeza que deseja remover este produto",
              "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                // Prosseguir com a exclusão
                Model.Livros livroApagar = new Model.Livros();
                livroApagar.Id = idLivro;
                if (livroApagar.Apagar())
                {
                    MessageBox.Show("livro apagado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgv();
                    //chamar o resetar campo 

                }
                else
                {
                    MessageBox.Show("Falha ao apagar o livro",
                                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
                
            
        }
    }
}
