using Webapp.Contexts;
using Webapp.Models.Entites;

namespace Webapp.Helpers.Repositories
{
    public class UserAddressRepository : Repo<UserAddressEntity>
    {
        public UserAddressRepository(DataContext context) : base(context)
        {
        }
    }
}
