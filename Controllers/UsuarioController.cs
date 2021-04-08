using AppBarganhaWEB.Models;
using AppBarganhaWEB.Services;
using AppBarganhaWEB.Utils;
using AppBarganhaWEB.ViewsObject;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

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

            return View(new UsuarioVO());
        }

        public IActionResult Cadastrar(UsuarioVO usuarioVO)
        {
            try
            {
                _usuarioService.Criar(usuarioVO);

                return RedirectToAction("Index", "Login");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Usuario");
            }
        }
    }
}