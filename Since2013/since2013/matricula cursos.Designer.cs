namespace since2013
{
    partial class matricula_cursos
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
            this.components = new System.ComponentModel.Container();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.conbcurso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(456, 84);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 6;
            this.btnsalvar.Text = "salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            // 
            // conbcurso
            // 
            this.conbcurso.FormattingEnabled = true;
            this.conbcurso.Items.AddRange(new object[] {
            "Ingles",
            "Espanhol"});
            this.conbcurso.Location = new System.Drawing.Point(103, 86);
            this.conbcurso.Name = "conbcurso";
            this.conbcurso.Size = new System.Drawing.Size(278, 21);
            this.conbcurso.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cusos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Registro de cursos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(62, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 241);
            this.dataGridView1.TabIndex = 8;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Disciplina";
            // 
            // matricula_cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.conbcurso);
            this.Controls.Add(this.label1);
            this.Name = "matricula_cursos";
            this.Text = "matricula_cursos";
            this.Load += new System.EventHandler(this.matricula_cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.ComboBox conbcurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
       
        private System.Windows.Forms.BindingSource disciplinaBindingSource;
       
        private System.Windows.Forms.BindingSource disciplinaBindingSource1;
        private System.Windows.Forms.BindingSource alunoBindingSource;
       
        private System.Windows.Forms.BindingSource bindingSource1;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn disccodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discnomeDataGridViewTextBoxColumn;
    }
}