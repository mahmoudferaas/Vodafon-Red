using BLL.Abstractions;
using BLL.Dtos;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace BLL.Implementions
{
    public class UserService : IUserService
    {
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _singInManager;

        public UserService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _singInManager = signInManager;
        }

        public async Task<object> PostUser(UserDto model)
        {
            var applicationUser = new IdentityUser()
            {
                UserName = model.UserName,
                Email = model.Email
            };

            try
            {
                var result = await _userManager.CreateAsync(applicationUser, model.Password);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
