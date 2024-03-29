﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinApplication.Models
{
    public class Artifacts
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid ArtifactsId { get; set; }
        public Set Set { get; set; }
        public string Name { get; set; }
        public ArtifactsTypeEnum ArtifactsType { get; set; }
        public NumberOfStarsEnum Stars { get; set; }
    }
}
