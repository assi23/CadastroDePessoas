using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class Endereco
	{
		public string Rua { get; set; }
		public int Numero { get; set; }
		public string Complemento { get; set; }
		public string Bairro { get; set; }
		public string Cidade { get; set; }

        public Endereco(string rua, int num, string comp, string bairro, string cidade)
        {
			this.Rua = rua;
			this.Numero = num;
			this.Complemento = comp;
			this.Bairro = bairro;
			this.Cidade = cidade;
        }
        public Endereco()
        {

        }
        public Endereco(List<Object> atributos)
        {
			this.Rua = (string)atributos[0];
			this.Numero = Convert.ToInt32(atributos[1]);
			this.Complemento = (string)atributos[2];
			this.Bairro = (string)atributos[3];
			this.Cidade = (string)atributos[4];
		}

		public override string ToString()
		{
			return $"Rua:{this.Rua} \nNúmero:{this.Numero} \nComplemento:{this.Complemento} \nBairro:{this.Bairro} \nCidade:{this.Cidade}";
		}
	}
}