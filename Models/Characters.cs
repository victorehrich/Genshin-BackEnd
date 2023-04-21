using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinApplication.Models
{
    public class Characters
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid CharactersId { get; set; }
        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Name { get; set; }
        [Required]
        [EnumDataType(typeof(ElementsEnum))]
        public ElementsEnum Element { get; set; }
        [Required]
        public NumberOfStarsEnum NumberOfStars { get; set; }
        [Required]
        public WeaponEnum WeaponType { get; set; }
        [Required]
        public GenderEnum Gender { get; set; }
        [Required]
        public LocationEnum Location { get; set; }
        [Required]
        public virtual ICollection<Constelation> Constelation { get; set; }

    }
}
