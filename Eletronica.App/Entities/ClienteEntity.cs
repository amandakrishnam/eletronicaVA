using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletronica.App.Entities
{
    public class ClienteEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Nome { get; set; }
        [Required]
        public required string Email { get; set; }
        [Required]
        public required string Telefone { get; set; }
        [Required]
        public required string CnpjCpf { get; set; }
        [Required]
        public required string RG {  get; set; }
        public string ? IE { get; set; } // ou string.Empty //não obrigatório
    }
}
