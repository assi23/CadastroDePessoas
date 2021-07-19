using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
	class PessoaJuridica : Pessoa	
	{
		public string IE{ get; set; }
		public string CNPJ{ get; set; }

		public PessoaJuridica(int id, string nome, DateTime datanasc, string email, string ie, string cnpj, Endereco endereco)
		{
			this.ID = id;
			this.Nome = nome;
			this.DataNasc = datanasc;
			this.Email = email;
			this.IE = ie;
			this.CNPJ = cnpj;
			this.Endereco = endereco;
		}
		public PessoaJuridica()
		{
		}
		public PessoaJuridica CadastroPJuridica(int id)
		{
			Console.WriteLine($"\nCadastrando {id}ª Pessoa: ");
			Console.Write("Digite o Nome: ");
			string nome = Validacao.ValidaString();
			Console.Write("Digite a data de fundação: ");
			DateTime data = Convert.ToDateTime(Console.ReadLine());
			Console.Write("Digite o Email: ");
			string email = Validacao.ValidaString();
			Console.Write("Digite o IE: ");
			string ie = Validacao.ValidaString();
			Console.Write("Digite o CNPJ: ");
			string cnpj = Validacao.ValidaString();
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
			PessoaJuridica model = new PessoaJuridica(id, nome, data, email, ie, cnpj, endModel);
			return model;
		}
		public override string ToString()
		{
			return $"Nome: {this.Nome}\n=-=-=-=-=-=-=-=-=-=\nID: {this.ID}\nData de Fundação: {this.DataNasc.ToShortDateString()}\nEmail: {this.Email}\nIE: {this.IE}\nCNPJ: {this.CNPJ}\nEndereço: {Endereco}";
		}

		public override bool Equals(object pessoaJuridica)
		{
			return this.CNPJ.Equals(((PessoaJuridica)pessoaJuridica).CNPJ);
		}
	}
	
}
