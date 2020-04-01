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
    public partial class cadastroaluno : Form
    {
        public cadastroaluno()
        {
            InitializeComponent();
        }

        private void cadastroaluno_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach(Form formaberto in Application.OpenForms)
                {
                    if(formaberto is menu)
                    {
                        formaberto.Show();
                        break;
                    }
                }
            }
        }
    }
}
