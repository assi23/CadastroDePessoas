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

		public override string ToString()
		{
			return $"Rua:{this.Rua} Número:{this.Numero} Complemento:{this.Complemento} Bairro:{this.Bairro} Cidade:{this.Cidade}";
		}
	}
}
