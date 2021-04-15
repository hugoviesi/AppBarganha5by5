﻿using AppBarganhaWEB.Services;
using AppBarganhaWEB.Models;
using AppBarganhaWEB.Utils;
using AppBarganhaWEB.ViewsObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace AppBarganhaWEB.Controllers
{
    public class AnuncioController : Controller
    {
        private readonly AnuncioService _anuncioService;
        private readonly UsuarioService _usuarioService;
        private readonly IWebHostEnvironment _hostEnvironment;

        public AnuncioController(AnuncioService anuncioService, IWebHostEnvironment hostEnvironment, UsuarioService usuarioService)
        {
            _anuncioService = anuncioService;
            _hostEnvironment = hostEnvironment;
            _usuarioService = usuarioService;
        }

        public IActionResult Index()
        {
            ViewBag.Interesses = ListaCategoria.Lista();

            var usuarioLogado = UsuarioLogadoSessao.Recuperar(HttpContext);

            var usuario = _usuarioService.Get(usuarioLogado.Id);

            if (_anuncioService.QtdAnunciosUsuario(usuarioLogado.Id) >= usuario.QtdAnuncios)
            {
                return RedirectToAction("Index", "Pacote");
            }

            return View();
        }

        public IActionResult Cadastrar(AnuncioVO anuncioVO, IFormFile pic)
        {

            var usuarioLogado = UsuarioLogadoSessao.Recuperar(HttpContext);

            var anuncio = new Anuncio
            {
                Nome = anuncioVO.Nome,
                Descricao = anuncioVO.Descricao,
                Categorias = anuncioVO.GetCategorias(),
                Valor = anuncioVO.Valor,
                Foto = UploadFoto(anuncioVO.ArquivoFoto),
                DataPublicacao = DateTime.Now,
                IdUsuario = usuarioLogado.Id,
                Status = StatusAnuncio.ABERTO
            };
            
            _anuncioService.Create(anuncio);

            return RedirectToAction("Index", "Home");
        }

        private string UploadFoto(IFormFile arquivoFoto)
        {
            return Upload.UploadArquivo(_hostEnvironment, arquivoFoto, "img");
        }
    }
}
