using AppBarganha.Services;
using AppBarganhaWEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppBarganhaWEB.Controllers
{
    public class HomeController : Controller
    {

        private readonly AnuncioService _anuncioService;

        public HomeController(AnuncioService anuncioService)
        {
            _anuncioService = anuncioService;
        }

        public IActionResult Index()
        {
            var usuarioLogado = Utils.UsuarioLogadoSessao.Recuperar(HttpContext);

            var homeVO = new HomeVO
            {
                UsuarioLogado = usuarioLogado,
                Anuncios = _anuncioService.GetForUser(usuarioLogado.Id)
            };

            return View(homeVO);
        }
    }
}
