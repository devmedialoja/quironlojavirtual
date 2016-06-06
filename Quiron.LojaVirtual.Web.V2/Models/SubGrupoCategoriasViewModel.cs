using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtual.Web.V2.Models
{
    public class SubGrupoCategoriasViewModel
    {
        public SubGrupo SubGrupo { get; set; }

        public IEnumerable<Categoria> Categorias { get; set; }
    }
}