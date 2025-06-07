using Eletronica.App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletronica.App.Services
{
    internal class UsuarioServices
    {
       public async Task CadastrarAsync(string nome, string email, string senha)
        {
            UsuarioEntity usuario = new UsuarioEntity()
            {
                Nome = nome,
                Email = email,
                Senha = senha
            };
            await Program.repositorio.Usuarios.InsertAsync(usuario);
        } 
    }
}
