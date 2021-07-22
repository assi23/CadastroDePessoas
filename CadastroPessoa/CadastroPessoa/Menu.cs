using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
    class Menu : Tela
    {
        ModuloPessoaFisica modPessoaFis;
        ModuloPessoaJuridica modPessoaJur;
        Validacao v;

        public Menu() : base("MENU PRINCIPAL                   ")
        {
            v = new Validacao();
            modPessoaFis = new ModuloPessoaFisica();
            modPessoaJur = new ModuloPessoaJuridica();
            this.funcaoEscolha = Escolha;
            this.funcaoOpcoes = Opcoes;
        }
        public int Opcoes()
        {
            Console.WriteLine("|================================================|");
            Console.WriteLine("|         [1] Modulo Pessoa Fisica               |");
            Console.WriteLine("|         [2] Modulo Pessoa Juridica             |");
            Console.WriteLine("|         [0] FINALIZA PROGRAMA                  |");
            Console.WriteLine("|================================================|");
            Console.Write("Opção: ");
            int escolha = v.ValidaInteiro();
            return escolha;
        }
        public void Escolha(int escolha)
        {
            switch (escolha)
            {
                case 0:
                    Console.WriteLine("Saindo... Pressione Qualquer Tecla Para Finalizar...");
                    Console.ReadKey();
                    break;
                case 1: // Modulo pessoa fisica
                    modPessoaFis.Executa();
                    break;
                case 2:// Modulo pessoa juridica
                    modPessoaJur.Executa();
                    break;
                default:
                    Console.WriteLine("Escolha Invalida. Pressione qualquer tecla para voltar...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
