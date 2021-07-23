using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuForm
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnPJ_Click(object sender, EventArgs e)
        {
            MenuPessoaForm menuPJ = new MenuPessoaForm(0);
            menuPJ.Show();
        }

        private void btnPF_Click(object sender, EventArgs e)
        {
            MenuPessoaForm menuPF = new MenuPessoaForm(1);
            menuPF.Show();
        }
    }
}
