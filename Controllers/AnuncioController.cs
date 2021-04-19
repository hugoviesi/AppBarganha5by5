using AppBarganhaWEB.Services;
using AppBarganhaWEB.Models;
using AppBarganhaWEB.Utils;
using AppBarganhaWEB.ViewsObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Collections.Generic;
using AppBarganhaWEB.Exceptions;

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
            try
            {
                var usuarioLogado = UsuarioLogadoSessao.Recuperar(HttpContext);

                if (anuncioVO.Nome == null)
                {
                    throw new ValidacaoException("Anuncio sem nome.");
                }

                if (anuncioVO.Descricao == null)
                {
                    throw new ValidacaoException("Anuncio sem descrição.");
                }

                if (anuncioVO.ArquivoFoto == null)
                {
                    throw new ValidacaoException("Anuncio sem foto.");
                }

                if (anuncioVO.InteressesSelecionados == null)
                {
                    throw new ValidacaoException("Anuncio precisa ter pelo menos uma categoria.");
                }

                if (anuncioVO.Valor < (decimal)0.10)
                {
                    throw new ValidacaoException("Valor menor que o mínimo de 10 centavos.");
                }

                var anuncio = new Anuncio
                {
                    Nome = anuncioVO.Nome,
                    Descricao = anuncioVO.Descricao,
                    Categorias = anuncioVO.GetCategorias(),
                    Valor = anuncioVO.Valor,
                    Ativo = true,
                    Foto = UploadFoto(anuncioVO.ArquivoFoto),
                    DataPublicacao = DateTime.Now,
                    DataFinal = DateTime.Now.AddDays(30),
                    IdUsuario = usuarioLogado.Id,
                    Status = StatusAnuncio.ABERTO
                };

                _anuncioService.Create(anuncio);

                CriarNotificacao(anuncio.Categorias, usuarioLogado.Id);

                return RedirectToAction("Index", "Home");

            }
            catch (ValidacaoException e)
            {
                TempData["Cadastrar_Anuncio_MensagemErro"] = e.Message;
                return RedirectToAction("Index");
            }

        }

        private string UploadFoto(IFormFile arquivoFoto)
        {
            return Upload.UploadArquivo(_hostEnvironment, arquivoFoto, "img");
        }

        private void CriarNotificacao(List<Categoria> interesses, string idUsuarioLogado)
        {
            var listaUsuarios = _usuarioService.GetByInteresses(interesses, idUsuarioLogado);
            foreach (var usuario in listaUsuarios)
            {
                _usuarioService.AtualizarNotificacoes(usuario);
            }
        }

        public IActionResult Desativar()
        {
            var anuncioId = HttpContext.Request.Query["idAnuncio"];

            var anuncio = _anuncioService.Get(anuncioId);

            anuncio.Ativo = false;

            _anuncioService.Update(anuncio.Id, anuncio);

            return RedirectToAction("Index", "Home");
        }
    }
}
