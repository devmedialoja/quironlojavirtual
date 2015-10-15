using System.Collections.Generic;
using Quiron.LojaVirtual.Dominio.Entidades.Vitrine;

namespace Quiron.LojaVirtual.Web.V2.Models
{
    public class ProdutosViewModel
    {
        public List<ProdutoVitrine> Produtos { get; set; }

        public string Titulo { get; set; }
    }
}