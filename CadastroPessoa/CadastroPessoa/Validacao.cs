using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
    class Validacao
    {
        public static int ValidaInteiro()
        {
            do
            {
                try
                {
                    int dado = Convert.ToInt32(Console.ReadLine().Trim());
                    return dado;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Dado nulo. Digite algo: ");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Dado invalido. Digite um número: ");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Número fora dos limites. Digite algo entre {int.MinValue} e {int.MaxValue}): ");
                }
                catch (Exception)
                {
                    Console.WriteLine("Dado invalido. Digite novamente: ");
                }
            } while (true);
        }
        public static string ValidaString()
        {
            do
            {

                string dado = Console.ReadLine().Trim();
                if (!string.IsNullOrEmpty(dado))
                {
                    return dado;
                }
                Console.WriteLine("Erro! Digite algo: ");
            } while (true);
        }
        public static string ValidaConfirmacao()
        {
            do
            {
                string dado = Console.ReadLine().Trim().ToLower();
                if (dado.Equals("s") || dado.Equals("n"))
                {
                    return dado;
                }
                Console.Write("Dado invalido. Digite apenas [S] ou [N]: ");
            } while (true);
        }
        public static string ValidaRG()
        {
            do
            {
                string dado = Console.ReadLine().Trim();
                if (!string.IsNullOrEmpty(dado))
                {
                    if (dado.Length <= 7)
                    {
                        return dado;
                    }
                    else
                    {

                    }
                }
                Console.WriteLine("Erro! Digite algo: ");
            } while (true);
        }
    }
}
