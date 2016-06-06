using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtual.Web.Models
{
    public class ProdutosViewModel
    {   

        public List<Produto> Produtos { get; set; }
      
        //public Paginacao Paginacao { get; set; }

        public string CategoriaAtual { get; set; }
    }
}