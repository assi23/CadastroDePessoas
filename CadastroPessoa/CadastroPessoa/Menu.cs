using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
    class Menu
    {
        public void Cabecalho()
        {
            Console.WriteLine(" ________________________________________________ ");
            Console.WriteLine("|               Cadastro de Pessoas              |");
            Console.WriteLine("|________________________________________________|");
        }
        public void Opcoes()
        {
            Console.WriteLine("|                                                |");
            Console.WriteLine("|[1] Cadastrar Pessoa Fisica                     |");
            Console.WriteLine("|[2] Cadastrar Pessoa Juridica                   |");
            Console.WriteLine("|[3] Lista De Pessoas Fisica                     |");
            Console.WriteLine("|[4] Lista De Pessoas Juridicas                  |");
            Console.WriteLine("|[0] FINALIZAR PROGRAMA                          |");
        }
        public void Rodape()
        {
            Console.WriteLine("|________________________________________________|");
        }
        public void Escolha()
        {
            do
            {
                Console.Write($"Opção: ");
                int option = Validacao.ValidaInteiro();
                do
                {
                    switch (option)
                    {
                        case 0:
                            Console.WriteLine("Saindo... Pressione qualquer tecla para finalizar...");
                            Console.ReadLine();
                            break;
                        case 1:
                            Console.Clear();
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        default:
                            break;
                    }
                } while (option < 0 && option > 4);
            } while (true);
        }
        public void CriarMenu()
        {
            Cabecalho();
            Opcoes();
            Rodape();
            Escolha();
        }
    }
}
