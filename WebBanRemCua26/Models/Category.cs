using System.ComponentModel.DataAnnotations;

namespace WebBanRemCua26.Models
{
    public class Category
    {
         [Key]
         public int CategoryId { get; set; }
         [StringLength(150)]
         public String? CategoryName { get; set; }
         [StringLength(300)]
         public String? CategoryPhoto { get; set; }
         public int CategoryOrder { get; set; }

    }
}
