using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinApplication.Models
{
    public class Build
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid BuildId { get; set; }
        public Artifacts Flower { get; set; }
        public Artifacts Plume { get; set; }
        public Artifacts Sands { get; set; }
        public Artifacts Goblet { get; set; }
        public Artifacts Circlet { get; set; }
        public Weapon Weapon { get; set; }

    }
}
