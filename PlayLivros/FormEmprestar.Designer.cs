namespace PlayLivros
{
    partial class FormEmprestar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmprestar));
            this.grbDescricaoEmprestar = new System.Windows.Forms.GroupBox();
            this.lblDescricaoEMP = new System.Windows.Forms.Label();
            this.btnApagarEMP = new System.Windows.Forms.Button();
            this.grbEditarEmprestar = new System.Windows.Forms.GroupBox();
            this.btnEditarEMP = new System.Windows.Forms.Button();
            this.TxbEditarTituloEMP = new System.Windows.Forms.TextBox();
            this.cmbEditarClasseEMP = new System.Windows.Forms.ComboBox();
            this.lblEditarClasseEMP = new System.Windows.Forms.Label();
            this.lblEditarTituloEMP = new System.Windows.Forms.Label();
            this.grbEmprestarLivro = new System.Windows.Forms.GroupBox();
            this.btnCadastarLivroEMP = new System.Windows.Forms.Button();
            this.txbTituloLivroEMP = new System.Windows.Forms.TextBox();
            this.cmbCadastrarEMP = new System.Windows.Forms.ComboBox();
            this.lblNomeTituloEMP = new System.Windows.Forms.Label();
            this.lblClasseEMP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvEmprestarLivro = new System.Windows.Forms.DataGridView();
            this.grbDescricaoEmprestar.SuspendLayout();
            this.grbEditarEmprestar.SuspendLayout();
            this.grbEmprestarLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestarLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDescricaoEmprestar
            // 
            this.grbDescricaoEmprestar.Controls.Add(this.lblDescricaoEMP);
            this.grbDescricaoEmprestar.Controls.Add(this.btnApagarEMP);
            this.grbDescricaoEmprestar.Location = new System.Drawing.Point(11, 550);
            this.grbDescricaoEmprestar.Name = "grbDescricaoEmprestar";
            this.grbDescricaoEmprestar.Size = new System.Drawing.Size(612, 75);
            this.grbDescricaoEmprestar.TabIndex = 10;
            this.grbDescricaoEmprestar.TabStop = false;
            this.grbDescricaoEmprestar.Text = "Apagar";
            // 
            // lblDescricaoEMP
            // 
            this.lblDescricaoEMP.AutoSize = true;
            this.lblDescricaoEMP.Location = new System.Drawing.Point(9, 42);
            this.lblDescricaoEMP.Name = "lblDescricaoEMP";
            this.lblDescricaoEMP.Size = new System.Drawing.Size(29, 13);
            this.lblDescricaoEMP.TabIndex = 1;
            this.lblDescricaoEMP.Text = "lable";
            // 
            // btnApagarEMP
            // 
            this.btnApagarEMP.BackColor = System.Drawing.Color.IndianRed;
            this.btnApagarEMP.Location = new System.Drawing.Point(293, 22);
            this.btnApagarEMP.Name = "btnApagarEMP";
            this.btnApagarEMP.Size = new System.Drawing.Size(295, 36);
            this.btnApagarEMP.TabIndex = 0;
            this.btnApagarEMP.Text = "APAGAR";
            this.btnApagarEMP.UseVisualStyleBackColor = false;
            // 
            // grbEditarEmprestar
            // 
            this.grbEditarEmprestar.Controls.Add(this.btnEditarEMP);
            this.grbEditarEmprestar.Controls.Add(this.TxbEditarTituloEMP);
            this.grbEditarEmprestar.Controls.Add(this.cmbEditarClasseEMP);
            this.grbEditarEmprestar.Controls.Add(this.lblEditarClasseEMP);
            this.grbEditarEmprestar.Controls.Add(this.lblEditarTituloEMP);
            this.grbEditarEmprestar.Location = new System.Drawing.Point(304, 381);
            this.grbEditarEmprestar.Margin = new System.Windows.Forms.Padding(4);
            this.grbEditarEmprestar.Name = "grbEditarEmprestar";
            this.grbEditarEmprestar.Padding = new System.Windows.Forms.Padding(4);
            this.grbEditarEmprestar.Size = new System.Drawing.Size(319, 162);
            this.grbEditarEmprestar.TabIndex = 9;
            this.grbEditarEmprestar.TabStop = false;
            this.grbEditarEmprestar.Text = "Editar";
            // 
            // btnEditarEMP
            // 
            this.btnEditarEMP.Location = new System.Drawing.Point(10, 110);
            this.btnEditarEMP.Name = "btnEditarEMP";
            this.btnEditarEMP.Size = new System.Drawing.Size(285, 35);
            this.btnEditarEMP.TabIndex = 6;
            this.btnEditarEMP.Text = "EDITAR";
            this.btnEditarEMP.UseVisualStyleBackColor = true;
            // 
            // TxbEditarTituloEMP
            // 
            this.TxbEditarTituloEMP.Location = new System.Drawing.Point(96, 31);
            this.TxbEditarTituloEMP.Name = "TxbEditarTituloEMP";
            this.TxbEditarTituloEMP.Size = new System.Drawing.Size(199, 20);
            this.TxbEditarTituloEMP.TabIndex = 6;
            // 
            // cmbEditarClasseEMP
            // 
            this.cmbEditarClasseEMP.FormattingEnabled = true;
            this.cmbEditarClasseEMP.Location = new System.Drawing.Point(96, 78);
            this.cmbEditarClasseEMP.Name = "cmbEditarClasseEMP";
            this.cmbEditarClasseEMP.Size = new System.Drawing.Size(199, 21);
            this.cmbEditarClasseEMP.TabIndex = 6;
            // 
            // lblEditarClasseEMP
            // 
            this.lblEditarClasseEMP.AutoSize = true;
            this.lblEditarClasseEMP.Location = new System.Drawing.Point(7, 81);
            this.lblEditarClasseEMP.Name = "lblEditarClasseEMP";
            this.lblEditarClasseEMP.Size = new System.Drawing.Size(71, 13);
            this.lblEditarClasseEMP.TabIndex = 1;
            this.lblEditarClasseEMP.Text = "Editar Classe:";
            // 
            // lblEditarTituloEMP
            // 
            this.lblEditarTituloEMP.AutoSize = true;
            this.lblEditarTituloEMP.Location = new System.Drawing.Point(7, 34);
            this.lblEditarTituloEMP.Name = "lblEditarTituloEMP";
            this.lblEditarTituloEMP.Size = new System.Drawing.Size(66, 13);
            this.lblEditarTituloEMP.TabIndex = 0;
            this.lblEditarTituloEMP.Text = "Editar Titulo:";
            // 
            // grbEmprestarLivro
            // 
            this.grbEmprestarLivro.Controls.Add(this.btnCadastarLivroEMP);
            this.grbEmprestarLivro.Controls.Add(this.txbTituloLivroEMP);
            this.grbEmprestarLivro.Controls.Add(this.cmbCadastrarEMP);
            this.grbEmprestarLivro.Controls.Add(this.lblNomeTituloEMP);
            this.grbEmprestarLivro.Controls.Add(this.lblClasseEMP);
            this.grbEmprestarLivro.Controls.Add(this.label3);
            this.grbEmprestarLivro.Location = new System.Drawing.Point(13, 381);
            this.grbEmprestarLivro.Margin = new System.Windows.Forms.Padding(4);
            this.grbEmprestarLivro.Name = "grbEmprestarLivro";
            this.grbEmprestarLivro.Padding = new System.Windows.Forms.Padding(4);
            this.grbEmprestarLivro.Size = new System.Drawing.Size(283, 162);
            this.grbEmprestarLivro.TabIndex = 8;
            this.grbEmprestarLivro.TabStop = false;
            this.grbEmprestarLivro.Text = "Cadastrar";
            // 
            // btnCadastarLivroEMP
            // 
            this.btnCadastarLivroEMP.Location = new System.Drawing.Point(14, 110);
            this.btnCadastarLivroEMP.Name = "btnCadastarLivroEMP";
            this.btnCadastarLivroEMP.Size = new System.Drawing.Size(246, 35);
            this.btnCadastarLivroEMP.TabIndex = 5;
            this.btnCadastarLivroEMP.Text = "CADASTAR";
            this.btnCadastarLivroEMP.UseVisualStyleBackColor = true;
            // 
            // txbTituloLivroEMP
            // 
            this.txbTituloLivroEMP.Location = new System.Drawing.Point(83, 31);
            this.txbTituloLivroEMP.Name = "txbTituloLivroEMP";
            this.txbTituloLivroEMP.Size = new System.Drawing.Size(177, 20);
            this.txbTituloLivroEMP.TabIndex = 4;
            // 
            // cmbCadastrarEMP
            // 
            this.cmbCadastrarEMP.FormattingEnabled = true;
            this.cmbCadastrarEMP.Location = new System.Drawing.Point(61, 73);
            this.cmbCadastrarEMP.Name = "cmbCadastrarEMP";
            this.cmbCadastrarEMP.Size = new System.Drawing.Size(199, 21);
            this.cmbCadastrarEMP.TabIndex = 3;
            // 
            // lblNomeTituloEMP
            // 
            this.lblNomeTituloEMP.AutoSize = true;
            this.lblNomeTituloEMP.Location = new System.Drawing.Point(7, 34);
            this.lblNomeTituloEMP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeTituloEMP.Name = "lblNomeTituloEMP";
            this.lblNomeTituloEMP.Size = new System.Drawing.Size(58, 13);
            this.lblNomeTituloEMP.TabIndex = 0;
            this.lblNomeTituloEMP.Text = "Titulo livro:";
            // 
            // lblClasseEMP
            // 
            this.lblClasseEMP.AutoSize = true;
            this.lblClasseEMP.Location = new System.Drawing.Point(7, 76);
            this.lblClasseEMP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClasseEMP.Name = "lblClasseEMP";
            this.lblClasseEMP.Size = new System.Drawing.Size(41, 13);
            this.lblClasseEMP.TabIndex = 1;
            this.lblClasseEMP.Text = "Classe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // dgvEmprestarLivro
            // 
            this.dgvEmprestarLivro.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.dgvEmprestarLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestarLivro.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEmprestarLivro.Location = new System.Drawing.Point(14, 6);
            this.dgvEmprestarLivro.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmprestarLivro.Name = "dgvEmprestarLivro";
            this.dgvEmprestarLivro.Size = new System.Drawing.Size(609, 367);
            this.dgvEmprestarLivro.TabIndex = 7;
            // 
            // FormEmprestar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlayLivros.Properties.Resources.biblioteca;
            this.ClientSize = new System.Drawing.Size(636, 636);
            this.Controls.Add(this.grbDescricaoEmprestar);
            this.Controls.Add(this.grbEditarEmprestar);
            this.Controls.Add(this.grbEmprestarLivro);
            this.Controls.Add(this.dgvEmprestarLivro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormEmprestar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmprestar";
            this.grbDescricaoEmprestar.ResumeLayout(false);
            this.grbDescricaoEmprestar.PerformLayout();
            this.grbEditarEmprestar.ResumeLayout(false);
            this.grbEditarEmprestar.PerformLayout();
            this.grbEmprestarLivro.ResumeLayout(false);
            this.grbEmprestarLivro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestarLivro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDescricaoEmprestar;
        private System.Windows.Forms.Label lblDescricaoEMP;
        private System.Windows.Forms.Button btnApagarEMP;
        private System.Windows.Forms.GroupBox grbEditarEmprestar;
        private System.Windows.Forms.Button btnEditarEMP;
        private System.Windows.Forms.TextBox TxbEditarTituloEMP;
        private System.Windows.Forms.ComboBox cmbEditarClasseEMP;
        private System.Windows.Forms.Label lblEditarClasseEMP;
        private System.Windows.Forms.Label lblEditarTituloEMP;
        private System.Windows.Forms.GroupBox grbEmprestarLivro;
        private System.Windows.Forms.Button btnCadastarLivroEMP;
        private System.Windows.Forms.TextBox txbTituloLivroEMP;
        private System.Windows.Forms.ComboBox cmbCadastrarEMP;
        private System.Windows.Forms.Label lblNomeTituloEMP;
        private System.Windows.Forms.Label lblClasseEMP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvEmprestarLivro;
    }
}