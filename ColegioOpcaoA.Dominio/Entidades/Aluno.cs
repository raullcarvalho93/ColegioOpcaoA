using ColegioOpcaoA.Dominio.Enumerados;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace ColegioOpcaoA.Dominio.Entidades
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int TurmaId { get; set; }
        public virtual Turma Turma { get; set; }
        public virtual ICollection<Prova> Provas { get; set; }
        public double Media { get; set; }
        public StatusAlunoEnum StatusAluno { get; set; }
        public bool MelhorAluno { get; set; }
        /// <summary>
        /// Um Aluno pode ter realizado 0 ou muitas provas
        /// </summary>
        public Aluno(int id, string nome,Turma turma)
        {
            Id = id;
            Nome = nome;
            Turma = turma;
            Provas = new List<Prova>();
        }

        public Aluno()
        {
            Provas = new List<Prova>();
        }

        //public void CalculaMedia(double novaProvaPeso, double novaProvaNota )
        //{
        //    double numerador = 0;
        //    double denominador = 0;
        //    double media = 0;
        //    switch (Provas.Count)
        //    {
        //        case 2:
        //            foreach (var prova in Provas)
        //            {
        //                numerador += prova.Nota * prova.Peso;
        //                denominador += prova.Peso;
        //            }
        //            numerador += novaProvaNota * novaProvaPeso;
        //            denominador += novaProvaPeso;
        //            media = numerador/denominador*(1.0);
        //            Media = media;
        //            AlunoAprovado();
        //            break;
        //        case 3:
        //            Media = (Media + novaProvaNota) / 2.0;
        //            AlunoAprovado();
        //            break;
        //        case 4:
        //            foreach(var prova in Provas)
        //            {
        //                numerador += prova.Nota;
        //                denominador++;
        //            }
        //            numerador += novaProvaNota * novaProvaPeso;
        //            denominador += novaProvaPeso;
        //            media = numerador / denominador;
        //            Media = media;
        //            break;
        //    }
          
        //}

        //public void AlunoAprovado()
        //{
        //    switch (Provas.Count)
        //    {
        //        case 2:
        //            if (Media <= 4)
        //                StatusAluno = StatusAlunoEnum.Reprovado;
        //            else if (Media <= 6)
        //                StatusAluno = StatusAlunoEnum.Recuperacao;
        //                else
        //                    StatusAluno = StatusAlunoEnum.Aprovado;
        //            break;
        //        case 3:
        //            if (Media >= 5)
        //                StatusAluno = StatusAlunoEnum.Aprovado;
        //            else
        //                StatusAluno = StatusAlunoEnum.Reprovado;
        //            break;
        //    }
        //}

    }
}
