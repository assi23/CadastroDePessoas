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


        public TelaPrincipalForm()  
        {
            InitializeComponent();
            listaPF = new List<Pessoa>();
            listaPF.Add(new PessoaFisica(1, "12 / 12 / 1212", Convert.ToDateTime("12 / 12 / 1212"), " 1", "1", " 1", new Endereco("1", 1, "1", "1", "1")));
            listaJuridica = new List<Pessoa>();
        }
        private void TelaPrincipalForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPessoaFisica_Click(object sender, EventArgs e)
        {
            PessoaFisicaForm pfForm = new PessoaFisicaForm(listaPF);
            pfForm.Show();
        }
    }
}
