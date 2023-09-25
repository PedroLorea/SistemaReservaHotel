using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reserva.Domain.Entidades;

namespace Reserva.Infra.Data.ConfiguracaoEntidades {

    public class HotelConfiguracao : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasKey(h => h.Id);

            builder.Property(p => p.Nome).IsRequired();

            builder.Property(p => p.Descricao).IsRequired();

            builder.Property(p => p.QntQuartos).IsRequired();

            builder.HasData(
                new Hotel(1, "Las Vegas Cassino & Hotel", "Cassino Hotel", 250),
                new Hotel(2, "England Palace", "Classic Hotel", 50),
                new Hotel(3, "Miami Hotel", "Beach Hotel", 120)
            );

        }
    }
}