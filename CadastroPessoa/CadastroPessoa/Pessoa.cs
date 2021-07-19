using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
	class Pessoa
	{
		public int ID{ get; set; }
		public string Nome { get; set; }
		public DateTime DataNasc { get; set; }
		public string Email { get; set; }
		public Endereco Endereco { get; set; }
	}
}
