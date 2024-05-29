using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        public int Id { get; set; } //for default is primary or can write [key]
        [Required]
        [DisplayName("Category Name")]
        public string Name { get; set; } = string.Empty;
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
