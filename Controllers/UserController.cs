using AutoMapper;
using GenshinApplication.DataContext.Interfaces;
using GenshinApplication.Models;
using GenshinApplication.Models.DTO.POST;
using GenshinApplication.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GenshinApplication.Controllers
{
    [Route("v1/User")]
    public class UserController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        private IUserRepository _usersRepository;
        private IMapper _mapper;
        public UserController(IUnitOfWork unitOfWork, IUserRepository usersRepository, IMapper mapper)
        {
            _usersRepository = usersRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult CreateUser(PostUsersDto user)
        {
            try
            {
                Users InsertUser = _mapper.Map<Users>(user);
                _usersRepository.InsertUser(InsertUser);
                _unitOfWork.Commit();
                return Ok(InsertUser);
            }
            catch(Exception ex)
            {
                _unitOfWork.Rollback();
                return BadRequest(ex);
            }
        }
    }
}
