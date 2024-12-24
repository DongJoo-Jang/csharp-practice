using HelloAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mappers
{
    public interface ILoginMapper
    {
        public Task<USER> Create(USER user);
    }
}
