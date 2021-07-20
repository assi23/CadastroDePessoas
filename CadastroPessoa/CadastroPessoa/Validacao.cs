using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
    class Validacao
    {
        public int ValidaInteiro()
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
        public long ValidaLong()
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
        public string ValidaString()
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
        public string ValidaConfirmacao()
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
        public string ValidaRG()
        {
            string rg;
            do
            {
                rg = ValidaString();
                if (rg.Length >= 6 && rg.Length <= 8)
                {
                    try
                    {
                        Convert.ToInt64(rg);
                        break;
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
                        Console.WriteLine("Tamanho invalido. Digite novamente: ");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Dado invalido. Digite novamente: ");
                    }
                }
                else
                {
                    Console.Write("Tamanho invalido. Digite um RG valido entre 6 e 8 digitos: ");
                }
            } while (true);
            return rg;
        }
        public string ValidaCPF()
        {
            string cpf;
            do
            {
                cpf = ValidaString();
                if (cpf.Length == 11)
                {
                    try
                    {
                        Convert.ToInt64(cpf);
                        break;
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
                        Console.WriteLine("Tamanho invalido. Digite novamente: ");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Dado invalido. Digite novamente: ");
                    }
                }
                else
                {
                    Console.Write("Tamanho invalido. Digite um CPF valido com 11 digitos: ");
                }
            } while (true);
            return cpf;
        }
        public string ValidaCNPJ()
        {
            string cnpj;
            do
            {
                cnpj = ValidaString();
                if (cnpj.Length == 14)
                {
                    try
                    {
                        Convert.ToInt64(cnpj);
                        break;
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
                        Console.WriteLine("Tamanho invalido. Digite novamente: ");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Dado invalido. Digite novamente: ");
                    }
                }
                else
                {
                    Console.Write("Tamanho invalido. Digite um CNPJ valido com 14 digitos: ");
                }
            } while (true);
            return cnpj;
        }
        public string ValidaIE()
        {
            string ie;
            do
            {
                ie = ValidaString();
                if (ie.Length == 13)
                {
                    try
                    {
                        Convert.ToInt64(ie);
                        break;
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
                        Console.WriteLine("Tamanho invalido. Digite novamente: ");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Dado invalido. Digite novamente: ");
                    }
                }
                else
                {
                    Console.Write("Tamanho invalido. Digite um IE valido com 13 digitos: ");
                }
            } while (true);
            return ie;
        }
        public string ValidaCPFIgual()
        {
            bool cpfIgual = true;
            string cpf;
            do
            {
                cpf = ValidaCPF();
                List<PessoaFisica> lista = Menu.listaPessoaFisica;
                if (lista.Count == 0)
                {
                    return cpf;
                }
                else
                {
                    foreach (var pessoa in lista)
                    {
                        if (pessoa.CPF != cpf)
                        {
                            cpfIgual = false;
                        }
                        else
                        {
                            Console.WriteLine($"O CPF {pessoa.CPF} ja está cadastrado no sistema no ID {pessoa.ID}!");
                            Console.WriteLine("Digite outro CPF: ");
                            cpfIgual = true;
                            break;
                        }
                    }
                }
            } while (cpfIgual);
            return cpf;
        }
        public string ValidaRGIgual()
        {
            bool rgIgual = true;
            string rg;
            do
            {
                rg = ValidaRG();
                List<PessoaFisica> lista = Menu.listaPessoaFisica;
                if (lista.Count == 0)
                {
                    return rg;
                }
                else
                {
                    foreach (var pessoa in lista)
                    {
                        if (pessoa.RG != rg)
                        {
                            rgIgual = false;
                        }
                        else
                        {
                            Console.WriteLine($"O CPF {pessoa.CPF} ja está cadastrado no sistema no ID {pessoa.ID}!");
                            Console.WriteLine("Digite outro CPF: ");
                            rgIgual = true;
                            break;
                        }
                    }
                }
            } while (rgIgual);
            return rg;
        }
        public string ValidaCNPJIgual()
        {
            bool cnpjIgual = true;
            string cnpj;
            do
            {
                cnpj = ValidaCNPJ();
                List<PessoaJuridica> lista = Menu.listaPessoaJuridica;
                if (lista.Count == 0)
                {
                    return cnpj;
                }
                else
                {
                    foreach (var pessoa in lista)
                    {
                        if (pessoa.CNPJ != cnpj)
                        {
                            cnpjIgual = false;
                        }
                        else
                        {
                            Console.WriteLine($"O CPF {pessoa.CNPJ} ja está cadastrado no sistema no ID {pessoa.ID}!");
                            Console.WriteLine("Digite outro CPF: ");
                            cnpjIgual = true;
                            break;
                        }
                    }
                }
            } while (cnpjIgual);
            return cnpj;
        }
        public string ValidaIEIgual()
        {
            bool ieIgual = true;
            string ie;
            do
            {
                ie = ValidaCNPJ();
                List<PessoaJuridica> lista = Menu.listaPessoaJuridica;
                if (lista.Count == 0)
                {
                    return ie;
                }
                else
                {
                    foreach (var pessoa in lista)
                    {
                        if (pessoa.IE != ie)
                        {
                            ieIgual = false;
                        }
                        else
                        {
                            Console.WriteLine($"O CPF {pessoa.CNPJ} ja está cadastrado no sistema no ID {pessoa.ID}!");
                            Console.WriteLine("Digite outro CPF: ");
                            ieIgual = true;
                            break;
                        }
                    }
                }
            } while (ieIgual);
            return ie;
        }


        public DateTime ValidaDataNasc()
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
