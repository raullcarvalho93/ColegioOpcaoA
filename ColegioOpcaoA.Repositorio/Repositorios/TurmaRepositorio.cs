using ColegioOpcaoA.Dominio.Contratos;
using ColegioOpcaoA.Dominio.Entidades;
using ColegioOpcaoA.Repositorio.Contexto;

namespace ColegioOpcaoA.Repositorio.Repositorios
{
    public class TurmaRepositorio : BaseRepositorio<Turma>, ITurmaRepositorio
    {
        public TurmaRepositorio(ColegioOpcaoAContexto colegioOpcaoAContexto) : base(colegioOpcaoAContexto)
        {
        }
    }
}
