using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhoFinalASW
{
    public class CustomUserStore : IUserStore<SimpleUser>, IUserPasswordStore<SimpleUser>, IUserLockoutStore<SimpleUser, object>
    {
        public List<SimpleUser> users;

        public CustomUserStore()
        {
            users = new List<SimpleUser>();
            users.Add(new SimpleUser()
            {
                Id = "Secretary",
                UserName = "Secretary",
                Type = Models.AccessType.Secretary
            });
            users.Add(new SimpleUser()
            {
                Id = "Professor",
                UserName = "Professor",
                Type = Models.AccessType.Teacher
            });
            users.Add(new SimpleUser()
            {
                Id = "Aluno",
                UserName = "Aluno",
                Type = Models.AccessType.Student
            });

        }

        public Task CreateAsync(SimpleUser user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(SimpleUser user)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            
        }

        public Task<SimpleUser> FindByIdAsync(object userId)
        {
            throw new NotImplementedException();
        }

        public SimpleUser FindByIdAsync(string userId)
        {
            return users.FirstOrDefault(c => c.Id == userId);
        }

        public SimpleUser FindByNameAsync(string userName)
        {
            return FindByIdAsync(userName);
        }

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

        public Task<string> GetPasswordHashAsync(SimpleUser user)
        {
            string hash = user.PasswordHash;
            return Task.FromResult<string>(hash);
        }

        public Task<bool> HasPasswordAsync(SimpleUser user)
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

        public Task SetPasswordHashAsync(SimpleUser user, string passwordHash)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(SimpleUser user)
        {
            throw new NotImplementedException();
        }

        Task<SimpleUser> IUserStore<SimpleUser, string>.FindByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        Task<SimpleUser> IUserStore<SimpleUser, object>.FindByNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        Task<SimpleUser> IUserStore<SimpleUser, string>.FindByNameAsync(string userName)
        {
            throw new NotImplementedException();
        }
    }
}