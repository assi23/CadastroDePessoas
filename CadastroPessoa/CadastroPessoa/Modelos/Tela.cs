using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
    public delegate int Opcoes();
    public delegate void Escolha(int escolha);
    class Tela
    {
        private string _nomeTela = "";
        protected Opcoes funcaoOpcoes;
        protected Escolha funcaoEscolha;

        public Tela(string nomeTela)
        {
            this._nomeTela = nomeTela;
        }

        public void Cabecalho()
        {
            Console.WriteLine("|================================================|");
            Console.WriteLine($"|                 {this._nomeTela}|");
            Console.WriteLine("|================================================|");
        }
        public void Esperar()
        {
            Console.WriteLine("Digite algo para voltar ao menu....");
            Console.ReadLine();
        }
        
        public void Executa()
        {
            int escolha = 0;
            do
            {
                Console.Clear();
                Cabecalho();
                escolha = funcaoOpcoes();
                funcaoEscolha(escolha);
            } while (escolha != 0);
        }
    }
}
