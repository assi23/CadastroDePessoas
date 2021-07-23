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
    public partial class TelaPrincipalForm : Form
    {
        List<Pessoa> listaPF;
        List<Pessoa> listaJuridica;

        PessoaFisicaForm pfForm;
        PessoaJuridicaForm pjForm;
        public TelaPrincipalForm()  
        {

            listaPF = new List<Pessoa>();
            InitializeComponent();
            listaPF.Add(new PessoaFisica(1, "12 / 12 / 1212", Convert.ToDateTime("12 / 12 / 1212"), " 1", "1", " 1", new Endereco("1", 1, "1", "1", "1")));
            listaJuridica = new List<Pessoa>();
            Hide();
            
            Show();
        }
        private void TelaPrincipalForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPessoaFisica_Click(object sender, EventArgs e)        
        {
            pfForm = new PessoaFisicaForm(listaPF);
            this.pfForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Operacao_FormClose);
            Hide();
            pfForm.Show();

        }
        private void Operacao_FormClose(Object sender, FormClosingEventArgs e)
        {
            Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pjForm = new PessoaJuridicaForm(listaJuridica);
            this.pjForm.FormClosing += new FormClosingEventHandler(this.Operacao_FormClose);
            Hide();
            pjForm.Show();
        }
    }
}
