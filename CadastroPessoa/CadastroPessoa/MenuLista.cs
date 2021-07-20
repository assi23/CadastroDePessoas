using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
    class MenuLista
    {
        public static void MontaMenuLista()
        {
            Console.WriteLine("\t\t\t\t ________________________________________________ ");
            Console.WriteLine("\t\t\t\t|___________________Menu Da Lista________________|");
            Console.WriteLine("\t\t\t\t|               [1] - Editar Por Id              |");
            Console.WriteLine("\t\t\t\t|               [2] - Deletar Por Id             |");
            Console.WriteLine("\t\t\t\t|               [3] - Procurar Por Id            |");
            Console.WriteLine("\t\t\t\t|               [4] - Procurar Por Nome          |");
            Console.WriteLine("\t\t\t\t|               [3] - Mostrar Lista Novamente    |");
            Console.WriteLine("\t\t\t\t|               [0] - Voltar Ao Menu             |");
            Console.WriteLine("\t\t\t\t|________________________________________________|");
        }
        public static void EscolhaPessoaFisica()
        {
            Validacao v = new Validacao();
            Console.Write("Opção: ");
            int resp = v.ValidaInteiro();
        }
    }
}
