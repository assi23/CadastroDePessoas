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

        public override string ToString()
        {
            return $"ID: {this.ID} Nome: {this.Nome} Email: {this.Email} RG: {this.RG} CPF: {this.CPF}\nEndereço: {Endereco}";
        }

        public override bool Equals(object pessoaFisica)
        {
            return this.CPF.Equals(((PessoaFisica)pessoaFisica).CPF);
        }
    }
}
