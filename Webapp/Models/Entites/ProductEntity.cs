using System.ComponentModel.DataAnnotations.Schema;

namespace Webapp.Models.Entites;

public class ProductEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }

    [Column(TypeName ="money")]
    public int Price { get; set; }


    public ICollection<ProductTagEntity> ProductTags { get; set; } = new HashSet<ProductTagEntity>();
}
