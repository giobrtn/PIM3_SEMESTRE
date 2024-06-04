using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM3_SEMESTRE.Model
{
    internal class OrdemProducaoModel
    {
        public int IdProducao { get; set; }
        public DateTime Datainicio { get; set; }
        public DateTime DataPrevista { get; set; }
        public string Cnpj { get; set; }
        public string EmailFornecedor { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public int Status { get; set; }

        public OrdemProducaoModel (int idProducao, DateTime dataInicio, DateTime dataPrevista, string cnpj, string emailFornecedor, string logradouro, string numero, string cidade, string endereco, int status)
        {
            IdProducao = idProducao;
            Datainicio = dataInicio;
            DataPrevista = dataPrevista;
            Cnpj = cnpj;
            EmailFornecedor = emailFornecedor;
            Logradouro = logradouro;
            Numero = numero;
            Cidade = cidade;
            Endereco = endereco;
            Status = status;

        }


    }
}
