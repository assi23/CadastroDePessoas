using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace CadastroPessoa
{
    public class OperacaoPessoa : Crud
    {
        int id;
        Validacao validacao;
        public OperacaoPessoa()
        {
            this.operacaoListar = MostrarLista;
            this.operacaoCriar = Cadastrar;
            this.operacaoEditar = Alterar;
            this.operacaoDeletar = DeletarPessoa;
            validacao = new Validacao();
            id = 1;
        }
        private void Cadastrar()
        {
            List<Object> atributos = new List<object>();                    
            foreach (var item in lista[0].GetType().GetProperties())
            {
                Console.Write($"Digite o {item.Name}: ");
                if (item.PropertyType == typeof(string))
                {
                    if (item.Name == "CPF")
                    {
                        atributos.Add(validacao.ValidaCPFIgual(lista));
                        
                    }else if (item.Name == "RG")
                    {
                        atributos.Add(validacao.ValidaRGIgual(lista));
                    }
                    else if (item.Name == "IE")
                    {
                        atributos.Add(validacao.ValidaIEIgual(lista));

                    }
                    else if (item.Name == "CNPJ")
                    {
                        atributos.Add(validacao.ValidaCNPJIgual(lista));
                    }
                    else
                    {
                        atributos.Add(validacao.ValidaString());
                    }
                }else if (item.PropertyType == typeof(int))
                {
                    if (item.Name == "Id")
                    {                            
                        atributos.Add(id);
                        id++;
                    }
                    else
                    {
                        atributos.Add(validacao.ValidaInteiro());
                    }
                }else if (item.PropertyType == typeof(Endereco))
                {
                    Console.WriteLine();
                    List<object> atributosEndereco = new List<object>();
                    Endereco e = new Endereco();
                    foreach (var i in e.GetType().GetProperties())
                    {
                         Console.Write($"Digite o {i.Name}: ");
                        if (item.GetType() == typeof(int))
                        {
                            atributosEndereco.Add(validacao.ValidaInteiro());
                        }
                        else
                        {
                            atributosEndereco.Add(validacao.ValidaString());
                        }
                    }
                    atributos.Add(new Endereco(atributosEndereco));
                }else if(item.PropertyType == typeof(DateTime))
                {
                    atributos.Add(validacao.ValidaData());
                }
                
            }
            if (lista[0].GetType() == typeof(PessoaFisica))
            {
                lista.Add(new PessoaFisica(atributos));
            } else if (lista[0].GetType() == typeof(PessoaJuridica))
            {
                lista.Add(new PessoaJuridica(atributos));
            } 
             
             
        }        
        private void MostrarLista()
        {
            Console.Clear();
            if (lista[0].GetType() == typeof(PessoaFisica))
            {
                for (int i = 1; i < lista.Count; i++)
                {
                    Console.WriteLine((PessoaFisica)lista[i]);
                }
            } else if (lista[0].GetType() == typeof(PessoaJuridica))
            {
                for (int i = 1; i < lista.Count; i++)
                {
                    Console.WriteLine((PessoaJuridica)lista[i]);
                }
            }
        }
        private void Alterar()
        {
            
            int resposta = 0;
            do
            {
                Console.Clear();
                MostrarLista();
                Pessoa pessoa;
                Console.Write("Qual o ID da pessoa que você deseja Alterar: ");
                resposta = validacao.ValidaInteiro();
                pessoa = ProcuraPorId(resposta);
                if (pessoa != null)
                {
                    List<Object> atributos = new List<object>();
                    if (lista[0].GetType() == typeof(PessoaFisica))
                    {
                        PessoaFisica p = (PessoaFisica)pessoa;
                        p.CPF = "UM CPF ALEATORIO";
                        p.RG = "UM RG ALEATORIO";
                        foreach (var item in p.GetType().GetProperties())
                        {
                            Console.Write($"Digite o {item.Name} da Pessoa Física: ");
                            if (item.PropertyType == typeof(string))
                            {
                                if (item.Name == "CPF")
                                {
                                    atributos.Add(validacao.ValidaCPFIgual(lista));

                                }
                                else if (item.Name == "RG")
                                {
                                    atributos.Add(validacao.ValidaRGIgual(lista));
                                }
                                else
                                {
                                    atributos.Add(validacao.ValidaString());
                                }
                            }
                            else if (item.PropertyType == typeof(int))
                            {
                                if (item.Name == "Id")
                                {
                                    
                                    atributos.Add(id);
                                    id++;
                                }
                                else
                                {
                                    atributos.Add(validacao.ValidaInteiro());
                                }
                            }
                            else if (item.PropertyType == typeof(Endereco))
                            {
                                Console.WriteLine();
                                List<object> atributosEndereco = new List<object>();
                                Endereco e = new Endereco();
                                foreach (var i in e.GetType().GetProperties())
                                {
                                    Console.Write($"Digite o  Novo {i.Name} da Pessoa Física: ");
                                    if (item.GetType() == typeof(int))
                                    {
                                        atributosEndereco.Add(validacao.ValidaInteiro());
                                    }
                                    else
                                    {
                                        atributosEndereco.Add(validacao.ValidaString());
                                    }
                                }
                                atributos.Add(new Endereco(atributosEndereco));
                            }
                            else if (item.PropertyType == typeof(DateTime))
                            {
                                atributos.Add(validacao.ValidaData());
                            }

                        }
                            p.AlterarPessoaFisica(atributos);
                    }
                    else if (lista[0].GetType() == typeof(PessoaJuridica))
                    {
                        PessoaJuridica p = (PessoaJuridica)pessoa;
                        p.IE = "UM IE ALEATORIO";
                        p.CNPJ = "UM CNPJ ALEATORIO";

                        foreach (var item in p.GetType().GetProperties())
                        {
                            Console.Write($"Digite o {item.Name} da Pessoa Jurídica: ");
                            if (item.PropertyType == typeof(string))
                            {
                                if (item.Name == "IE")
                                {
                                    atributos.Add(validacao.ValidaIEIgual(lista));

                                }
                                else if (item.Name == "CNPJ")
                                {
                                    atributos.Add(validacao.ValidaCNPJIgual(lista));
                                }
                                else
                                {
                                    atributos.Add(validacao.ValidaString());
                                }
                            }
                            else if (item.PropertyType == typeof(int))
                            {
                                if (item.Name == "Id")
                                {                                    
                                    atributos.Add(id);
                                    id++;
                                }
                                else
                                {
                                    atributos.Add(validacao.ValidaInteiro());
                                }
                            }
                            else if (item.PropertyType == typeof(Endereco))
                            {
                                List<object> atributosEndereco = new List<object>();
                                Endereco e = new Endereco();
                                Console.WriteLine();
                                foreach (var i in e.GetType().GetProperties())
                                {
                                    Console.Write($"Digite o {i.Name} da Pessoa Jurídica: ");
                                    if (item.GetType() == typeof(int))
                                    {
                                        atributosEndereco.Add(validacao.ValidaInteiro());
                                    }
                                    else
                                    {
                                        atributosEndereco.Add(validacao.ValidaString());
                                    }
                                }
                                atributos.Add(new Endereco(atributosEndereco));


                            }
                            else if (item.PropertyType == typeof(DateTime))
                            {
                                atributos.Add(validacao.ValidaData());
                            }

                        }
                        p.AlterarPessoaJuridica(atributos);

                    }
                    Console.Write("PESSOA ALTERADA, DESEJA MUDAR OUTRA? (s/n): ");
                }
                else
                {
                    Console.Write("ID NÃO ENCONTRADO, DESEJA TENTAR NOVAMENTE? (s/n):");
                }
            } while (validacao.ValidaConfirmacao() == "s");
            
        }
        private Pessoa ProcuraPorId(int id)
        {
            return (Pessoa)lista.Find(x => x.Id == id);
        }
        private void DeletarPessoa()
        {
            int r = 0;
            do
            {
                Console.Clear();
                MostrarLista();
                Pessoa pessoa;
                Console.Write("Qual o ID da pessoa que você deseja Deletar: ");
                r = validacao.ValidaInteiro();
                pessoa = ProcuraPorId(r);
                if (pessoa != null)
                {
                    lista.Remove(lista.Find(x => x.Id == r));
                    Console.Write("PESSOA DELETADA, DESEJA DELETAR OUTRA? (s/n): ");

                }else
                {
                    Console.Write("ID NÃO ENCONTRADO, DESEJA TENTAR NOVAMENTE? (s/n):");
                }
            } while (validacao.ValidaConfirmacao() == "s");
        }

    }
}
