
using System.ComponentModel.DataAnnotations;

namespace AppTop.Models
{
    public class TokenRequest
    {
        [Required] public required string user { get; set; }
        [Required] public int password { get; set; }
    }
}
