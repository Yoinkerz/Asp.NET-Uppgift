using Webapp.Contexts;
using Webapp.Models.Entites;

namespace Webapp.Helpers.Repositories
{
    public class AddressRepository : Repo<AddressEntity>
    {
        public AddressRepository(DataContext context) : base(context)
        {
        }
    }
}
