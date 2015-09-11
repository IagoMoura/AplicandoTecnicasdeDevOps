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

            //var Name = ClaimsPrincipal.Current.Identity.Name;
            //var Name1 = User.Identity.Name;

            //var userName = principal.Claims.Where(c => c.Type == "sub").Single().Value;

            return Ok(Notas.CreateOrders());
        }

    }


    #region Helpers

    public class Notas
    {
        public int ID { get; set; }
        public string StudentName { get; set; }
        public double Grade { get; set; }


        public static List<Notas> CreateOrders()
        {
            List<Notas> NotasList = new List<Notas> 
            {
                new Notas {ID = 10248, StudentName = "Taiseer Joudeh", Grade = 89 },
                new Notas {ID = 10249, StudentName = "Ahmad Hasan", Grade = 75},
                new Notas {ID = 10250,StudentName = "Tamer Yaser", Grade = 45 },
                new Notas {ID = 10251,StudentName = "Lina Majed", Grade = 94 },
                new Notas {ID = 10252,StudentName = "Yasmeen Rami", Grade = 56}
            };

            return NotasList;
        }
    }

    #endregion
}
