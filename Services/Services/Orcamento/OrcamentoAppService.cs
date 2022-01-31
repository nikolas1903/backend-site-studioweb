using System;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces.Orcamento;
using Domain.Models.Orcamento.Requests;
using Domain.Utils;

namespace Services.Services.Orcamento
{
    public class OrcamentoAppService : IOrcamentoAppService
    {
        private IOrcamentoRepository<OrcamentoEntity> _orcamentoRepository;

        public OrcamentoAppService(IOrcamentoRepository<OrcamentoEntity> orcamentoRepository)
        {
            _orcamentoRepository = orcamentoRepository;
        }


        public Task<RespostaPadrao> Cadastrar(CadastrarOrcamentoRequest request)
        {
            var lOrcamento = _orcamentoRepository.CadastrarOrcamento(request);
            if (lOrcamento.Result == null)
                return Task.FromResult(new RespostaPadrao().Falha("Erro ao realizar orçamento. Tente novamente!", null));
            
            
            return Task.FromResult(new RespostaPadrao().Sucesso("Orçamento realizado com sucesso!", lOrcamento.Result));
        }

        public Task<RespostaPadrao> Listar()
        {
            var lOrcamentos = _orcamentoRepository.BuscarOrcamentos();
            if (lOrcamentos.Result == null)
                return Task.FromResult(new RespostaPadrao().Falha("Nenhum orçamento à ser listado!", null));
            
            return Task.FromResult(new RespostaPadrao().Sucesso("Consulta realizada com sucesso!", lOrcamentos.Result));
        }
    }
}