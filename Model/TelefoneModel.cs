using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM3_SEMESTRE.Model
{
    internal class TelefoneModel
    {
        public int IdTelefone { get; set; }
        public string Ddd { get; set; }
        public string Telefone { get; set; }
        public int Status { get; set; }

        public TelefoneModel(int idTelefone, string ddd, string telefone, int status)
        {
            IdTelefone = idTelefone;
            Ddd = ddd;
            Telefone = telefone;
            Status = status;
        }



    }
}
