using FinalProject.Models;
using FinalProject.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers {
    public class UsuarioController : Controller {
        private UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_USUARIO = "_USUARIO";
        [HttpGet]
        public IActionResult Login () {
            ViewData["NomeView"] = "Login";

            return View ();
        }

        [HttpPost]
        public IActionResult Login (IFormCollection form) {
            ViewData["User"] = HttpContext.Session.GetString (SESSION_USUARIO);
            var user = (string) ViewData["User"]; 

            var usuario = form["email"];
            var senha = form["senha"];

            var p = usuarioRepositorio.ObterPor (usuario);

            if (p != null && usuario.Equals ("admin@agoravai.com") && p.Senha.Equals ("admin")) {
                HttpContext.Session.SetString (SESSION_EMAIL, usuario);                
                HttpContext.Session.SetString (SESSION_USUARIO, p.Nome);
                return RedirectToAction ("Index", "Admin");
            }
            if (p != null && p.Email.Equals (usuario) && p.Senha.Equals (senha)) {
                HttpContext.Session.SetString (SESSION_EMAIL, usuario);
                HttpContext.Session.SetString (SESSION_USUARIO, p.Nome);
                return RedirectToAction ("Index", "Depoimento");

            } else {
                return View ("_Falha");
            }
        }

        public IActionResult Logout () {
            HttpContext.Session.Remove (SESSION_EMAIL);
            HttpContext.Session.Remove (SESSION_USUARIO);
            HttpContext.Session.Clear ();

            return RedirectToAction ("Index", "Home");
        }
        [HttpGet]
        public IActionResult Listar() {
            ViewData["User"] = HttpContext.Session.GetString (SESSION_USUARIO);
            var user = (string) ViewData["User"];
            ViewData["NomeView"] = "Depoimento";
            
            DepoimentoRepositorio depoimentoRepositorio = new DepoimentoRepositorio ();
            ViewData["depoimentos"] = depoimentoRepositorio.ListarDepoimentos();
            return View ();
        }
    }
}