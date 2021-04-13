using AppBarganha.Services;
using AppBarganhaWEB.Models;
using AppBarganhaWEB.Utils;
using AppBarganhaWEB.ViewsObject;
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

        public Usuario Get(string id)
        {
            var pessoaFisica = _pessoaFisicaService.Get(id);

            if (pessoaFisica != null)
            {
                return pessoaFisica;
            }

            var pessoaJuridica = _pessoaJuridicaService.Get(id);

            if (pessoaJuridica != null)
            {
                return pessoaJuridica;
            }

            return null;
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

        public Usuario CriarOrAtualizar(UsuarioVO usuarioVO)
        {
            if (!Documento.EhValido(usuarioVO.Documento))
            {
                throw new Exception("Documento inválido");
            }

            var ehAtualizar = usuarioVO.id != null && usuarioVO.id != "";

            if (usuarioVO.TipoUsuario.Contains("Física"))
            {
                return CriarOuAtualizarPessoaFisica(usuarioVO, ehAtualizar);

            }
            else if (usuarioVO.TipoUsuario.Contains("Jurídica"))
            {
                return CriarOuAtualizarPessoaJuridica(usuarioVO, ehAtualizar);
            }
            else
            {
                throw new Exception("Tipo de documento desconhecido.");
            }
        }

        private Usuario CriarOuAtualizarPessoaJuridica(UsuarioVO usuarioVO, bool ehAtualizar)
        {

            if (ehAtualizar)
            {

                var usuarioAtual = _pessoaJuridicaService.Get(usuarioVO.id);
                usuarioAtual.RazaoSocial = usuarioVO.RazaoSocial;
                usuarioAtual.NomeFantasia = usuarioVO.NomeFantasia;
                usuarioAtual.Cnpj = usuarioVO.Documento;
                usuarioAtual.Endereco = usuarioVO.Endereco;
                usuarioAtual.Login = usuarioVO.Login;
                usuarioAtual.Interesses = usuarioVO.GetInteresses(usuarioVO.InteressesSelecionados);
                if (usuarioVO.Senha != null)
                {
                    usuarioAtual.Senha = Senha.GeraHash(usuarioVO.Senha);
                }

                _pessoaJuridicaService.Update(usuarioAtual.Id, usuarioAtual);
                return usuarioAtual;

            }
            else
            {
                if (ExisteDocumento(usuarioVO.Documento))
                {
                    throw new Exception("Documento já cadastrado");
                }

                if(ExisteLogin(usuarioVO.Login))
                {
                    throw new Exception("Login já cadastrado");
                }

                var pessoaJuridica = new PessoaJuridica
                {
                    Pontuacao = 0,
                    RazaoSocial = usuarioVO.RazaoSocial,
                    NomeFantasia = usuarioVO.NomeFantasia,
                    Cnpj = usuarioVO.Documento,
                    Endereco = usuarioVO.Endereco,
                    Login = usuarioVO.Login,
                    Senha = Senha.GeraHash(usuarioVO.Senha),
                    Interesses = usuarioVO.GetInteresses(usuarioVO.InteressesSelecionados)
                };

                return _pessoaJuridicaService.Create(pessoaJuridica);
            }
        }

        private Usuario CriarOuAtualizarPessoaFisica(UsuarioVO usuarioVO, bool ehAtualizar)
        {
            if (ehAtualizar)
            {
                var usuarioAtual = _pessoaFisicaService.Get(usuarioVO.id);
                usuarioAtual.Nome = usuarioVO.Nome;
                usuarioAtual.Cpf = usuarioVO.Documento;
                usuarioAtual.Endereco = usuarioVO.Endereco;
                usuarioAtual.Login = usuarioVO.Login;
                usuarioAtual.Interesses = usuarioVO.GetInteresses(usuarioVO.InteressesSelecionados);
                if (usuarioVO.Senha != null)
                {
                    usuarioAtual.Senha = Senha.GeraHash(usuarioVO.Senha);
                }

                _pessoaFisicaService.Update(usuarioAtual.Id, usuarioAtual);
                return usuarioAtual;
            }
            else
            {
                if (ExisteDocumento(usuarioVO.Documento))
                {
                    throw new Exception("Usuário já cadastrado");
                }

                if (ExisteLogin(usuarioVO.Login))
                {
                    throw new Exception("Login já cadastrado");
                }

                var pessoaFisica = new PessoaFisica
                {
                    Pontuacao = 0,
                    Nome = usuarioVO.Nome,
                    Cpf = usuarioVO.Documento,
                    Endereco = usuarioVO.Endereco,
                    Login = usuarioVO.Login,
                    Senha = Senha.GeraHash(usuarioVO.Senha),
                    Interesses = usuarioVO.GetInteresses(usuarioVO.InteressesSelecionados)
                };

                return _pessoaFisicaService.Create(pessoaFisica);
            }
        }

        public Usuario AtualizarPontuacao(string idUsuario, int pontos)
        {
            var usuario = Get(idUsuario);
            usuario.Pontuacao += pontos;

            if (usuario is PessoaFisica)
            {
                _pessoaFisicaService.Update(idUsuario, usuario as PessoaFisica);
            }
            else
            {
                _pessoaJuridicaService.Update(idUsuario, usuario as PessoaJuridica);
            }

            return usuario;
        }

        public bool ExisteDocumento(string documento)
        {
            if (_pessoaFisicaService.GetDocumento(documento) != null)
            {
                return true;
            }
            if (_pessoaJuridicaService.GetDocumento(documento) != null)
            {
                return true;
            }
            return false;
        }

        public bool ExisteLogin(string login)
        {
            if (_pessoaFisicaService.GetLogin(login) != null)
            {
                return true;
            }
            if (_pessoaJuridicaService.GetLogin(login) != null)
            {
                return true;
            }
            return false;
        }
    }
}