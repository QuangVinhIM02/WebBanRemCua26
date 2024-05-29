using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebBanRemCua26.Models
{
    public class FeedBack
    {
        [Key]
        public int FeedbackId { get; set; }

        [Required]
        [StringLength(100)]
        public string? UserName { get; set; }

        [Required]
        [StringLength(10000)]
        public string? Content { get; set; }

        [Required]
        public DateTime CreateAt { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
