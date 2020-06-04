using ColegioOpcaoA.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColegioOpcaoA.Repositorio.Config
{
    public class ProvaConfiguration : IEntityTypeConfiguration<Prova>
    {
        public void Configure(EntityTypeBuilder<Prova> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(p => p.Nota)
                .IsRequired();

            builder
                .Property(p => p.Tipo)
                .IsRequired();

            builder
                .Property(p => p.Peso)
                .IsRequired();

        }
    }
}
