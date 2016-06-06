using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtual.Web.V2.Models
{
    public class CategoriaSubGruposViewModel
    {
        public Categoria Categoria { get; set; }

        public IEnumerable<SubGrupo> SubGrupos { get; set; }
    }
}