using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
	class Program
	{
		static void Main(string[] args)
		{
			//Menu m = new Menu();
			//m.CriarMenu();
			PessoaFisica pessoa1 = new PessoaFisica(1, "leonardo.cascaes@hotmail.com", "5.253-78", "54454454654");
            Console.WriteLine(pessoa1);
			Console.ReadLine();
		}
	}
}
