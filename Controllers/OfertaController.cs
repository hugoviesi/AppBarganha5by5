using AppBarganha.Services;
using AppBarganhaWEB.Models;
using AppBarganhaWEB.Services;
using AppBarganhaWEB.Utils;
using AppBarganhaWEB.ViewsObject;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AppBarganhaWEB.Controllers
{
    public class OfertaController : Controller
    {
        public readonly AnuncioService _anuncioService;
        public readonly OfertaService _ofertaService;

        public OfertaController(AnuncioService anuncioService, OfertaService ofertaService)
        {
            _anuncioService = anuncioService;
            _ofertaService = ofertaService;
        }

        public IActionResult Index()
        {
            var anuncioId = HttpContext.Request.Query["idAnuncio"];

            var ofertaVO = new OfertaVO
            {
                Anuncio = _anuncioService.Get(anuncioId)
            };

            return View(ofertaVO);
        }


        public IActionResult Ofertar(OfertaVO ofertaVO)
        {
            var usuarioLogado = UsuarioLogadoSessao.Recuperar(HttpContext);

            var anuncio = ofertaVO.Anuncio;

            var oferta = new Oferta()
            {
                IdUsuarioOfertante = usuarioLogado.Id,
                IdAnuncio = anuncio.Id,
                DataOferta = DateTime.Now,
                DataAtualizacao = DateTime.Now,
                Valor = ofertaVO.Valor,
                Descricao = ofertaVO.Descricao,
                Status = OfertaStatus.ABERTO
            };

            _ofertaService.Create(oferta);

            return (RedirectToAction("Index", "Leilao"));
        }

        public IActionResult OfertasPorAnuncio()
        {
            var anuncioId = HttpContext.Request.Query["idAnuncio"];

            var ofertasAnuncio = new OfertasPorAnuncioVO
            {
                Ofertas = _ofertaService.GetPorAnuncio(anuncioId),
                Anuncio = _anuncioService.Get(anuncioId)
            };

            return View(ofertasAnuncio);
        }

        public IActionResult Aceitar()
        {
            var idOferta = HttpContext.Request.Query["idOferta"];

            var ofertaAtual = _ofertaService.Get(idOferta);
            ofertaAtual.Status = OfertaStatus.ACEITO;
            ofertaAtual.DataAtualizacao = DateTime.Now;
            _ofertaService.Update(ofertaAtual.Id, ofertaAtual);

            var anuncio = _anuncioService.Get(ofertaAtual.IdAnuncio);
            anuncio.Status = StatusAnuncio.ENCERRADO;
            _anuncioService.Update(anuncio.Id, anuncio);

            return RedirectToAction("Index", "Avalicao");
        }

        public IActionResult Recusar()
        {
            var idOferta = HttpContext.Request.Query["idOferta"];
         
            var ofertaAtual = _ofertaService.Get(idOferta);
            ofertaAtual.Status = OfertaStatus.RECUSADO;
            ofertaAtual.DataAtualizacao = DateTime.Now;
            _ofertaService.Update(ofertaAtual.Id, ofertaAtual);

            return RedirectToAction("OfertasPorAnuncio", "Oferta", new { idAnuncio = ofertaAtual.IdAnuncio });
        }

    }
}
