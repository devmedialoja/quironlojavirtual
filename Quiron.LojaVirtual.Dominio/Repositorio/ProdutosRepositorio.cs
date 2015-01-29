using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {

        private readonly EfDbContext _context = new EfDbContext();

        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }




        //Salvar Produto - Alterar Produto
        public void Salvar(Produto produto)
        {
            if (produto.ProdutoId == 0)
            {
                //Salvado
                _context.Produtos.Add(produto);
            }
            else
            {
                //Alteração
                Produto prod = _context.Produtos.Find(produto.ProdutoId);

                if (prod != null)
                {
                    prod.Nome = produto.Nome;
                    prod.Descricao = produto.Descricao;
                    prod.Preco = produto.Preco;
                    prod.Categoria = produto.Categoria;
                }

            }

            _context.SaveChanges();
        }


        //Excluir

        public Produto Excluir(int produtoId)
        {

            Produto prod = _context.Produtos.Find(produtoId);

            if (prod != null)
            {
                _context.Produtos.Remove(prod);
              // _context.SaveChanges();
            }

            return prod;
        }
    }
}
