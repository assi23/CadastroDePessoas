using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace CadastroPessoa
{
    public delegate void Operacoes();
    public class Crud
    {
        protected List<BaseModel> lista = new List<BaseModel>();
        protected Operacoes operacaoCriar;
        protected Operacoes operacaoListar;
        protected Operacoes operacaoEditar;
        protected Operacoes operacaoDeletar;
        Validacao v = new Validacao();
        public void Criar()
        {
            string resp = string.Empty;
            do
            {
                Tela tela = new Tela("   CADASTRO         ");
                Console.Clear();
                tela.Cabecalho();
                operacaoCriar();
                Console.Write("Deseja cadastrar mais uma Pessoa? [S/N]: ");
                resp = v.ValidaConfirmacao();
            } while (resp.Equals("s"));
        }

        public void Listar()
        {
            Tela tela = new Tela("   LISTAGEM         ");
            Console.Clear();
            tela.Cabecalho();
            operacaoListar();
        }

        public void Editar()
        {
            Tela tela = new Tela("   EDITAR           ");
            Console.Clear();
            tela.Cabecalho();
            operacaoEditar();
            Console.ReadKey();
        }

        public void Deletar()
        {
            Tela tela = new Tela("   DELETAR          ");
            Console.Clear();
            tela.Cabecalho();
            operacaoDeletar();
            Console.ReadKey();
        }
    }
}
