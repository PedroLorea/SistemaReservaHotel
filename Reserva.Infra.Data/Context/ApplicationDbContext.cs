using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Reserva.Domain.Entidades;

namespace Reserva.Infra.Data.Context {

    public class ApplicationDbContext : DbContext {

        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        { }

        public virtual DbSet<Hotel> Hoteis { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

        
    }
}