using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Quiron.LojaVirtual.Dominio.Entidades;
using Quiron.LojaVirtual.Dominio.Repositorio;

namespace Quiron.LojaVirtual.Web.Areas.Administrativo.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutosRepositorio _repositorio;

        public ActionResult Index()
        {
            _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos;
            return View(produtos);
        }


        public ViewResult Alterar(int produtoId)
        {
            _repositorio = new ProdutosRepositorio();
            Produto produto = _repositorio.Produtos
                .FirstOrDefault(p => p.ProdutoId == produtoId);

            return View(produto);
        }



        [HttpPost]
        public ActionResult Alterar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _repositorio = new ProdutosRepositorio();
                _repositorio.Salvar(produto);

                TempData["mensagem"] = string.Format("{0} foi salvo com sucesso", produto.Nome);

                return RedirectToAction("Index");

            }
            return View(produto);
        }

        public ViewResult NovoProduto()
        {
            return View("Alterar", new Produto());
        }


        //[HttpPost]
        //public ActionResult Excluir(int produtoId)
        //{
        //    _repositorio = new ProdutosRepositorio();

        //    Produto prod = _repositorio.Excluir(produtoId);

        //    if (prod != null)
        //    {
        //        TempData["mensagem"] = string.Format("{0} excluído com sucesso", prod.Nome);
        //    }

        //    return RedirectToAction("Index");
        //}



        [HttpPost]
        public JsonResult Excluir(int produtoId)
        {

            string mensagem = string.Empty;
            _repositorio = new ProdutosRepositorio();

            Produto prod = _repositorio.Excluir(produtoId);

            if (prod != null)
            {
                mensagem = string.Format("{0} excluído com sucesso", prod.Nome);
            }

            return Json(mensagem, JsonRequestBehavior.AllowGet);
        }
    }
}