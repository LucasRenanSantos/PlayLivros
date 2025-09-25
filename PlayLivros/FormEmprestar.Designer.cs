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
            this.grbEmprestarDevolverLivro = new System.Windows.Forms.GroupBox();
            this.btnCadastarLivroEMP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvEmprestarLivro = new System.Windows.Forms.DataGridView();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.grbDevolvervolução = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldevolverLivro = new System.Windows.Forms.Label();
            this.txbLivrodevolver = new System.Windows.Forms.TextBox();
            this.grbEmprestarDevolverLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestarLivro)).BeginInit();
            this.grbDevolvervolução.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEmprestarDevolverLivro
            // 
            this.grbEmprestarDevolverLivro.Controls.Add(this.btnCadastarLivroEMP);
            this.grbEmprestarDevolverLivro.Controls.Add(this.label3);
            this.grbEmprestarDevolverLivro.Location = new System.Drawing.Point(14, 381);
            this.grbEmprestarDevolverLivro.Margin = new System.Windows.Forms.Padding(4);
            this.grbEmprestarDevolverLivro.Name = "grbEmprestarDevolverLivro";
            this.grbEmprestarDevolverLivro.Padding = new System.Windows.Forms.Padding(4);
            this.grbEmprestarDevolverLivro.Size = new System.Drawing.Size(276, 184);
            this.grbEmprestarDevolverLivro.TabIndex = 8;
            this.grbEmprestarDevolverLivro.TabStop = false;
            this.grbEmprestarDevolverLivro.Text = "Emprestar e Devolver ";
            // 
            // btnCadastarLivroEMP
            // 
            this.btnCadastarLivroEMP.Location = new System.Drawing.Point(7, 126);
            this.btnCadastarLivroEMP.Name = "btnCadastarLivroEMP";
            this.btnCadastarLivroEMP.Size = new System.Drawing.Size(271, 35);
            this.btnCadastarLivroEMP.TabIndex = 5;
            this.btnCadastarLivroEMP.Text = "EMPRESTAR LIVRO";
            this.btnCadastarLivroEMP.UseVisualStyleBackColor = true;
            this.btnCadastarLivroEMP.Click += new System.EventHandler(this.btnCadastarLivroEMP_Click);
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
            this.dgvEmprestarLivro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmprestarDevolverLivro_CellClick);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(5, 126);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(264, 35);
            this.btnDevolver.TabIndex = 6;
            this.btnDevolver.Text = "DEVOLVER LIVRO";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // grbDevolvervolução
            // 
            this.grbDevolvervolução.Controls.Add(this.txbLivrodevolver);
            this.grbDevolvervolução.Controls.Add(this.lbldevolverLivro);
            this.grbDevolvervolução.Controls.Add(this.label1);
            this.grbDevolvervolução.Controls.Add(this.btnDevolver);
            this.grbDevolvervolução.Location = new System.Drawing.Point(317, 381);
            this.grbDevolvervolução.Margin = new System.Windows.Forms.Padding(4);
            this.grbDevolvervolução.Name = "grbDevolvervolução";
            this.grbDevolvervolução.Padding = new System.Windows.Forms.Padding(4);
            this.grbDevolvervolução.Size = new System.Drawing.Size(276, 184);
            this.grbDevolvervolução.TabIndex = 9;
            this.grbDevolvervolução.TabStop = false;
            this.grbDevolvervolução.Text = "Emprestar e Devolver ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // lbldevolverLivro
            // 
            this.lbldevolverLivro.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lbldevolverLivro.AutoSize = true;
            this.lbldevolverLivro.Location = new System.Drawing.Point(51, 48);
            this.lbldevolverLivro.Name = "lbldevolverLivro";
            this.lbldevolverLivro.Size = new System.Drawing.Size(26, 13);
            this.lbldevolverLivro.TabIndex = 7;
            this.lbldevolverLivro.Text = "livro";
            // 
            // txbLivrodevolver
            // 
            this.txbLivrodevolver.Location = new System.Drawing.Point(92, 48);
            this.txbLivrodevolver.Name = "txbLivrodevolver";
            this.txbLivrodevolver.Size = new System.Drawing.Size(100, 20);
            this.txbLivrodevolver.TabIndex = 8;
            // 
            // FormEmprestar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlayLivros.Properties.Resources.biblioteca;
            this.ClientSize = new System.Drawing.Size(770, 599);
            this.Controls.Add(this.grbDevolvervolução);
            this.Controls.Add(this.grbEmprestarDevolverLivro);
            this.Controls.Add(this.dgvEmprestarLivro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormEmprestar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmprestar";
            this.grbEmprestarDevolverLivro.ResumeLayout(false);
            this.grbEmprestarDevolverLivro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestarLivro)).EndInit();
            this.grbDevolvervolução.ResumeLayout(false);
            this.grbDevolvervolução.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbEmprestarDevolverLivro;
        private System.Windows.Forms.Button btnCadastarLivroEMP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvEmprestarLivro;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.GroupBox grbDevolvervolução;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbLivrodevolver;
        private System.Windows.Forms.Label lbldevolverLivro;
    }
}