using HelloAsp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface ILoginService
    {
        public Task CreateUser(CreateUserDTO createUserDTO);
    }
}
