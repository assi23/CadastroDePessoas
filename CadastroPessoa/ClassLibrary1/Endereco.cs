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

        public Endereco(string cidade, string bairro, string rua, int num, string comp)
        {
			this.Rua = rua;
			this.Numero = num;
			this.Complemento = comp;
			this.Bairro = bairro;
			this.Cidade = cidade;
        }

		public override string ToString()
		{
			return $"Cidade:{this.Cidade}\nBairro:{this.Bairro}\nRua:{this.Rua}\nNúmero:{this.Numero}\nComplemento:{this.Complemento} ";
		}
	}
}