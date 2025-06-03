using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletronica.App.Entities
{
    public class ProdutoEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Nome { get; set; }
        [Required]
        public string ? Tipo { get; set; }
        public string ? Modelo { get; set; }
        public string ? Marca { get; set; }
        public string ? Categoria { get; set; }
        [Required]
        public required string Defeito { get; set; }
    }
}
