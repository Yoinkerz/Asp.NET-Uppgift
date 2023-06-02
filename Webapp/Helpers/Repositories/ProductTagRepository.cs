using Webapp.Contexts;
using Webapp.Models.Entites;

namespace Webapp.Helpers.Repositories
{
    public class ProductTagRepository : Repo<ProductTagEntity>
    {
        public ProductTagRepository(DataContext context) : base(context)
        {
        }
    }
}
