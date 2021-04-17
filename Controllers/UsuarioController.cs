using AppBarganhaWEB.Exceptions;
using AppBarganhaWEB.Models;
using AppBarganhaWEB.Services;
using AppBarganhaWEB.Utils;
using AppBarganhaWEB.ViewsObject;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppBarganhaWEB.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuarioService _usuarioService;


        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
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
                    FotoDocumento = pessoaJurudica.FotoDocumento,
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
            try
            {

                var usuario = _usuarioService.CriarOuAtualizar(usuarioVO);
                if (usuarioVO.id != null)
                {
                    UsuarioLogadoSessao.Armazenar(HttpContext, usuario);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Index", "Login");
                }

            }
            catch (ValidacaoException e)
            {
                TempData["CadastrarOuAtualizar_Usuario_MensagemErro"] = e.Message;
                return RedirectToAction("Index");

            }
        }

        public IActionResult Desativar()
        {
            var usuarioLogado = UsuarioLogadoSessao.Recuperar(HttpContext);

            var usuario = _usuarioService.GetUsuario(usuarioLogado.Id, usuarioLogado.Tipo);

            _usuarioService.AtualizarStatus(usuario.Id, false);

            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Login");
        }
    }
}