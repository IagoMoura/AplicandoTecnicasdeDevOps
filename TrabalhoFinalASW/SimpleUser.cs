using System;
using Microsoft.AspNet.Identity;
using TrabalhoFinalASW.Models;

namespace TrabalhoFinalASW
{
    public class SimpleUserNew : IUser
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        
        public AccessType Type { get; set; }
        public string PasswordHash { get; set; }
    }
}