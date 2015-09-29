using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace TrabalhoFinalASW.App_Start
{
    // Configure the application user manager used in this application. UserManager is defined in ASP.NET Identity and is used by the application.    
    public class ApplicationUserManager : UserManager<SimpleUser>
    {
        public ApplicationUserManager(IUserStore<SimpleUser> store) : base(store)
        {
        } 

        public override Task<SimpleUser> FindAsync(string userName, string password)
        {
            return base.FindAsync(userName, password);
        }

        public override Task<SimpleUser> FindByEmailAsync(string email)
        {
            return base.FindByEmailAsync(email);
        }

        public override Task<SimpleUser> FindByNameAsync(string userName)
        {
            return base.FindByNameAsync(userName);
        }

        protected override Task<bool> VerifyPasswordAsync(IUserPasswordStore<SimpleUser, string> store, SimpleUser user, string password)
        {
            return base.VerifyPasswordAsync(store, user, password);
        }

        public override Task<bool> IsLockedOutAsync(string userId)
        {
            return base.IsLockedOutAsync(userId);
        }

        public override Task<bool> GetTwoFactorEnabledAsync(string userId)
        {
            return Task.FromResult<bool>(false);
        }

        public override Task<string> GetSecurityStampAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public override Task<IList<string>> GetRolesAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public override Task<IList<Claim>> GetClaimsAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public override Task<ClaimsIdentity> CreateIdentityAsync(SimpleUser user, string authenticationType)
        {
            ClaimsIdentity claims = new ClaimsIdentity(authenticationType);
            claims.AddClaim(new Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", user.UserName));
            claims.AddClaim(new Claim("http://schemas.microsoft.com/accesscontrolservice/2010/07/claims/identityprovider", user.UserName));
            return Task.FromResult(claims);
        }

        public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context)
        {
            var manager = new ApplicationUserManager(new UserStore());
            var dataProtectionProvider = options.DataProtectionProvider;
            if (dataProtectionProvider != null)
            {
                manager.UserTokenProvider = new DataProtectorTokenProvider<SimpleUser>(dataProtectionProvider.Create("ASP.NET Identity"));
            }
            return manager;
        }
    }

    // Configure the application sign-in manager which is used in this application.
    public class ApplicationSignInManager : SignInManager<SimpleUser,string>
    {
        public ApplicationSignInManager(ApplicationUserManager userManager, IAuthenticationManager authenticationManager)
            : base(userManager, authenticationManager)
        {
        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(SimpleUser user)
        {
            return user.GenerateUserIdentityAsync((ApplicationUserManager)UserManager);
        }

        public override Task<SignInStatus> PasswordSignInAsync(string userName, string password, bool isPersistent, bool shouldLockout)
        {

            return base.PasswordSignInAsync(userName, password, isPersistent, shouldLockout);
        }

        public static ApplicationSignInManager Create(IdentityFactoryOptions<ApplicationSignInManager> options, IOwinContext context)
        {
            return new ApplicationSignInManager(context.GetUserManager<ApplicationUserManager>(), context.Authentication);
        }

    }
}