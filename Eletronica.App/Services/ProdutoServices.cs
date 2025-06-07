using Eletronica.App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletronica.App.Services
{
    internal class ProdutoServices
    {
        public async Task CadastrarAsync(string nome, string tipo, string modelo, string marca, string categoria, string defeito)
        {
            ProdutoEntity produto = new ProdutoEntity()
            {
                Nome = nome,
                Tipo = tipo,
                Modelo = modelo,
                Marca = marca,
                Categoria = categoria,
                Defeito = defeito
            };

            await Program.repositorio.Produtos.InsertAsync(produto);
        }
    }
}
