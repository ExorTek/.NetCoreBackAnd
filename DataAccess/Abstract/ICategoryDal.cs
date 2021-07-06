using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        //methods other than add, delete, update and list
        //simple: Fetch categories by categoryId
    }
}
