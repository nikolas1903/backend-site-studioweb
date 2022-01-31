﻿using System;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces.Usuario;
using Domain.Models.Usuario.Requests;
using Domain.Utils;

namespace Services.Services.Usuario
{
    public class UsuarioAppService : IUsuarioAppService
    {
        private IUsuarioRepository<UsuarioEntity> _usuarioRepository;
        private const string Hash = "|2d331cca-f6c0-40c0-bb43-6e32989c2881";

        public UsuarioAppService(IUsuarioRepository<UsuarioEntity> usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }


        public async Task<RespostaPadrao> Cadastrar(CadastrarUsuarioRequest request)
        {
            var lUsuario = _usuarioRepository.BuscarUsuario(request.Login);
            if (lUsuario.Result != null)
                return new RespostaPadrao().Falha("Usuário já cadastrado! Utilize outro Login para continuar.", null);


            request.Senha = MD5Hash.Hash($"{request.Senha}{Hash}");
            await _usuarioRepository.CadastrarUsuario(request);

            return await Task.FromResult(new RespostaPadrao().Sucesso("Usuário cadastrado com sucesso!", null));
        }

        public async Task<RespostaPadrao> Login(LoginRequest request)
        {
            request.Senha = MD5Hash.Hash($"{request.Senha}{Hash}");
            var lUsuario = _usuarioRepository.BuscarUsuario(request.Login);
            if (lUsuario.Result == null)
                return new RespostaPadrao().Falha("Usuário inexistente! Tente novamente.", null);

            var lUsuarioSenha = _usuarioRepository.BuscarUsuarioSenha(request);
            if (lUsuarioSenha.Result == null)
                return new RespostaPadrao().Falha("Senha Incorreta! Tente novamente.", null);

            return await Task.FromResult(new RespostaPadrao().Sucesso("Login efetuado com sucesso!", lUsuarioSenha.Result));
        }
    }
}