using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoFinalASW.App_Start;
using TrabalhoFinalASW.Entities;
using TrabalhoFinalASW.Providers;

namespace TrabalhoFinalASW.Models
{
    public class Repository
    {
        public List<SimpleUser> Users = new List<SimpleUser>();
        public static List<RefreshToken> Tokens = new List<RefreshToken>();
        public static List<Client> Clients = new List<Client>();

        public Repository()
        {
            Users.Add(new SimpleUser()
            {
                UserName = "Professor",
                Id = "Professor",
                PasswordHash = "AMe3/dcKmSbiJGcVFp0D8GU9ZJNGUffVa8CZLXLAV9PVvY0yi36HzPI0UBSqEDIE2A=="
            });

            Users.Add(new SimpleUser()
            {
                UserName = "Aluno",
                Id = "Aluno",
                PasswordHash = "AMe3/dcKmSbiJGcVFp0D8GU9ZJNGUffVa8CZLXLAV9PVvY0yi36HzPI0UBSqEDIE2A=="
            });

            Users.Add(new SimpleUser()
            {
                UserName = "Secretaria",
                Id = "Secretaria",
                PasswordHash = "AMe3/dcKmSbiJGcVFp0D8GU9ZJNGUffVa8CZLXLAV9PVvY0yi36HzPI0UBSqEDIE2A=="
            });
        }
    }
}