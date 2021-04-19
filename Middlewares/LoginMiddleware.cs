using AppBarganhaWEB.Utils;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

/*
    Não permite o usuário navegar em páginas que exige estar logado na sessão 
*/

namespace AppBarganhaWEB.Middlewares
{
    public class LoginMiddleware
    {
        private readonly RequestDelegate _next; //responsável por trabalhar com a chamada do próximo middleware

        private static List<string> PAGINAS_DESLOGADAS = new List<string>() { "/Usuario", "/Usuario/CadastrarOuAtualizar", "/Login", "/Login/Logar", "/ValidadorDocumento", "/Login/SobreNos", "/Login/Contato" };
        //páginas que o usuário é permitido navegar sem estar logado na sessão
        public LoginMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (!PAGINAS_DESLOGADAS.Contains(context.Request.Path) && !UsuarioLogadoSessao.Logado(context))
            {
                context.Response.Redirect("/Login");
            }
            else
            {
                await _next.Invoke(context); //chamar o próximo middleware
            }
        }
    }
}