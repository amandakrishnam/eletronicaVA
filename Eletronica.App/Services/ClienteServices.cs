﻿using Eletronica.App.Data;
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

    }
}
