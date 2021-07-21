using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace CadastroPessoa
{
    public delegate void Operacoes();
    public class Crud
    {
            protected List<BaseModel> lista = new List<BaseModel>();
            protected Operacoes operacaoCriar;
            protected Operacoes operacaoListar;
            protected Operacoes operacaoEditar;
            protected Operacoes operacaoDeletar;

        public void Criar()
        {
            operacaoCriar();
        }

        public void Listar()
        {
            operacaoListar();
        }

        public void Editar()
        {
            operacaoEditar();
        }

        public void Deletar()
        {
            operacaoDeletar();
        }
    }
}
