using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletronica.App.Entities
{
    public class OrdemServicoEntity
    {
        public int Id { get; set; }
        public float Orcamento { get; set; } 
        public DateTime Data { get; set; }
        public required string Descricao { get; set; }

    }
}
