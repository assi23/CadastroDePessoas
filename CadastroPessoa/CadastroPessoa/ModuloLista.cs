using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
    class ModuloLista : Tela
    {
        Validacao v;
        OperacoesLista opLista;
        List<BaseModel> lista = new List<BaseModel>();
        public ModuloLista() : base("   LISTAGEM         ")
        {
            this.funcaoEscolha = Escolha;
            this.funcaoOpcoes = Opcoes;
            this.v = new Validacao();
            this.opLista = new OperacoesLista();
        }
        private int Opcoes()
        {
            Console.Clear();
            Cabecalho();
            opLista.MostrarListaCompleta(lista);
            Console.WriteLine(" ________________________________________________ ");
            Console.WriteLine("|                   Menu Da Lista                |");
            Console.WriteLine("|================================================|");
            Console.WriteLine("|               [1] - Buscar Por Id              |");
            Console.WriteLine("|               [2] - Buscar Por Nome            |");
            Console.WriteLine("|               [0] - Voltar Ao Menu             |");
            Console.WriteLine("|================================================|");
            Console.Write("Opção: ");
            int escolha = v.ValidaInteiro();
            return escolha;
        }
        private void Escolha(int escolha)
        {
            switch (escolha)
            {
                case 0:
                    break;
                case 1:
                    opLista.BuscarPorId(lista);
                    break;
                case 2:
                    opLista.BuscarPorNome(lista);
                    break;
                default:
                    Console.WriteLine("Escolha Invalida. Pressione qualquer tecla para voltar...");
                    Console.ReadKey();
                    break;
            }
        }

        public void CopiaLista(List<BaseModel> listaRecebida)
        {
                    lista = listaRecebida;
        }
    }
}
