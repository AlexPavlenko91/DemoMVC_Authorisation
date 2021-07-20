using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    class AlexAttribute : Attribute , IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context) {
            // throw new NotImplementedException();
            context.Result = new UnauthorizedResult();
        }
    }
    public class SecretController : Controller
    {
        
        //[Authorize(Roles ="Administrators")]
        [Authorize(Policy ="RequireAdministrator")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
