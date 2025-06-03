using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Eletronica.App.Entities
{
    public class OrdemServicoEntity 
    {
        [Key]
        public int Id { get; set; }
        public float Orcamento { get; set; } 
        public DateTime Data { get; set; }
        [Required]
        public required string Descricao { get; set; }

        public enum TiposStatus
        {
            EmEspera,
            EmAndamento,            
            Pronto
        }
        [Required]
        public required TiposStatus Status { get; set; }
        
        public int IdCliente { get; set; }
        [ForeignKey("IdCliente")]
        public virtual ClienteEntity Cliente { get; set; }
        [Required]
        public int IdProduto { get; set; }
        [ForeignKey("IdProduto")]
        public virtual ProdutoEntity Produto { get; set; }
    }
}
