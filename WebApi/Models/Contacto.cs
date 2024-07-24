using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; } = "";
        [Column(TypeName = "nvarchar(20)")]
        public string Phone { get; set; } = "";
    }
}
