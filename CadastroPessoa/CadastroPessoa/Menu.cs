using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
    class Menu
    {
         List<PessoaFisica> listaPessoaFisica = new List<PessoaFisica>();
         List<PessoaJuridica> listaPessoaJuridica = new List<PessoaJuridica>();

        PessoaFisica pFisica = new PessoaFisica();
        PessoaJuridica pJuridica = new PessoaJuridica();
        int idpFis = 1;
        int idpJuri = 1;
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
            int option;
            do
            {
                Console.Write("Opção: ");
                option = Validacao.ValidaInteiro();

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Saindo... Pressione qualquer tecla para finalizar...");
                        Console.ReadLine();
                        break;
                    case 1:
                            string resp = string.Empty;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\t\t\t\t ________________________________________________ ");
                            Console.WriteLine("\t\t\t\t|            Cadastrando Pessoa Fisica           |");
                            Console.WriteLine("\t\t\t\t|________________________________________________|");
                            PessoaFisica model = pFisica.Cadastro(idpFis);
                            listaPessoaFisica.Add(model);
                            idpFis++;
                            Console.Write("Deseja cadastrar outra pessoa?[S/N]: ");
                            resp = Validacao.ValidaConfirmacao();
                        } while (resp.Equals("s"));
                        CriarMenu();
                        break;
                    case 2:
                        string resp2 = string.Empty;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\t\t\t\t ________________________________________________ ");
                            Console.WriteLine("\t\t\t\t|            Cadastrando Pessoa Jurídica         |");
                            Console.WriteLine("\t\t\t\t|________________________________________________|");
                            PessoaJuridica model = pJuridica.CadastroPJuridica(idpJuri);
                            listaPessoaJuridica.Add(model);
                            idpJuri++;
                            Console.WriteLine("Deseja cadastrar outra pessoa? [S/N]: ");
                            resp2 = Validacao.ValidaConfirmacao();
                        } while (resp2.Equals('s'));
                        CriarMenu();
                        break;
                    case 3:
                        MostrarListaPessoaFisica();
                        Console.Read();
                        break;
                    case 4:
                        MostrarListaPessoaJuridica();
                        Console.Read();
                        break;
                    default:
                        break;
                }
            } while (option < 0 && option > 4);
        }
        public void CriarMenu()
        {
            Console.Clear();
            Cabecalho();
            Opcoes();
            Rodape();
            Escolha();
        }
        public void MostrarListaPessoaFisica()
        {
            Console.WriteLine("\t\tLista De Pessoas Fisica");
            Console.WriteLine("\t\t***********************");
            foreach(var pessoa in listaPessoaFisica)
            {
                Console.WriteLine(pessoa);
            }
        }
        public void MostrarListaPessoaJuridica()
        {
            Console.WriteLine("\t\tLista de Pessoa Jurídica");
            Console.WriteLine("\t\t***********************");
            foreach (var pessoa in listaPessoaJuridica)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}
