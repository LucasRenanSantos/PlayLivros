namespace PlayLivros
{
    partial class FormsUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsUsuarios));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDevolver = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEmprestar = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Futura Bk BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(296, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(187, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Menu Inicial";
            // 
            // lblDevolver
            // 
            this.lblDevolver.Location = new System.Drawing.Point(303, 267);
            this.lblDevolver.Name = "lblDevolver";
            this.lblDevolver.Size = new System.Drawing.Size(180, 46);
            this.lblDevolver.TabIndex = 3;
            this.lblDevolver.Text = "Devolver";
            this.lblDevolver.UseVisualStyleBackColor = true;
            this.lblDevolver.Click += new System.EventHandler(this.lblDevolver_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(303, 344);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(180, 46);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEmprestar
            // 
            this.btnEmprestar.Location = new System.Drawing.Point(303, 184);
            this.btnEmprestar.Name = "btnEmprestar";
            this.btnEmprestar.Size = new System.Drawing.Size(180, 46);
            this.btnEmprestar.TabIndex = 5;
            this.btnEmprestar.Text = "Emprestar livro";
            this.btnEmprestar.UseVisualStyleBackColor = true;
            this.btnEmprestar.Click += new System.EventHandler(this.btnEmprestar_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(63, 98);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(710, 25);
            this.lblDescricao.TabIndex = 6;
            this.lblDescricao.Text = "Bem Vindo!! ao lugar onde a sua imaginação te levara há um novo mundo.";
            // 
            // FormsUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlayLivros.Properties.Resources.biblioteca;
            this.ClientSize = new System.Drawing.Size(813, 464);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.btnEmprestar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblDevolver);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Futura Bk BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormsUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormsUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button lblDevolver;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEmprestar;
        private System.Windows.Forms.Label lblDescricao;
    }
}