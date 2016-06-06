using System;

namespace Quiron.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        public int ItensTotal { get; set; }

        public int ItensPorPagina { get; set; }

        public int PaginaAtual { get; set; }

        public int TotalPagina
        {
            get { return (int) Math.Ceiling((decimal) ItensTotal/ItensPorPagina); }
            
        }

    }
}