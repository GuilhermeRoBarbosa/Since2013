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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroaluno tela = new cadastroaluno();
            tela.Show();
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void matricularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            matriculacursos tela = new matriculacursos();
            tela.Show();
            this.Hide();

        }

        private void lançarNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           lançarnota tela = new lançarnota();
            tela.Show();
            this.Hide();
        }
    }
}
