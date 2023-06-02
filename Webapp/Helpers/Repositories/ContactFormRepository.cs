using Webapp.Contexts;
using Webapp.Models.Entites;

namespace Webapp.Helpers.Repositories
{
    public class ContactFormRepository : Repo<ContactFormEntity>
    {
        public ContactFormRepository(DataContext context) : base(context)
        {
        }
    }
}
