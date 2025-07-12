using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess
{
    //IEntity: IEntity olabilir veya IEntity'den türeyen bir nesne olabilir.
    // new () new'lenebilir olmalıdır.
    //IEntity newlenemez oldugu için IEntity gelemez.Zaten istenen de bu. IEntity'den kalıtım alan nesneleri biz istiyoruz.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T ENTITY);
        void Update(T ENTITY);
        void Delete(T ENTİTY);

    }
}