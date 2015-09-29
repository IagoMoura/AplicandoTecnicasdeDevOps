using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;

namespace TrabalhoFinalASW.Controllers
{
    [RoutePrefix("api/Notas")]
    public class NotasController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            //ClaimsPrincipal principal = Request.GetRequestContext().Principal as ClaimsPrincipal;

            ar Name = ClaimsPrincipal.Current.Identity.Name;
            //var Name1 = User.Identity.Name;

            //var userName = principal.Claims.Where(c => c.Type == "sub").Single().Value;
            if (Name == "Aluno")
            {
                return Ok(Notas.CreateNotasALuno());
            }
            return Ok(Notas.CreateNotas());
        }
        
        [AllowAnonymous]
        [Route("Notas/Test")]
        public IHttpActionResult Get(int id)
        {
            //ClaimsPrincipal principal = Request.GetRequestContext().Principal as ClaimsPrincipal;

            var Name = ClaimsPrincipal.Current.Identity.Name;
            //var Name1 = User.Identity.Name;

            //var userName = principal.Claims.Where(c => c.Type == "sub").Single().Value;
            if (Name == "Aluno")
            {
                return Ok(Notas.CreateNotasALuno());
            }
            return Ok(Notas.CreateNotas());
        }

    }


    #region Helpers

    public class Notas
    {
        public int ID { get; set; }
        public string StudentName { get; set; }
        public string CourseName { get; set; }
        public double Grade { get; set; }


        public static List<Notas> CreateNotas()
        {
            List<Notas> NotasList = new List<Notas> 
            {
                new Notas {ID = 10248, StudentName = "Taiseer Joudeh", Grade = 89 , CourseName = "APA" },
                new Notas {ID = 10249, StudentName = "Aluno", Grade = 75 , CourseName = "PAS"},
                new Notas {ID = 10250,StudentName = "Tamer Yaser", Grade = 45 , CourseName = "APAW"},
                new Notas {ID = 10251,StudentName = "Lina Majed", Grade = 94 , CourseName = "JPA" },
                new Notas {ID = 10252,StudentName = "Yasmeen Rami", Grade = 56, CourseName = ".NET"}
            };

            return NotasList;
        }


        public static List<Notas> CreateNotasALuno()
        {
            List<Notas> NotasList = new List<Notas>
            {
                new Notas {ID = 10248, StudentName = "Aluno", Grade = 89 , CourseName = "APA" },
                new Notas {ID = 10249, StudentName = "Aluno", Grade = 75 , CourseName = "PAS"},
                new Notas {ID = 10250,StudentName = "Aluno", Grade = 45 , CourseName = "APAW"},
                new Notas {ID = 10251,StudentName = "Aluno", Grade = 94 , CourseName = "JPA" },
                new Notas {ID = 10252,StudentName = "Aluno", Grade = 56, CourseName = ".NET"}
            };

            return NotasList;
        }
    }

    #endregion
}
