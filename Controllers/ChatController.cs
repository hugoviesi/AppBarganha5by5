using AppBarganhaWEB.Services;
using AppBarganhaWEB.Utils;
using AppBarganhaWEB.ViewsObject;
using Microsoft.AspNetCore.Mvc;

namespace AppBarganhaWEB.Controllers
{
    public class ChatController : Controller
    {
        private readonly UsuarioService _usuarioService;

        public ChatController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public IActionResult Index()
        {
            var idOferta = HttpContext.Request.Query["idOferta"];

            var usuarioLogado = UsuarioLogadoSessao.Recuperar(HttpContext);

            var usuario = _usuarioService.Get(usuarioLogado.Id);

            var chatVo = new ChatVO
            {
                idOferta = idOferta,
                Nome = usuarioLogado.Nome,
                Usuario = usuario
            };

            return View(chatVo);
        }
    }
}
