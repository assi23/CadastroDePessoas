using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
    public class OperacoesPessoaJuridica : Crud
    {
        ModuloLista modLista;
        Validacao v;
        int idPessoaJur = 1;
        public OperacoesPessoaJuridica()
        {
            modLista = new ModuloLista();
            v = new Validacao();
            this.operacaoCriar = Cadastro;
            this.operacaoListar = MostraLista;
            this.operacaoEditar = EditaCadastro;
            this.operacaoDeletar = DeletaCadastro;
        }

        private void Cadastro()
        {
                Console.WriteLine($"\nCadastrando {idPessoaJur}ª Pessoa: ");
                Console.Write("Digite o Nome: ");
                string nome = v.ValidaString();
                Console.Write("Digite a data de fundação dd/mm/aaaa ou aaaa/mm/dd: ");
                DateTime data = v.ValidaData();
                Console.Write("Digite o Email: ");
                string email = v.ValidaString();
                Console.Write("Digite a Inscrição Estadual (IE): ");
                string ie = v.ValidaIEIgual(lista);
                Console.Write("Digite o CNPJ: ");
                string cnpj = v.ValidaCNPJIgual(lista);
                Console.Write("Digite a Rua: ");
                string cidade = v.ValidaString();
                Console.Write("Digite o Bairro: ");
                string bairro = v.ValidaString();
                Console.Write("Digite a Cidade: ");
                string rua = v.ValidaString();
                Console.Write("Digite o número: ");
                int num = v.ValidaInteiro();
                Console.Write("Digite o complemento: ");
                string comp = v.ValidaString();

            Endereco endModel = new Endereco(cidade, bairro, rua, num, comp);
                PessoaJuridica model = new PessoaJuridica(idPessoaJur, nome, data, email, ie, cnpj, endModel);
                lista.Add(model);
                idPessoaJur++;
        }
        private void MostraLista()
        {
            modLista.CopiaLista(lista);
            modLista.Executa();
        }
        private void EditaCadastro()
        {
            int var;
        }
        private void DeletaCadastro()
        {
            int var;
        }
    }
}
