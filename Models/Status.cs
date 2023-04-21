using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinApplication.Models
{
    public class Status
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid StatusId { get; set; }
        public string Name { get; set; }
    }
}
