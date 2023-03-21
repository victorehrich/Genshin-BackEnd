using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinApplication.Models
{
    public class Weapon
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid WeaponId { get; set; }
        public string Effect { get; set; }
        public string Name { get; set; }
        public NumberOfStarsEnum Stars { get; set; }
    }
}
