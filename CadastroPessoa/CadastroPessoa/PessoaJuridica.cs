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

		public PessoaJuridica(int id, DateTime datanasc, string email, Endereco endereco, string ie, string cnpj)
		{
			this.ID = id;
			this.DataNasc = datanasc;
			this.Email = email;
			this.Endereco = endereco;
			this.IE = ie;
			this.CNPJ = cnpj;
		}
	}
	
}
