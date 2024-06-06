using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM3_SEMESTRE.Model
{
    internal class FornecedorModel
    {
        public int IdFornecedor { get; set; }
        public string NomeFornecedor { get; set; }
        public string Cnpj { get; set; } 
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public int Status { get; set; }
        public string Telefone { get; set; }
        public FornecedorModel (string nomeFornecedor, string cnpj, string logradouro, string numero, string cidade, string endereco, int status, string telefone)

        {
            NomeFornecedor = nomeFornecedor;
            Cnpj = cnpj;
            Logradouro = logradouro;
            Numero = numero;
            Cidade = cidade;
            Endereco = endereco;
            Status = status;
            Telefone = telefone;


        }




    }
}
