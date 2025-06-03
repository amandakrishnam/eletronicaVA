using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletronica.App.Entities
{
    public class UsuarioEntity
    {
        [Key] //define como PK no banco
        public int Id { get; set; }
        [Required] // Define o campo como obg no banco
        public required string Nome { get; set; }
        [Required]
        public required string Email { get; set; } 
        [Required]
        public required string Senha { get; set; }
        [Required]
        public int IdGrupoUsuario { get; set; }
        [ForeignKey("IdGrupoUsuario")]
        public virtual GrupoUsuarioEntity GrupoUsuario { get; set; }
    }
}
