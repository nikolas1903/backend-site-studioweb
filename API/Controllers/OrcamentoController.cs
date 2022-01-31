using System.Threading.Tasks;
using Domain.Interfaces.Orcamento;
using Domain.Models.Orcamento.Requests;
using Domain.Models.Usuario.Requests;
using Domain.Utils;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace AgendaChurras.Controllers
{
    [Route("Orcamento")]
    public class OrcamentoController : ControllerBase
    {

        private readonly IOrcamentoAppService _orcamentoAppService;

        public OrcamentoController(IOrcamentoAppService orcamentoAppService)
        {
            _orcamentoAppService = orcamentoAppService;
        }

        [Produces("application/json")]
        [EnableCors]
        [HttpPost("Cadastrar")]
        public async Task<RespostaPadrao> Cadastrar([FromBody]CadastrarOrcamentoRequest request)
        {
            return await _orcamentoAppService.Cadastrar(request);
        }
        
        [Produces("application/json")]
        [EnableCors]
        [HttpGet("Listar")]
        public async Task<RespostaPadrao> Listar()
        {
            return await _orcamentoAppService.Listar();
        }
    }
}