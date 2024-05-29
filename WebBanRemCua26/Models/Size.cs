using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace WebBanRemCua26.Models
{
    public class Size
    {
        [Key]
        public int SizeId { get; set; }
        [StringLength(10)]
        public string? SizeName { get; set; }
    }
}
