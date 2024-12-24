using AutoMapper;
using DataAccessLayer.Mappers;
using HelloAsp.DAL;
using HelloAsp.DTO;
using HelloAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class LoginService : ILoginService
    {
        ILoginMapper loginMapper;
        public LoginService()
        {
            loginMapper = new LoginMapper();
        }

        public void CreateUser(CreateUserDTO createUserDTO)
        {
            // 속성 유효성 검사
            //비지니스 로직
            //DTO <-> Entity 변경

            // Configure AutoMapper

            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<CreateUserDTO, USER>());

            // Perform mapping
            Mapper mapper = new Mapper(configuration);
            USER user = mapper.Map<CreateUserDTO, USER>(createUserDTO);

            loginMapper.Create(user);

        }
    }
}
