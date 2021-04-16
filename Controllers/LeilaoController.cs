using AppBarganhaWEB.Services;
using AppBarganhaWEB.Utils;
using AppBarganhaWEB.ViewsObject;
using Microsoft.AspNetCore.Mvc;

namespace AppBarganhaWEB.Controllers
{
    public class LeilaoController : Controller
    {
        private readonly UsuarioService _usuarioService;
        private readonly AnuncioService _anuncioService;

        public LeilaoController(UsuarioService usuarioService, AnuncioService anuncioService)
        {
            _usuarioService = usuarioService;
            _anuncioService = anuncioService;
        }

        public IActionResult Index()
        {
            var usuarioLogado = UsuarioLogadoSessao.Recuperar(HttpContext);

            var usuario = _usuarioService.GetUsuario(usuarioLogado.Id, usuarioLogado.Tipo);

            _usuarioService.ZerarNotificacoes(usuario);

            var leilaoVO = new LeilaoVO
            {
                Anuncios = _anuncioService.GetPorCategoriaEmAberto(usuario.Interesses, usuarioLogado.Id)
            };

            return View(leilaoVO);
        }
    }
}

