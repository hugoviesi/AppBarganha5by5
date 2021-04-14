using AppBarganhaWEB.Services;
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
        private readonly IWebHostEnvironment _hostEnvironment;

        public AnuncioController(AnuncioService anuncioService, IWebHostEnvironment hostEnvironment)
        {
            _anuncioService = anuncioService;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            ViewBag.Interesses = ListaCategoria.Lista();

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
            string wwwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(arquivoFoto.FileName);
            string extension = Path.GetExtension(arquivoFoto.FileName);
            var foto = fileName + DateTime.Now.ToString("yymmssffff") + extension;
            string path = Path.Combine(wwwwRootPath + "/img/", foto);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                arquivoFoto.CopyToAsync(fileStream);
            }
            return foto;
        }
    }
}
