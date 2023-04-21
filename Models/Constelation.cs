﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinApplication.Models
{
    public class Constelation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid ConstelationId { get; set; }
        public string Name { get; set; }
        public ConstellationLevelEnum ContellationLevel { get; set; }
        public string Effect { get; set; }
        public virtual Characters Characters { get; set; }
    }
}
