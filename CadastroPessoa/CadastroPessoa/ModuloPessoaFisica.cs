using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
    class ModuloPessoaFisica : Tela
    {
        Validacao v;
        OperacoesPessoaFisica crud = new OperacoesPessoaFisica();
        public ModuloPessoaFisica() : base("MENU PESSOA FISICA             ")
        {
            this.funcaoEscolha = Escolha;
            this.funcaoOpcoes = Opcoes;
            v = new Validacao();
        }

        public int Opcoes()
        {
            Console.WriteLine("|================================================|");
            Console.WriteLine("|         [1] Cadastrar                          |");
            Console.WriteLine("|         [2] Listar                             |");
            Console.WriteLine("|         [3] Editar                             |");
            Console.WriteLine("|         [4] Deletar                            |");
            Console.WriteLine("|         [0] Voltar Ao Menu Principal           |");
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
                    break;
                case 1: // CREATE
                    crud.Criar();
                    break;
                case 2:// READ
                    crud.Listar();
                    break;
                case 3:// UPDATE
                    crud.Editar();
                    break;
                case 4:// DELETE
                    crud.Deletar();
                    break;
                default:
                    Console.WriteLine("Escolha Invalida. Pressione qualquer tecla para voltar...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
