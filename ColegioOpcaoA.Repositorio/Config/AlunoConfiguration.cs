using ColegioOpcaoA.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColegioOpcaoA.Repositorio.Config
{
    public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.HasKey(a => a.Id);

            builder
                .Property(a => a.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .HasMany(a => a.Provas)
                .WithOne(p => p.Aluno);
        }
    }
}
