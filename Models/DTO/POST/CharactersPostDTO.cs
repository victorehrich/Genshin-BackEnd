namespace GenshinApplication.Models.DTO.POST
{
    public class CharactersPostDto
    {
        public string Name { get; set; }
        public ElementsEnum Element { get; set; }
        public NumberOfStarsEnum NumberOfStars { get; set; }
        public WeaponEnum WeaponType { get; set; }
        public GenderEnum Gender { get; set; }
        public LocationEnum Location { get; set; }
        public List<Build>? Build { get; set; }
    }
}
