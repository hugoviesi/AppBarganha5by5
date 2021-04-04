using AppBarganhaWEB.Utils;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

// TODO: comentar funcionamento

namespace AppBarganhaWEB.Middlewares
{
    public class LoginMiddleware
    {
        private readonly RequestDelegate _next;

        private static List<string> PAGINAS_DESLOGADAS = new List<string>() { "/Usuario", "/Usuario/Cadastrar", "/Login", "/Login/Logar", "/ValidadorDocumento" };

        public LoginMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (!PAGINAS_DESLOGADAS.Contains(context.Request.Path) && !UsuarioLogadoSessao.Logado(context))
            {
                context.Response.Redirect("/Login");
            }
            else
            {
                await _next.Invoke(context);
            }

        }
    }
}