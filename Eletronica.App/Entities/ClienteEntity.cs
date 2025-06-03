using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletronica.App.Entities
{
    public class ClienteEntity
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Email { get; set; }
        public required string Telefone { get; set; }
        public required string CnpjCpf { get; set; }
        public required string RG {  get; set; }
        public string ? IE { get; set; } // ou string.Empty //não obrigatório
    }
}
