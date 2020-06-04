using ColegioOpcaoA.Dominio.Enumerados;

namespace ColegioOpcaoA.Dominio.Entidades
{
    public class Prova
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int AlunoId { get; set; }
        public virtual Aluno Aluno { get; set; }
        public double Nota { get; set; }
        public TipoProvaEnum Tipo { get; set; }
        public double Peso { get; set; }

        public Prova(TipoProvaEnum tipo, double nota, Aluno aluno)
        {
            Nota = nota;
            Tipo = tipo;
            Aluno = aluno;
            switch ((int)Tipo)
            {
                case 1:
                    Peso = 1;
                    Nome = "Prova 1";
                    break;
                case 2:
                    Peso = 1.2;
                    Nome = "Prova 2";
                    break;
                case 3:
                    Peso = 1.4;
                    //aluno.CalculaMedia(Peso, nota);
                    Nome = "Prova 3";
                    break;
                case 4:
                    Peso = 1;
                   // aluno.CalculaMedia(Peso, nota);
                    Nome = "Prova Recuperação";
                    break;
                case 5:
                    Peso = 2;
                    //aluno.CalculaMedia(Peso, nota);
                    Nome = "Prova Especial";
                    break;
            }
        }

        public Prova()
        {

        }
    }
}
