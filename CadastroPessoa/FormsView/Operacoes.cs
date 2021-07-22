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
    public partial class Operacoes : Form
    {
        public List<Pessoa> Lista { get; set; }
        bool fisica;
        public Operacoes(List<Pessoa> listaFora, bool fisicaFora)
        {
            InitializeComponent();
            fisica = fisicaFora;
            Lista = listaFora;
            LimpaGrid();
            CarregarLista();
        }
        private void CarregarLista()
        {
            dgLista.Refresh();
            LimpaGrid();
            this.dgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clDelete});
            this.clDelete.HeaderText = "Deletar";
            this.clDelete.Name = "clDelete";
            this.clDelete.Text = "Delete";
            dgLista.DataSource = Lista;
        }

     

        private void Listar_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void dgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Lista.Count > 0)
            {
                Pessoa pessoaF = this.Lista[e.RowIndex];
                LimpaGrid();
                this.Lista.Remove(pessoaF);
                MessageBox.Show("Removido com sucesso");
                CarregarLista();  
            }
        }
        private void LimpaGrid()
        {
            dgLista.DataSource = null;
            dgLista.Rows.Clear();
            this.dgLista.Columns.Clear();
        }
    }
}
