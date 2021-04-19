using AppBarganhaWEB.Exceptions;
using AppBarganhaWEB.Models;
using AppBarganhaWEB.Services;
using AppBarganhaWEB.ViewsObject;
using Microsoft.AspNetCore.Mvc;

namespace AppBarganhaWEB.Controllers
{
    public class AvaliacaoController : Controller
    {
        private readonly OfertaService _ofertaService;
        private readonly AnuncioService _anuncioService;
        private readonly UsuarioService _usuarioService;

        public AvaliacaoController(OfertaService ofertaService, AnuncioService anuncioService, UsuarioService usuarioService)
        {
            _ofertaService = ofertaService;
            _anuncioService = anuncioService;
            _usuarioService = usuarioService;
        }

        public IActionResult Index()
        {
            var ofertaId = HttpContext.Request.Query["idOferta"];
            var modo = HttpContext.Request.Query["modo"];

            var oferta = _ofertaService.Get(ofertaId);
            var anuncio = _anuncioService.Get(oferta.IdAnuncio);

            Usuario usuario = null;
            if (modo == "OFERTANTE")
            {
                usuario = _usuarioService.Get(oferta.IdUsuarioOfertante);
            }
            else if (modo == "ANUNCIANTE")
            {
                usuario = _usuarioService.Get(anuncio.IdUsuario);
            }
            else
            {
                throw new ValidacaoException("modo desconhecido");
            };

            var avaliacaoVO = new AvaliacaoVO
            {
                Oferta = oferta,
                Anuncio = anuncio,
                Usuario = usuario,
                Modo = modo
            };

            return View(avaliacaoVO);
        }

        public IActionResult Avaliar(AvaliarVO avaliarVO)
        {
            var oferta = _ofertaService.Get(avaliarVO.Oferta.Id);

            if (avaliarVO.Modo == "ANUNCIANTE")
            {
                oferta.AnuncianteAvaliado = true;
                _ofertaService.Update(oferta.Id, oferta);
            }
            else if (avaliarVO.Modo == "OFERTANTE") 
            {                        
                oferta.OfertanteAvaliado = true;
                _ofertaService.Update(oferta.Id, oferta);
            }

            int pontos = 0;

            if (avaliarVO.Pontos == "Positivo")
            {
                pontos = 2;
            }
            else if (avaliarVO.Pontos == "Neutro")
            {
                pontos = 1;
            }
            else
            {
                pontos = -2;
            }

            _usuarioService.AtualizarPontuacao(avaliarVO.Usuario.Id, pontos);

            return RedirectToAction("Index", "Home");
        }
    }


}
