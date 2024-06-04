using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM3_SEMESTRE.Model
{
    internal class UsuarioModel
    {

        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public int Status { get; set; }

        public UsuarioModel(int idUsuario, string nomeUsuario, string emailUsuario, string senhaUsuario, int status)
        {
            IdUsuario = idUsuario;
            NomeUsuario = nomeUsuario;
            EmailUsuario = emailUsuario;
            SenhaUsuario = senhaUsuario;
            Status = status;
        }


    }
}
