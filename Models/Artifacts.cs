using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinApplication.Models
{
    public class Artifacts
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid ArtifactsId { get; set; }
        public string Set { get; set; }
        public string SetBonusOne { get; set; }
        public string SetBonusTwo { get; set; }
        public string Name { get; set; }
        public NumberOfStarsEnum Stars { get; set; }
    }
}
