using AppBarganhaWEB.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppBarganhaWEB.Controllers
{
    public class ValidadorDocumentoController : Controller
    {
        public IActionResult Index()
        {
            var documento = HttpContext.Request.Query["documento"];
            if (!Documento.EhValido(documento))
            {
                return BadRequest();
            }
            else
            {
                return Ok();
            }
        }
    }
}
