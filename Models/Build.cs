using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinApplication.Models
{
    public class Build
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid BuildId { get; set; }
        public Set SetOne { get; set; }
        public Set? SetTwo { get; set; }
        public List<Weapon> Weapon { get; set; }
        public Status SandMainStatus { get; set; }
        public Status GobletMainStatus { get; set; }
        public Status CircletMainStatus { get; set; }
        public List<Status> Substatus { get; set; }

    }
}
