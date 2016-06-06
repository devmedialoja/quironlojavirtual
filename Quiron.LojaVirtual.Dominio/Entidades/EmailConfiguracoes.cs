using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quiron.LojaVirtual.Dominio.Entidades
{
    public class EmailConfiguracoes
    {
        public bool UsarSsl = false;
        public string ServidorSmtp = "smtp.quiron.com.br";
        public int ServidorPorta = 587;
        public string Usuario = "quiron";
        public bool EscreverArquivo = false;
        public string PastaArquivo = @"c:\envioemail";
        public string De = "quiron@quiron.com.br";
        public string Para = "pedido@quiron.com.br";
    }
}
