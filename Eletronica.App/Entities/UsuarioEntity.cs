﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletronica.App.Entities
{
    public class UsuarioEntity
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Email { get; set; } 
        public required string Senha { get; set; }
    }
}
