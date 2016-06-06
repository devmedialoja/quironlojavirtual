using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtual.Web.Infraestrutura
{

    // IModelBinder interface define o método: BindModel
    public class CarrinhoModelBinder : IModelBinder
    {
        private const string SessionKey = "Carrinho";

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            //Obtenho o carrinho da sessão
            Carrinho carrinho = null;
            if (controllerContext.HttpContext.Session != null)
            {
                carrinho = (Carrinho)controllerContext.HttpContext.Session[SessionKey];
            }
            // Crio o carrinho se não tenho a sessao
            if (carrinho == null)
            {
                carrinho = new Carrinho();
                if (controllerContext.HttpContext.Session != null)
                {
                    controllerContext.HttpContext.Session[SessionKey] = carrinho;
                }
            }
            // Returno o carrinho
            return carrinho;
        }
    }
}
