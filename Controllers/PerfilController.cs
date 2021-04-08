using AppBarganhaWEB.Services;
using AppBarganhaWEB.Utils;
using Microsoft.AspNetCore.Mvc;

namespace AppBarganhaWEB.Controllers
{
    public class PerfilController : Controller
    {
        private readonly UsuarioService _usuarioService;

        public PerfilController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public IActionResult Index()
        {
            var usuarioLogado = UsuarioLogadoSessao.Recuperar(HttpContext);

            var usuario = _usuarioService.GetUsuario(usuarioLogado.Id, usuarioLogado.Tipo);



            return View();
        }
    }
}
