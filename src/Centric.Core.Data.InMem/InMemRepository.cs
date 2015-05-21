using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griz.Core.Data.InMem
{
  public class InMemRepository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : IEntity<TKey> 
  {
    

	  public InMemRepository(IUnitOfWork db)
	  {
		  UnitOfWork = db;
	  }

	  protected static List<TEntity> Collection
    {
      get { return _collection ?? (_collection = new List<TEntity>()); }
      set { _collection = value; }
    }
		private static List<TEntity> _collection;

    public IUnitOfWork UnitOfWork { get; set; }
    public TEntity GetById(TKey id)
    {
      return (TEntity) Collection.FirstOrDefault(c => c.Id.Equals(id));
    }

    public TEntity Create(TEntity entity)
    {
      Collection.Add(entity);
      return entity;
    }

    public void Update(TEntity entity)
    {
      Collection.Remove(entity);
      Collection.Add(entity);
    }

    public void Delete(TEntity entity)
    {
      Collection.Remove(entity);
    }

    public IList<TEntity> GetAll()
    {
      return Collection;
    }

	  public void CleanUp()
	  {
		  _collection = new List<TEntity>();
	  }
  }
}
