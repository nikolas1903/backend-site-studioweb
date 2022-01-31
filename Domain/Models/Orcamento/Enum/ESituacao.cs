using System.ComponentModel;

namespace Domain.Models.Orcamento.ESituacao
{
    public enum ESituacao
    {
        [Description("Pendente")]
        Pendente = 1,
        [Description("Cancelado")]
        Cancelado = 2,
        [Description("Respondido")]
        Respondido = 3,
        [Description("Realizado")]
        Realizado = 4
    }
}