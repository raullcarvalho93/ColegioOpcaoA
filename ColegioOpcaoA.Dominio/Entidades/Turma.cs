using System.Collections.Generic;

namespace ColegioOpcaoA.Dominio.Entidades
{
    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Aluno> Alunos { get; set; }

        public Turma(int id, string nome)
        {
            Id = id;
            Nome = nome;
            Alunos = new List<Aluno>();
        }

        public Turma(string nome)
        {
            Nome = nome;
            Alunos = new List<Aluno>();
        }
        public Turma()
        {
            Alunos = new List<Aluno>();
        }
    }
}
