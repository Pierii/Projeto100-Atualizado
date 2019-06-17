using FinalProject.Models;
using FinalProject.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers {
    public class AdminController : Controller {
        private const string SESSION_USUARIO = "_USUARIO";

        [HttpGet]
        public IActionResult Index () {
            ViewData["User"] = HttpContext.Session.GetString(SESSION_USUARIO);
            var user = (string) ViewData["User"];
            return View ();
        }
    }
}