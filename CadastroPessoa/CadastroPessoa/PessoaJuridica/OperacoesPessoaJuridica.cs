using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
    public class OperacoesPessoaJuridica : OperacaoPessoa
    {
        public OperacoesPessoaJuridica()
        {
            lista.Add(new PessoaJuridica());
        }
    }
}
