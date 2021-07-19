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
        public static long ValidaLong()
        {
            do
            {
                try
                {
                    long dado = Convert.ToInt64(Console.ReadLine().Trim());
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
                string dado = Convert.ToString(Validacao.ValidaInteiro());
                if (dado.Length >= 6 && dado.Length <= 8)
                {
                    return dado.ToString();
                }
                else
                {
                    Console.WriteLine("Tamanho invalido. Digite um RG valido: ");
                }
            } while (true);
        }
        public static string ValidaCPF()
        {
            do
            {
                string dado = Convert.ToString(Validacao.ValidaLong());
                if (dado.ToString().Length == 11)
                {
                    return dado.ToString();
                }
                else
                {
                    Console.WriteLine("Tamanho invalido. Digite um CPF valido. Apenas números, 11 digitos: ");
                }
            } while (true);
        }
        public static string ValidaCNPJ()
        {
            do
            {
                string dado = Convert.ToString(Validacao.ValidaLong());
                if (dado.ToString().Length == 14)
                {
                    return dado.ToString();
                }
                else
                {
                    Console.WriteLine("Tamanho invalido. Digite um CNPJ valido. Apenas números, 14 digitos: ");
                }
            } while (true);
        }
        public static string ValidaIE()
        {
            do
            {
                string dado = Convert.ToString(Validacao.ValidaLong());
                if (dado.ToString().Length == 13)
                {
                    return dado.ToString();
                }
                else
                {
                    Console.WriteLine("Tamanho invalido. Digite um IE valido. Apenas números, 13 digitos: ");
                }
            } while (true);
        }


        public static DateTime ValidaDataNasc()
        {
            do
            {
                try
                {
                    DateTime data = Convert.ToDateTime(Console.ReadLine());
                    return data;
                }
                catch (Exception)
                {
                    Console.Write("Data invalida. Digite no formato dd/mm/aaaa ou aaaa/mm/dd: ");
                }
            } while (true);
        }
    }
}
