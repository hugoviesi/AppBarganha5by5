using AppBarganhaWEB.Models;
using Microsoft.AspNetCore.Http;

namespace AppBarganhaWEB.Utils
{
    public class UsuarioLogadoSessao
    {

        public static bool Logado(HttpContext httpContext)
        {
            return Recuperar(httpContext).Id != null;
        }

        public static Models.UsuarioLogado Recuperar(HttpContext httpContext)
        {
            return new Models.UsuarioLogado
            {
                Id = httpContext.Session.GetString("id"),
                Nome = httpContext.Session.GetString("nome"),
                Tipo = (httpContext.Session.GetString("tipo") == "FISICA") ? TipoUsuario.FISICA : TipoUsuario.JURIDICA
            };
        }

        public static void Armazenar(HttpContext httpContext, Usuario usuario)
        {
            httpContext.Session.SetString("id", usuario.Id);
            if (usuario is PessoaFisica)
            {
                httpContext.Session.SetString("nome", (usuario as PessoaFisica).Nome);
                httpContext.Session.SetString("tipo", TipoUsuario.FISICA.ToString());
            }
            else
            {
                httpContext.Session.SetString("nome", (usuario as PessoaJuridica).RazaoSocial);
                httpContext.Session.SetString("tipo", TipoUsuario.JURIDICA.ToString());
            }
        }

    }
}
