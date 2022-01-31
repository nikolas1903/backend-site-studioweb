using Domain.Models.Orcamento.ESituacao;

namespace Domain.Entities
{
    public class OrcamentoEntity : BaseEntity
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Ramo { get; set; }
        public string NomeEmpresa { get; set; }
        public string Templates { get; set; }
        public string Sugestao { get; set; }
        public ESituacao Situacao { get; set; }
    }
}