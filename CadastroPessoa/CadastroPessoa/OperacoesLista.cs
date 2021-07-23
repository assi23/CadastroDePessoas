using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
    class OperacoesLista
    {
        Validacao v = new Validacao();
        public void BuscarPorId(List<BaseModel> lista)
        {
            Tela tela = new Tela("Busca Por ID        ");
            Console.Clear();
            tela.Cabecalho();
            if (lista.Count > 0)
            {
                Console.Write("Digite o ID que deseja buscar: ");
                int id = v.ValidaInteiro();
                foreach (var pessoa in lista)
                {
                    if (pessoa.Id == id)
                    {
                        Console.Clear();
                        Console.WriteLine(pessoa);
                        Console.WriteLine("\nEncontrado. Pressione qualquer tecla para voltar....");
                    }
                }
                Console.WriteLine("\nId não encontrado. Pressione qualquer tecla para voltar....");
            }
            else if (lista.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nOpção invalida com a lista vazia. Pressione qualquer tecla para voltar...");
                Console.ResetColor();
            }
            Console.ReadKey();
        }

        public void BuscarPorNome(List<BaseModel> lista)
        {
            Tela tela = new Tela("Busca Por Nome      ");
            Console.Clear();
            tela.Cabecalho();
            if (lista.Count > 0)
            {
                Console.Write("Digite o Nome que deseja buscar: ");
                string nome = v.ValidaString().ToLower();
                foreach (var pessoa in lista)
                {
                    if (((Pessoa)pessoa).Nome.ToLower() == nome)
                    {
                        Console.Clear();
                        Console.WriteLine(pessoa);
                        Console.WriteLine("\nEncontrado. Pressione qualquer tecla para voltar....");
                    }
                }
            }
            else if (lista.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nOpção invalida com a lista vazia. Pressione qualquer tecla para voltar...");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("\nId não encontrado. Pressione qualquer tecla para voltar....");
            }
            Console.ReadKey();
        }

        public void MostrarListaCompleta(List<BaseModel> lista)
        {
            if (lista.Count > 0)
            {
                foreach (var pessoa in lista)
                {
                    Console.WriteLine(pessoa);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nEssa lista não possui nenhum registro...\n");
                Console.ResetColor();
            }
        }
    }
}
