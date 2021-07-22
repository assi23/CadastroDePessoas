using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;

namespace FormsView
{
    public partial class PessoaFisicaForm : Form
    {
        List<Pessoa> listaPF;
        public PessoaFisicaForm(List<Pessoa> lista)
        {
            listaPF = lista;
            InitializeComponent();
        }

        private void PessoaFisicaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar(listaPF, true);
            cadastrar.Show();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Operacoes listar = new Operacoes(listaPF, true);
            listar.Show();
        }
    }
}
