using System;
using System.Linq;
using System.Threading.Tasks;
using Data.Context;
using Domain.Entities;
using Domain.Interfaces.Usuario;
using Domain.Models.Usuario.Requests;
using Domain.Utils;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class UsuarioRepository<TUsuarioEntity> : IUsuarioRepository<TUsuarioEntity> where TUsuarioEntity : UsuarioEntity
    {
        protected readonly DatabaseContext _context;
        private DbSet<UsuarioEntity> _dataSet;

        public UsuarioRepository (DatabaseContext context)
        {
            _context = context;
            _dataSet = _context.Set<UsuarioEntity> ();
        }





        public async Task<CadastrarUsuarioRequest> CadastrarUsuario(CadastrarUsuarioRequest request)
        {
            try
            {
                var usuario = new UsuarioEntity();

                usuario.Nome = request.Nome;
                usuario.Cpf = request.Cpf;
                usuario.Login = request.Login;
                usuario.Email = request.Email;
                usuario.Senha = request.Senha;
                usuario.Ativo = request.Ativo;
                usuario.DataCriacao = DateTime.Now;
                _dataSet.Add(usuario);

                await _context.SaveChangesAsync();
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return request;
        }

        

        public Task<UsuarioEntity> BuscarUsuario(string login)
        {
            try
            {
                return Task.FromResult(_context.Users.FirstOrDefault(c => c.Login.Equals(login)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<UsuarioEntity> BuscarUsuarioSenha(LoginRequest request)
        {
            try
            {
                return await Task.FromResult(_context.Users.FirstOrDefault(c => c.Login.Equals(request.Login) && c.Senha.Equals(request.Senha)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}