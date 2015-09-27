using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;
using Quiron.LojaVirtual.Web.V2.Models;

namespace Quiron.LojaVirtual.Web.V2.Controllers
{
    public class NavController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult TesteMetedoVitrine()
        {
            ProdutoModeloRepositorio repositorio = new ProdutoModeloRepositorio();

           

            var produtos =  repositorio.ObterProdutosVitrine(modalidade:"0051");

            return Json(produtos, JsonRequestBehavior.AllowGet);
        }


        [Route("nav/{id}/{marca}")]
        public ActionResult ObterProdutosPorMarcas(string id)
        {
            ProdutoModeloRepositorio repositorio = new ProdutoModeloRepositorio();

            //repositorio.ObterProdutosVitrine(linha: id, subcategoria: id);

           // var model = new ProdutosViewModel {Produtos = null};

            return View();
        }
    }
}