using System.Globalization;

namespace GeraEstoque
{
    class Produtos
    {
        
        //Propriedades
        public string Id { get; set; }
        public string Nome { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public double ValorCompra { get; set; }
        public double ValorVenda { get; set; }

        //Construtor padrao
        public Produtos()
        {
        }
        //Construtor com argumentos
        public Produtos(string nome, int quantidadeEmEstoque, double valorCompra, double valorVenda)
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
            return Id
                 + Nome
                + " , Nome:"
                + QuantidadeEmEstoque
                + " unidades ,"
                + ValorCompra.ToString("F2", CultureInfo.InvariantCulture)
                + " R$ Compra:"
                + ValorVenda.ToString("F2", CultureInfo.InvariantCulture)
                + "R$ Venda:";

        }
    }
}
