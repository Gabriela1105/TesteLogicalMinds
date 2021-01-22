using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteLogicalMinds.Models;
using Microsoft.EntityFrameworkCore;

namespace TesteLogicalMinds.Contexts
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions options):base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


    }
}
