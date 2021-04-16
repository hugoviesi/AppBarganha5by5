using AppBarganhaWEB.Utils;
using AppBarganhaWEB.ViewsObject;
using Microsoft.AspNetCore.Mvc;

namespace AppBarganhaWEB.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            var idOferta = HttpContext.Request.Query["idOferta"];

            var usuarioLogado = UsuarioLogadoSessao.Recuperar(HttpContext);

            var chatVo = new ChatVO
            {
                idOferta = idOferta,
                Nome = usuarioLogado.Nome
            };

            return View(chatVo);
        }
    }
}
