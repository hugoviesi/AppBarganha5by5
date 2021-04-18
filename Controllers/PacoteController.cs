using AppBarganhaWEB.Services;
using AppBarganhaWEB.Utils;
using Microsoft.AspNetCore.Mvc;

namespace AppBarganhaWEB.Controllers
{
    public class PacoteController : Controller
    {
        private readonly UsuarioService _usuarioService;

        public PacoteController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PacoteAnuncios()
        {
            var usuarioLogado = UsuarioLogadoSessao.Recuperar(HttpContext);

            var usuario = _usuarioService.AtualizarQtdAnuncio(usuarioLogado.Id);

            return RedirectToAction("Index", "Anuncio");
        }
    }
}
