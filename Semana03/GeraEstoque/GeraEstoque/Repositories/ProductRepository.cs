
using GeraEstoque.Models;

namespace GeraEstoque.Repositories
{
    public class ProductRepository
    {

        public IList<Product> Produtos { get; set; }
        //construtor
        public ProductRepository()
        {
            Produtos = new List<Product>();
        }
    }
}
