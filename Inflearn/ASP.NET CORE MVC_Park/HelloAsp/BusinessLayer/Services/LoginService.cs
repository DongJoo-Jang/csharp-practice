using AutoMapper;
using DataAccessLayer.Mappers;
using DataAccessLayer.Models;
using HelloAsp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class LoginService : ILoginService
    {
        ILoginMapper _loginMapper;
        public LoginService(ILoginMapper loginMapper)
        {
            _loginMapper = loginMapper;
        }

        public async  Task CreateUser(CreateUserDTO createUserDTO)
        {
            try
            {
                // 속성 유효성 검사
                //비지니스 로직
                //DTO <-> Entity 변경

                // Configure AutoMapper

                var configuration = new MapperConfiguration(cfg => cfg.CreateMap<CreateUserDTO, USER>());

                // Perform mapping
                Mapper mapper = new Mapper(configuration);
                USER user = mapper.Map<CreateUserDTO, USER>(createUserDTO);

                await _loginMapper.Create(user);
            }
            catch (Exception ex)
            {
                throw;
            }


        }
    }
}
