using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {

        private ProdutosRepositorio _repositorio;


        //[Route("produtos/obter")]
        public ActionResult Index()
        {
            _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos.Take(3);



            return View(produtos);
        }
	}
}