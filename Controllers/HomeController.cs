﻿using AppBarganhaWEB.Services;
using AppBarganhaWEB.Utils;
using AppBarganhaWEB.ViewsObject;
using Microsoft.AspNetCore.Mvc;

namespace AppBarganhaWEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly UsuarioService _usuarioService;
        private readonly AnuncioService _anuncioService;

        public HomeController(AnuncioService anuncioService, UsuarioService usuarioService)
        {
            _anuncioService = anuncioService;
            _usuarioService = usuarioService;
        }

        public IActionResult Index()
        {
            var usuarioLogado = UsuarioLogadoSessao.Recuperar(HttpContext);

            var homeVO = new HomeVO
            {
                UsuarioLogado = _usuarioService.Get(usuarioLogado.Id),
                Anuncios = _anuncioService.GetForUser(usuarioLogado.Id)
            };

            return View(homeVO);
        }

        public IActionResult Chat()
        {
            return View();
        }
    }
}
