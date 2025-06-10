using Eletronica.App.Data;
using Eletronica.App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eletronica.App.Services
{
    public class ClienteServices
    {
        public async Task CadastrarAsync(string nome, string email, string telefone, string cpfCnpj, string rg, string ie)
        {
            ClienteEntity cliente = new ClienteEntity()
            {
                CnpjCpf = cpfCnpj,
                Email = email,
                Id = 0,
                IE = ie,
                Nome = nome,
                RG = rg,
                Telefone = telefone
            };

            await Program.repositorio.Clientes.InsertAsync(cliente);
        }

        public async Task<List<ClienteEntity>> ConsultarAsync(string nome)
        {          
        
            return await Program.repositorio.Clientes.ListAsync(c => c.Nome.Contains(nome));
        }

        // teste
          public async Task<ClienteEntity> ConsultarPorIdAsync(int id)
        {
            return await Program.repositorio.Clientes.GetAsync(c => c.Id == id);
        }
        //fim teste


        public async Task AtualizarAsync(int id, string nome, string email, string telefone, string cpfCnpj, string rg, string ie)
        {
            ClienteEntity cliente = new ClienteEntity()
            {
                Id = id,
                CnpjCpf = cpfCnpj,
                Email = email,              
                IE = ie,
                Nome = nome,
                RG = rg,
                Telefone = telefone
            };
            await Program.repositorio.Clientes.UpdateAsnc(cliente);
        }

        public async Task ExcluirAsync(int id)
        { 
            await Program.repositorio.Clientes.DeleteAsync(c=>c.Id==id);
        }

    }
}
