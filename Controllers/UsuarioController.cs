using AppBarganhaWEB.Models;
using AppBarganhaWEB.Services;
using AppBarganhaWEB.Utils;
using AppBarganhaWEB.ViewsObject;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AppBarganhaWEB.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuarioService _usuarioService;
        private readonly IWebHostEnvironment _hostEnvironment;

        public UsuarioController(UsuarioService usuarioService, IWebHostEnvironment hostEnviroment)
        {
            _usuarioService = usuarioService;
            _hostEnvironment = hostEnviroment;
        }

        public IActionResult Index()
        {
            ViewBag.TipoUsuario = new List<string>() { "Pessoa Física", "Pessoa Jurídica" };

            ViewBag.Interesses = ListaCategoria.Lista();

            return View("Index", new UsuarioVO());
        }

        public IActionResult Perfil()
        {
            ViewBag.TipoUsuario = new List<string>() { "Pessoa Física", "Pessoa Jurídica" };

            ViewBag.Interesses = ListaCategoria.Lista();

            var usuarioLogado = UsuarioLogadoSessao.Recuperar(HttpContext);

            var usuario = _usuarioService.GetUsuario(usuarioLogado.Id, usuarioLogado.Tipo);

            if (usuario is PessoaFisica)
            {

                var pessoaFisica = usuario as PessoaFisica;

                var usuarioVO = new UsuarioVO
                {
                    id = usuarioLogado.Id,
                    TipoUsuario = "Pessoa Física",
                    Nome = pessoaFisica.Nome,
                    Documento = pessoaFisica.Cpf,
                    Login = pessoaFisica.Login,
                    Endereco = pessoaFisica.Endereco,
                    InteressesSelecionados = pessoaFisica.Interesses.Select(cat => (int)cat).ToList()
                };

                return View("Index", usuarioVO);

            }
            else
            {

                var pessoaJurudica = usuario as PessoaJuridica;

                var usuarioVO = new UsuarioVO
                {
                    id = usuarioLogado.Id,
                    TipoUsuario = "Pessoa Jurídica",
                    NomeFantasia = pessoaJurudica.NomeFantasia,
                    RazaoSocial = pessoaJurudica.RazaoSocial,
                    Documento = pessoaJurudica.Cnpj,
                    Login = pessoaJurudica.Login,
                    Endereco = pessoaJurudica.Endereco,
                    InteressesSelecionados = pessoaJurudica.Interesses.Select(cat => (int)cat).ToList()
                };

                return View("Index", usuarioVO);
            };

        }

        public IActionResult CadastrarOuAtualizar(UsuarioVO usuarioVO)
        {
            var usuario = _usuarioService.CriarOrAtualizar(usuarioVO);

            if(usuarioVO.id != null)
            {
                UsuarioLogadoSessao.Armazenar(HttpContext, usuario);
                return RedirectToAction("Index", "Home");
            } else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        private async void InserirFoto(UsuarioVO usuarioVO)
        {
            string wwwwRootPath = _hostEnvironment.WebRootPath;
            string nomeArquivo = Path.GetFileNameWithoutExtension(usuarioVO.Foto.FileName);
            string extensao = Path.GetExtension(usuarioVO.Foto.FileName);
            usuarioVO.CaminhoFoto = nomeArquivo + DateTime.Now.ToString("yymmssffff") + extensao;
            string path = Path.Combine(wwwwRootPath + "/img/", usuarioVO.CaminhoFoto);
            using var fs = new FileStream(path, FileMode.Create);
            await usuarioVO.Foto.CopyToAsync(fs);
        }
    }
}