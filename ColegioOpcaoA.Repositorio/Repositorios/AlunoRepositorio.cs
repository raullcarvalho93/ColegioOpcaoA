using ColegioOpcaoA.Dominio.Contratos;
using ColegioOpcaoA.Dominio.Entidades;
using ColegioOpcaoA.Repositorio.Contexto;

namespace ColegioOpcaoA.Repositorio.Repositorios
{
    public class AlunoRepositorio : BaseRepositorio<Aluno>, IAlunoRepositorio
    {
        public AlunoRepositorio(ColegioOpcaoAContexto colegioOpcaoAContexto) : base(colegioOpcaoAContexto)
        {
        }
    }
}
