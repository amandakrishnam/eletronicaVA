﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletronica.App.Entities
{
    public class GrupoUsuarioEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Grupo { get; set; }
        public bool ManterUsuario {  get; set; }
        public bool ManterServico { get; set; }

    }
}
