using BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Abstractions
{
    public interface IUserService
    {
        Task<Object> PostUser(UserDto model);

    }
}
