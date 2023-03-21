using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinApplication.Models
{
    public class Characters
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid CharactersId { get; set; }
        public string Name { get; set; }
        public ElementsEnum Element { get; set; }
        public NumberOfStarsEnum NumberOfStars { get; set; }
        public WeaponEnum WeaponType { get; set; }
        public GenderEnum Gender { get; set; }
        public LocationEnum Location { get; set; }
        public List<Build>? Build { get; set; }
        public Constelation Constelation { get; set; }

    }
}
