using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Dto;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtual.Web.V2.Models
{
    public class DetalhesProdutoViewModel
    {
        public QuironProduto Produto { get; set; }
        public IEnumerable<Cor> Cores { get; set; }
        public IEnumerable<Tamanho> Tamanhos { get; set; }
        public BreadCrumbDto Breadcrumb { get; set; }
        public SelectList CoresList { get; set; }
        public SelectList TamanhoList { get; set; }
    }
}