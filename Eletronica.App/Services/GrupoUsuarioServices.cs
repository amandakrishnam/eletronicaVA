using Eletronica.App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletronica.App.Services
{
    internal class GrupoUsuarioServices
    {
        public async Task CadastrarAsync(string grupo, bool manterUsuario, bool manterServico)
        {
            GrupoUsuarioEntity grupoUsuario = new GrupoUsuarioEntity()
            {
                Grupo = grupo,
                Id = 0,
                ManterUsuario = false,
                ManterServico = false
            };

            await Program.repositorio.GruposUsuarios.InsertAsync(grupoUsuario);
        }
    }
}
