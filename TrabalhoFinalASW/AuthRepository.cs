using TrabalhoFinalASW.Entities;
using TrabalhoFinalASW.Models;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using TrabalhoFinalASW.App_Start;

namespace TrabalhoFinalASW
{

    public class AuthRepository : IDisposable
    {
      
        private UserManager<SimpleUser> _userManager;

        public AuthRepository()
        {
            _userManager = new UserManager<SimpleUser>(new TrabalhoFinalASW.App_Start.UserStore());
        }

        public async Task<IdentityResult> RegisterUser(UserModel userModel)
        {
            SimpleUser user = new SimpleUser
            {
                UserName = userModel.UserName
            };

            var result = await _userManager.CreateAsync(user, userModel.Password);

            return result;
        }

        public async Task<SimpleUser> FindUser(string userName, string password)
        {
            SimpleUser user = await _userManager.FindAsync(userName, password);

            return user;
        }

        //public Client FindClient(string clientId)
        //{
        //    var client = _ctx.Clients.Find(clientId);

        //    return client;
        //}

        


     
        public async Task<SimpleUser> FindAsync(UserLoginInfo loginInfo)
        {
            SimpleUser user = await _userManager.FindAsync(loginInfo);

            return user;
        }

        public async Task<IdentityResult> CreateAsync(SimpleUser user)
        {
            var result = await _userManager.CreateAsync(user);

            return result;
        }

        public async Task<IdentityResult> AddLoginAsync(string userId, UserLoginInfo login)
        {
            var result = await _userManager.AddLoginAsync(userId, login);

            return result;
        }

        public void Dispose()
        {
            _userManager.Dispose();

        }
    }
}