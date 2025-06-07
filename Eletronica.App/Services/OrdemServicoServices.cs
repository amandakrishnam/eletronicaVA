using Eletronica.App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletronica.App.Services
{
    internal class OrdemServicoServices
    {
        public async Task CadastrarAsync(float orcamento, DateTime data, string descricao)
        {
            OrdemServicoEntity ordemServico = new OrdemServicoEntity()
            {
                Orcamento = orcamento,
                Data = data,
                Descricao = descricao
            };

            await Program.repositorio.OrdensServicos.InsertAsync(ordemServico);
        }
    }
}
