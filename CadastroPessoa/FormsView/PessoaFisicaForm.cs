﻿using System;
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
        Cadastrar cadastrar;
        Operacoes listar;
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
            cadastrar = new Cadastrar(listaPF, true);
            this.cadastrar.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Operacao_FormClosed);
            Hide();
            cadastrar.Show();
        }
        private void Operacao_FormClosed(object sender, FormClosingEventArgs e)
        {
            Show();
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            listar = new Operacoes(listaPF, true);          
            this.listar.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Operacao_FormClosed);
            Hide();
            listar.Show();
        }
    }
}
