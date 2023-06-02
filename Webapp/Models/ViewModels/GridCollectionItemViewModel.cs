

using System.ComponentModel.DataAnnotations;

namespace Webapp.Models.ViewModels
{
    public class GridCollectionItemViewModel
    {
        [Key]
        public string Id { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string Title { get; set; } = null!;
        public decimal Price { get; set; }
    }
}
