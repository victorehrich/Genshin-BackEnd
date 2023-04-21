using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinApplication.Models
{
    public class ArtifactsPostDTO
    {
        public string Set { get; set; }
        public string SetBonusOne { get; set; }
        public string SetBonusTwo { get; set; }
        public string Name { get; set; }
        public NumberOfStarsEnum Stars { get; set; }
        public ArtifactsTypeEnum ArtifactsType { get; set; }

    }
}
