﻿using AppBarganhaWEB.Services;
using AppBarganhaWEB.Models;
using AppBarganhaWEB.Utils;
using AppBarganhaWEB.ViewsObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AppBarganhaWEB.Controllers
{
    public class AnuncioController : Controller
    {
        private readonly AnuncioService _anuncioService;

        public AnuncioController(AnuncioService anuncioService)
        {
            _anuncioService = anuncioService;
        }

        public IActionResult Index()
        {
            ViewBag.Interesses = ListaCategoria.Lista();

            return View();
        }

        public IActionResult Cadastrar(AnuncioVO anuncioVO, IFormFile pic)
        {
            var usuarioLogado = UsuarioLogadoSessao.Recuperar(HttpContext);

            var path = Upload.UploadFoto(pic);

            var anuncio = new Anuncio
            {
                Nome = anuncioVO.Nome,
                Descricao = anuncioVO.Descricao,
                Categorias = anuncioVO.GetCategorias(),
                Valor = anuncioVO.Valor,
                DataPublicacao = DateTime.Now,
                IdUsuario = usuarioLogado.Id,
                FileName = path,
                Status = StatusAnuncio.ABERTO
            };
            
            _anuncioService.Create(anuncio);

            return RedirectToAction("Index", "Home");
        }
    }
}
