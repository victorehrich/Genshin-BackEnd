using AutoMapper;
using GenshinApplication.Models;
using GenshinApplication.Models.DTO.GET;
using GenshinApplication.Models.DTO.POST;

namespace GenshinApplication.Helpers
{
    public class Mappers: Profile
    {
        public Mappers()
        {
            
        }
        public MapperConfiguration Configuration()
        {
            return new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<Characters, CharactersPostDto>();
                cfg.CreateMap<CharactersPostDto, Characters>();

                cfg.CreateMap<Constelation, ConstelationPostDTO>();
                cfg.CreateMap<ConstelationPostDTO, Constelation>();

                cfg.CreateMap<Artifacts, ArtifactsPostDTO>();
                cfg.CreateMap<ArtifactsPostDTO, Artifacts>();

                cfg.CreateMap<ConstelationGetDTO, Constelation>();
                cfg.CreateMap<Constelation, ConstelationGetDTO>();
            });
        }
    }
}
