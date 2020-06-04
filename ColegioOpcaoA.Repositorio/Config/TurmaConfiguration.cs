using ColegioOpcaoA.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColegioOpcaoA.Repositorio.Config
{
    public class TurmaConfiguration : IEntityTypeConfiguration<Turma>
    {
        public void Configure(EntityTypeBuilder<Turma> builder)
        {
            builder.HasKey(t => t.Id);

            builder
                .Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .HasMany(t => t.Alunos)
                .WithOne(a => a.Turma);
        }
    }
}
