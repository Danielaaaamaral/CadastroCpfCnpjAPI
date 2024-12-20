using CadastroAPI.Domain.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAPI.Infrastructure.Data.Repositorys
{
    public abstract class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext _context;
        public RepositoryBase(SqlContext context) { 
            _context = context;
        }

        public void Add(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Add(obj);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Remove(obj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(TEntity obj)
        {

            try
            {
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
