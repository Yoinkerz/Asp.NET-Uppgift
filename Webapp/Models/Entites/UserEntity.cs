using Microsoft.AspNetCore.Identity;

namespace Webapp.Models.Entites;

public class UserEntity : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set;}
    public ICollection<UserAddressEntity> UserÁddresses { get; set; } = new HashSet<UserAddressEntity>();
}
