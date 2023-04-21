namespace GenshinApplication.Models.DTO.GET
{
    public class SummarizedCharacters
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Element { get; set; }
        public string NumberOfStars { get; set; }
        public string WeaponType { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
    }
}