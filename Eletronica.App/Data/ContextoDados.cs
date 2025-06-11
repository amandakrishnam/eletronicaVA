using Eletronica.App.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletronica.App.Data
{
    public class ContextoDados : DbContext
    {
        public ContextoDados()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            optionsBuilder.UseNpgsql("Host=localhost;Database=eletronicaBD;Username=postgres;Password=1234");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ClienteEntity>? Clientes { get; }
        public DbSet<GrupoUsuarioEntity>? GruposUsuarios { get; }
        public DbSet<OrdemServicoEntity>? OrdensServicos { get; }
        public DbSet<ProdutoEntity>? Produtos { get; }
        public DbSet<ServicoEntity>? Servicos { get; }
        public DbSet<UsuarioEntity>? Usuarios { get; } //*adicionei ? por causa de um aviso
    }
}
