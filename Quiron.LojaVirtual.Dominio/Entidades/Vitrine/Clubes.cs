using System.ComponentModel.DataAnnotations;

namespace Quiron.LojaVirtual.Dominio.Entidades.Vitrine
{
    public abstract class Clubes
    {
        [Key]
        public string LinhaCodigo { get; set; }

        public string LinhaDescricao { get; set; }
    }
}
