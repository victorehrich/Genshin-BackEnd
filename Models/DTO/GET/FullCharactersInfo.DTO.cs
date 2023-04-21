namespace GenshinApplication.Models.DTO.GET
{
    public class FullCharactersInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ElementsEnum Element { get; set; }
        public NumberOfStarsEnum NumberOfStars { get; set; }
        public WeaponEnum WeaponType { get; set; }
        public GenderEnum Gender { get; set; }
        public LocationEnum Location { get; set; }
        public List<ConstelationGetDTO> Constelations { get; set; } 
    }
}