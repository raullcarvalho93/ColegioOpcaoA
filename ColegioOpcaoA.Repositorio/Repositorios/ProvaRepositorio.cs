using ColegioOpcaoA.Dominio.Contratos;
using ColegioOpcaoA.Dominio.Entidades;
using ColegioOpcaoA.Repositorio.Contexto;

namespace ColegioOpcaoA.Repositorio.Repositorios
{
    public class ProvaRepositorio : BaseRepositorio<Prova>, IProvaRepositorio
    {
        public ProvaRepositorio(ColegioOpcaoAContexto colegioOpcaoAContexto) : base(colegioOpcaoAContexto)
        {

        }
    }
}
