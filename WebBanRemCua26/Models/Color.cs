using System.ComponentModel.DataAnnotations;

namespace WebBanRemCua26.Models
{
    public class Color
    {
        [Key]
        public int ColorId { get; set; }
        [StringLength(30)]
        public String? ColorName { get; set; }
    }
}
