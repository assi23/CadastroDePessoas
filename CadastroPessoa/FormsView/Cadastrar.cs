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
    public partial class Cadastrar : Form
    {
        List<Pessoa> lista;
        bool fisica;
        public Cadastrar(List<Pessoa> listaFora, bool fisicaFora)
        {
            fisica = fisicaFora;
            lista = listaFora;
            InitializeComponent();
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Endereco endereco = new Endereco(tbxRua.Text, Convert.ToInt32(textBox9.Text), tbxComplemento.Text, tbxBairro.Text, tbxCidade.Text);
            if (fisica)
            {
                lista.Add(new PessoaFisica(lista.Count + 1, tbxNome.Text, Convert.ToDateTime(tbxData.Text), tbxEmail.Text, tbxRG.Text, tbxCPF.Text, endereco));

            }
            lbAviso.Visible = true;

        }
    }
}
