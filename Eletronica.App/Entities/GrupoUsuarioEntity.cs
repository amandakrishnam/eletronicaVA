using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletronica.App.Entities
{
    public class TecnicoEntity
    {
        public int Id { get; set; }
        public required string Grupo { get; set; }
        public bool ManterUsuario {  get; set; }
        public bool ManterServico { get; set; }

    }
}
