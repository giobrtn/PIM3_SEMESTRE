using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM3_SEMESTRE.Model
{
    internal class PedidoVendaModel
    {
        public int IdVenda { get; set; }
        public string Pagamento { get; set; }
        public DateTime DataVenda { get; set; }
        public double TotalVenda { get; set; }
        public int Status { get; set; }

        public PedidoVendaModel(int idVenda, string pagamento, DateTime dataVenda, double totalVenda, int status)
        {
            IdVenda = idVenda;
            Pagamento = pagamento;
            DataVenda = dataVenda;
            TotalVenda = totalVenda;
            Status = status;
        }


    }
}
