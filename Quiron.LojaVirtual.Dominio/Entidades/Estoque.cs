using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Entidades
{
    public class Estoque
    {
        [Key]
        public int EstoqueId { get; set; }

        public string ProdutoCodigo { get; set; }
        public int Quantidade { get; set; }

        public DateTime DataAtualizacao { get; set; }
    }
}
