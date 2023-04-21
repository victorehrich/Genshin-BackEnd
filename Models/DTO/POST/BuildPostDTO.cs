using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinApplication.Models
{
    public class BuildPostDTO
    {
        public Guid FlowerId { get; set; }
        public Guid PlumeId { get; set; }
        public Guid SandsId { get; set; }
        public Guid GobletId { get; set; }
        public Guid CircletId { get; set; }
        public Guid WeaponId { get; set; }

    }
}
