using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM3_SEMESTRE.Model
{
    internal class ProdutoModel
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string Categoria { get; set; }
        public int QuantidadeEstoque { get; set; }
        public double Preco { get; set; }
        public double PrecoFinal { get; set; }
        public int Status { get; set; }


        public ProdutoModel (int idProduto, string nomeProduto, string categoria, int quantidadeEstoque, double preco, double precoFinal, int status)
        {

            IdProduto = idProduto;
            NomeProduto = nomeProduto;
            Categoria = categoria;
            QuantidadeEstoque = quantidadeEstoque;
            Preco = preco;
            PrecoFinal = precoFinal;
            Status = status;

        }
        
        
        
        
        
        
        
        







    }
}
