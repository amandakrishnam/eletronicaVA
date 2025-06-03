using Eletronica.App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletronica.App.Data
{
    public class Repositorio
    {
        private readonly ContextoDados _context;

        public Repositorio(ContextoDados contextData)
        {

            _context = contextData;
        }

        private RepositorioGenerico<ClienteEntity>? RepositorioClientes { get; set; }
        public RepositorioGenerico<ClienteEntity> Clientes
        {
            get
            {
                if (RepositorioClientes == null)
                    RepositorioClientes = new RepositorioGenerico<ClienteEntity>(_context);

                return RepositorioClientes;
            }
        }

        private RepositorioGenerico<GrupoUsuarioEntity>? RepositorioGruposUsuarios { get; set; }
        public RepositorioGenerico<GrupoUsuarioEntity> GruposUsuarios
        {
            get
            {
                if (RepositorioGruposUsuarios == null)
                    RepositorioGruposUsuarios = new RepositorioGenerico<GrupoUsuarioEntity>(_context);

                return RepositorioGruposUsuarios;
            }
        }

        private RepositorioGenerico<OrdemServicoEntity>? RepositorioOrdensServicos { get; set; }
        public RepositorioGenerico<OrdemServicoEntity> OrdensServicos
        {
            get
            {
                if (RepositorioOrdensServicos == null)
                    RepositorioOrdensServicos = new RepositorioGenerico<OrdemServicoEntity>(_context);

                return RepositorioOrdensServicos;
            }
        }

        private RepositorioGenerico<ProdutoEntity>? RepositorioProdutos { get; set; }
        public RepositorioGenerico<ProdutoEntity> Produtos
        {
            get
            {
                if (RepositorioProdutos == null)
                    RepositorioProdutos = new RepositorioGenerico<ProdutoEntity>(_context);

                return RepositorioProdutos;
            }
        }

        private RepositorioGenerico<ServicoEntity>? RepositorioServicos { get; set; }
        public RepositorioGenerico<ServicoEntity> Servicos
        {
            get
            {
                if (RepositorioServicos == null)
                    RepositorioServicos = new RepositorioGenerico<ServicoEntity>(_context);

                return RepositorioServicos;
            }
        }

        private RepositorioGenerico<UsuarioEntity>? RepositorioUsuarios { get; set; }
        public RepositorioGenerico<UsuarioEntity> Usuarios
        {
            get
            {
                if (RepositorioUsuarios == null)
                    RepositorioUsuarios = new RepositorioGenerico<UsuarioEntity>(_context);

                return RepositorioUsuarios;
            }
        }
    }
}
