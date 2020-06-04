using ColegioOpcaoA.Dominio.Contratos;
using ColegioOpcaoA.Repositorio.Contexto;
using ColegioOpcaoA.Repositorio.Services;
using System.Collections.Generic;
using System.Linq;

namespace ColegioOpcaoA.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {

        protected readonly ColegioOpcaoAContexto _colegioOpcaoAContexto;
        protected readonly SeedingService _seedingService;

        public BaseRepositorio(ColegioOpcaoAContexto colegioOpcaoAContexto)
        {
            _colegioOpcaoAContexto = colegioOpcaoAContexto;
        }

        public void Adicionar(TEntity entity)
        {
            _colegioOpcaoAContexto.Set<TEntity>().Add(entity);
            _colegioOpcaoAContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            _colegioOpcaoAContexto.Set<TEntity>().Update(entity);
            _colegioOpcaoAContexto.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            return _colegioOpcaoAContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _colegioOpcaoAContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            _colegioOpcaoAContexto.Remove(entity);
            _colegioOpcaoAContexto.SaveChanges();
        }

        public void Dispose()
        {
            _colegioOpcaoAContexto.Dispose();
        }
    }
}
