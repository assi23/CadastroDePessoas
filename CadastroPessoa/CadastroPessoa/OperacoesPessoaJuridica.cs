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
        Validacao v;
        int idPessoaJur = 1;
        public OperacoesPessoaJuridica()
        {
            v = new Validacao();
            this.operacaoCriar = Cadastro;
            this.operacaoListar = MostraLista;
            this.operacaoEditar = EditaCadastro;
            this.operacaoDeletar = DeletaCadastro;
        }

        private void Cadastro()
        {
            string resp = string.Empty;
            do
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
                string rua = v.ValidaString();
                Console.Write("Digite o número: ");
                int num = v.ValidaInteiro();
                Console.Write("Digite o complemento: ");
                string comp = v.ValidaString();
                Console.Write("Digite o Bairro: ");
                string bairro = v.ValidaString();
                Console.Write("Digite a Cidade: ");
                string cidade = v.ValidaString();

                Endereco endModel = new Endereco(rua, num, comp, bairro, cidade);
                PessoaJuridica model = new PessoaJuridica(idPessoaJur, nome, data, email, ie, cnpj, endModel);
                lista.Add(model);
                idPessoaJur++;

                Console.Write("Deseja cadastrar mais uma Pessoa? [S/N]: ");
                resp = v.ValidaConfirmacao();
            } while (resp.Equals("s"));
        }
        private void MostraLista()
        {
            int var;
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
