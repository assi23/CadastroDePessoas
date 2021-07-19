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
	}
	
}
