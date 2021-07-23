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
    public partial class PessoaJuridicaForm : Form
    {
        List<Pessoa> listaPF;
        Operacoes listar;
        Cadastrar cadastrar;


        public PessoaJuridicaForm(List<Pessoa> lista)
        {
            listaPF = lista;
            InitializeComponent();
        }

        private void PessoaFisicaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrar = new Cadastrar(listaPF, false);
            this.cadastrar.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Operacao_FormClose);
            Hide();
            cadastrar.Show();
            
        }
        private void Operacao_FormClose(Object sender, FormClosingEventArgs e)
        {
            Show();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listar = new Operacoes(listaPF, false);
            this.listar.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Operacao_FormClose);
            Hide();
            listar.Show();
        }
    }
}
