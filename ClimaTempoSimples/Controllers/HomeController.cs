using ClimaTempoSimples.Models;
using ClimaTempoSimples.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClimaTempoSimples.Controllers
{
    public class HomeController : Controller
    {
        readonly IClimaRepository climaRepositorio;
        readonly ICidadeRepository cidadeRepositorio;

        public HomeController(IClimaRepository climaRepositorio, ICidadeRepository cidadeRepositorio)
        {
            this.climaRepositorio = climaRepositorio;
            this.cidadeRepositorio = cidadeRepositorio;
        }

        public ActionResult Index()
        {
            ViewBag.Cidades = new SelectList(cidadeRepositorio.ObterCidades(), "CidadeID", "Nome");
            ViewBag.CidadesQuentes = climaRepositorio.ObterCidadesQuentes();
            ViewBag.CidadesFrias = climaRepositorio.ObterCidadesFrias();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [AllowAnonymous]
        public JsonResult ObterPrevisaoDoTempo(int cidadeID)
        {            
            var previsaoTempo = climaRepositorio.ObterClima(cidadeID);                           
            return Json(new { success = true , data = previsaoTempo }, JsonRequestBehavior.AllowGet);
        }
    }
}