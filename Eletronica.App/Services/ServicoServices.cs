using Eletronica.App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletronica.App.Services
{
    internal class ServicoServices
    {
        public async Task CadastrarAsync(string descricao)
        {
            ServicoEntity servico = new ServicoEntity()
            {
                Descricao = descricao
            };

            await Program.repositorio.Servicos.InsertAsync(servico);
        }
    }
}
