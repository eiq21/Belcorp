using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Belcorp.API.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Index() {
            return Ok("Running...!");
        }
    }
}
