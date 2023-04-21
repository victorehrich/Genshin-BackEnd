using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinApplication.Models
{
    public class WeaponPostDTO
    {
        public string Effect { get; set; }
        public string Name { get; set; }
        public NumberOfStarsEnum Stars { get; set; }

    }
}
