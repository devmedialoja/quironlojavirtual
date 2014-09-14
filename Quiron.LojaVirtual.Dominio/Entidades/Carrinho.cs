using System.Collections.Generic;
using System.Linq;

namespace Quiron.LojaVirtual.Dominio.Entidades
{
    public class Carrinho
    {

        private readonly List<ItemCarrinho> _itensCarrinho = new List<ItemCarrinho>();
    
        
        public void AdicionarItem(Produto produto, int quantidade)
        {
            ItemCarrinho item = _itensCarrinho.FirstOrDefault(p => p.Produto.ProdutoId == produto.ProdutoId);

            if (item == null)
            {
                _itensCarrinho.Add(new ItemCarrinho
                {
                    Produto = produto,
                    Quantidade = quantidade
                });
            }
            else
            {
                item.Quantidade += quantidade;
            }
        }


        public void RemoverItem(Produto produto)
        {
            _itensCarrinho.RemoveAll(l => l.Produto.ProdutoId == produto.ProdutoId);
        }

        public decimal ObterValorTotal()
        {
            return _itensCarrinho.Sum(e => e.Produto.Preco*e.Quantidade);
        }

        public IEnumerable<ItemCarrinho> ItensCarrinhos
        {
            get { return _itensCarrinho; }
        }
    }

    public class ItemCarrinho
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
