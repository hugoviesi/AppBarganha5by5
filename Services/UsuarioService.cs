using AppBarganha.Services;
using AppBarganhaWEB.Models;
using AppBarganhaWEB.Utils;
using System;

namespace AppBarganhaWEB.Services
{
    public class UsuarioService
    {
        private readonly PessoaFisicaService _pessoaFisicaService;
        private readonly PessoaJuridicaService _pessoaJuridicaService;

        public UsuarioService(PessoaFisicaService pessoaFisicaService, PessoaJuridicaService pessoaJuridicaService)
        {
            _pessoaFisicaService = pessoaFisicaService;
            _pessoaJuridicaService = pessoaJuridicaService;
        }

        public Usuario GetUsuario(string id, TipoUsuario tipoUsuario)
        {
            if (tipoUsuario == TipoUsuario.FISICA)
            {
                return _pessoaFisicaService.Get(id);
            }
            else
            {
                return _pessoaJuridicaService.Get(id);
            }
        }

        public Usuario Login(string login, string senha)
        {
            var senhaHash = Senha.GeraHash(senha);

            var pessoaFisica = _pessoaFisicaService.Login(login, senhaHash);

            if (pessoaFisica != null)
            {
                return pessoaFisica;
            }

            var pessoaJuridica = _pessoaJuridicaService.Login(login, senhaHash);

            if (pessoaJuridica != null)
            {
                return pessoaJuridica;
            }

            return null;
        }

        public void Criar(UsuarioVO usuarioVO)
        {
            if (!Documento.EhValido(usuarioVO.Documento))
            {
                throw new Exception("Documento inválido");
            }

            if (usuarioVO.Documento.Length == 11)
            {
                var pessoaFisica = new PessoaFisica
                {
                    Nome = usuarioVO.Nome,
                    Cpf = usuarioVO.Documento,
                    Endereco = usuarioVO.Endereco,
                    Login = usuarioVO.Login,
                    Senha = Senha.GeraHash(usuarioVO.Senha),
                    Interesses = usuarioVO.GetInteresses(usuarioVO.InteressesSelecionados)
                };

                _pessoaFisicaService.Create(pessoaFisica);
            }
            else if (usuarioVO.Documento.Length == 14)
            {
                var pessoaJuridica = new PessoaJuridica
                {
                    RazaoSocial = usuarioVO.RazaoSocial,
                    NomeFantasia = usuarioVO.NomeFantasia,
                    Cnpj = usuarioVO.Documento,
                    Endereco = usuarioVO.Endereco,
                    Login = usuarioVO.Login,
                    Senha = Senha.GeraHash(usuarioVO.Senha),
                    Interesses = usuarioVO.GetInteresses(usuarioVO.InteressesSelecionados)
                };

                _pessoaJuridicaService.Create(pessoaJuridica);
            }
            else
            {
                throw new Exception("Tipo de documento desconhecido.");
            }
        }


    }
}
