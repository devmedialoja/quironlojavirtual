using System.Collections.Generic;
using Quiron.LojaVirtual.Dominio.Dto;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtual.Web.Models
{
    public class ModalidadeSubGrupoViewModel
    {
        public Modalidade Modalidade { get; set; }
        public IEnumerable<SubGrupoDto> SubGrupos { get; set; }

    }
}