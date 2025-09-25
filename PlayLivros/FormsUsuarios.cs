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
    public partial class FormsUsuarios : Form
    {
        Model.Usuarios usuarios;

        public FormsUsuarios(Model.Usuarios usuarios)
        {
            InitializeComponent();
            this.usuarios = usuarios;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormsCadastrar formsCadastrar = new FormsCadastrar();
            Hide(); // esconder a janela atual
            formsCadastrar.ShowDialog(); // Mostrar o menuprincipal

            Show(); // Mostrar a tela de login ao sair do menu principal
        }

        //private void lblDevolver_Click(object sender, EventArgs e)
        //{
          //  FormDevolver formDevolver = new FormDevolver();
            //Hide(); // esconder a janela atual
            //formDevolver.ShowDialog(); // Mostrar o menuprincipal

            //Show(); // Mostrar a tela de login ao sair do menu principal
        //}

        private void btnEmprestar_Click(object sender, EventArgs e)
        {
            FormEmprestar formEmprestar = new FormEmprestar(usuarios);
            Hide(); // esconder a janela atual
            formEmprestar.ShowDialog(); // Mostrar o menuprincipal

            Show(); // Mostrar a tela de login ao sair do menu principal
        }
    }
}
