using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletronica.App.Entities
{
    public class ServicoOrdemServicoEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int IdServico { get; set; }
        [ForeignKey("IdServico")]
        public virtual ServicoEntity Servico { get; set; }
    }
}
