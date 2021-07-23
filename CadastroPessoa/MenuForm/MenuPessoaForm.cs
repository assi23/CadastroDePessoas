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
    public partial class MenuPessoaForm : Form
    {
        public MenuPessoaForm(int index)
        {
            Inicializacao();
            tabMenuPessoa.SelectedIndex = index;
            if (index == 0)
            {
                
                tabPessoaFis.Dispose();
            }
            else
            {
                tabPessoaJur.Dispose();
            }
        }

        public void Inicializacao()
        {
            InitializeComponent();
            dgPF.AllowUserToAddRows = false;
            dgPJ.AllowUserToAddRows = false;
            dgPF.AutoGenerateColumns = false;
            dgPJ.AutoGenerateColumns = false;
        }
    }
}
