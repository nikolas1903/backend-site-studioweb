using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Models.Orcamento.Requests;
using Domain.Models.Usuario.Requests;

namespace Domain.Interfaces.Orcamento
{
    public interface IOrcamentoRepository<TOrcamentoEntity> where TOrcamentoEntity : OrcamentoEntity
    {
        Task<OrcamentoEntity> CadastrarOrcamento(CadastrarOrcamentoRequest request);
        Task<IEnumerable<OrcamentoEntity>> BuscarOrcamentos();
    }
}