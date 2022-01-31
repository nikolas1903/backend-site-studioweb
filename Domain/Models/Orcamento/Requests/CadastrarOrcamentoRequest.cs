using System;
using System.Collections.Generic;

namespace Domain.Models.Orcamento.Requests
{
    public class CadastrarOrcamentoRequest
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Ramo { get; set; }
        public string NomeEmpresa { get; set; }
        public List<string> Templates { get; set; }
        public string Sugestao { get; set; }  
    }
}