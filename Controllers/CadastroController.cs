using System;
using FinalProject.Models;
using FinalProject.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class CadastroController : Controller
    {
        private UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Cadastro";
            return View();
        }
        
        public IActionResult Cadastrar(IFormCollection form)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = form["nome"];        
            usuario.Email = form["email"];
            usuario.Senha = form["senha"];
            usuario.DataDeNascimento = DateTime.Parse(form["dataNascimento"]);

            if (usuario != null)
            {
                usuarioRepositorio.Inserir(usuario);
                ViewData["Action"] = "Cadastro";
                return View("_Sucesso");
            }else{
                return View("_Falha");
            }
        }
    }
}