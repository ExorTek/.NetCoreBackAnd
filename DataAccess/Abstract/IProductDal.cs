using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        //methods other than add, delete, update and list
        //simple:Listing products by categoryId from parameter
        List<ProductDetailDto> GetProductDetails();
    }
}
