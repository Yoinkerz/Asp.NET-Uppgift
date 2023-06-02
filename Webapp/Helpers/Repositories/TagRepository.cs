using Webapp.Contexts;
using Webapp.Models.Entites;

namespace Webapp.Helpers.Repositories
{
    public class TagRepository : Repo<TagEntity>
    {
        public TagRepository(DataContext context) : base(context)
        {
        }
    }
}
