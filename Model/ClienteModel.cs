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
        public string EmailCliente { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public int Status { get; set; }


        public ClienteModel (string nomeCliente, string cpf, string emailCliente, string logradouro, string numero, string cidade, string endereco, int status)
        {

            NomeCliente = nomeCliente;
            Cpf = cpf;
            EmailCliente = emailCliente;
            Logradouro = logradouro;
            Numero = numero;
            Cidade = cidade;
            Endereco = endereco;
            Status = status;
            
        }



    }
}
