namespace since2013
{
    partial class cadastroaluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.txtra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.conbcurso = new System.Windows.Forms.ComboBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nome";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(32, 92);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(364, 20);
            this.txtnome.TabIndex = 1;
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(424, 92);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(364, 20);
            this.txttelefone.TabIndex = 3;
            // 
            // txtra
            // 
            this.txtra.Location = new System.Drawing.Point(32, 163);
            this.txtra.Name = "txtra";
            this.txtra.Size = new System.Drawing.Size(364, 20);
            this.txtra.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "cursos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "RA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "telefone";
            // 
            // conbcurso
            // 
            this.conbcurso.FormattingEnabled = true;
            this.conbcurso.Location = new System.Drawing.Point(424, 161);
            this.conbcurso.Name = "conbcurso";
            this.conbcurso.Size = new System.Drawing.Size(364, 21);
            this.conbcurso.TabIndex = 8;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(32, 209);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 9;
            this.btnsalvar.Text = "salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            // 
            // cadastroaluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.conbcurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtra);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label1);
            this.Name = "cadastroaluno";
            this.Text = "cadastroaluno";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cadastroaluno_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.TextBox txtra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox conbcurso;
        private System.Windows.Forms.Button btnsalvar;
    }
}