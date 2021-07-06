using Core.Entities;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        //the names of our table will be added to this field
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
