using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class PessoaFisica : Pessoa
	{
		public string RG{ get; set; }
		public string CPF{ get; set; }

		public PessoaFisica(int id,string nome, DateTime datanasc, string email,string rg,string cpf, Endereco endereco)
		{
			this.Id = id;
			this.Nome = nome;
			this.DataNasc = datanasc;
			this.Email = email;
			this.RG = rg;
			this.CPF = cpf;
			this.Endereco = endereco;
		}
        public PessoaFisica(List<Object> atributos)
        {
            this.RG = (string)atributos[0];
            this.CPF = (string)atributos[1];
            this.Nome = (string)atributos[2];
            this.DataNasc = (DateTime)atributos[3];
            this.Email = (string)atributos[4];
            this.Endereco = (Endereco)atributos[5];
            this.Id = Convert.ToInt32(atributos[6]);
        }
        public PessoaFisica()
        {
        }
        public void AlterarPessoaFisica(List<Object> atributos)
        {
            this.RG = (string)atributos[0];
            this.CPF = (string)atributos[1];
            this.Nome = (string)atributos[2];
            this.DataNasc = (DateTime)atributos[3];
            this.Email = (string)atributos[4];
            this.Endereco = (Endereco)atributos[5];
        }

        public override string ToString()
        {
            return $"Pessoa {this.Id}\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nNome: {this.Nome}\nData Nascimento: {this.DataNasc.ToShortDateString()}\nEmail: {this.Email}\nRG: {this.RG}\nCPF: {this.CPF.Insert(3, ".").Insert(7, ".").Insert(11, "-")}\nEndereço: {Endereco}\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=";
        }

        //public override bool Equals(object pessoaFisica)
        //{
        //    return this.CPF.Equals(((PessoaFisica)pessoaFisica).CPF);
        //}
    }
}
