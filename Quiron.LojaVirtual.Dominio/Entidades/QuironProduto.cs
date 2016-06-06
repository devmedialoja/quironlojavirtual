using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Entidades
{
     public class QuironProduto
    {
        [Key]
        public int ProdutoId { get; set; }

        public string ProdutoCodigo { get; set; }

        public string ProdutoModeloCodigo { get; set; }

        public string CorCodigo { get; set; }

        public string TamanhoCodigo { get; set; }

        public decimal Preco { get; set; }

        public string ProdutoDescricao { get; set; }

        public string ProdutoDescricaoResumida { get; set; }

        public string MarcaDescricao { get; set; }

        public string ModeloDescricao { get; set; }

        public string UnidadeVenda { get; set; }


        public string Imagem
        {
            get { return ProdutoCodigo.Substring(0,8) + ".jpg"; }

        }

       
    }
}
}
