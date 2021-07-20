using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
    class Cadastro
    {
        Validacao v = new Validacao();
        public PessoaFisica CadastroPFis(int id)
        {
            Console.WriteLine($"\nCadastrando {id}ª Pessoa: ");
            Console.Write("Digite o Nome: ");
            string nome = v.ValidaString();
            Console.Write("Digite a Data de Nascimento (dd/mm/aaaa): ");
            DateTime data = v.ValidaDataNasc();
            Console.Write("Digite o Email: ");
            string email = v.ValidaString();
            Console.Write("Digite o RG: ");
            string rg = v.ValidaRGIgual();
            Console.Write("Digite o CPF: ");
            string cpf = v.ValidaCPFIgual();
            Console.Write("Digite a Rua: ");
            string rua = v.ValidaString();
            Console.Write("Digite o número: ");
            int num = v.ValidaInteiro();
            Console.Write("Digite o complemento: ");
            string comp = v.ValidaString();
            Console.Write("Digite o Bairro: ");
            string bairro = v.ValidaString();
            Console.Write("Digite a Cidade: ");
            string cidade = v.ValidaString();

            Endereco endModel = new Endereco(rua, num, comp, bairro, cidade);
            PessoaFisica model = new PessoaFisica(id, nome, data, email, rg, cpf, endModel);
            return model;
        }

        public PessoaJuridica CadastroPJur(int id)
        {
            Console.WriteLine($"\nCadastrando {id}ª Pessoa: ");
            Console.Write("Digite o Nome: ");
            string nome = v.ValidaString();
            Console.Write("Digite a data de fundação dd/mm/aaaa ou aaaa/mm/dd: ");
            DateTime data = v.ValidaDataNasc();
            Console.Write("Digite o Email: ");
            string email = v.ValidaString();
            Console.Write("Digite o IE: ");
            string ie = v.ValidaIEIgual();
            Console.Write("Digite o CNPJ: ");
            string cnpj = v.ValidaCNPJIgual();
            Console.Write("Digite a Rua: ");
            string rua = v.ValidaString();
            Console.Write("Digite o número: ");
            int num = v.ValidaInteiro();
            Console.Write("Digite o complemento: ");
            string comp = v.ValidaString();
            Console.Write("Digite o Bairro: ");
            string bairro = v.ValidaString();
            Console.Write("Digite a Cidade: ");
            string cidade = v.ValidaString();

            Endereco endModel = new Endereco(rua, num, comp, bairro, cidade);
            PessoaJuridica model = new PessoaJuridica(id, nome, data, email, ie, cnpj, endModel);
            return model;
        }

    }
}
