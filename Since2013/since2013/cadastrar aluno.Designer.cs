namespace since2013
{
    partial class cadastrar_aluno
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
            this.txttelefones = new System.Windows.Forms.TextBox();
            this.txtrra = new System.Windows.Forms.TextBox();
            this.conbcursos = new System.Windows.Forms.ComboBox();
            this.conbnome = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnsalva = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txttelefones
            // 
            this.txttelefones.Location = new System.Drawing.Point(52, 237);
            this.txttelefones.Name = "txttelefones";
            this.txttelefones.Size = new System.Drawing.Size(235, 20);
            this.txttelefones.TabIndex = 111;
            // 
            // txtrra
            // 
            this.txtrra.Location = new System.Drawing.Point(52, 161);
            this.txtrra.Name = "txtrra";
            this.txtrra.Size = new System.Drawing.Size(235, 20);
            this.txtrra.TabIndex = 110;
            // 
            // conbcursos
            // 
            this.conbcursos.FormattingEnabled = true;
            this.conbcursos.Items.AddRange(new object[] {
            "Ingles",
            "Espanhol"});
            this.conbcursos.Location = new System.Drawing.Point(52, 196);
            this.conbcursos.Name = "conbcursos";
            this.conbcursos.Size = new System.Drawing.Size(235, 21);
            this.conbcursos.TabIndex = 109;
            // 
            // conbnome
            // 
            this.conbnome.FormattingEnabled = true;
            this.conbnome.Location = new System.Drawing.Point(52, 130);
            this.conbnome.Name = "conbnome";
            this.conbnome.Size = new System.Drawing.Size(235, 21);
            this.conbnome.TabIndex = 108;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 112;
            this.label6.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 15);
            this.label7.TabIndex = 113;
            this.label7.Text = "RA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(171, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(280, 47);
            this.label8.TabIndex = 114;
            this.label8.Text = "Cadastro Alunos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 115;
            this.label9.Text = "Cursos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-3, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 116;
            this.label10.Text = "Telefone";
            // 
            // btnsalva
            // 
            this.btnsalva.Location = new System.Drawing.Point(115, 319);
            this.btnsalva.Name = "btnsalva";
            this.btnsalva.Size = new System.Drawing.Size(75, 23);
            this.btnsalva.TabIndex = 117;
            this.btnsalva.Text = "salvar";
            this.btnsalva.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(304, 69);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(359, 309);
            this.dataGridView2.TabIndex = 118;
            // 
            // cadastrar_aluno
            // 
            this.ClientSize = new System.Drawing.Size(675, 408);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnsalva);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttelefones);
            this.Controls.Add(this.txtrra);
            this.Controls.Add(this.conbcursos);
            this.Controls.Add(this.conbnome);
            this.Name = "cadastrar_aluno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.ComboBox conbcurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtra;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
       
        private System.Windows.Forms.BindingSource alunoBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn alucodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alunomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aluRADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alutelefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disccodDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txttelefones;
        private System.Windows.Forms.TextBox txtrra;
        private System.Windows.Forms.ComboBox conbcursos;
        private System.Windows.Forms.ComboBox conbnome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnsalva;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}