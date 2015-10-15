using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Quiron.LojaVirtual.Web.V2.Helpers
{
    public class ImageHelper
    {
        private static AppSettingsReader _app;

        public static string CaminhoImagem()
        {
            _app = new AppSettingsReader();
            return _app.GetValue("Imagem", typeof (String)).ToString();
        }
    }
}