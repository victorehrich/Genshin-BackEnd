﻿namespace GenshinApplication.Models.DTO.POST
{
    public class ConstelationPostDTO
    {
        public string Name { get; set; }
        public ConstellationLevelEnum ConstellationLevel { get; set; }
        public string Effect { get; set; }
        public Guid CharactersId { get; set; }
    }
}
