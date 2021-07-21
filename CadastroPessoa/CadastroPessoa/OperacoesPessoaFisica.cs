using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
    class OperacoesPessoaFisica : Crud
    {
        Validacao v;
        int idPessoaFis = 1;
        public OperacoesPessoaFisica()
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
                Console.WriteLine($"\nCadastrando {idPessoaFis}ª Pessoa: ");
                Console.Write("Digite o Nome: ");
                string nome = v.ValidaString();
                Console.Write("Digite a Data de Nascimento dd/mm/aaaa ou aaaa/mm/dd: ");
                DateTime data = v.ValidaData();
                Console.Write("Digite o Email: ");
                string email = v.ValidaString();
                Console.Write("Digite o RG: ");
                string rg = v.ValidaRGIgual(lista);
                Console.Write("Digite o CPF: ");
                string cpf = v.ValidaCPFIgual(lista);
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
                PessoaFisica model = new PessoaFisica(idPessoaFis, nome, data, email, rg, cpf, endModel);
                lista.Add(model);
                idPessoaFis++;

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
