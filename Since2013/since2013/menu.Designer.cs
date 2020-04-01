namespace since2013
{
    partial class menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosDeAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasDosAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matricularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lançarNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtjanela = new System.Windows.Forms.TextBox();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosDeAlunoToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.notasDosAlunosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosDeAlunoToolStripMenuItem
            // 
            this.cadastrosDeAlunoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.cadastrosDeAlunoToolStripMenuItem.Name = "cadastrosDeAlunoToolStripMenuItem";
            this.cadastrosDeAlunoToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.cadastrosDeAlunoToolStripMenuItem.Text = "cadastros de aluno";
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matricularToolStripMenuItem});
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.cursosToolStripMenuItem.Text = "cursos";
            // 
            // notasDosAlunosToolStripMenuItem
            // 
            this.notasDosAlunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lançarNotaToolStripMenuItem});
            this.notasDosAlunosToolStripMenuItem.Name = "notasDosAlunosToolStripMenuItem";
            this.notasDosAlunosToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.notasDosAlunosToolStripMenuItem.Text = "notas dos alunos";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarToolStripMenuItem.Text = "cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // matricularToolStripMenuItem
            // 
            this.matricularToolStripMenuItem.Name = "matricularToolStripMenuItem";
            this.matricularToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.matricularToolStripMenuItem.Text = "matricular";
            this.matricularToolStripMenuItem.Click += new System.EventHandler(this.matricularToolStripMenuItem_Click);
            // 
            // lançarNotaToolStripMenuItem
            // 
            this.lançarNotaToolStripMenuItem.Name = "lançarNotaToolStripMenuItem";
            this.lançarNotaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lançarNotaToolStripMenuItem.Text = "lançar nota";
            this.lançarNotaToolStripMenuItem.Click += new System.EventHandler(this.lançarNotaToolStripMenuItem_Click);
            // 
            // txtjanela
            // 
            this.txtjanela.Location = new System.Drawing.Point(12, 36);
            this.txtjanela.Multiline = true;
            this.txtjanela.Name = "txtjanela";
            this.txtjanela.Size = new System.Drawing.Size(757, 350);
            this.txtjanela.TabIndex = 1;
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtjanela);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosDeAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matricularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasDosAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lançarNotaToolStripMenuItem;
        private System.Windows.Forms.TextBox txtjanela;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}