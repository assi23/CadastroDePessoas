using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
    class OperacoesPessoaFisica : OperacaoPessoa
    {
        public OperacoesPessoaFisica()
        {
            lista.Add(new PessoaFisica());
        }
    }
}
