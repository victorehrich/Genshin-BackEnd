namespace GenshinApplication.Models.DTO.POST
{
    public class ConstelationPostDTO
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string Effect { get; set; }
        public Guid CharactersId { get; set; }
        public Characters Characters { get; set; }
    }
}
