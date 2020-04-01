namespace since2013
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CadastrarAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MatricularCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LançamentoDeNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lançarNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CadastrarAlunosToolStripMenuItem,
            this.MatricularCursosToolStripMenuItem,
            this.LançamentoDeNotaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(396, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CadastrarAlunosToolStripMenuItem
            // 
            this.CadastrarAlunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem});
            this.CadastrarAlunosToolStripMenuItem.Name = "CadastrarAlunosToolStripMenuItem";
            this.CadastrarAlunosToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.CadastrarAlunosToolStripMenuItem.Text = "cadastrar alunos";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarToolStripMenuItem.Text = "cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // MatricularCursosToolStripMenuItem
            // 
            this.MatricularCursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matriculaToolStripMenuItem});
            this.MatricularCursosToolStripMenuItem.Name = "MatricularCursosToolStripMenuItem";
            this.MatricularCursosToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.MatricularCursosToolStripMenuItem.Text = "matricular cursos";
            // 
            // matriculaToolStripMenuItem
            // 
            this.matriculaToolStripMenuItem.Name = "matriculaToolStripMenuItem";
            this.matriculaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.matriculaToolStripMenuItem.Text = "matricula";
            this.matriculaToolStripMenuItem.Click += new System.EventHandler(this.matriculaToolStripMenuItem_Click);
            // 
            // LançamentoDeNotaToolStripMenuItem
            // 
            this.LançamentoDeNotaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lançarNotaToolStripMenuItem});
            this.LançamentoDeNotaToolStripMenuItem.Name = "LançamentoDeNotaToolStripMenuItem";
            this.LançamentoDeNotaToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.LançamentoDeNotaToolStripMenuItem.Text = "lançamento de nota";
            // 
            // lançarNotaToolStripMenuItem
            // 
            this.lançarNotaToolStripMenuItem.Name = "lançarNotaToolStripMenuItem";
            this.lançarNotaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lançarNotaToolStripMenuItem.Text = "lançar nota";
            this.lançarNotaToolStripMenuItem.Click += new System.EventHandler(this.lançarNotaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem1});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.sairToolStripMenuItem.Text = "sair";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem1.Text = "sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(396, 166);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CadastrarAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MatricularCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LançamentoDeNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lançarNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
    }
}

