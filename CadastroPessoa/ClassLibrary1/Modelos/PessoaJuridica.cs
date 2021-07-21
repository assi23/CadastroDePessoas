using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class PessoaJuridica : Pessoa	
	{
		public string IE{ get; set; }
		public string CNPJ{ get; set; }

		public PessoaJuridica(int id, string nome, DateTime datanasc, string email, string ie, string cnpj, Endereco endereco)
		{
			this.Id = id;
			this.Nome = nome;
			this.DataNasc = datanasc;
			this.Email = email;
			this.IE = ie;
			this.CNPJ = cnpj;
			this.Endereco = endereco;
		}
		public PessoaJuridica(List<object> atributo)
		{
			this.Id = Convert.ToInt32(atributo[6]);
			this.Nome = (string)atributo[2];
			this.DataNasc = (DateTime)atributo[3];
			this.Email = (string)atributo[4];
			this.IE = (string)atributo[0];
			this.CNPJ = (string)atributo[1];
			this.Endereco = (Endereco)atributo[5];
		}
		public PessoaJuridica()
		{
		}
		public void AlterarPessoaJuridica(List<object> atributo)
		{
			this.Nome = (string)atributo[2];
			this.DataNasc = (DateTime)atributo[3];
			this.Email = (string)atributo[4];
			this.IE = (string)atributo[0];
			this.CNPJ = (string)atributo[1];
			this.Endereco = (Endereco)atributo[5];
		}
		public override string ToString()
		{
			return $"Empresa {this.Id}\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nNome: {this.Nome}\nData de Fundação: {this.DataNasc.ToShortDateString()}\nEmail: {this.Email}\nIE: {this.IE}\nCNPJ: {this.CNPJ.Insert(2, ".").Insert(6, ".").Insert(10, "/").Insert(15,"-")}\nEndereço: {Endereco}\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=";
		}

		//public override bool Equals(object pessoaJuridica)
		//{
		//	return this.CNPJ.Equals(((PessoaJuridica)pessoaJuridica).CNPJ);
		//}
	}
	
}
