using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletronica.App.Entities
{
    public class ProdutoEntity
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public string ? Tipo { get; set; }
        public string ? Modelo { get; set; }
        public string ? Marca { get; set; }
        public string ? Categoria { get; set; }
        public required string Defeito { get; set; }
    }
}
