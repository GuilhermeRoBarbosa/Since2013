namespace since2013
{
    partial class lançarnota
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
            this.conbnome = new System.Windows.Forms.ComboBox();
            this.conbcursos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conbnome
            // 
            this.conbnome.FormattingEnabled = true;
            this.conbnome.Location = new System.Drawing.Point(29, 74);
            this.conbnome.Name = "conbnome";
            this.conbnome.Size = new System.Drawing.Size(232, 21);
            this.conbnome.TabIndex = 0;
            // 
            // conbcursos
            // 
            this.conbcursos.FormattingEnabled = true;
            this.conbcursos.Location = new System.Drawing.Point(297, 74);
            this.conbcursos.Name = "conbcursos";
            this.conbcursos.Size = new System.Drawing.Size(247, 21);
            this.conbcursos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "cursos";
            // 
            // txtnota1
            // 
            this.txtnota1.Location = new System.Drawing.Point(124, 191);
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(100, 20);
            this.txtnota1.TabIndex = 4;
            // 
            // txtnota2
            // 
            this.txtnota2.Location = new System.Drawing.Point(346, 191);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(100, 20);
            this.txtnota2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "nota:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "nota:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 100;
            this.label5.Text = "notas do aluno";
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(571, 187);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 101;
            this.btnsalvar.Text = "salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            // 
            // lançarnota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnota2);
            this.Controls.Add(this.txtnota1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conbcursos);
            this.Controls.Add(this.conbnome);
            this.Name = "lançarnota";
            this.Text = "lançarnota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox conbnome;
        private System.Windows.Forms.ComboBox conbcursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsalvar;
    }
}