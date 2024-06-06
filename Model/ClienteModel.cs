using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM3_SEMESTRE.Model
{
    internal class ClienteModel
    {
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string Cpf { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public int Status { get; set; }
        public string Telefone { get; set; }

        public ClienteModel (string nomeCliente, string cpf, string logradouro, string numero, string cidade, string endereco, int status, string telefone)
        {

            NomeCliente = nomeCliente;
            Cpf = cpf;
            Logradouro = logradouro;
            Numero = numero;
            Cidade = cidade;
            Endereco = endereco;
            Status = status;
            Telefone = telefone;
        }



    }
}
