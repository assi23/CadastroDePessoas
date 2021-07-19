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

		public PessoaFisica(int id, DateTime datanasc,string email,Endereco endereco,string rg,string cpf)
		{
			this.ID = id;
			this.DataNasc = datanasc;
			this.Email = email;
			this.Endereco = endereco;
			this.RG = rg;
			this.CPF = cpf;
		}
	}
}
