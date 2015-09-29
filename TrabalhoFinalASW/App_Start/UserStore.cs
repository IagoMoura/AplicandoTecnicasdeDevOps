using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using TrabalhoFinalASW.Entities;
using TrabalhoFinalASW.Models;

namespace TrabalhoFinalASW.App_Start
{

    public class SimpleUser : IUser 
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public AccessType Type { get; internal set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<SimpleUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
        
    }

    public class UserStore : IUserStore<SimpleUser>, IUserPasswordStore<SimpleUser>, IUserLockoutStore<SimpleUser, object>
    {
        Repository _repo;
       public UserStore()
        {
            _repo = new Repository();
        }

        #region IUserStore implementation

        public Task<SimpleUser> FindByIdAsync(string userId)
        {
            if (string.IsNullOrEmpty(userId)) return Task.FromResult<SimpleUser>(null);

            SimpleUser u = _repo.Users.FirstOrDefault(c => c.Id == userId);
            
            return Task.FromResult<SimpleUser>(u);
        }

        public Task<SimpleUser> FindByNameAsync(string userName)
        {
             string s = "pop";
            string s1 = new PasswordHasher().HashPassword(s);
            return FindByIdAsync(userName);

        }

        public Task CreateAsync(SimpleUser user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(SimpleUser user)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(SimpleUser user)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IUserPasswordStore implementation

        public Task<string> GetPasswordHashAsync(SimpleUser user)
        {
            string hash = user.PasswordHash;
            return Task.FromResult<string>(hash);
        }

        public Task<bool> HasPasswordAsync(SimpleUser user)
        {
            throw new NotImplementedException();
        }

        public Task SetPasswordHashAsync(SimpleUser user, string passwordHash)
        {
            string hash = passwordHash;
            return Task.FromResult<string>(hash);

        }

        #endregion

        #region IUserLockoutStore implementation

        public Task<int> GetAccessFailedCountAsync(SimpleUser user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GetLockoutEnabledAsync(SimpleUser user)
        {
             return Task.FromResult<bool>(false);
        }

        public Task<DateTimeOffset> GetLockoutEndDateAsync(SimpleUser user)
        {
            throw new NotImplementedException();
        }

        public Task<int> IncrementAccessFailedCountAsync(SimpleUser user)
        {
            throw new NotImplementedException();
        }

        public Task ResetAccessFailedCountAsync(SimpleUser user)
        {
            throw new NotImplementedException();
        }

        public Task SetLockoutEnabledAsync(SimpleUser user, bool enabled)
        {
            throw new NotImplementedException();
        }

        public Task SetLockoutEndDateAsync(SimpleUser user, DateTimeOffset lockoutEnd)
        {
            throw new NotImplementedException();
        }

        public Task<SimpleUser> FindByIdAsync(object userId)
        {
            throw new NotImplementedException();
        }

        #endregion

        public void Dispose()
        {
        }
    }
}