using AppBarganhaWEB.Models;
using AppBarganhaWEB.Services;
using AppBarganhaWEB.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppBarganhaWEB.Controllers
{
    public class LoginController : Controller
    {
        private readonly UsuarioService _usuarioService;


        public LoginController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public IActionResult Index()
        {
            return View(new Login());
        }

        public IActionResult Logar(Login login)
        {
            var usuario = _usuarioService.Login(login.Apelido, login.Senha);

            if (usuario != null)
            {
                UsuarioLogadoSessao.Armazenar(HttpContext, usuario);
                return RedirectToAction("Index", "Home");
            }

            return View("Index");
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Login");
        }
    }
}
