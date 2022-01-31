using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Context;
using Domain.Entities;
using Domain.Interfaces.Orcamento;
using Domain.Models.Orcamento.ESituacao;
using Domain.Models.Orcamento.Requests;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class OrcamentoRepository<TOrcamentoEntity> : IOrcamentoRepository<TOrcamentoEntity> where TOrcamentoEntity : OrcamentoEntity
    {
        protected readonly DatabaseContext _context;
        private DbSet<OrcamentoEntity> _dataSet;

        public OrcamentoRepository (DatabaseContext context)
        {
            _context = context;
            _dataSet = _context.Set<OrcamentoEntity> ();
        }


        public async Task<OrcamentoEntity> CadastrarOrcamento(CadastrarOrcamentoRequest request)
        {
            try
            {
                var orcamento = new OrcamentoEntity();

                orcamento.Nome = request.Nome;
                orcamento.Cpf = request.Cpf;
                orcamento.Telefone = request.Telefone;
                orcamento.Email = request.Email;
                orcamento.Ramo = request.Ramo;
                orcamento.NomeEmpresa = request.NomeEmpresa;
                
                const char delim = ',';
                var str = string.Join(delim, request.Templates);
                orcamento.Templates = str;

                orcamento.Sugestao = request.Sugestao;
                orcamento.Situacao = ESituacao.Pendente;
                
                orcamento.DataCriacao = DateTime.Now;
                _dataSet.Add(orcamento);

                await _context.SaveChangesAsync();
                
                return orcamento;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public async Task<IEnumerable<OrcamentoEntity>> BuscarOrcamentos()
        {
            try
            {
                var lOrcamentos = await _dataSet.ToListAsync();
                var orcamentos = new List<OrcamentoEntity>();
                
                foreach (var orcamento in lOrcamentos)
                {
                    if (orcamento.Situacao == ESituacao.Pendente)
                        orcamentos.Add(orcamento);
                }

                return orcamentos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}