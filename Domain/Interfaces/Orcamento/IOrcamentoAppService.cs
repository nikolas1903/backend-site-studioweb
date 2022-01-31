using System.Threading.Tasks;
using Domain.Models.Orcamento.Requests;
using Domain.Utils;

namespace Domain.Interfaces.Orcamento
{
    public interface IOrcamentoAppService
    {
        Task<RespostaPadrao> Cadastrar(CadastrarOrcamentoRequest request);
        Task<RespostaPadrao> Listar();
    }
}