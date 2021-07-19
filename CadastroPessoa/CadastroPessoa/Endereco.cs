using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
	class Endereco
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

		public override string ToString()
		{
			return $"Rua:{this.Rua} \nNúmero:{this.Numero} \nComplemento:{this.Complemento} \nBairro:{this.Bairro} \nCidade:{this.Cidade}";
		}
	}
}
