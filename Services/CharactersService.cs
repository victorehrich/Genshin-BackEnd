using AutoMapper;
using GenshinApplication.Interfaces.Services;
using GenshinApplication.Models;
using GenshinApplication.Models.DTO.GET;
using GenshinApplication.Models.DTO.POST;
using GenshinApplication.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GenshinApplication.Services
{
    public class CharactersService : ICharactersService
    {
        private readonly IUnitOfWork _repositoryUoW;
        private readonly IMapper _mapper;
        public CharactersService(IUnitOfWork repositoryUoW, IMapper mapper)
        {
            _repositoryUoW = repositoryUoW;
            _mapper = mapper;
        }
        public Characters Create(CharactersPostDto charactersPostDto)
        {
            try
            {
                Characters character = _mapper.Map<CharactersPostDto, Characters>(charactersPostDto);
                _repositoryUoW.CharactersRepository.AddCharacter(character);
                _repositoryUoW.Commit();
                return character;
            }
            catch(Exception e)
            {
                _repositoryUoW.Rollback();
                throw new Exception(e.Message);
            }
        }
        public FullCharactersInfo GetCharacterFullInfo(string characterName)
        {
            try
            {
                Characters character = _repositoryUoW.CharactersRepository.GetCharacterByName(characterName);

                List<ConstelationGetDTO> constelationGet = new ();
                List<Constelation> constelation = _repositoryUoW.ConstelationRepository.GetAllCharacterConstelations(character.CharactersId).ToList();
                constelation.ForEach(c =>
                {
                    constelationGet.Add(new()
                    {
                        Name = c.Name,
                        ConstellationLevel = c.ContellationLevel,
                        Effect = c.Effect
                    });
                });

                FullCharactersInfo fullCharactersInfo = new()
                {
                    Constelations = constelationGet,
                    Id = character.CharactersId,
                    Name = character.Name,
                    Element = character.Element,
                    NumberOfStars = character.NumberOfStars,
                    WeaponType = character.WeaponType,
                    Location = character.Location,
                    Gender = character.Gender
                };
                return fullCharactersInfo;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        public List<SummarizedCharacters> GetCharactersSummerized()
        {
            try
            {
                List<SummarizedCharacters> characters = _repositoryUoW.CharactersRepository.GetAllResumedCharactes().ToList<SummarizedCharacters>();
                return characters;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        public Characters GetById(Guid characterId)
        {
            try
            {
                var character = _repositoryUoW.CharactersRepository.GetById(characterId);
                return character;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void AddBuild(Build build, Guid characterId)
        {
            /*Build build = new()
            {
                Flower = _repositoryUoW.ItemRepository.GetArtifact(buildDto.FlowerId),
                Circlet = _repositoryUoW.ItemRepository.GetArtifact(buildDto.CircletId),
                Goblet = _repositoryUoW.ItemRepository.GetArtifact(buildDto.GobletId),
                Sands = _repositoryUoW.ItemRepository.GetArtifact(buildDto.SandsId),
                Plume = _repositoryUoW.ItemRepository.GetArtifact(buildDto.PlumeId),
                Weapon = _repositoryUoW.ItemRepository.GetWeapon(buildDto.WeaponId)
            };*/
            var character = _repositoryUoW.CharactersRepository.GetById(characterId);
        }

    }
}
