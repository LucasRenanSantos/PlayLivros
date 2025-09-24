namespace PlayLivros
{
    partial class FormsCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsCadastrar));
            this.dgvCadastroLivro = new System.Windows.Forms.DataGridView();
            this.grbCadastrarLivro = new System.Windows.Forms.GroupBox();
            this.btnCadastarLivro = new System.Windows.Forms.Button();
            this.txbTituloLivro = new System.Windows.Forms.TextBox();
            this.cmbCadastrar = new System.Windows.Forms.ComboBox();
            this.lblNomeTitulo = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.TxbEditarTitulo = new System.Windows.Forms.TextBox();
            this.cmbEditarClasse = new System.Windows.Forms.ComboBox();
            this.lblEditarClasse = new System.Windows.Forms.Label();
            this.lblEditarTitulo = new System.Windows.Forms.Label();
            this.grbDescricao = new System.Windows.Forms.GroupBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroLivro)).BeginInit();
            this.grbCadastrarLivro.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbDescricao.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCadastroLivro
            // 
            this.dgvCadastroLivro.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.dgvCadastroLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroLivro.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCadastroLivro.Location = new System.Drawing.Point(15, 13);
            this.dgvCadastroLivro.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCadastroLivro.Name = "dgvCadastroLivro";
            this.dgvCadastroLivro.Size = new System.Drawing.Size(609, 367);
            this.dgvCadastroLivro.TabIndex = 0;
            // 
            // grbCadastrarLivro
            // 
            this.grbCadastrarLivro.Controls.Add(this.btnCadastarLivro);
            this.grbCadastrarLivro.Controls.Add(this.txbTituloLivro);
            this.grbCadastrarLivro.Controls.Add(this.cmbCadastrar);
            this.grbCadastrarLivro.Controls.Add(this.lblNomeTitulo);
            this.grbCadastrarLivro.Controls.Add(this.lblClasse);
            this.grbCadastrarLivro.Controls.Add(this.label3);
            this.grbCadastrarLivro.Location = new System.Drawing.Point(14, 388);
            this.grbCadastrarLivro.Margin = new System.Windows.Forms.Padding(4);
            this.grbCadastrarLivro.Name = "grbCadastrarLivro";
            this.grbCadastrarLivro.Padding = new System.Windows.Forms.Padding(4);
            this.grbCadastrarLivro.Size = new System.Drawing.Size(283, 162);
            this.grbCadastrarLivro.TabIndex = 1;
            this.grbCadastrarLivro.TabStop = false;
            this.grbCadastrarLivro.Text = "Cadastrar";
            // 
            // btnCadastarLivro
            // 
            this.btnCadastarLivro.Location = new System.Drawing.Point(14, 110);
            this.btnCadastarLivro.Name = "btnCadastarLivro";
            this.btnCadastarLivro.Size = new System.Drawing.Size(246, 35);
            this.btnCadastarLivro.TabIndex = 5;
            this.btnCadastarLivro.Text = "CADASTAR";
            this.btnCadastarLivro.UseVisualStyleBackColor = true;
            this.btnCadastarLivro.Click += new System.EventHandler(this.btnCadastarLivro_Click);
            // 
            // txbTituloLivro
            // 
            this.txbTituloLivro.Location = new System.Drawing.Point(83, 31);
            this.txbTituloLivro.Name = "txbTituloLivro";
            this.txbTituloLivro.Size = new System.Drawing.Size(177, 23);
            this.txbTituloLivro.TabIndex = 4;
            // 
            // cmbCadastrar
            // 
            this.cmbCadastrar.FormattingEnabled = true;
            this.cmbCadastrar.Location = new System.Drawing.Point(61, 73);
            this.cmbCadastrar.Name = "cmbCadastrar";
            this.cmbCadastrar.Size = new System.Drawing.Size(199, 24);
            this.cmbCadastrar.TabIndex = 3;
            // 
            // lblNomeTitulo
            // 
            this.lblNomeTitulo.AutoSize = true;
            this.lblNomeTitulo.Location = new System.Drawing.Point(7, 34);
            this.lblNomeTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeTitulo.Name = "lblNomeTitulo";
            this.lblNomeTitulo.Size = new System.Drawing.Size(69, 16);
            this.lblNomeTitulo.TabIndex = 0;
            this.lblNomeTitulo.Text = "Titulo livro:";
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(7, 76);
            this.lblClasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(47, 16);
            this.lblClasse.TabIndex = 1;
            this.lblClasse.Text = "Classe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 2;
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.TxbEditarTitulo);
            this.grbEditar.Controls.Add(this.cmbEditarClasse);
            this.grbEditar.Controls.Add(this.lblEditarClasse);
            this.grbEditar.Controls.Add(this.lblEditarTitulo);
            this.grbEditar.Location = new System.Drawing.Point(305, 388);
            this.grbEditar.Margin = new System.Windows.Forms.Padding(4);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Padding = new System.Windows.Forms.Padding(4);
            this.grbEditar.Size = new System.Drawing.Size(319, 162);
            this.grbEditar.TabIndex = 2;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(10, 110);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(285, 35);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // TxbEditarTitulo
            // 
            this.TxbEditarTitulo.Location = new System.Drawing.Point(96, 31);
            this.TxbEditarTitulo.Name = "TxbEditarTitulo";
            this.TxbEditarTitulo.Size = new System.Drawing.Size(199, 23);
            this.TxbEditarTitulo.TabIndex = 6;
            // 
            // cmbEditarClasse
            // 
            this.cmbEditarClasse.FormattingEnabled = true;
            this.cmbEditarClasse.Location = new System.Drawing.Point(96, 78);
            this.cmbEditarClasse.Name = "cmbEditarClasse";
            this.cmbEditarClasse.Size = new System.Drawing.Size(199, 24);
            this.cmbEditarClasse.TabIndex = 6;
            // 
            // lblEditarClasse
            // 
            this.lblEditarClasse.AutoSize = true;
            this.lblEditarClasse.Location = new System.Drawing.Point(7, 81);
            this.lblEditarClasse.Name = "lblEditarClasse";
            this.lblEditarClasse.Size = new System.Drawing.Size(83, 16);
            this.lblEditarClasse.TabIndex = 1;
            this.lblEditarClasse.Text = "Editar Classe:";
            // 
            // lblEditarTitulo
            // 
            this.lblEditarTitulo.AutoSize = true;
            this.lblEditarTitulo.Location = new System.Drawing.Point(7, 34);
            this.lblEditarTitulo.Name = "lblEditarTitulo";
            this.lblEditarTitulo.Size = new System.Drawing.Size(77, 16);
            this.lblEditarTitulo.TabIndex = 0;
            this.lblEditarTitulo.Text = "Editar Titulo:";
            // 
            // grbDescricao
            // 
            this.grbDescricao.Controls.Add(this.lblDescricao);
            this.grbDescricao.Controls.Add(this.btnApagar);
            this.grbDescricao.Location = new System.Drawing.Point(12, 557);
            this.grbDescricao.Name = "grbDescricao";
            this.grbDescricao.Size = new System.Drawing.Size(612, 75);
            this.grbDescricao.TabIndex = 6;
            this.grbDescricao.TabStop = false;
            this.grbDescricao.Text = "Apagar";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(9, 42);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(0, 16);
            this.lblDescricao.TabIndex = 1;
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.IndianRed;
            this.btnApagar.Location = new System.Drawing.Point(317, 22);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(295, 36);
            this.btnApagar.TabIndex = 0;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // FormsCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlayLivros.Properties.Resources.biblioteca;
            this.ClientSize = new System.Drawing.Size(642, 641);
            this.Controls.Add(this.grbDescricao);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastrarLivro);
            this.Controls.Add(this.dgvCadastroLivro);
            this.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormsCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormsCadastrar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroLivro)).EndInit();
            this.grbCadastrarLivro.ResumeLayout(false);
            this.grbCadastrarLivro.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbDescricao.ResumeLayout(false);
            this.grbDescricao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCadastroLivro;
        private System.Windows.Forms.GroupBox grbCadastrarLivro;
        private System.Windows.Forms.Label lblNomeTitulo;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnCadastarLivro;
        private System.Windows.Forms.TextBox txbTituloLivro;
        private System.Windows.Forms.ComboBox cmbCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox TxbEditarTitulo;
        private System.Windows.Forms.ComboBox cmbEditarClasse;
        private System.Windows.Forms.Label lblEditarClasse;
        private System.Windows.Forms.Label lblEditarTitulo;
        private System.Windows.Forms.GroupBox grbDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnApagar;
    }
}