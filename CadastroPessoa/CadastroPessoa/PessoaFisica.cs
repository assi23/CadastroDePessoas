using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
	class PessoaFisica : Pessoa
	{
		public string RG{ get; set; }
		public string CPF{ get; set; }

		public PessoaFisica(int id,string nome, DateTime datanasc, string email,string rg,string cpf, Endereco endereco)
		{
			this.ID = id;
			this.Nome = nome;
			this.DataNasc = datanasc;
			this.Email = email;
			this.RG = rg;
			this.CPF = cpf;
			this.Endereco = endereco;
		}
        public PessoaFisica()
        {
        }

		public PessoaFisica Cadastro(int id)
        {
            Console.WriteLine($"\nCadastrando {id}ª Pessoa: ");
            Console.Write("Digite o Nome: ");
			string nome = Validacao.ValidaString();
            Console.Write("Digite o ano de Nascimento: ");
            DateTime data = Validacao.ValidaDataNasc();
            Console.Write("Digite o Email: ");
			string email = Validacao.ValidaString();
            Console.Write("Digite o RG: ");
			string rg = Validacao.ValidaRG();
            Console.Write("Digite o CPF: ");
			string cpf = Validacao.ValidaString();
            Console.Write("Digite a Rua: ");
            string rua = Validacao.ValidaString();
            Console.Write("Digite o número: ");
            int num = Validacao.ValidaInteiro();
            Console.Write("Digite o complemento: ");
            string comp = Validacao.ValidaString();
            Console.Write("Digite o Bairro: ");
            string bairro = Validacao.ValidaString();
            Console.Write("Digite a Cidade: ");
            string cidade = Validacao.ValidaString();

            Endereco endModel = new Endereco(rua, num, comp, bairro, cidade);
            PessoaFisica model = new PessoaFisica(id, nome, data, email, rg, cpf, endModel);
            return model;
        }

        public override string ToString()
        {
            return $"Nome: {this.Nome}\n=-=-=-=-=-=-=-=-=-=\nID: {this.ID}\nData Nascimento: {this.DataNasc.ToShortDateString()}\nEmail: {this.Email}\nRG: {this.RG}\nCPF: {this.CPF}\nEndereço: {Endereco}";
        }

        public override bool Equals(object pessoaFisica)
        {
            return this.CPF.Equals(((PessoaFisica)pessoaFisica).CPF);
        }
    }
}
