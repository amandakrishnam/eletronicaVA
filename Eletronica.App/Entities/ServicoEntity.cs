using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletronica.App.Entities
{
    public class ServicoEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Descricao { get; set; }
    }
}

