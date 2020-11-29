using Common;

namespace DataAccesLayer
{
   public interface IDataRepository<TEntity>
    {
        ApiResult GetAll();
        ApiResult Get(object Id);
        ApiResult Add(TEntity Entity);
        ApiResult Update(int Id, TEntity Entity);
        ApiResult Delete(TEntity Entity);
    }
}
