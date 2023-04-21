using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinApplication.Models
{
    public class Set
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid SetId { get; set; }
        public string Name { get; set; }
        public string SetBonusOne { get; set; }
        public string? SetBonusTwo { get; set; }
    }
}
