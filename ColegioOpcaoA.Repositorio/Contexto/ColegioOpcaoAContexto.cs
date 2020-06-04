using ColegioOpcaoA.Dominio.Entidades;
using ColegioOpcaoA.Repositorio.Config;
using Microsoft.EntityFrameworkCore;

namespace ColegioOpcaoA.Repositorio.Contexto
{
    public class ColegioOpcaoAContexto : DbContext
    {

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Prova> Provas { get; set; }
        public DbSet<Turma> Turmas { get; set; }

        public ColegioOpcaoAContexto(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /// Classes de mapeamento aqui...
            modelBuilder.ApplyConfiguration(new AlunoConfiguration());
            modelBuilder.ApplyConfiguration(new ProvaConfiguration());
            modelBuilder.ApplyConfiguration(new TurmaConfiguration());


           

            base.OnModelCreating(modelBuilder);
        }

    }
}
