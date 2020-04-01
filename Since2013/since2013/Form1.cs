using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace since2013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrar_aluno tela = new cadastrar_aluno();
            tela.Show();
           // this.Hide();
        }

        private void matriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            matricula_cursos tela = new matricula_cursos();
            tela.Show();
           // this.Hide();

        }

        private void lançarNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lançamento_nota tela = new lançamento_nota();
            tela.Show();
           // this.Hide();
        }

       
    }
}
