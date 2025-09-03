using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimento.Model
{
    public class Clientes
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Cpf_Cnpj { get; set; }
        public string? TipoPessoa { get; set; }
        public string? Telefone { get; set; }
        public string? Celular { get; set; }
        public string? Cep {  get; set; }
        public string? endereco { get; set; }
        public string? numero { get; set; }
        public string? complemento { get; set; }
        public string? bairro { get; set; }
        public string? cidade { get; set; }
        public string? estado { get; set; }
        public bool ativo { get; set; }

    }
}
