using FinalProject.Models;
using FinalProject.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers {
    public class DepoimentoController : Controller {
        private const string SESSION_USUARIO = "_USUARIO";

        private DepoimentoRepositorio depoimentoRepositorio = new DepoimentoRepositorio ();
        [HttpGet]
        public IActionResult Index () {
            ViewData["User"] = HttpContext.Session.GetString (SESSION_USUARIO);
            var user = (string) ViewData["User"];
            ViewData["NomeView"] = "Depoimento";
            return View ();
        }

        [HttpPost]
        public IActionResult CadastrarDepoimento (IFormCollection form) {
            ViewData["User"] = HttpContext.Session.GetString (SESSION_USUARIO);
            var user = (string) ViewData["User"];
            ViewData["NomeView"] = "Depoimento";

            Depoimento depoimento = new Depoimento ();
            depoimento.NomeDeQuemComentou = form["nomeDepoimento"];
            depoimento.TextoDepoimento = form["textoDepoimento"];
            depoimento.Escolha = "Neutro";

            depoimentoRepositorio.SalvarDepoimento (depoimento);

            ViewData["Action"] = "Depoimento";
            return View ("_SucessoDep");
        }

        [HttpGet]
        public IActionResult ListarDep () {
            ViewData["User"] = HttpContext.Session.GetString (SESSION_USUARIO);
            var user = (string) ViewData["User"];
            ViewData["NomeView"] = "Depoimento";
            
            DepoimentoRepositorio depoimentoRepositorio = new DepoimentoRepositorio ();
            ViewData["depoimentos"] = depoimentoRepositorio.ListarDepoimentos ();
            return View ();
        }
        public IActionResult Aprovar () {
            ViewData["User"] = HttpContext.Session.GetString (SESSION_USUARIO);
            var user = (string) ViewData["User"];
            ViewData["NomeView"] = "Depoimento";

            Depoimento depoimento = new Depoimento ();
            depoimento.Escolha = "Aprovado";
            return View();
        }
        public IActionResult Rejeitar () {
            ViewData["User"] = HttpContext.Session.GetString (SESSION_USUARIO);
            var user = (string) ViewData["User"];
            ViewData["NomeView"] = "Depoimento";

            Depoimento depoimento = new Depoimento ();

            depoimento.Escolha = "Rejeitado";
            return View ();
        }
    }
}