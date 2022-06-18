
using System.Globalization;

namespace GeraEstoque.Models
{
    public class Product
    {


        //Propriedades
        public string Id { get; set; }
        public string Nome { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public double ValorCompra { get; set; }
        public double ValorVenda { get; set; }
        //Construtor padrao
        public Product()
        {
        }
        //Construtor com argumentos
        public Product(string nome, int quantidadeEmEstoque, double valorCompra, double valorVenda)
        {
            Id = Guid.NewGuid().ToString();
            Nome = nome;
            QuantidadeEmEstoque = quantidadeEmEstoque;
            ValorCompra = valorCompra;
            ValorVenda = valorVenda;
        }
        //ToString
        public override string ToString()
        {
            return string.Format("Produto: Id: {0} | Nome: {1} | Quantidaded: {2}| R$ Compra: {3:c} | R$ Venda: {4:c}",
        Id,
        Nome,
         QuantidadeEmEstoque,
        ValorCompra,
        ValorVenda
        );

        }

    }

}
